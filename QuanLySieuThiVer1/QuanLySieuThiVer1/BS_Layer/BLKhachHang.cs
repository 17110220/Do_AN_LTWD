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
    class BLKhachHang
    {
        KetNoi db = null;
        public BLKhachHang()
        {
            db = new KetNoi();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKH, string TenKH, string DiaChiKH,  string SDT,  ref string err)
        {
            string sqlString = "Insert Into KhachHang Values(' " +  MaKH + "',N'" + TenKH + "',N'" + DiaChiKH +  "',N'" + SDT + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachhang(ref string err, string MaKH)
        {
            string sqlString = "Delete From KhachHang Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, string DiaChiKH, string SDT, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" + TenKH + "',DiaChiKH=N'" + DiaChiKH +  "',SDT=N'" + SDT + "' Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
