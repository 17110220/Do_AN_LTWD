using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThiVer1.DB_Layer;
using QuanLySieuThiVer1.BS_Layer;
namespace QuanLySieuThiVer1.BS_Layer
{
    class BlTimKiemKhachHang
    {
        KetNoi db = null;
        public BlTimKiemKhachHang()
        {
            db = new KetNoi();
        }
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

        public DataTable LayKHTheoTen(String HoTenKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE HoTenKH LIKE '%' + @HoTenKH + '%'");
            cmd.Parameters.Add("HoTenKH", SqlDbType.NVarChar).Value = HoTenKH;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataTable LayMaKHTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaKH FROM KhachHang WHERE HoTenKH LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("HoTenKH", SqlDbType.NVarChar).Value = ten;

            m_KhachHangData.Load(cmd);
            return m_KhachHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.NewRow();
        }

    }
}
