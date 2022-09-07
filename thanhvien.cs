using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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


namespace quanly
{
    public partial class thanhvien : Form
    {
        public thanhvien()
        {
            InitializeComponent();
        }
        quanlyquanContext sql = new quanlyquanContext();
        
        private Nhanvien kq;
        private int id;

        public object Parse { get; private set; }

        public thanhvien(Nhanvien kq1)
        {
            kq = kq1;
            id = kq.Idnv;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            test1.Text = kq.Idnv.ToString();

        }

        private void thanhvien_Load(object sender, EventArgs e)
        {
            string a = $"xin chao {kq.HoTen}";
            test1.Text = a; 
        }
        private bool ktcheckin(Chamcong chamcong)
        {
            var kq = (from p in sql.Chamcongs
                     where p.IdNv == id
                     select p.Checkin).FirstOrDefault();
            if(kq == null)
            {
                return false;
            }else return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool kt = false;
            var kq = (from p in sql.Chamcongs
                      where p.IdNv == id
                      select p.Checkin).FirstOrDefault();
            if (kq != null)
            {
                kt = true;
            }
            else kt = false;

            if(kt == true)
            {
                MessageBox.Show("bạn đã bấm checkin rồi");
            }
            else
            {
                sql.Add(new Chamcong() { IdNv = id, Checkin = DateTime.Now });
                sql.SaveChanges();
                this.Hide();
                this.Close();
            }

        }

        private void chekuot_Click(object sender, EventArgs e)
        {
            bool kt = false;
            var kq2 = (from p in sql.Chamcongs
                      where p.IdNv == id
                      select p.Checkin).FirstOrDefault();
            if (kq2 != null)
            {
                kt = true;
            }
            else kt = false;

            if (kt == false)
            {
                MessageBox.Show("bạn chưa checkin nên bạm hãy checkin trước khi checkout");
            }
            else {
                var tgcheckin = (from p in sql.Chamcongs
                                 where p.IdNv == id
                                 select p.Checkin).FirstOrDefault();
                DateTime checkin = (DateTime)tgcheckin;
                DateTime now = DateTime.Now;
                TimeSpan kq = now - checkin;
                int kq1 = (int)kq.TotalMinutes;
                int gio = kq1 / 60;
                int phuc = kq1 % 60;
                MessageBox.Show($"hôm nay đã làm được {gio} giờ {phuc} phút");

                var qr = (from p in sql.Nhanviens
                          where p.Idnv == id
                          select p).FirstOrDefault();
                if (qr != null)
                {
                    qr.Thoigian = qr.Thoigian + kq1;
                    sql.SaveChanges();
                }

                var chamcong = (from p in sql.Chamcongs
                                where p.IdNv == id
                                select p).FirstOrDefault();
                if (chamcong != null)
                {
                    sql.Remove(chamcong);
                    sql.SaveChanges();
                }
                this.Hide();
                this.Close();
            }
          
        }
    }

    
}
