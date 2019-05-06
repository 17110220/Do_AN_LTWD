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
    public partial class DanhMucNhanVien : Form
    {
        ZoomManHinh _form_resize;
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        public DanhMucNhanVien()
        {
            InitializeComponent();
            _form_resize = new ZoomManHinh(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
