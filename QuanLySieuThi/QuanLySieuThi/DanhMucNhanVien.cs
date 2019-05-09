using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySieuThi.BS_Layer;

namespace QuanLySieuThi
{
   
    public partial class DanhMucNhanVien : Form
    {
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();

        ZoomManHinh _form_resize;
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        public DanhMucNhanVien()
        {
            InitializeComponent();
            _form_resize = new ZoomManHinh(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        void LoadData()
        {
            try
            {
                dataGridView1.DataSource = dbNV.LayNhanVien();
                dataGridView1.AutoResizeColumns();
                this.txtmanv.ResetText();
                this.txttennv.ResetText();
                this.txtdiachi.ResetText();
                this.txtdienthoai.ResetText();
                this.chnam.ResetText();
                this.dangaysinh.ResetText();
                this.btnluu.Enabled = false;
                this.btnboqua.Enabled = false;
                this.btnthem.Enabled = true;
                this.btnsua.Enabled = true;
                this.btnxoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("không lấy được nội dung từ bảng nhân viên");
            }
        }

        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panelthis.txtThanhPho.ResetText();
            this.txtmanv.ResetText();
            this.txttennv.ResetText();
            this.txtdiachi.ResetText();
            this.txtdienthoai.ResetText();
            this.chnam.ResetText();
            this.dangaysinh.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnluu.Enabled = true;
            this.btnboqua.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtmanv.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel1.Enabled = true;
          //  dgvNhanVien_CellClick(null, null);
            this.btnluu.Enabled = true;
            this.btnboqua.Enabled = true;
            this.panel1.Enabled = true;
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;          
            this.txtmanv.Enabled = false;
            this.txttennv.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;// Lấy MaKH của record hiện hành
                string strNHANVIEN =
                dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbNV.XoaNhanVien(ref err, strNHANVIEN);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLNhanVien nv = new BLNhanVien();
                    nv.ThemNhanVien(this.txtmanv.Text, this.txttennv.Text, (this.chnam.Checked ? true : false),  this.txtdiachi.Text, this.dangaysinh.Value, this.txtdienthoai.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLNhanVien NV = new BLNhanVien();
                NV.CapNhatNhanVien(this.txtmanv.Text, this.txttennv.Text, (this.chnam.Checked ? true : false), this.txtdiachi.Text, this.dangaysinh.Value, this.txtdienthoai.Text, ref err);
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
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
        private void ResetValues()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            chnam.Checked = false;
            txtdiachi.Text = "";
            dangaysinh.Text = "";
            txtdienthoai.Text = "";
        }
        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
        }
    }
}
