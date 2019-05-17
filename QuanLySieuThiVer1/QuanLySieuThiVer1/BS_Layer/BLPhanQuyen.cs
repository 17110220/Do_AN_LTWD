using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using QuanLySieuThiVer1.BS_Layer;

namespace QuanLySieuThiVer1.BS_Layer
{
    class BLPhanQuyen
    {
        DaTaServer m_PhanQuyenData = new DaTaServer();

        public DataTable LayPhanQuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phan_Quyen");
            m_PhanQuyenData.Load(cmd);
            return m_PhanQuyenData;
        }

        public DataTable LayPhanQuyen(String m_Name)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phan_Quyen WHERE TenDangNhap = @m_Name");
            cmd.Parameters.Add("m_Name", SqlDbType.VarChar).Value = m_Name;

            m_PhanQuyenData.Load(cmd);
            return m_PhanQuyenData;
        }

        
    }
}
