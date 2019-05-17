using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiVer1.DaTa;
using QuanLySieuThiVer1.DB_Layer;
using QuanLySieuThiVer1.Info;
using QuanLySieuThiVer1.BS_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLySieuThiVer1.ConTrol
{
    class ChiTietHoaDonCtr
    {
        ChiTietHoaDonDaTa m_XuatHangData = new ChiTietHoaDonDaTa();
        ChiTietHoaDonInfo m_XuatHangInfo = new ChiTietHoaDonInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_XuatHangData.LayChiTietHoaDon();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaHD";

            cbx.ValueMember = "MaHD";
        }

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_XuatHangData.LayChiTietHoaDon();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public static IList<ChiTietHoaDonInfo> LayDsXuatHangTheoMa(String MaHD)
        {
            IList<ChiTietHoaDonInfo> ds = new List<ChiTietHoaDonInfo>();

            ChiTietHoaDonDaTa data = new ChiTietHoaDonDaTa();
            DataTable tbl = data.LayDSXuatHangTheoMa(MaHD);

            IList<ChiTietHoaDonInfo> XuatHang = new List<ChiTietHoaDonInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                ChiTietHoaDonInfo XH = new ChiTietHoaDonInfo();

                SanPhamInfo m_MH = new SanPhamInfo();
                m_MH.MaSP = Convert.ToString(row["MaSP"]);
                m_MH.TenSP = Convert.ToString(row["TenSP"]);
                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.MaKH = Convert.ToString(row["MaKH"]);
                m_KH.TenKH = Convert.ToString(row["TenKH"]);
                NhanVienInfo m_NV = new NhanVienInfo();
                m_NV.MaNV = Convert.ToString(row["MaNV"]);
                m_NV.HoTenNV = Convert.ToString(row["HoTenNV"]);

                HoaDonInfo m_HD = new HoaDonInfo();
                m_HD.MaHD = Convert.ToString(row["MaHD"]);
                m_HD.NgayBan = Convert.ToDateTime(row["NgayBan"]);
                XH.SoLuong = Convert.ToString(row["SoLuong"]);
                XH.DonGia = Convert.ToString(row["GiaBan"]);
                XH.ThanhTien = Convert.ToString(row["ThanhTien"]);

                XH.MaKH = m_KH;
                XH.MaNV = m_NV;
                XH.MaSP = m_MH;
                XuatHang.Add(XH);
            }
            return XuatHang;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            ComboBox cmbMaHD,
                            DateTimeInput DTNgayBan,
                            TextBox txtSoLuong,
                            TextBox txtGiaBan,
                            TextBox txtThanhTien,
                            TextBox txtDiaChiKH,
                            TextBox txtSDT,
                            ComboBox cmbTenSP,
                            ComboBox cmbMaSP,
                            ComboBox cmbTenKH,
                            ComboBox cmbMaKH,
                            ComboBox cmbTenNV,
                            ComboBox cmbMaNV)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_XuatHangData.LayChiTietHoaDon();

            cmbMaHD.DataBindings.Clear();
            cmbMaHD.DataBindings.Add("SelectedValue", bS, "MaHD");

            DTNgayBan.DataBindings.Clear();
            DTNgayBan.DataBindings.Add("Value", bS, "NgayBan");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", bS, "GiaBan");

            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", bS, "ThanhTien");
            txtDiaChiKH.DataBindings.Clear();
            txtDiaChiKH.DataBindings.Add("Text", bS, "DiaChiKH");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bS, "SDT");

            cmbMaSP.DataBindings.Clear();
            cmbMaSP.DataBindings.Add("SelectedValue", bS, "MaSP");

            cmbTenSP.DataBindings.Clear();
            cmbTenSP.DataBindings.Add("SelectedValue", bS, "TenSP");

            cmbTenKH.DataBindings.Clear();
            cmbTenKH.DataBindings.Add("SelectedValue", bS, "TenKH");

            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("SelectedValue", bS, "MaKH");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bS, "MaNV");

            cmbTenNV.DataBindings.Clear();
            cmbTenNV.DataBindings.Add("SelectedValue", bS, "TenNV");



            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_XuatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_XuatHangData.ThemChiTietHoaDon(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuXuatHang()
        {
            return m_XuatHangData.LuuChiTietHoaDon();
        }

        public void LuuXuatHang(String MaHD, DateTime NgayBan, String MaNV, String TenNV, String MaKH, String TenKH, String DiaChiKH, String SDT, String MaSP, String TenSP, String DonGia, String SoLuong, String ThanhTien)
        {
            m_XuatHangData.LuuChiTietHoaDon(MaHD, NgayBan, MaNV, TenNV, MaKH, TenKH, DiaChiKH, SDT, MaSP, TenSP, DonGia, SoLuong, ThanhTien);
        }
        #endregion

        #region Sửa
        public void SuaXuatHang(String MaHD, DateTime NgayBan, String MaNV, String TenNV, String MaKH, String TenKH, String DiaChiKH, String SDT, String MaSP, String TenSP, String DonGia, String SoLuong, String ThanhTien)
        {
            m_XuatHangData.SuaXuatHang(MaHD, NgayBan, MaNV, TenNV, MaKH, TenKH, DiaChiKH, SDT, MaSP, TenSP, DonGia, SoLuong, ThanhTien);
        }
        #endregion

       
        public void XoaXuatHang(String MaHD, String MaSP, String MaKH, String MaNV)
        {
            m_XuatHangData.XoaXuatHang(MaHD, MaSP, MaKH, MaNV);
        }
    }
}
