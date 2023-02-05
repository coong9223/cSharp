namespace BaiThi_MOB104.Views
{
    partial class FrmDangKy
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
            this.llb_DangNhap = new System.Windows.Forms.LinkLabel();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txt_Tentaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // llb_DangNhap
            // 
            this.llb_DangNhap.AutoSize = true;
            this.llb_DangNhap.Location = new System.Drawing.Point(183, 364);
            this.llb_DangNhap.Name = "llb_DangNhap";
            this.llb_DangNhap.Size = new System.Drawing.Size(85, 20);
            this.llb_DangNhap.TabIndex = 14;
            this.llb_DangNhap.TabStop = true;
            this.llb_DangNhap.Text = "Đăng Nhập";
            this.llb_DangNhap.Click += new System.EventHandler(this.llb_DangNhap_Click);
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(282, 191);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(341, 26);
            this.txt_Matkhau.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật Khẩu";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(347, 342);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(149, 62);
            this.btn_DangKy.TabIndex = 11;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // txt_Tentaikhoan
            // 
            this.txt_Tentaikhoan.Location = new System.Drawing.Point(282, 110);
            this.txt_Tentaikhoan.Name = "txt_Tentaikhoan";
            this.txt_Tentaikhoan.Size = new System.Drawing.Size(341, 26);
            this.txt_Tentaikhoan.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "SĐT";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(282, 265);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(341, 26);
            this.txt_SDT.TabIndex = 16;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llb_DangNhap);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_Tentaikhoan);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangKy";
            this.Text = "FrmDangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb_DangNhap;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox txt_Tentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SDT;
    }
}