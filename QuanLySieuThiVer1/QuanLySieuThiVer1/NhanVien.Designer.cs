namespace QuanLySieuThiVer1
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dangaysinh = new System.Windows.Forms.DateTimePicker();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.lbdanhmucquanlynhanvien = new System.Windows.Forms.Label();
            this.pannel = new System.Windows.Forms.Panel();
            this.quayGiaoDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quayGiaoDichBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dangaysinh
            // 
            this.dangaysinh.Location = new System.Drawing.Point(499, 136);
            this.dangaysinh.Name = "dangaysinh";
            this.dangaysinh.Size = new System.Drawing.Size(200, 20);
            this.dangaysinh.TabIndex = 21;
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btndong.Location = new System.Drawing.Point(689, 372);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 45);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.Color.Green;
            this.btnboqua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnboqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnboqua.Location = new System.Drawing.Point(557, 372);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 45);
            this.btnboqua.TabIndex = 19;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Blue;
            this.btnluu.Location = new System.Drawing.Point(413, 372);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 45);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Lime;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsua.Location = new System.Drawing.Point(280, 372);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 45);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Navy;
            this.btnxoa.Location = new System.Drawing.Point(140, 372);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 45);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnthem.Location = new System.Drawing.Point(14, 372);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 45);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.DiaChi,
            this.NgSinh,
            this.SDT,
            this.Nam});
            this.dataGridView1.Location = new System.Drawing.Point(2, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 199);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(498, 89);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(264, 20);
            this.txtdienthoai.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(499, 53);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(264, 20);
            this.txtdiachi.TabIndex = 10;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(126, 93);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(264, 20);
            this.txttennv.TabIndex = 9;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(126, 56);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(264, 20);
            this.txtmanv.TabIndex = 8;
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaysinh.Location = new System.Drawing.Point(409, 136);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(79, 16);
            this.lbngaysinh.TabIndex = 6;
            this.lbngaysinh.Text = "Ngày Sinh";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgioitinh.Location = new System.Drawing.Point(11, 136);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(70, 16);
            this.lbgioitinh.TabIndex = 5;
            this.lbgioitinh.Text = "Giới Tính";
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.AutoSize = true;
            this.lbdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdienthoai.Location = new System.Drawing.Point(409, 96);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(83, 16);
            this.lbdienthoai.TabIndex = 4;
            this.lbdienthoai.Text = "Điên Thoại";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennv.Location = new System.Drawing.Point(11, 96);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(110, 16);
            this.lbtennv.TabIndex = 3;
            this.lbtennv.Text = "Tên Nhân Viên";
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.Location = new System.Drawing.Point(409, 56);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(57, 16);
            this.lbdiachi.TabIndex = 2;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanv.Location = new System.Drawing.Point(11, 56);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(104, 16);
            this.lbmanv.TabIndex = 1;
            this.lbmanv.Text = "Mã Nhân Viên";
            // 
            // lbdanhmucquanlynhanvien
            // 
            this.lbdanhmucquanlynhanvien.AutoSize = true;
            this.lbdanhmucquanlynhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdanhmucquanlynhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbdanhmucquanlynhanvien.Location = new System.Drawing.Point(200, 2);
            this.lbdanhmucquanlynhanvien.Name = "lbdanhmucquanlynhanvien";
            this.lbdanhmucquanlynhanvien.Size = new System.Drawing.Size(405, 31);
            this.lbdanhmucquanlynhanvien.TabIndex = 0;
            this.lbdanhmucquanlynhanvien.Tag = "";
            this.lbdanhmucquanlynhanvien.Text = "Danh Mục Quản Lý Nhân Viên";
            // 
            // pannel
            // 
            this.pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pannel.Controls.Add(this.txtGioiTinh);
            this.pannel.Controls.Add(this.dangaysinh);
            this.pannel.Controls.Add(this.btndong);
            this.pannel.Controls.Add(this.btnboqua);
            this.pannel.Controls.Add(this.btnluu);
            this.pannel.Controls.Add(this.btnsua);
            this.pannel.Controls.Add(this.btnxoa);
            this.pannel.Controls.Add(this.btnthem);
            this.pannel.Controls.Add(this.dataGridView1);
            this.pannel.Controls.Add(this.txtdienthoai);
            this.pannel.Controls.Add(this.txtdiachi);
            this.pannel.Controls.Add(this.txttennv);
            this.pannel.Controls.Add(this.txtmanv);
            this.pannel.Controls.Add(this.lbngaysinh);
            this.pannel.Controls.Add(this.lbgioitinh);
            this.pannel.Controls.Add(this.lbdienthoai);
            this.pannel.Controls.Add(this.lbtennv);
            this.pannel.Controls.Add(this.lbdiachi);
            this.pannel.Controls.Add(this.lbmanv);
            this.pannel.Controls.Add(this.lbdanhmucquanlynhanvien);
            this.pannel.Location = new System.Drawing.Point(12, 8);
            this.pannel.Name = "pannel";
            this.pannel.Size = new System.Drawing.Size(798, 437);
            this.pannel.TabIndex = 2;
            // 
            // quayGiaoDichBindingSource
            // 
            this.quayGiaoDichBindingSource.DataMember = "QuayGiaoDich";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(126, 131);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.txtGioiTinh.TabIndex = 22;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Tên Nhân Viên";
            this.HoTenNV.Name = "HoTenNV";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // NgSinh
            // 
            this.NgSinh.DataPropertyName = "NgSinh";
            this.NgSinh.HeaderText = "Ngày Sinh";
            this.NgSinh.Name = "NgSinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "GioiTinh";
            this.Nam.HeaderText = "Giới Tính";
            this.Nam.Name = "Nam";
            this.Nam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.pannel);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pannel.ResumeLayout(false);
            this.pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quayGiaoDichBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dangaysinh;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbgioitinh;
        private System.Windows.Forms.Label lbdienthoai;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label lbdanhmucquanlynhanvien;
        private System.Windows.Forms.Panel pannel;
       
        private System.Windows.Forms.BindingSource quayGiaoDichBindingSource;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
    }
}