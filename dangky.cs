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
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        // bam mk
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxtaikhoang.Text.Length > 0 && textBoxmatkhau.Text.Length > 0 && textBoxhoten.Text.Length > 0 && textBoxsdt.Text.Length > 0 && textBoxgmail.Text.Length > 0)
                {
                    string tk = textBoxtaikhoang.Text;
                    string mk = textBoxmatkhau.Text;
                    string mkbam = Base64Encode(mk);
                    string ten = textBoxhoten.Text;
                    string sdt = textBoxsdt.Text;
                    string gmail = textBoxgmail.Text;
                    var namsinh = dateTimePickernamsinh.Text;
                    int ktsdt = 0;

                    if(sdt.Length == 10)
                    {
                        try
                        {
                            int sdt1 = int.Parse(sdt);
                            ktsdt = 1;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("không đúng định dạng sdt");
                        }

                    }else MessageBox.Show("không đúng định dạng sdt hoặc không đủ 10 số");

                    using quanlyquanContext sql = new quanlyquanContext();
                    {
                        var kq = (from p in sql.Nhanviens
                                 where p.Taikhoan == tk
                                 select p).FirstOrDefault();

                        if(kq == null && ktsdt == 1)
                        {
                            var them = new Nhanvien();
                            them.HoTen = ten;
                            them.Sdt = sdt;
                            them.Taikhoan = tk;
                            them.Matkhau = mkbam;
                            them.Chucvu = 6;
                            them.Gmail = gmail;
                            them.Namsinh = DateTime.Parse(namsinh);
                            them.Thoigian = 0;
                            them.Mucluong = 0;
                            sql.Add(them);
                            sql.SaveChanges();
                            MessageBox.Show("Đăng Ký Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Tài Trùng Hoặc SĐT Không Đúng Định Dạng");
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("không được để trống giá trị nào");
                }
            }
            catch
            {

            }
        }
    }
}
