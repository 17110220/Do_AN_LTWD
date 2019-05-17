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
    class BLSanPham
    {
        KetNoi db = null;
        public BLSanPham()
        {
            db = new KetNoi();
        }
        public DataSet LaySanPham()
        {
            return db.ExecuteQueryDataSet("select * from SanPham", CommandType.Text);
        }
        public bool ThemSanPham(string MaSP, string TenSP, string DonGia,string DonGiaBan,string SoLuong,  string DonViTinh, ref string err)
        {
            string sqlString = "Insert Into SanPham Values('"  + MaSP + "',N'" + TenSP + "',N'" + DonGia + "',N'" + DonGiaBan + "',N'" + SoLuong +  "',N'" + DonViTinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSanPham(ref string err, string MaSP)
        {
            string sqlString = "Delete From SanPham Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSanPham(string MaSP, string TenSP, string DonGia, string DonGiaBan, string SoLuong, string DonViTinh, ref string err)
        {
            string sqlString = "Update SanPham Set TenSP=N'" + TenSP + "',DonGia=N'" + DonGia + "',DonGiaBan=N'" + DonGiaBan + "',SoLuong=N'" + SoLuong + "',DonViTinh=N'" + DonViTinh + "' Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
