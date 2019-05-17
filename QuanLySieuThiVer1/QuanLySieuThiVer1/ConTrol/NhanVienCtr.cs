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

namespace QuanLySieuThiVer1.ConTrol
{
    class NhanVienCtr
    {
        NhanVienDaTa m_NhanVienData = new NhanVienDaTa();
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_NhanVienData.LayNhanVien();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "HoTenNV";

            cbx.ValueMember = "MaNV";


        }

        public static IList<NhanVienInfo> LayDsNhanVien()
        {
            IList<NhanVienInfo> ds = new List<NhanVienInfo>();

            NhanVienDaTa data = new NhanVienDaTa();
            DataTable tbl = data.LayNhanVien();

            IList<NhanVienInfo> NhanVien = new List<NhanVienInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                NhanVienInfo NV = new NhanVienInfo();
              
                NV.MaNV = Convert.ToString(row["MaNV"]);
                NV.HoTenNV = Convert.ToString(row["HoTenNV"]);
                NV.DiaChi = Convert.ToString(row["DiaChi"]);               
                NV.NgSinh = Convert.ToDateTime(row["NgaySinh"]);
                NV.SDT = Convert.ToString(row["DienThoai"]);
                NV.GioiTinh = Convert.ToString(row["GioiTinh"]);
               

                NhanVien.Add(NV);
            }
            return NhanVien;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhanVienData.LayNhanVien();
            cmbColumn.DisplayMember = "HoTenNV";
            cmbColumn.ValueMember = "MaNV";
            cmbColumn.DataPropertyName = "MaNV";
            cmbColumn.HeaderText = "Tên nhân viên";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_NhanVienData.LayNhanVien();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaNV,
                            TextBox txtHoTen,
                            DateTimePicker dtNgaySinh,
                            TextBox txtDiaChi,
                            TextBox txtSoDienThoai,
                            TextBox txtGioiTinh)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.LayNhanVien();

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bS, "MaNV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bS, "HoTenNV");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

           


            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_NhanVienData.ThemNhanVien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuNhanVien()
        {
            return m_NhanVienData.LuuNhanVien();
        }

        public void LuuNhanVien(String MaNV, String TenNV, String DiaChi,DateTime NgSinh, String SDT, String GioiTinh)
        {
            m_NhanVienData.LuuNhanVien(MaNV, TenNV, DiaChi, NgSinh, SDT,GioiTinh);
        }
        #endregion

        #region Sửa
        public void SuaNhanVien(String MaNV, String TenNV, String DiaChi, DateTime NgSinh, String SDT, String GioiTinh)
        {
            m_NhanVienData.SuaNhanVien(MaNV, TenNV, DiaChi, NgSinh, SDT, GioiTinh);
        }
        #endregion

        #region Xóa
        public void XoaNhanVien(String MaNV)
        {
            m_NhanVienData.XoaNhanVien(MaNV);
        }
        #endregion
        //#region tim kiem
        //public void TimKiemTheoMa(String m_MaNV)
        //{
        //    m_NhanVienData.TimKiemTheoMa(m_MaNV);
        //}

        //public void TiemKiemTheoTen(String m_HoTen)
        //{
        //    m_NhanVienData.TimKiemTheoTen(m_HoTen);
        //}
        //#endregion

    }
}
