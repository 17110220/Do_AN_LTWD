using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1.Info
{
    class ChiTietHoaDonInfo
    {
        public ChiTietHoaDonInfo()
        {
        }
        private String m_SoLuong;
        public String SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }
        private String m_DonGia;
        public String DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }
        private String m_ThanhTien;
        public String ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        }
        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV;}
            set { m_MaNV = value; }
        }
        private NhanVienInfo m_TenNV;
        public NhanVienInfo TenNV
        {
            get { return m_TenNV; }
            set { m_TenNV = value; }
        }
        private KhachHangInfo m_MaKH;
        public KhachHangInfo MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }
        private KhachHangInfo m_TenKH;
        public KhachHangInfo TenKH
        {
            get { return m_TenKH; }
            set { m_TenKH = value; }
        }
        private KhachHangInfo m_DiaChiKH;
        public KhachHangInfo DiaChiKH
        {
            get { return m_DiaChiKH; }
            set { m_DiaChiKH = value; }
        }
        private KhachHangInfo m_SDT;
        public KhachHangInfo SDT
        {
            get { return m_SDT; }
            set { m_SDT = value; }
        }
        private HoaDonInfo m_MaHD;
        public HoaDonInfo MaHD
        {
            get { return m_MaHD; }
            set { m_MaHD = value; }
        }
        private HoaDonInfo m_NgayBan;
        public HoaDonInfo NgayBan
        {
            get { return m_NgayBan; }
            set { m_NgayBan = value; }
        }
        private SanPhamInfo m_MaSP;
        public SanPhamInfo MaSP
        {
            get { return m_MaSP; }
            set { m_MaSP = value; }
        }
        private SanPhamInfo m_TenSP;
        public SanPhamInfo TenSP
        {
            get { return m_TenSP; }
            set { m_TenSP = value; }
        }
    }
}
