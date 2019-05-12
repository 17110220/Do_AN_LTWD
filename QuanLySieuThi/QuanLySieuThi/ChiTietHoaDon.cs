namespace QuanLySieuThi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [StringLength(10)]
        public string MaPhieu { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        public double? SoLuong { get; set; }

        public double? ThanhTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngayxuat { get; set; }

        [StringLength(10)]
        public string MaLoaiTien { get; set; }

        [StringLength(10)]
        public string MaLoaiGiaoDich { get; set; }
    }
}
