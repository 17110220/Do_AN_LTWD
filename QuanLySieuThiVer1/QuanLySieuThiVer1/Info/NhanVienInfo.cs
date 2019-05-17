using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1.Info
{
    class NhanVienInfo
    {
        public NhanVienInfo()
        {
        }

        private String m_MaNV;
        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTenNV;
        public String HoTenNV
        {
            get { return m_HoTenNV; }
            set { m_HoTenNV = value; }
        }

       
        private DateTime m_NgSinh;
        public DateTime NgSinh
        {
            get { return m_NgSinh; }
            set { m_NgSinh = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_SDT;
        public String SDT
        {
            get { return m_SDT; }
            set { m_SDT = value; }
        }
        private String m_GioiTinh;
        public String GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }
    }
}
