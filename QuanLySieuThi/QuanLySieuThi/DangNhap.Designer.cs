namespace QuanLySieuThi
{
    partial class DangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusernam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.txtusernam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbusername);
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 143);
            this.panel2.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(168, 81);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(196, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // txtusernam
            // 
            this.txtusernam.Location = new System.Drawing.Point(168, 34);
            this.txtusernam.Name = "txtusernam";
            this.txtusernam.Size = new System.Drawing.Size(196, 20);
            this.txtusernam.TabIndex = 2;
            this.txtusernam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.BackColor = System.Drawing.Color.Transparent;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbusername.Location = new System.Drawing.Point(59, 34);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(87, 20);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "UseName";
            this.lbusername.Click += new System.EventHandler(this.lbusername_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnthoat);
            this.panel3.Controls.Add(this.btnlogin);
            this.panel3.Location = new System.Drawing.Point(12, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 139);
            this.panel3.TabIndex = 1;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Yellow;
            this.btnthoat.Location = new System.Drawing.Point(237, 48);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(127, 39);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Yellow;
            this.btnlogin.Location = new System.Drawing.Point(43, 48);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(127, 39);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::QuanLySieuThi.Properties.Resources.Capture;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 118);
            this.panel1.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusernam;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlogin;
    }
}