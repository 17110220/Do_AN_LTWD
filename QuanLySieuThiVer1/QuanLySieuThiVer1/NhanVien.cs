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
    public partial class NhanVien : Form
    {
        DataTable dtNhanVien = null;
        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();
        public NhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbNV.LayNhanVien();
                dtNhanVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = dtNhanVien;
                // Thay đổi độ rộng cột
                dataGridView1.AutoResizeColumns();
                this.txtmanv.ResetText();
                this.txttennv.ResetText();
                this.txtdiachi.ResetText();
                this.dangaysinh.ResetText();
                this.txtdienthoai.ResetText();
                this.chnam.ResetText();
                this.comboBox1.ResetText();
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

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.QuayGiaoDich' table. You can move, or remove it, as needed.
            this.quayGiaoDichTableAdapter.Fill(this.quanLySieuThiDataSet.QuayGiaoDich);



            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtmanv.Text =
            dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txttennv.Text =
            dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txtdiachi.Text =
            dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.dangaysinh.Text =
            dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.txtdienthoai.Text =
            dataGridView1.Rows[r].Cells[4].Value.ToString();                    
            this.chnam.Text =
            dataGridView1.Rows[r].Cells[5].Value.ToString();
            this.comboBox1.Text =
            dataGridView1.Rows[r].Cells[6].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtmanv.ResetText();
            this.txttennv.ResetText();
            this.txtdiachi.ResetText();
            this.dangaysinh.ResetText();
            this.txtdienthoai.ResetText();
            this.chnam.ResetText();
            this.comboBox1.ResetText();
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
            this.txtmanv.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNhanVien =
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
                    dbNV.XoaNhanVien(ref err, strNhanVien);
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
            this.txtmanv.Enabled = false;
            this.txttennv.Focus();
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
                    BLNhanVien blTp = new BLNhanVien();
                    blTp.ThemNhanVien(this.txtmanv.Text, this.txttennv.Text,this.txtdiachi.Text,this.dangaysinh.Value,this.txtdienthoai.Text,(this.chnam.Checked ? true : false),this.comboBox1.Text, ref err);
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
                BLNhanVien blTp = new BLNhanVien();
                blTp.CapNhatNhanVien(this.txtmanv.Text, this.txttennv.Text, this.txtdiachi.Text, this.dangaysinh.Value, this.txtdienthoai.Text, (this.chnam.Checked ? true : false), this.comboBox1.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtmanv.ResetText();
            this.txttennv.ResetText();
            this.txtdiachi.ResetText();
            this.dangaysinh.ResetText();
            this.txtdienthoai.ResetText();
            this.chnam.ResetText();
            this.comboBox1.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnthem.Enabled = true;
            this.btnsua.Enabled = true;
            this.btnxoa.Enabled = true;
            this.btndong.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnluu.Enabled = false;
            this.btnboqua.Enabled = false;
            this.panel1.Enabled = false;
            dataGridView1_CellClick(null, null);
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
