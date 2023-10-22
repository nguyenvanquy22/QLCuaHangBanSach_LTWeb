using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hdbs = new HashSet<Hdb>();
            Hdms = new HashSet<Hdm>();
        }

        public string MaNv { get; set; } = null!;
        public string TenNv { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public int Luong { get; set; }

        public virtual ICollection<Hdb> Hdbs { get; set; }
        public virtual ICollection<Hdm> Hdms { get; set; }
    }
}
