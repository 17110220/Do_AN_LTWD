using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1.Info
{
    class HoaDonInfo
    {
        public HoaDonInfo()
        {

        }
        private String m_MaHD;
        public String MaHD
        {
            get { return m_MaHD; }
            set { m_MaHD = value; }
        }
        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }
        private KhachHangInfo m_MaKH;
        public KhachHangInfo MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }
        private DateTime m_NgayBan;
        public DateTime NgayBan
        {
            get { return m_NgayBan; }
            set { m_NgayBan = value; }

        }
        private String m_TongTien;
        public String TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
    }
}

