using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Lktl
    {
        public string MaSach { get; set; } = null!;
        public string MaTl { get; set; } = null!;

        public virtual Sach MaSachNavigation { get; set; } = null!;
        public virtual Theloai MaTlNavigation { get; set; } = null!;
    }
}
