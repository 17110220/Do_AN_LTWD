using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiVer1.BS_Layer;
namespace QuanLySieuThiVer1
{
    public partial class TimKhachHang : Form
    {
        KhachHangCtr m_KhachHangCtrl = new KhachHangCtr();
        public TimKhachHang()
        {
            InitializeComponent();
            DaTaServer.OpenConnection();
        }
       
      
        private void btnTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemKhachHang();
            }
        }
        void TimKiemKhachHang()
        {
            try
            {
                
                    m_KhachHangCtrl.TimKiemTheoMa(txtTimKiem.Text);          
            }
            catch
            {
                MessageBox.Show("Không thể tìm thấy Giá trị cần tìm!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Giá trị tìm rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TimKiemKhachHang();
            }
        }

       

        private void TimKhachHang_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThi(dataGridView1);
        }
       
    }
}
