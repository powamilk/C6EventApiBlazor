using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class GiaoDichTaiChinh
    {
        public Guid Id { get; set; }
        public string NguoiThucHien { get; set; } = null!;
        public string LoaiGiaoDich { get; set; } = null!;
        public string DiaChiVi { get; set; } = null!;
        public decimal SoLuong { get; set; }
        public DateTime NgayGiaoDich { get; set; }
        public decimal PhiGiaoDich { get; set; }
        public string TrangThai { get; set; } = null!;
    }
}
