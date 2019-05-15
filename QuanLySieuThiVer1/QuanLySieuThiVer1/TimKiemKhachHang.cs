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
using QuanLySieuThiVer1.DB_Layer;
namespace QuanLySieuThiVer1
{
    public partial class TimKiemKhachHang : Form
    {
        private DataTable tblH;

        public TimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLySieuThiDataSet.KhachHang);
            // TODO: This line of code loads data into the 'quanLySieuThiDataSet.KhachHang' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTimKiem.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from KhachHang WHERE 1=1";
            if (txtTimKiem.Text != "")
                sql += " AND MaKH LIKE N'%" + txtTimKiem.Text + "%'";
            tblH = KetNoi.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = tblH;
            ResetValues();
        }
        private void ResetValues()
        {
            this.txtTimKiem.Text = "";
            
        }
    }
}
