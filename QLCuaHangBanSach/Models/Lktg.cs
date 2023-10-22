using System;
using System.Collections.Generic;

namespace QLCuaHangBanSach.Models
{
    public partial class Lktg
    {
        public string MaSach { get; set; } = null!;
        public string MaTg { get; set; } = null!;

        public virtual Sach MaSachNavigation { get; set; } = null!;
        public virtual Tacgia MaTgNavigation { get; set; } = null!;
    }
}
