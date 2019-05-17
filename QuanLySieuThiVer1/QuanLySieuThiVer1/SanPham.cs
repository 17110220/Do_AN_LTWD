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
using QuanLySieuThiVer1.BS_Layer;


namespace QuanLySieuThiVer1
{
    public partial class SanPham : Form
    {
        DataTable dtSanPham = null;
        bool Them;
        string err;
        BLSanPham dbSP = new BLSanPham();
        public SanPham()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtSanPham = new DataTable();
                dtSanPham.Clear();
                DataSet ds = dbSP.LaySanPham();
                dtSanPham = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = dtSanPham;
                // Thay đổi độ rộng cột
                dataGridView1.AutoResizeColumns();
                this.txtmasp.ResetText();
                this.txttensp.ResetText();
                this.txtgianhap.ResetText();
                this.txtgiaban.ResetText();
                this.txtsoluong.ResetText();
                this.txtdonvitinh.ResetText();

              
                this.btnluu.Enabled = false;
                this.btnboqua.Enabled = false;
                this.btnthem.Enabled = true;
                this.btnsua.Enabled = true;
                this.btnxoa.Enabled = true;
                dataGridView1_CellClick(null, null);
            }

            catch
            {
                MessageBox.Show("không lấy được nội dung từ bảng nhân viên");
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.SanPham' table. You can move, or remove it, as needed.
           
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtmasp.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txttensp.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtgianhap.Text =
           dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txtgiaban.Text =
           dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtsoluong.Text =
           dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.txtdonvitinh.Text =
           dataGridView1.Rows[r].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtmasp.ResetText();
            this.txttensp.ResetText();
            this.txtgianhap.ResetText();
            this.txtgiaban.ResetText();
            this.txtsoluong.ResetText();
            this.txtdonvitinh.ResetText();

           
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnluu.Enabled = true;
            this.btnboqua.Enabled = true;

            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btndong.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtmasp.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strSanPham =
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
                    dbSP.XoaSanPham(ref err, strSanPham);
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
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel1.Enabled = true;
            dataGridView1_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnluu.Enabled = true;
            this.btnboqua.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnthem.Enabled = false;
            this.btnsua.Enabled = false;
            this.btnxoa.Enabled = false;
            this.btndong.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtmasp.Enabled = false;
            this.txttensp.Focus();
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
                    BLSanPham blSP = new BLSanPham();
                    blSP.ThemSanPham(this.txtmasp.Text, this.txttensp.Text, this.txtgianhap.Text, this.txtgiaban.Text, this.txtsoluong.Text,  this.txtdonvitinh.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLSanPham blTp = new BLSanPham();
                blTp.CapNhatSanPham(this.txtmasp.Text, this.txttensp.Text, this.txtgianhap.Text, this.txtgiaban.Text, this.txtsoluong.Text, this.txtdonvitinh.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtmasp.ResetText();
            this.txttensp.ResetText();
            this.txtgianhap.ResetText();
            this.txtgiaban.ResetText();
            this.txtsoluong.ResetText();
            this.txtdonvitinh.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnthem.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btndong.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnluu.Enabled = false;
            this.btnboqua.Enabled = false;
            this.panel1.Enabled = false;
            //dataGridView1_CellClick(null, null);
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
