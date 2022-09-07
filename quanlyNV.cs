using FastMember;
using Microsoft.EntityFrameworkCore;
using quanly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly
{
    public partial class quanlyNV : Form
    {
        
        public quanlyNV()
        {
            InitializeComponent();
        }

        private void quanlyNV_Load(object sender, EventArgs e)
        {
            using quanlyquanContext sql = new quanlyquanContext();
            {
                var kq = from p in sql.Nhanviens
                         join cv in sql.Chucvus on p.Chucvu equals cv.IdCv
                         join chamcong in sql.Chamcongs on p.Idnv equals chamcong.IdNv
                         into temp
                         from last in temp.DefaultIfEmpty()
                         where p.Chucvu != 1
                         select new
                         {
                             idbangnhanvien = p.Idnv,
                             idchucvu = cv.IdCv,
                             trangthai = last.IdNv == p.Idnv ? "đang làm" : "đang nghĩ",
                             ten = p.HoTen,
                             sdt = p.Sdt,
                             Emai = p.Gmail,
                             namsinh = p.Namsinh,
                             MucLuong = $"{p.Mucluong}đ Trên Giờ ",
                             mucluongso = p.Mucluong,
                             chucvu = cv.TenCv,
                             taikhoang = p.Taikhoan,
                             
                         };

               
                var lay = kq.ToList();
                ////chuyển sang data table
                //DataTable dt = new DataTable();
                //var doc = ObjectReader.Create(lay);
                //dt.Load(doc);
                dataGridView1.DataSource = lay;

            }
            //load();

        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            using quanlyquanContext sql = new quanlyquanContext();
            {
                
                string luuten = textboxten.Text;
                string luucv = combochucvu.Text;
                string luusdt = textboxsdt.Text;
                string luuemail = textboxemail.Text;
                string luumucluong = textboxmucluong.Text;
                string luusinhnhat = textboxsinhnhat.Text;

                var qr = (from p in sql.Nhanviens
                          where p.Idnv == int.Parse(IDnhanvien)
                          select p).FirstOrDefault();
                //MessageBox.Show($"{IdChucVu}");
                if (qr != null)
                {
                    //sql.Add(new Nhanvien() { Idnv = int.Parse(IDnhanvien), HoTen = luuten, Chucvu = IdChucVu, Sdt = luusdt,
                    //    Gmail = luuemail,Mucluong = int.Parse(luumucluong) , Namsinh = DateTime.Parse(luusinhnhat)});
                    //sql.SaveChanges();
                    qr.HoTen = luuten;
                    qr.Chucvu = IdChucVu;
                    qr.Sdt = luusdt;
                    qr.Gmail = luuemail;
                    qr.Mucluong = int.Parse(luumucluong);
                    qr.Namsinh = DateTime.Parse(luusinhnhat);
                    MessageBox.Show("Bạn có chắc là thay đổi không");
                    sql.SaveChanges();
                    MessageBox.Show("thay đổi thành công");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên để thay đổi");
                }
               
            }

        }

        public string IDnhanvien;
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];

            IDnhanvien = dataGridViewRow.Cells["idbangnhanvien"].Value.ToString();
            //IDchucvu = dataGridViewRow.Cells["idchucvu"].Value.ToString();

            //MessageBox.Show($"{IDchucvu}");


            quanlyquanContext sql = new quanlyquanContext();
            //var lay = from p in sql.Chucvus
            //          select new
            //          {
            //              id = p.IdCv,
            //              ten = p.TenCv,
            //          };

            combochucvu.DataSource = sql.Chucvus.ToList();
            combochucvu.DisplayMember = "TenCv";
            combochucvu.ValueMember = "IdCv";
            
            //MessageBox.Show();


            textboxten.Text = dataGridViewRow.Cells["ten"].Value.ToString();
            combochucvu.Text = dataGridViewRow.Cells["chucvu"].Value.ToString();
            textboxsdt.Text = dataGridViewRow.Cells["sdt"].Value.ToString();
            textboxemail.Text = dataGridViewRow.Cells["email"].Value.ToString();
            textboxmucluong.Text = dataGridViewRow.Cells["mucluongso"].Value.ToString();
            textboxsinhnhat.Text = dataGridViewRow.Cells["namsinh"].Value.ToString();
            IdChucVu = int.Parse(dataGridViewRow.Cells["idchucvu"].Value.ToString());




        }
        public int IdChucVu;
        private void combochucvu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Chucvu obj = combochucvu.SelectedItem as Chucvu;
            if(obj != null)
            {
                IdChucVu = int.Parse(obj.IdCv.ToString());
                //MessageBox.Show(id);
            }
            Cursor.Current = Cursors.Default;

        }

        private void tailai_Click(object sender, EventArgs e)
        {
            quanlyNV ql = new quanlyNV();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }

        private void trove_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }
    }
}
