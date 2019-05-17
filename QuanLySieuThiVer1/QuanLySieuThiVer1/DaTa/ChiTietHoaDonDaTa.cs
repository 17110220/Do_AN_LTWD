using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using QuanLySieuThiVer1.DB_Layer;
namespace QuanLySieuThiVer1.BS_Layer
{
    class ChiTietHoaDonDaTa
    {
        DaTaServer m_ChiTietHoaDonData = new DaTaServer();
        DaTaServer m_SanPhamgData = new DaTaServer();
        public DataTable LaySanPham()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham");
            m_SanPhamgData.Load(cmd);
            return m_SanPhamgData;
        }
        public DataTable LayChiTietHoaDon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTietHoaDon");
            m_ChiTietHoaDonData.Load(cmd);
            return m_ChiTietHoaDonData;
        }
        public DataTable LayDSXuatHangTheoMa(String MaHD)
        {
            SqlCommand cmd = new SqlCommand("SELECT HD.MaHD,CTHD.SoLuong,CTHD.DonGia,CTHD.ThanhTien, SP.MaSP,SP.TenSP, KH.MaKH, KH.TenKH,KH.DiaChiKH,KH.SDT, NV.MaNV, NV.HoTenNV, HD.NgayBan FROM ChiTietHoaDon CTHD INNER JOIN SanPham SP ON SP.MaSP = CTHD.MaSP INNER JOIN HoaDon HD ON HD.MaHD=CTHD.MaHD INNER JOIN KhachHang KH ON KH.MaKH = HD.MaKH INNER JOIN NhanVien NV ON NV.MaNV = HD.MaNV  WHERE CTHD.MaHD = @MaHD");
            cmd.Parameters.Add("MaHD", SqlDbType.VarChar).Value = MaHD;
            m_ChiTietHoaDonData.Load(cmd);
            return m_ChiTietHoaDonData;
        }
        public DataRow ThemDongMoi()
        {
            return m_ChiTietHoaDonData.NewRow();
        }

        public void ThemChiTietHoaDon(DataRow m_Row)
        {
            m_ChiTietHoaDonData.Rows.Add(m_Row);
        }

        public bool LuuChiTietHoaDon()
        {
            return m_ChiTietHoaDonData.ExecuteNoneQuery() > 0;
        }
        public void LuuChiTietHoaDon(String MaHD, DateTime NgayBan, String MaNV,String TenNV, String MaKH, String TenKH,String DiaChiKH,String SDT, String MaSP,String TenSP,String DonGia,String SoLuong,String ThanhTien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietHoaDon VALUES(@MaHD, @NgayBan, @mMaNV, @TenNV, @MaKH, @TenKH, @DiaChiKH, @SDT, @MaSP, @TenSP,@DonGia,@SoLuong,ThanhTien)");
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = MaHD;
            cmd.Parameters.Add("NgayBan", SqlDbType.DateTime).Value = NgayBan;
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("MaTenNV", SqlDbType.NVarChar).Value = TenNV;
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("DiaCHiKH", SqlDbType.NVarChar).Value = DiaChiKH;
            cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;
            cmd.Parameters.Add("TenSP", SqlDbType.NVarChar).Value = TenSP;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = DonGia;
            cmd.Parameters.Add("SoLuong", SqlDbType.NVarChar).Value = SoLuong;
            cmd.Parameters.Add("ThanhTien", SqlDbType.NVarChar).Value = ThanhTien;

            m_ChiTietHoaDonData.Load(cmd);
        }

        public void SuaXuatHang(String MaHD, DateTime NgayBan, String MaNV, String TenNV, String MaKH, String TenKH, String DiaChiKH, String SDT, String MaSP, String TenSP, String DonGia, String SoLuong, String ThanhTien)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ChiTietHoaDon SET SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien, NgayBan = @NgayBan, TenNV=@TenNV,TenKH=@TenKH,DiaChiKH=@DiaChiKH,SDT=@SDT,TenSP=@TenSP  WHERE MaHD = @MaHD AND MaSP = @MaSP AND MaKH = @MaKH AND  MaNV = @MaNV");
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = MaHD;
            cmd.Parameters.Add("NgayBan", SqlDbType.DateTime).Value = NgayBan;
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("MaTenNV", SqlDbType.NVarChar).Value = TenNV;
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("TenKH", SqlDbType.NVarChar).Value = TenKH;
            cmd.Parameters.Add("DiaCHiKH", SqlDbType.NVarChar).Value = DiaChiKH;
            cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;
            cmd.Parameters.Add("TenSP", SqlDbType.NVarChar).Value = TenSP;
            cmd.Parameters.Add("DonGia", SqlDbType.NVarChar).Value = DonGia;
            cmd.Parameters.Add("SoLuong", SqlDbType.NVarChar).Value = SoLuong;
            cmd.Parameters.Add("ThanhTien", SqlDbType.NVarChar).Value = ThanhTien;
            m_ChiTietHoaDonData.Load(cmd);
        }

        public void XoaXuatHang(String MaHD, String MaSP, String MaKH, String MaNV)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP AND MaKH = @MaKH AND MaNV = @MaNV");
            cmd.Parameters.Add("MaHD", SqlDbType.NVarChar).Value = MaHD;
            cmd.Parameters.Add("MaSP", SqlDbType.NVarChar).Value = MaSP;
            cmd.Parameters.Add("MaKH", SqlDbType.NVarChar).Value = MaKH;
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            m_ChiTietHoaDonData.Load(cmd);
        }
    }
}
