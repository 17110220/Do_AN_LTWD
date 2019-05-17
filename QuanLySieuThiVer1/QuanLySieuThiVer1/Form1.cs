using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiVer1
{
    public partial class Main : Form
    {
        public static bool bIsLogin = false;//Biến tĩnh ghi nhận tình trạng đăng nhập
        PhongManHinh _form_resize;

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
       
        public Main()
        {
            InitializeComponent();
            _form_resize = new PhongManHinh(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (bIsLogin == true)
            {
                this.quảnLýToolStripMenuItem.Enabled = true;
                this.thốngKêToolStripMenuItem.Enabled = true;
                this.báoCáoToolStripMenuItem.Enabled = true;
                this.tìmKiếmToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.quảnLýToolStripMenuItem.Enabled = false;
                this.thốngKêToolStripMenuItem.Enabled = false;
                this.báoCáoToolStripMenuItem.Enabled = false;
                this.tìmKiếmToolStripMenuItem.Enabled = false;
            }
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKhachHang tkkh = new TimKhachHang();
            tkkh.Show();
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
             KhachHang kh = new KhachHang();
             kh.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Show();
        }
    }
}
