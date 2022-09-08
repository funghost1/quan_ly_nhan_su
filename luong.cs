using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using quanly.Models;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace quanly
{
    public partial class luong : Form
    {
        public luong()
        {
            InitializeComponent();
        }

        private void luong_Load(object sender, EventArgs e)
        {
            try
            {
                using quanlyquanContext sql = new quanlyquanContext();
                {
                    var kq = from p in sql.Nhanviens
                             join cv in sql.Chucvus on p.Chucvu equals cv.IdCv
                             where p.Chucvu != 1
                             select new
                             {
                                 idbangnhanvien = p.Idnv,
                                 //idchucvu = cv.IdCv,
                                 cv = p.Chucvu,
                                 ten = p.HoTen,
                                 sdt = p.Sdt,
                                 Emai = p.Gmail,
                                 namsinh = p.Namsinh,
                                 MucLuong = $"{p.Mucluong}đ Trên Giờ ",
                                 mucluongso = p.Mucluong,
                                 tenchucvu = cv.TenCv,
                                 taikhoang = p.Taikhoan,
                                 tienluonghientai = $"{(p.Thoigian) * (p.Mucluong / 60)} đồng",
                                 tienluongso = (p.Thoigian) * (p.Mucluong / 60),
                                 thoigianglam = p.Thoigian,
                                 thoigianglamshow = $"{p.Thoigian / 60} Giờ {p.Thoigian %60} Phút"
                             };
                    var lay = kq.ToList();
                    dataGridView1.DataSource = lay;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private string _idnv;
        private string _cv;
        private string _ten;
        private string _sdt;
        private string _email;
        private string _namsinh;
        private string _mucluong;
        private string _taikhoang;
        private string _tiengluong;
        private string _thoigiang;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
                
                textboxten.Text = dataGridViewRow.Cells["ten"].Value.ToString();
                textboxsdt.Text = dataGridViewRow.Cells["sdt"].Value.ToString();
                textboxmucluong.Text = dataGridViewRow.Cells["thoigianglamshow"].Value.ToString();
                texboxtiengluong.Text = dataGridViewRow.Cells["tienluonghientai"].Value.ToString();


                // lấy giá trị
                _idnv = dataGridViewRow.Cells["idbangnhanvien"].Value.ToString();
                _cv = dataGridViewRow.Cells["tenchucvu"].Value.ToString();
                _ten = dataGridViewRow.Cells["ten"].Value.ToString();
                _sdt = dataGridViewRow.Cells["sdt"].Value.ToString();
                _email = dataGridViewRow.Cells["Emai"].Value.ToString();
                _namsinh = dataGridViewRow.Cells["namsinh"].Value.ToString();
                _mucluong = dataGridViewRow.Cells["mucluongso"].Value.ToString();
                _taikhoang = dataGridViewRow.Cells["taikhoang"].Value.ToString();
                _tiengluong = dataGridViewRow.Cells["tienluongso"].Value.ToString();
                _thoigiang = dataGridViewRow.Cells["thoigianglam"].Value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void traluong_Click(object sender, EventArgs e)
        {
            try
            {

                using quanlyquanContext sql = new quanlyquanContext();
                {
                    if (_idnv != null)
                    {
                        var them = new Bangluong();
                        them.Idnv = int.Parse(_idnv);
                        them.Tennv = _ten;
                        them.Sdtnv = _sdt;
                        them.Emailnv = _email;
                        them.Namsinhnv = DateTime.Parse(_namsinh);
                        them.Taikhoangnv = _taikhoang;
                        them.Mucluongnv = int.Parse(_mucluong);
                        them.Thoigianglam = int.Parse(_thoigiang);
                        them.Tiengluong = int.Parse(_tiengluong);
                        them.Ngaytra = DateTime.Now;
                        them.Chucvu = _cv;
                        sql.Add(them);
                        sql.SaveChanges();
                        


                        quanlyquanContext sql1 = new quanlyquanContext();
                        // chuyển tg về 0
                        var qr = (from p in sql1.Nhanviens
                                  where p.Idnv == int.Parse(_idnv)
                                  select p).FirstOrDefault();
                        qr.Thoigian = 0;
                        sql1.SaveChanges();
                        MessageBox.Show($"Trả lương cho {_ten} thành công");
                    }
                    else MessageBox.Show("Bạn chưa chọn nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i=0;i<dataGridView1.Columns.Count;i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j=0; j<dataGridView1.Columns.Count;j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true; 
        }

        // nút xuất file pdf
        private void indanhsach_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Bảng Lương";
            save.Filter = "Excel (*.xlsx)|*.xls";
            if(save.ShowDialog()== DialogResult.OK)
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

        private void trove_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            luong ql = new luong();
            this.Hide();
            ql.ShowDialog();
            this.Close();
        }
    }
}

