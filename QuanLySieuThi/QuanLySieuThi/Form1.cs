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
        //ZoomManHinh _form_resize;
        
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
    }
}
