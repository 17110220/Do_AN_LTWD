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
    class HoaDonDaTa
    {
       DaTaServer m_DatHangData = new DaTaServer();
        DaTaServer m_MatHangData = new DaTaServer();
        public DataTable LayMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }
        public DataTable LayDatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon");
            m_DatHangData.Load(cmd);
            return m_DatHangData;
        }
        public DataTable LayDSDatHangTheoMa(String MaHD)
        {
            SqlCommand cmd = new SqlCommand("SELECT HD.MaHD,NV.MaNV,NV.HoTenNV, KH.MaKH, KH.TenKH,KH.DiaChiKH,KH.SDT , HD.TongTien, HD.NgayBan  FROM HoaDon HD  INNER JOIN KhachHang KH ON KH.MaKH = HD.MaKH  INNER JOIN NhanVien NV ON NV.MaNV=HD.MaNV  WHERE HD.MaHD = @MaHD");
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            m_DatHangData.Load(cmd);
            return m_DatHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DatHangData.NewRow();
        }

        public void ThemDatHang(DataRow m_Row)
        {
            m_DatHangData.Rows.Add(m_Row);
        }

        public bool LuuDatHang()
        {
            return m_DatHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuDatHang(String MaHD, String MaNV, String TenNV, DateTime NgayBan, String MaKH,String TenKH,String TongTien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon VALUES(@MaHD, @MaNV, @TenNV, @NgayBan, @MaKH, @TenKH, @TongTien)");
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = MaHD;
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = TenNV;
            cmd.Parameters.Add("NgayBan", SqlDbType.DateTime).Value = NgayBan;
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("TongTien", SqlDbType.NVarChar).Value = TongTien;
           
            m_DatHangData.Load(cmd);
        }

        public void SuaDatHang(String MaHD, String MaNV, String TenNV, DateTime NgayBan, String MaKH, String TenKH, String TongTien)
        {
            SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET TenNV = @TenNV, NgayBan = @NgayBan, TenKH = @TenKH, NgayBan = @NgayBan, TongTien = @TongTien,  WHERE MaHD = @MaHD AND MaKH = @MaKH AND MaNV = @MaNV");
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = MaHD;
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("TenNV", SqlDbType.NVarChar).Value = TenNV;
            cmd.Parameters.Add("NgayBan", SqlDbType.DateTime).Value = NgayBan;
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("TongTien", SqlDbType.NVarChar).Value = TongTien;

            m_DatHangData.Load(cmd);
        }

        public void XoaDatHang(String MaHD, String MaKH, String MaNV)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHD = @MaHD AND MaNV = @MaNV AND MaKH = @MaKH");
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;
            cmd.Parameters.Add("MaKH", SqlDbType.VarChar).Value = MaKH;
            m_DatHangData.Load(cmd);
        }
    }
}
