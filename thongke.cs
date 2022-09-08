using quanly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace quanly
{
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            using quanlyquanContext sql = new quanlyquanContext();
            {
                if(thang.Text.Length == 0 && idnv.Text.Length == 0)
                {
                    var kq = from p in sql.Bangluongs
                             where p.Ngaytra.Value.Month == (DateTime.Now.Month - 0)
                             select new
                             {
                                 id = p.Idnv,
                                 ten = p.Tennv,
                                 chucvu = p.Chucvu,
                                 ngaytra = p.Ngaytra,
                                 mucluong = p.Mucluongnv,
                                 thoigianglam = p.Thoigianglam,
                                 tongluong = p.Tiengluong,
                             };
                    dataGridView1.DataSource = kq.ToList();
                }
  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thang.Text.Length > 0 && idnv.Text.Length == 0)
            {
                using quanlyquanContext sql = new quanlyquanContext();
                {
                    try
                    {
                        var kq = from p in sql.Bangluongs
                                 where p.Ngaytra.Value.Month == int.Parse(thang.Text)
                                 select new
                                 {
                                     id = p.Idnv,
                                     ten = p.Tennv,
                                     chucvu = p.Chucvu,
                                     ngaytra = p.Ngaytra,
                                     mucluong = p.Mucluongnv,
                                     thoigianglam = p.Thoigianglam,
                                     tongluong = p.Tiengluong,
                                 };
                        dataGridView1.DataSource = kq.ToList();
                    }catch(Exception ex)
                    {
                        MessageBox.Show($"nhập sai định dạng số từ 1-12");
                    }
                    

                }
                //MessageBox.Show($"thang{thang.Text}");
            }else if(thang.Text.Length == 0 && idnv.Text.Length > 0)
            {
                using quanlyquanContext sql = new quanlyquanContext();
                {
                    try
                    {
                        var kq = from p in sql.Bangluongs
                                 where p.Idnv == int.Parse(idnv.Text)
                                 select new
                                 {
                                     id = p.Idnv,
                                     ten = p.Tennv,
                                     chucvu = p.Chucvu,
                                     ngaytra = p.Ngaytra,
                                     mucluong=p.Mucluongnv,
                                     thoigianglam=p.Thoigianglam,
                                     tongluong = p.Tiengluong,
                                 };
                        dataGridView1.DataSource = kq.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"nhập sai định dạng mã nhân viên là một số nguyên");
                    }


                }
            }
            else if (thang.Text.Length > 0 && idnv.Text.Length > 0)
            {
                using quanlyquanContext sql = new quanlyquanContext();
                {
                    try
                    {
                        var kq = from p in sql.Bangluongs
                                 where p.Idnv == int.Parse(idnv.Text) && p.Ngaytra.Value.Month == int.Parse(thang.Text)
                                 select new
                                 {
                                     id = p.Idnv,
                                     ten = p.Tennv,
                                     chucvu = p.Chucvu,
                                     ngaytra = p.Ngaytra,
                                     mucluong = p.Mucluongnv,
                                     thoigianglam = p.Thoigianglam,
                                     tongluong = p.Tiengluong,
                                 };
                        dataGridView1.DataSource = kq.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"xem lại định dạng đã nhập");
                    }


                }
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Bảng Lương";
            save.Filter = "Excel (*.xlsx)|*.xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(save.FileName);
                    MessageBox.Show("xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xuất file thất bại : {ex}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }
    }
}
