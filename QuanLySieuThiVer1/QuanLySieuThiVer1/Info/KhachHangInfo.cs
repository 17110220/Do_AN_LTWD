using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiVer1.Info
{
    class KhachHangInfo
    {
        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private String m_TenKH;
        public String TenKH
        {
            get { return m_TenKH; }
            set { m_TenKH = value; }
        }

        private String m_DiaChiKH;
        public String DiaChiKH
        {
            get { return m_DiaChiKH; }
            set { m_DiaChiKH = value; }
        }

        private String m_SDT;
        public String SDT
        {
            get { return m_SDT; }
            set { m_SDT = value; }
        }
    }
}
