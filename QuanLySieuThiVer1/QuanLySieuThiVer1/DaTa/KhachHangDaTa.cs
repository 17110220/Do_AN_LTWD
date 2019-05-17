using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiVer1.DB_Layer;
using QuanLySieuThiVer1.BS_Layer;
using System.Data.SqlClient;
using System.Data;

namespace QuanLySieuThiVer1.DaTa
{
    class KhachHangDaTa
    {
        DaTaServer m_KhachHangData = new DaTaServer();

        public DataTable LayKhachHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang");
            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayKHTheoMa(String MaKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaKH LIKE '%' + @MaKH + '%'");
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayKHTheoTen(String TenKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE TenKH LIKE '%' + @TenKH + '%'");
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayMaKHTheoTen(String TenKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaKH FROM KhachHang WHERE TenKH LIKE '%' + @TenKH + '%'");
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.NewRow();
        }

        public void ThemKhachHang(DataRow m_Row)
        {
            m_KhachHangData.Rows.Add(m_Row);
        }

        public bool LuuKhachHang()
        {
            return m_KhachHangData.ExecuteNoneQuery() > 0;
        }
        public void LuuKhachHang(String MaKH, String TenKH, String DiaChiKH, String SDT)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang VALUES(@MaKH, @TenKH, @DiaChiKH, @SDT)");
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("DiaChiKH", SqlDbType.NVarChar).Value = DiaChiKH;
            cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = SDT;

            m_KhachHangData.Load(cmd);
        }
    }
}
