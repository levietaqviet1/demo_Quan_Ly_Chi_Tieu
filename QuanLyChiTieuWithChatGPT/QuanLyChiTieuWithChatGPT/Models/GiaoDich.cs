using System;
using System.Collections.Generic;

namespace QuanLyChiTieuWithChatGPT.Models
{
    public partial class GiaoDich
    {
        public int MaGiaoDich { get; set; }
        public int? MaTaiKhoan { get; set; }
        public int? MaChiTieu { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
        public decimal? SoTien { get; set; }
        public string? GhiChu { get; set; }

        public virtual ChiTieu? MaChiTieuNavigation { get; set; }
        public virtual TaiKhoan? MaTaiKhoanNavigation { get; set; }
    }
}
