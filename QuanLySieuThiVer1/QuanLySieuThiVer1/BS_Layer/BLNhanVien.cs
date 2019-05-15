using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThiVer1.DB_Layer;
namespace QuanLySieuThiVer1.BS_Layer
{
    class BLNhanVien
    {
        KetNoi db = null;
        public BLNhanVien()
        {
            db = new KetNoi();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string HoTenNV, string DiaChi, DateTime NgSinh, string SDT, bool Nam,string MaQuayGiaoDich,  ref string err)
        {
            string sqlString = "Insert Into MaNV Values(" + "'" + MaNV + "',N'" + HoTenNV + "',N'" + DiaChi + "'" + NgSinh + "'" + SDT + "'" + Nam +"'"+MaQuayGiaoDich+ "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNV, string HoTenNV, string DiaChi, DateTime NgSinh, string SDT, bool Nam,string MaQuayGiaoDich , ref string err)
        {
            string sqlString = "Update NhanVien Set HoTenNV=N'" + HoTenNV + ",DiaChi=N'" + DiaChi + ",NgSinh='" + NgSinh + ",SDT='" + SDT + ",Nam='" + Nam +",MaQuayGiaoDich='"+MaQuayGiaoDich+ "' Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
