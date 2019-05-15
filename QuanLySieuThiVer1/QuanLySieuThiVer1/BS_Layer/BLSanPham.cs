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
        public bool ThemSanPham(string MaSP, string TenSP, string DonGia,string DonGiaBan,string SoLuong, DateTime NgayNhap,  string DonViTinh, ref string err)
        {
            string sqlString = "Insert Into MaSP Values(" + "'" + MaSP + "',N'" + TenSP + "'" + DonGia + "'" + DonGiaBan + "'" + SoLuong + "'" + NgayNhap + ",N'" + DonViTinh + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSanPham(ref string err, string MaSP)
        {
            string sqlString = "Delete From SanPham Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSanPham(string MaSP, string TenSP, string DonGia, string DonGiaBan, string SoLuong, DateTime NgayNhap, string DonViTinh, ref string err)
        {
            string sqlString = "Update SanPham Set TenSP=N'" + TenSP + "DonGia='" + DonGia + "DonGiaBan='" + DonGiaBan + "SoLuong='" + SoLuong + "NgayNhap='" + NgayNhap + ",DonViTinh=N'" + DonViTinh + "' Where MaSP='" + MaSP + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
