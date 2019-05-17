using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1.Info
{
    class SanPhamInfo
    {
        public SanPhamInfo()
        {
            
        }
        private String m_MaSP;
        public String MaSP
        {
            get { return m_MaSP; }
            set { m_MaSP = value; }
        }
        private String m_TenSP;
        public String TenSP
        {
            get { return m_TenSP; }
            set { m_TenSP = value; }
        }
        private String m_DonGia;
        public String DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }
        private String m_DonGiaBan;
        public String DonGiaBan
        {
            get { return m_DonGiaBan; }
            set { m_DonGiaBan = value; }
        }
        private String m_SoLuong;
        public String SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }
        private String m_DonViTinh;
        public String DonViTinh
        {
            get { return m_DonViTinh; }
            set { m_DonViTinh = value; }
        }
    }
}
