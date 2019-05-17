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
    class SanPhamDaTa
    {

        DaTaServer m_MatHangData = new DaTaServer();
        public DataTable LayMatHang()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham");
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }
        

        public DataTable LayDSMatHangTheoMa(String MaSP)
        {
            SqlCommand cmd = new SqlCommand("SELECT SP.MaSP, SP.TenSP, SP.SoLuong, SP.DonGia, SP.DonGiaBan  WHERE SP.MaSP = @MaSP");
            cmd.Parameters.Add("MaSP", SqlDbType.VarChar).Value = MaSP;
            m_MatHangData.Load(cmd);
            return m_MatHangData;
        }

        public DataRow ThemDongMoi()
        {
            return m_MatHangData.NewRow();
        }

        public void ThemMatHang(DataRow m_Row)
        {
            m_MatHangData.Rows.Add(m_Row);
        }

        public bool LuuMatHang()
        {
            return m_MatHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuMatHang(String MaSP, String TenSP,  String DonGia, String DonGiaBan, String SoLuong, String DonViTinh)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SanPham VALUES(@MaSP, @TenSP, @DonGia, @DonGiaBan, @SoLuong,@DonViTinh)");
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;
            cmd.Parameters.Add("TenSP", SqlDbType.NVarChar).Value = TenSP;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = DonGia;
            cmd.Parameters.Add("DonGiaBan", SqlDbType.NVarChar).Value = DonGiaBan;
            cmd.Parameters.Add("SoLuong", SqlDbType.NVarChar).Value = SoLuong;
            cmd.Parameters.Add("DonViTinh", SqlDbType.NVarChar).Value = DonViTinh;
          

            m_MatHangData.Load(cmd);
        }

        public void SuaMatHang(String MaSP, String TenSP, String DonGia, String DonGiaBan, String SoLuong, String DonViTinh)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SanPham SET TenSP= @TenSP,DonGia = @DonGia, DonGiaBan = @DonGiaBan ,SoLuong = @SoLuong, DonViTinh=@DonViTinh WHERE MaSP = @MaSP ");
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;
            cmd.Parameters.Add("TenSP", SqlDbType.NVarChar).Value = TenSP;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = DonGia;
            cmd.Parameters.Add("DonGiaBan", SqlDbType.NVarChar).Value = DonGiaBan;
            cmd.Parameters.Add("SoLuong", SqlDbType.NVarChar).Value = SoLuong;
            cmd.Parameters.Add("DonViTinh", SqlDbType.NVarChar).Value = DonViTinh;


            m_MatHangData.Load(cmd);
        }

        public void XoaMatHang( String MaSP)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSP = @MaSP ");
           
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;

            m_MatHangData.Load(cmd);
        }
    }
}
