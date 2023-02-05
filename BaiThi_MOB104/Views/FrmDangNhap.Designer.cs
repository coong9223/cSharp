namespace BaiThi_MOB104.Views
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tentaikhoan = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.llb_DangKy = new System.Windows.Forms.LinkLabel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txt_Tentaikhoan
            // 
            this.txt_Tentaikhoan.Location = new System.Drawing.Point(233, 86);
            this.txt_Tentaikhoan.Name = "txt_Tentaikhoan";
            this.txt_Tentaikhoan.Size = new System.Drawing.Size(341, 26);
            this.txt_Tentaikhoan.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(498, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên Mật Khẩu";
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.Location = new System.Drawing.Point(292, 255);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(149, 62);
            this.btn_Dangnhap.TabIndex = 3;
            this.btn_Dangnhap.Text = "Đăng Nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = true;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(233, 167);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(341, 26);
            this.txt_Matkhau.TabIndex = 6;
            // 
            // llb_DangKy
            // 
            this.llb_DangKy.AutoSize = true;
            this.llb_DangKy.Location = new System.Drawing.Point(130, 277);
            this.llb_DangKy.Name = "llb_DangKy";
            this.llb_DangKy.Size = new System.Drawing.Size(64, 20);
            this.llb_DangKy.TabIndex = 7;
            this.llb_DangKy.TabStop = true;
            this.llb_DangKy.Text = "Đăng Ký";
            this.llb_DangKy.Click += new System.EventHandler(this.llb_DangKy_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(606, 349);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(139, 62);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 423);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.llb_DangKy);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txt_Tentaikhoan);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tentaikhoan;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.LinkLabel llb_DangKy;
        private System.Windows.Forms.Button btn_Thoat;
    }
}