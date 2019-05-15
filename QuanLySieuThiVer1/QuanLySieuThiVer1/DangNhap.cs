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
    public partial class DangNhap : Form
    {
        string err;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User upass = new User();
            if (txtUserName.Text.Trim().Equals("admin") && txtPassWord.Text.Trim() == "123")
            {
                Main.bIsLogin = true;
                Close();
            }

            else
            {
                try
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                    txtUserName.Focus();
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }       

        private void BtnThoat_Click(object sender, EventArgs e)
        {
       DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Close();
        }
    }
}
