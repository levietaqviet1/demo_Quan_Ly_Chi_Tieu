using System;
using System.Collections.Generic;

namespace QuanLyChiTieuWithChatGPT.Models
{
    public partial class ChiTieu
    {
        public ChiTieu()
        {
            GiaoDiches = new HashSet<GiaoDich>();
        }

        public int MaChiTieu { get; set; }
        public int? MaLoai { get; set; }
        public decimal? SoTien { get; set; }
        public DateTime? NgayChi { get; set; }
        public string? MoTa { get; set; }

        public virtual LoaiChiTieu? MaLoaiNavigation { get; set; }
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
    }
}
