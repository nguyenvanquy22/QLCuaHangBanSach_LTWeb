using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Sach
    {
        public string MaSach { get; set; } = null!;
        public string TenSach { get; set; } = null!;
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int SoTrang { get; set; }
        public int KhoiLuong { get; set; }
        public string MaNxb { get; set; } = null!;

        public virtual Nhaxuatban MaNxbNavigation { get; set; } = null!;
    }
}
