using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Tacgia
    {
        public string MaTg { get; set; } = null!;
        public string TenTg { get; set; } = null!;
        public int? NamSinh { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
    }
}
