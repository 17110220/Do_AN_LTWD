using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThiVer1.BS_Layer;
using System.Windows.Forms;
namespace QuanLySieuThiVer1
{
    class KhachHangCtr
    {
        BlTimKiemKhachHang m_KhachHangData = new BlTimKiemKhachHang ();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_KhachHangData.LayKhachHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "TenKH";
            cbx.ValueMember = "MaKH";
        }

        public void HienThiComboBox1(ComboBox cbx)
        {
            DataTable m_DT = m_KhachHangData.LayKhachHang();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "DiaChiKH";
            cbx.ValueMember = "MaKH";
        }
        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhachHangData.LayKhachHang();
            cmbColumn.DisplayMember = "TenKH";
            cmbColumn.ValueMember = "MaKH";
            cmbColumn.DataPropertyName = "MaKH";
            cmbColumn.HeaderText = "Tên khách hàng";
        }

        public void LayMaTheoTen(String TenKH)
        {
            DataTable dt = m_KhachHangData.LayMaKHTheoTen(TenKH);
            this.MaKH = dt.Rows[0]["MaKH"].ToString();
        }

        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }
        #endregion
        #region hien thi
        public void HienThi(DataGridView Dgv)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = m_KhachHangData.LayKhachHang();
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaKH,
                            TextBox txtHoTen,
                            TextBox txtDiaChi,
                            TextBox txtSoDienThoai
                            )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhachHangData.LayKhachHang();

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", bS, "MaKH");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bS, "TenKH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChiKH");

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bS, "SDT");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion      
        public void TimKiemTheoMa(String m_MaKH)
        {
            m_KhachHangData.LayKHTheoMa(m_MaKH);
        }

       
    }
}
