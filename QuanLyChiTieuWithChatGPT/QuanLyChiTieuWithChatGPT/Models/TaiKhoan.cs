using System;
using System.Collections.Generic;

namespace QuanLyChiTieuWithChatGPT.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            GiaoDiches = new HashSet<GiaoDich>();
        }

        public int MaTaiKhoan { get; set; }
        public string? TenTaiKhoan { get; set; }
        public decimal? SoDuTaiKhoan { get; set; }

        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
    }
}
