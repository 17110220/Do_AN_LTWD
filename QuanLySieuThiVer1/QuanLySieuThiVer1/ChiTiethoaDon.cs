using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiVer1.DB_Layer;
using System.Data.SqlClient;
using QuanLySieuThiVer1.ConTrol;
namespace QuanLySieuThiVer1
{
    public partial class ChiTietHoaDon : Form
    {

        PhongManHinh _form_resize;
        ChiTietHoaDonCtr m_XuatHangCtrl = new ChiTietHoaDonCtr();
        SanPhamCtr m_MatHangCtrl = new SanPhamCtr();
        HoaDonCtr m_HoaDonCtr = new HoaDonCtr();
        KhachHangCtr1 m_KhachHangCtrl = new KhachHangCtr1();
        NhanVienCtr m_NhanVienCtrl = new NhanVienCtr();
        QuyDinh m_QuyDinh = new QuyDinh();
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        public ChiTietHoaDon()
        {
            InitializeComponent();
            DaTaServer.OpenConnection();
            _form_resize = new PhongManHinh(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            m_HoaDonCtr.HienThiComboBox(cmbMaHD);
            m_HoaDonCtr.HienThiDataGridViewComboBoxColumn(MaHD);

            m_KhachHangCtrl.HienThiComboBox(cmbMaKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(MaKH);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(TenKH);

            m_NhanVienCtrl.HienThiComboBox(cmbMaNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(MaNV);
            m_NhanVienCtrl.HienThiComboBox(cmbTenNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(HoTenNV);

            m_MatHangCtrl.HienThiComboBox(cmbMaSP);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(MaSP);
            m_MatHangCtrl.HienThiComboBox(cmbTenSP);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(TenSP);
            m_XuatHangCtrl.HienThi(dataGridView1, bindingNavigator1, cmbMaHD, dalap, txtsoluong, txtGiaBan, txtthanhtien, txtdiachi, txtSDT, cmbTenSP, cmbMaSP, cmbTenKH, cmbMaKH, cmbTenNV, cmbMaNV);
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_HoaDonCtr.HienThiComboBox(cmbMaHD);
            m_HoaDonCtr.HienThiDataGridViewComboBoxColumn(MaHD);

            m_KhachHangCtrl.HienThiComboBox(cmbMaKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(MaKH);
            m_KhachHangCtrl.HienThiComboBox(cmbTenKH);
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(TenKH);

            m_NhanVienCtrl.HienThiComboBox(cmbMaNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(MaNV);
            m_NhanVienCtrl.HienThiComboBox(cmbTenNV);
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(HoTenNV);

            m_MatHangCtrl.HienThiComboBox(cmbMaSP);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(MaSP);
            m_MatHangCtrl.HienThiComboBox(cmbTenSP);
            m_MatHangCtrl.HienThiDataGridViewComboBoxColumn(TenSP);
            m_XuatHangCtrl.HienThi(dataGridView1, bindingNavigator1, cmbMaHD, dalap, txtsoluong, txtGiaBan, txtthanhtien, txtdiachi, txtSDT, cmbTenSP, cmbMaSP, cmbTenKH, cmbMaKH, cmbTenNV, cmbMaNV);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                bindingNavigator1.Enabled = true;
            DataRow m_Row = m_XuatHangCtrl.ThemDongMoi();
            m_Row["MaHD"] = "CTHD" + m_QuyDinh.LaySTT(dataGridView1.Rows.Count + 1);
            m_Row["NgayBan"] = DateTime.Today;
            m_Row["MaNV"] = "";
            m_Row["TenNV"] = "";
            m_Row["MaKH"] = "";
            m_Row["TenKH"] = "";
            m_Row["DiaChiKH"] = "";
            m_Row["SDT"] = 0;

            m_Row["MaSP"] = 0;
            m_Row["TenSP"] = 0;

            m_Row["DonGia"] = "";
            m_Row["SoLuong"] = "";
            m_Row["ThanhTien"] = "";

            m_XuatHangCtrl.ThemMoi(m_Row);
            bindingNavigator1.BindingSource.MoveLast();
        }
        public Boolean KiemTraTruocKhiLuu(String str)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[str].Value != null)
                {
                    String m_Str = row.Cells[str].Value.ToString();
                    if (m_Str == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click_Click(object sender, EventArgs e)
        {
            if (
                    KiemTraTruocKhiLuu("MaHD") == true &&
                   KiemTraTruocKhiLuu("TenSP") == true &&
                   KiemTraTruocKhiLuu("MaSP") == true &&
                   KiemTraTruocKhiLuu("TenKH") == true &&
                   KiemTraTruocKhiLuu("MaKH") == true &&
                   KiemTraTruocKhiLuu("HoTenNV") == true &&
                   KiemTraTruocKhiLuu("MaNV") == true &&
                   KiemTraTruocKhiLuu("DonGia") == true &&
                   KiemTraTruocKhiLuu("ThanhTien") == true &&
                   KiemTraTruocKhiLuu("SDT") == true &&
                   KiemTraTruocKhiLuu("DiaChiKH") == true &&
                   KiemTraTruocKhiLuu("NgayBan") == true &&
                   KiemTraTruocKhiLuu("SoLuong") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_XuatHangCtrl.LuuXuatHang();
            }
            else
            {
                MessageBox.Show("Giá trị ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else
               if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorCloseItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                bindingNavigator1.Enabled = true;
            DataRow m_Row = m_XuatHangCtrl.ThemDongMoi();
            m_Row["MaHD"] = "CTHD" + m_QuyDinh.LaySTT(dataGridView1.Rows.Count + 1);
            m_Row["NgayBan"] = DateTime.Today;
            m_Row["MaNV"] = "";
            m_Row["TenNV"] = "";
            m_Row["MaKH"] = "";
            m_Row["TenKH"] = "";
            m_Row["DiaChiKH"] = "";
            m_Row["SDT"] = 0;

            m_Row["MaSP"] = 0;
            m_Row["TenSP"] = 0;

            m_Row["DonGia"] = "";
            m_Row["SoLuong"] = "";
            m_Row["ThanhTien"] = "";
            m_XuatHangCtrl.ThemMoi(m_Row);
            bindingNavigator1.BindingSource.MoveLast();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            m_XuatHangCtrl.SuaXuatHang(cmbMaHD.SelectedValue.ToString(), dalap.Value, cmbMaNV.SelectedValue.ToString(), cmbTenNV.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString() ,txtdiachi.Text,txtSDT.Text, cmbMaSP.SelectedValue.ToString(),cmbTenSP.SelectedValue.ToString(),txtGiaBan.Text,txtsoluong.Text, txtthanhtien.Text);
            m_XuatHangCtrl.HienThi(dataGridView1, bindingNavigator1, cmbMaHD, dalap, txtsoluong, txtGiaBan, txtthanhtien, txtdiachi, txtSDT, cmbTenSP, cmbMaSP, cmbTenKH, cmbMaKH, cmbTenNV, cmbMaNV);
            MessageBox.Show("Đã sửa thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa đặt hàng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_XuatHangCtrl.XoaXuatHang(cmbMaHD.SelectedValue.ToString(), cmbMaSP.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(), cmbMaNV.SelectedValue.ToString());
                m_XuatHangCtrl.HienThi(dataGridView1, bindingNavigator1, cmbMaHD, dalap, txtsoluong, txtGiaBan, txtthanhtien, txtdiachi, txtSDT, cmbTenSP, cmbMaSP, cmbTenKH, cmbMaKH, cmbTenNV, cmbMaNV);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtGiaBan.Text != "" && txtsoluong.Text != "" && txtthanhtien.Text != "" && cmbTenKH.SelectedValue != null && cmbMaKH.SelectedValue != null && cmbMaNV.SelectedValue != null&& cmbTenNV.SelectedValue != null && cmbMaSP.SelectedValue != null&& cmbTenSP.SelectedValue != null && dalap.Value != null && txtdiachi.Text != "" && txtSDT.Text != "")
            {
                m_XuatHangCtrl.LuuXuatHang(cmbMaHD.SelectedValue.ToString(), dalap.Value, cmbMaNV.SelectedValue.ToString(), cmbTenNV.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(), cmbTenKH.SelectedValue.ToString(), txtdiachi.Text, txtSDT.Text, cmbMaSP.SelectedValue.ToString(), cmbTenSP.SelectedValue.ToString(), txtGiaBan.Text, txtsoluong.Text, txtthanhtien.Text);
                m_XuatHangCtrl.HienThi(dataGridView1, bindingNavigator1, cmbMaHD, dalap, txtsoluong, txtGiaBan, txtthanhtien, txtdiachi, txtSDT, cmbTenSP, cmbMaSP, cmbTenKH, cmbMaKH, cmbTenNV, cmbMaNV);
                MessageBox.Show("Đã lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Phải nhập đầy đủ dữ liệu để thêm đơn xuất hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
    }
}
