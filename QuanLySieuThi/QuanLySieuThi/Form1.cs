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
        ZoomManHinh _form_resize;
        
        public Main()
        {
            InitializeComponent();
            _form_resize = new ZoomManHinh(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
