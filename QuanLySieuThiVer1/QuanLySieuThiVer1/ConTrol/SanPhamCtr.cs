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
    class SanPhamCtr
    {
        SanPhamDaTa m_MatHangData = new SanPhamDaTa();
        SanPhamInfo m_MatHangInfo = new SanPhamInfo();
        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_MatHangData.LayMatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenSP";

            cbx.ValueMember = "MaSP";


        }

        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_MatHangData.LayMatHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "MaSP";

            cbx.ValueMember = "MaSP";
        }
        public static IList<SanPhamInfo> LayDsMatHang()
        {
            IList<SanPhamInfo> ds = new List<SanPhamInfo>();

            SanPhamDaTa data = new SanPhamDaTa();
            DataTable tbl = data.LayMatHang();

            IList<SanPhamInfo> MatHang = new List<SanPhamInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                SanPhamInfo MH = new SanPhamInfo();

               

                MH.MaSP = Convert.ToString(row["MaSP"]);
                MH.TenSP = Convert.ToString(row["TenSP"]);              
                MH.DonGia = Convert.ToString(row["DonGia"]);
                MH.DonGiaBan = Convert.ToString(row["GiaBan"]);
                MH.SoLuong = Convert.ToString(row["SoLuong"]);
                MH.DonViTinh = Convert.ToString(row["DonViTinh"]);
                MatHang.Add(MH);
            }
            return MatHang;
        }

        public static IList<SanPhamInfo> LayDsMatHangTheoMa(String MaSP)
        {
            IList<SanPhamInfo> ds = new List<SanPhamInfo>();

            SanPhamDaTa data = new SanPhamDaTa();
            DataTable tbl = data.LayDSMatHangTheoMa(MaSP);

            IList<SanPhamInfo> MatHang = new List<SanPhamInfo>();

            foreach (DataRow row in tbl.Rows)
            {
                SanPhamInfo MH = new SanPhamInfo();



                MH.MaSP = Convert.ToString(row["MaSP"]);
                MH.TenSP = Convert.ToString(row["TenSP"]);
                MH.DonGia = Convert.ToString(row["DonGia"]);
                MH.DonGiaBan = Convert.ToString(row["GiaBan"]);
                MH.SoLuong = Convert.ToString(row["SoLuong"]);
                MH.DonViTinh = Convert.ToString(row["DonViTinh"]);
                MatHang.Add(MH);

                MatHang.Add(MH);
            }
            return MatHang;
        }

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_MatHangData.LayMatHang();
            cmbColumn.DisplayMember = "TenSP";
            cmbColumn.ValueMember = "MaSP";
            cmbColumn.DataPropertyName = "MaSP";
            cmbColumn.HeaderText = "Tên Sản Phẩm";
        }
        #endregion

        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_MatHangData.LayMatHang();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaSP,
                            TextBox txtTenSP,
                            TextBox txtDonGia,
                            TextBox txtDonGiaBan,
                            TextBox txtSoLuong,
                             TextBox txtDonViTinh)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_MatHangData.LayMatHang();

            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", bS, "MaSP");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", bS, "TenSP");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bS, "DonGia");

            txtDonGiaBan.DataBindings.Clear();
            txtDonGiaBan.DataBindings.Add("Value", bS, "DonGiaBan");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", bS, "SoLuong");

            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", bS, "DonViTinh");          

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_MatHangData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
            m_MatHangData.ThemMatHang(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuMatHang()
        {
            return m_MatHangData.LuuMatHang();
        }

        public void LuuMatHang(String MaSP, String TenSP, String DonGia, String DonGiaBan, String SoLuong, String DonViTinh)
        {
            m_MatHangData.LuuMatHang(MaSP, TenSP, DonGia, DonGiaBan, SoLuong, DonViTinh);
        }
        #endregion
        #region Sửa
        public void SuaMatHang(String MaSP, String TenSP, String DonGia, String DonGiaBan, String SoLuong, String DonViTinh)
        { 
            m_MatHangData.SuaMatHang(MaSP, TenSP, DonGia, DonGiaBan, SoLuong, DonViTinh);
        }
        #endregion

        #region Xóa
        public void XoaMatHang(String MaSP)
        {
            m_MatHangData.XoaMatHang(MaSP);
        }
        #endregion
        //#region tim kiem
        //public void TimKiemTheoMa(String m_MaMH)
        //{
        //    m_MatHangData.TimKiemTheoMa(m_MaMH);
        //}

        //public void TiemKiemTheoTen(String m_TenMH)
        //{
        //    m_MatHangData.TimKiemTheoTen(m_TenMH);
        //}
        //#endregion
    }
}
