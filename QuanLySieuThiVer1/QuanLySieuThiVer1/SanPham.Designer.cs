namespace QuanLySieuThiVer1
{
    partial class SanPham
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
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.lbdonvitinh = new System.Windows.Forms.Label();
            this.lbgiaban = new System.Windows.Forms.Label();
            this.lbgianhap = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbtensp = new System.Windows.Forms.Label();
            this.lbmasp = new System.Windows.Forms.Label();
            this.lbdanhmucquanlysanpham = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanLySieuThiDataSet = new QuanLySieuThiVer1.QuanLySieuThiDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(661, 398);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(104, 31);
            this.btndong.TabIndex = 25;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(532, 398);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(104, 31);
            this.btnboqua.TabIndex = 22;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(405, 398);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(104, 31);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(275, 398);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 31);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(143, 398);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 31);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(7, 398);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 31);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.Location = new System.Drawing.Point(444, 43);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(85, 20);
            this.txtdonvitinh.TabIndex = 15;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(105, 162);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(252, 20);
            this.txtgiaban.TabIndex = 14;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(105, 136);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(252, 20);
            this.txtgianhap.TabIndex = 13;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(105, 108);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(252, 20);
            this.txtsoluong.TabIndex = 12;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(105, 80);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(252, 20);
            this.txttensp.TabIndex = 11;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(105, 49);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(252, 20);
            this.txtmasp.TabIndex = 10;
            // 
            // lbdonvitinh
            // 
            this.lbdonvitinh.AutoSize = true;
            this.lbdonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdonvitinh.Location = new System.Drawing.Point(362, 46);
            this.lbdonvitinh.Name = "lbdonvitinh";
            this.lbdonvitinh.Size = new System.Drawing.Size(76, 13);
            this.lbdonvitinh.TabIndex = 9;
            this.lbdonvitinh.Text = "Đơn Vị Tính";
            // 
            // lbgiaban
            // 
            this.lbgiaban.AutoSize = true;
            this.lbgiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiaban.Location = new System.Drawing.Point(13, 165);
            this.lbgiaban.Name = "lbgiaban";
            this.lbgiaban.Size = new System.Drawing.Size(52, 13);
            this.lbgiaban.TabIndex = 6;
            this.lbgiaban.Text = "Giá Bán";
            // 
            // lbgianhap
            // 
            this.lbgianhap.AutoSize = true;
            this.lbgianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgianhap.Location = new System.Drawing.Point(13, 139);
            this.lbgianhap.Name = "lbgianhap";
            this.lbgianhap.Size = new System.Drawing.Size(60, 13);
            this.lbgianhap.TabIndex = 5;
            this.lbgianhap.Text = "Giá Nhập";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoluong.Location = new System.Drawing.Point(13, 111);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(61, 13);
            this.lbsoluong.TabIndex = 4;
            this.lbsoluong.Text = "Số Lượng";
            // 
            // lbtensp
            // 
            this.lbtensp.AutoSize = true;
            this.lbtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtensp.Location = new System.Drawing.Point(11, 83);
            this.lbtensp.Name = "lbtensp";
            this.lbtensp.Size = new System.Drawing.Size(90, 13);
            this.lbtensp.TabIndex = 3;
            this.lbtensp.Text = "Tên Sản Phẩm";
            // 
            // lbmasp
            // 
            this.lbmasp.AutoSize = true;
            this.lbmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmasp.Location = new System.Drawing.Point(13, 52);
            this.lbmasp.Name = "lbmasp";
            this.lbmasp.Size = new System.Drawing.Size(85, 13);
            this.lbmasp.TabIndex = 2;
            this.lbmasp.Text = "Mã Sản Phẩm";
            // 
            // lbdanhmucquanlysanpham
            // 
            this.lbdanhmucquanlysanpham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbdanhmucquanlysanpham.AutoSize = true;
            this.lbdanhmucquanlysanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdanhmucquanlysanpham.Location = new System.Drawing.Point(0, 0);
            this.lbdanhmucquanlysanpham.Name = "lbdanhmucquanlysanpham";
            this.lbdanhmucquanlysanpham.Size = new System.Drawing.Size(477, 37);
            this.lbdanhmucquanlysanpham.TabIndex = 1;
            this.lbdanhmucquanlysanpham.Tag = "1";
            this.lbdanhmucquanlysanpham.Text = "Danh Mục Quản Lý Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btndong);
            this.panel1.Controls.Add(this.btnboqua);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.txtdonvitinh);
            this.panel1.Controls.Add(this.txtgiaban);
            this.panel1.Controls.Add(this.txtgianhap);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.txttensp);
            this.panel1.Controls.Add(this.txtmasp);
            this.panel1.Controls.Add(this.lbdonvitinh);
            this.panel1.Controls.Add(this.lbgiaban);
            this.panel1.Controls.Add(this.lbgianhap);
            this.panel1.Controls.Add(this.lbsoluong);
            this.panel1.Controls.Add(this.lbtensp);
            this.panel1.Controls.Add(this.lbmasp);
            this.panel1.Controls.Add(this.lbdanhmucquanlysanpham);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 434);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ngày Nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonGia,
            this.DonGiaBan,
            this.SoLuong,
            this.DonViTinh});
            this.dataGridView1.Location = new System.Drawing.Point(16, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1078, 198);
            this.dataGridView1.TabIndex = 29;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá Nhập";
            this.DonGia.Name = "DonGia";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // quanLySieuThiDataSet
            // 
            this.quanLySieuThiDataSet.DataSetName = "QuanLySieuThiDataSet";
            this.quanLySieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label lbdonvitinh;
        private System.Windows.Forms.Label lbgiaban;
        private System.Windows.Forms.Label lbgianhap;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbtensp;
        private System.Windows.Forms.Label lbmasp;
        private System.Windows.Forms.Label lbdanhmucquanlysanpham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private QuanLySieuThiDataSet quanLySieuThiDataSet;
    }
}