using System;
using System.Collections.Generic;

namespace quanly.Models
{
    public partial class Bangluong
    {
        public int Id { get; set; }
        public int? Idnv { get; set; }
        public string? Tennv { get; set; }
        public string? Sdtnv { get; set; }
        public string? Emailnv { get; set; }
        public DateTime? Namsinhnv { get; set; }
        public string? Taikhoangnv { get; set; }
        public int? Mucluongnv { get; set; }
        public int? Thoigianglam { get; set; }
        public int? Tiengluong { get; set; }
        public DateTime? Ngaytra { get; set; }
        public string? Chucvu { get; set; }
    }
}
