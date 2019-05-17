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
    class NhanVienDaTa
    {
        DaTaServer m_NhanVienData = new DaTaServer();

        public DataTable LayNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }
        

        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.NewRow();
        }

        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.Rows.Add(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhanVien(String MaNV, String HoTenNV, String DiaChi,DateTime NgSinh, String SDT,String GioiTinh)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien VALUES(@MaNV, @HoTenNV, @DiaChi,@NgSinh, @SDT,  @GioiTinh)");
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("HoTenNV", SqlDbType.NVarChar).Value = HoTenNV;
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = DiaChi;
            cmd.Parameters.Add("NgSinh", SqlDbType.DateTime).Value = NgSinh;
            cmd.Parameters.Add("SDT", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("GioiTinh", SqlDbType.NVarChar).Value = GioiTinh;

            m_NhanVienData.Load(cmd);
        }

        public void SuaNhanVien(String MaNV, String HoTenNV, String DiaChi, DateTime NgSinh, String SDT, String GioiTinh)
        {
            SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET HoTenNV = @HoTenNV,DiaChi=@DiaChi, NgSinh = @NgaySinh, SDT = @SDT,  GioiTinh=@GioiTinh WHERE MaNV = @MaNV");
            cmd.Parameters.Add("MaNV", SqlDbType.NVarChar).Value = MaNV;
            cmd.Parameters.Add("HoTenNV", SqlDbType.NVarChar).Value = HoTenNV;           
            cmd.Parameters.Add("DiaChi", SqlDbType.NVarChar).Value = DiaChi;
            cmd.Parameters.Add("NgSinh", SqlDbType.DateTime).Value = NgSinh;
            cmd.Parameters.Add("SDT", SqlDbType.VarChar).Value = SDT;
            cmd.Parameters.Add("GioiTinh", SqlDbType.VarChar).Value = GioiTinh;

            m_NhanVienData.Load(cmd);
        }

        public void XoaNhanVien(String MaNV)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV = @MaNV");
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;
            m_NhanVienData.Load(cmd);
        }

    }
}
