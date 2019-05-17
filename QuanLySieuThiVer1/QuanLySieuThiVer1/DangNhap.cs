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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=QuanLySieuThi;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Phan_quyen WHERE TenDangNhap = '" + txtUserName.Text + "' AND MatKhau = '" + txtPassWord.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0) //Kiểm tra số hàng
            {
                MessageBox.Show("Đăng Nhâp Thành Công!");
                Form main = new Main();
                this.Close();
                Main.bIsLogin = true;
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên tài khoản hoạc mật khẩu!");
            }
        }

    }
}

