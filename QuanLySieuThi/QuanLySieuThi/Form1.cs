using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class Main : Form
    {
        public static bool bIsLogin = false;//Biến tĩnh ghi nhận tình trạng đăng nhập

        public Main()
        {
            InitializeComponent();
          
        }
       

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucKhachHang dmkh = new DanhMucKhachHang();
            
            dmkh.ShowDialog();
          

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien dmnv = new DanhMucNhanVien();
           
            dmnv.ShowDialog();
           
        }

        

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucChiTietHoaDon dmcthd = new DanhMucChiTietHoaDon();
            
            dmcthd.ShowDialog();
           
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucQuanLySanPham Dmqlsp= new DanhMucQuanLySanPham();

            Dmqlsp.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DangNhap login = new DangNhap();

            login.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (bIsLogin == true)
            {
                this.danhMucToolStripMenuItem.Enabled = true;
                this.tìmKiếmToolStripMenuItem.Enabled = true;
                this.báoCáoToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.danhMucToolStripMenuItem.Enabled = false;
                this.tìmKiếmToolStripMenuItem.Enabled = false;
                this.báoCáoToolStripMenuItem.Enabled = false;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
