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
    class BLNhanVien
    {
        public DataTable LayNhanVien()
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            var tps = from p in qlst.NhanViens
                      select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Nhân Viên");
            dt.Columns.Add("Tên Nhân Viên");
            dt.Columns.Add("Giới Tính", typeof(bool));
            dt.Columns.Add("Địa Chỉ");
            dt.Columns.Add("Ngày Sinh", typeof(DateTime));
            dt.Columns.Add("SDT");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.MaNV, p.HoTenNV, p.Nam, p.DiaChi, p.NgSinh, p.SDT);

            }
            return dt;
        }
        public bool ThemNhanVien(string MaNV, string HoTenNV, bool Nam, string DiaChi,
            DateTime NgSinh, string SDT, ref string err)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.HoTenNV = HoTenNV;
            nv.Nam = Nam;
            nv.DiaChi = DiaChi;
            nv.NgSinh = NgSinh;
            nv.SDT = SDT;
            qlst.NhanViens.Add(nv);
            qlst.SaveChanges();
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;

            qlst.NhanViens.Attach(nv);
            qlst.NhanViens.Remove(nv);
            qlst.SaveChanges();
            return true;
        }
        public bool CapNhatNhanVien (string MaNV, string HoTenNV, bool Nam, string DiaChi,
            DateTime NgSinh, string SDT, ref string err)
        {
            QuanLySieuThiEntities qlst = new QuanLySieuThiEntities();
            var nvQuery = (from nv in qlst.NhanViens
                           where nv.MaNV == MaNV
                           select nv).SingleOrDefault();
            if(nvQuery!=null)
            {
                nvQuery.HoTenNV = HoTenNV;
                nvQuery.Nam = Nam;
                nvQuery.DiaChi = DiaChi;
                nvQuery.NgSinh = NgSinh;
                nvQuery.SDT = SDT;
            }
            return true;
        }
    }
}
