using System;
using System.Collections.Generic;

namespace quanly.Models
{
    public partial class Nhanvien
    {
        public int Idnv { get; set; }
        public string? HoTen { get; set; }
        public string? Sdt { get; set; }
        public string? Taikhoan { get; set; }
        public string? Matkhau { get; set; }
        public int? Chucvu { get; set; }
        public string? Gmail { get; set; }
        public DateTime? Namsinh { get; set; }
        public int? Thoigian { get; set; }
        public int? Mucluong { get; set; }
    }
}
