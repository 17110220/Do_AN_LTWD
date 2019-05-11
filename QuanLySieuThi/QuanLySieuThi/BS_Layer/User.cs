using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.DB_Layer;

namespace QuanLySieuThi
{
    class User
    {
       public bool dangnhap(string MaQuyen,string MaNV, string TenDangNhap, string MatKhau, ref string err)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            var khQuery = (from dn in qlst.Phan_quyen
                           where dn.MaQuyen == MaQuyen
                           select dn).SingleOrDefault();
            if (khQuery != null)
            {
                khQuery.MaNV = MaNV;
                khQuery.TenDanNhap = TenDangNhap;
                khQuery.MatKhau = MatKhau;
            }
            return true;
        }
    }
}
