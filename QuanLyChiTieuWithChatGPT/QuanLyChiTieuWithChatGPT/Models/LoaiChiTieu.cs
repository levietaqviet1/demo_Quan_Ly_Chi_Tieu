using System;
using System.Collections.Generic;

namespace QuanLyChiTieuWithChatGPT.Models
{
    public partial class LoaiChiTieu
    {
        public LoaiChiTieu()
        {
            ChiTieus = new HashSet<ChiTieu>();
        }

        public int MaLoai { get; set; }
        public string? TenLoai { get; set; }

        public virtual ICollection<ChiTieu> ChiTieus { get; set; }
    }
}
