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
    class BLHoaDon
    {
        KetNoi db = null;
        public BLHoaDon()
        {
            db = new KetNoi();
        }
        public DataSet LayHoaDon()
        {
            return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text);
        }
        public bool ThemHoaDon(string MaHD,string MaSP,string SoLuong,string DonGia, ref string err)
        {
            string sqlString = "Insert Into HoaDon Values(' " + MaHD + "',N'" + MaSP + "',N'" + SoLuong + "',N'" + DonGia + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHoaDon(ref string err, string MaHD)
        {
            string sqlString = "Delete From HoaDon Where MaHD='" + MaHD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatHoaDon(string MaHD, string MaSP, string SoLuong, string DonGia, ref string err)
        {
            string sqlString = "Update HoaDon Set MaSP=N'" + MaSP + "',SoLuong=N'" + SoLuong + "',DonGia=N'" + DonGia +  "' Where MaNV='" + MaHD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
