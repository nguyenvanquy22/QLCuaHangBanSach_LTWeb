using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hdbs = new HashSet<Hdb>();
        }

        public string MaKh { get; set; } = null!;
        public string TenKh { get; set; } = null!;
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<Hdb> Hdbs { get; set; }
    }
}
