using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanly.Models;

namespace quanly
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        
        private void xem_Click(object sender, EventArgs e)
        {
            using quanlyquanContext sql = new quanlyquanContext();
            {
                var kq = from p in sql.Nhanviens
                         join cv in sql.Chucvus
                         on p.Chucvu equals cv.IdCv
                         where p.Chucvu != 1
                         select new
                         {
                             ten = p.HoTen,
                             sdt = p.Sdt,
                             Emai = p.Gmail,
                             namsinh = p.Namsinh,
                             MucLuong = $"{p.Mucluong}đ Trên Giờ ",
                             chucvu = cv.TenCv,
                         };
                var lay = kq.ToList();

                dataGridView1.DataSource = lay;
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
            using quanlyquanContext sql = new quanlyquanContext();
            {
                var kq = from p in sql.Nhanviens
                         join cv in sql.Chucvus on p.Chucvu equals cv.IdCv into t
                         from tencv in t
                         where p.Chucvu != 1
                         select new
                         {
                             ten = p.HoTen,
                             sdt = p.Sdt,
                             Emai = p.Gmail,
                             namsinh = p.Namsinh,
                             MucLuong = $"{p.Mucluong}đ Trên Giờ ",
                             chucvu = tencv.TenCv,
                         };
                var lay = kq.ToList();

                dataGridView1.DataSource = lay;
            }
           
        }

        private void tiem_TextChanged(object sender, EventArgs e)
        {
            string t1 = tiem.Text;

            using quanlyquanContext sql = new quanlyquanContext();
            {
                var kq = from p in sql.Nhanviens
                         join cv in sql.Chucvus on p.Chucvu equals cv.IdCv into t
                         from tencv in t
                         where p.Chucvu != 1 && (p.HoTen.StartsWith(t1) || tencv.TenCv.StartsWith(t1) || p.Sdt.StartsWith(t1))
                         select new
                         {
                             ten = p.HoTen,
                             sdt = p.Sdt,
                             Emai = p.Gmail,
                             namsinh = p.Namsinh,
                             MucLuong = $"{p.Mucluong}đ Trên Giờ ",
                             chucvu = tencv.TenCv,
                         };
                var lay = kq.ToList();

                dataGridView1.DataSource = lay;
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            this.Hide();
            admin.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlyNV admin = new quanlyNV();
            this.Hide();
            admin.ShowDialog();
        }

        private void tiềngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            luong admin = new luong();
            this.Hide();
            admin.ShowDialog();
        }
    }
}
