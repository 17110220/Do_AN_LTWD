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
    class HoaDonCtr
    {
        HoaDonDaTa m_DatHangData = new HoaDonDaTa();
        HoaDonInfo m_DatHangInfo = new HoaDonInfo();


        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_DatHangData.LayDatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaHD";

            cbx.ValueMember = "MaHD";
        }
        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_DatHangData.LayDatHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DatHangData.LayDatHang();
            cmbColumn.DisplayMember = "MaHD";
            cmbColumn.ValueMember = "MaHD";
            cmbColumn.DataPropertyName = "MaHD";
            cmbColumn.HeaderText = "Mã Hóa Đơn";
        }
        public static IList<HoaDonInfo> LayDsDatHangTheoMa(String MaHD)
        {
            IList<HoaDonInfo> ds = new List<HoaDonInfo>();

            HoaDonDaTa data = new HoaDonDaTa();
            DataTable tbl = data.LayDSDatHangTheoMa(MaHD);

            IList<HoaDonInfo> DatHang = new List<HoaDonInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                HoaDonInfo DH = new HoaDonInfo();

                SanPhamInfo m_MH = new SanPhamInfo();
                m_MH.MaSP = Convert.ToString(row["MaSP"]);
                m_MH.TenSP = Convert.ToString(row["TenSP"]);              
                KhachHangInfo m_KH = new KhachHangInfo();
                m_KH.TenKH = Convert.ToString(row["TenKH"]);
                m_KH.MaKH = Convert.ToString(row["MaKH"]);
                NhanVienInfo m_NV = new NhanVienInfo();
                m_NV.MaNV = Convert.ToString(row["MaNV"]);
                m_NV.HoTenNV = Convert.ToString(row["HoTenNV"]);
                DH.MaHD = Convert.ToString(row["MaHD"]);                                            
                DH.TongTien = Convert.ToString(row["TongTien"]);
                DH.NgayBan = Convert.ToDateTime(row["NgayBan"]);
                DatHang.Add(DH);
            }
            return DatHang;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaHD,
                            ComboBox cmbMaNV,
                            ComboBox cmbTenNV,
                            DateTimeInput DTNgayBan,
                            ComboBox cmbMaKH,
                            ComboBox cmbTenKH,
                            TextBox txtTongTien)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DatHangData.LayDatHang();
            DataTable dT = m_DatHangData.LayDatHang();
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", bS, "MaHD");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bS, "MaNV");

            cmbTenNV.DataBindings.Clear();
            cmbTenNV.DataBindings.Add("SelectedValue", bS, "TenNV");

            DTNgayBan.DataBindings.Clear();
            DTNgayBan.DataBindings.Add("Value", bS, "NgayBan");

            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("SelectedValue", bS, "MaKH");

            cmbTenKH.DataBindings.Clear();
            cmbTenKH.DataBindings.Add("SelectedValue", bS, "TenKH");

            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", bS, "TongTien");
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_DatHangData.ThemDatHang(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuDatHang()
        {
            return m_DatHangData.LuuDatHang();
        }

        public void LuuDatHang(String MaHD, String MaNV, String TenNV, DateTime NgayBan, String MaKH, String TenKH, String TongTien)
        {
            m_DatHangData.LuuDatHang(MaHD, MaNV, TenNV, NgayBan, MaKH, TenKH, TongTien);
        }
        #endregion

        #region Sửa
        public void SuaDatHang(String MaHD, String MaNV, String TenNV, DateTime NgayBan, String MaKH, String TenKH, String TongTien)
        {
            m_DatHangData.SuaDatHang(MaHD, MaNV, TenNV, NgayBan, MaKH, TenKH, TongTien);
        }
        #endregion

        #region Xóa
        public void XoaDatHang(String MaHD, String MaKH, String MaNV)
        {
            m_DatHangData.XoaDatHang(MaHD, MaKH, MaNV);
        }
        #endregion
    }
}
