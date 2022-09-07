using System;
using System.Collections.Generic;

namespace quanly.Models
{
    public partial class Chamcong
    {
        public int Id { get; set; }
        public int? IdNv { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Chekout { get; set; }
    }
}
