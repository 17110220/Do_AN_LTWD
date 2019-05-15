using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThiVer1.DB_Layer;
namespace QuanLySieuThiVer1
{
    class User
    {
        KetNoi db = null;
        public User()
        {
            db = new KetNoi();
        }
        public int KtraUser(string username, string password, ref string err)
        {
            string sqlString = "Select Count(*) from Phan_quyen where TenDangNhap='" + username.Trim() + "' and MatKhau='" + password.Trim() + "'";
            return db.MyExecuteScalarUser(sqlString, CommandType.Text);
        }
    }
}
