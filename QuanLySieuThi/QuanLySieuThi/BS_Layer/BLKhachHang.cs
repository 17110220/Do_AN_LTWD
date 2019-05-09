using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.DB_Layer;

namespace QuanLySieuThi.BS_Layer
{
    class BLKhachHang
    {
        public DataTable LayKhachHang()
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            var tps = from p in qlst.KhachHangs
                      select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Tên Khách Hàng");         
            dt.Columns.Add("Địa Chỉ");        
            dt.Columns.Add("SDT");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaKH, p.TenKH, p.DiaChiKH,p.SDT);

            }
            return dt;
        }
        public bool ThemKhachHang(string MaKH, string Hoten, string DiaChi, string SDT, ref string err)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.TenKH = Hoten;           
            kh.DiaChiKH = DiaChi;
            kh.SDT = SDT;
            qlst.KhachHangs.Add(kh);
            qlst.SaveChanges();
            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;

            qlst.KhachHangs.Attach(kh);
            qlst.KhachHangs.Remove(kh);
            qlst.SaveChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string Hoten, string DiaChi, string SDT, ref string err)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            var khQuery = (from kh in qlst.KhachHangs
                           where kh.MaKH == MaKH
                           select kh).SingleOrDefault();
            if (khQuery != null)
            {
                khQuery.TenKH= Hoten;
                khQuery.DiaChiKH = DiaChi;
                khQuery.SDT = SDT;
            }
            return true;
        }
    }
}
