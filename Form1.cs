
using quanly.Models;
using System.Xml.Linq;

namespace quanly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        private void dangnhap_Click(object sender, EventArgs e)
        {
             
            string tk = textBoxTK.Text;
            string mk1 = textBoxMK.Text;
            string mk = Base64Encode(mk1);
            if (tk.Length != 0 && mk.Length != 0)
            {
                quanlyquanContext sql = new quanlyquanContext();
                
                var kq = from p in sql.Nhanviens
                         where p.Taikhoan == tk && p.Matkhau == mk 
                         select p;
                
                if (kq.Count() > 0 && kq.FirstOrDefault().Chucvu == 1) // đăng nhập admin
                {
                    admin admin = new admin();
                    this.Hide();
                    admin.ShowDialog();
                    
                    this.Close();
                }
                else if(kq.Count() > 0 && kq.FirstOrDefault().Chucvu == 2) // đăng nhập thanhvien
                {
                    string id = kq.FirstOrDefault().Idnv.ToString();
                    thanhvien add = new thanhvien(kq.FirstOrDefault());
                    
                    this.Hide();
                    add.ShowDialog();
                    this.Visible = false;
                    this.Close();
                  
                }
                else if (kq.Count() > 0 && kq.FirstOrDefault().Chucvu ==6) 
                {
                    
                    MessageBox.Show("Tài Khoảng Của Bạn Chưa Được Kích Hoạt Vui Lòng Liên Hệ Với Chủ Shop");

                }
                else MessageBox.Show("sai tên tài khoản hoặc mật khẩu");
            }
            else MessageBox.Show("Bạn chưa nhập mật tài khoản hoặc mật khẩu");
        }

        private void dangky_Click(object sender, EventArgs e)
        {
           
        }
    }
}