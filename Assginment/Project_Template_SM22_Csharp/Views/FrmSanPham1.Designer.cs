namespace Project_Template_SM22_Csharp.Views
{
    partial class FrmSanPham1
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
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Giaban = new System.Windows.Forms.TextBox();
            this.cmb_Web = new System.Windows.Forms.ComboBox();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.dgrid_SanPham1 = new System.Windows.Forms.DataGridView();
            this.rbtn_KhongHoatdong = new System.Windows.Forms.RadioButton();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(215, 63);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(120, 26);
            this.txt_Ma.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gía Bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Web";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trang Thái";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(215, 110);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(120, 26);
            this.txt_Ten.TabIndex = 6;
            // 
            // txt_Giaban
            // 
            this.txt_Giaban.Location = new System.Drawing.Point(215, 178);
            this.txt_Giaban.Name = "txt_Giaban";
            this.txt_Giaban.Size = new System.Drawing.Size(120, 26);
            this.txt_Giaban.TabIndex = 7;
            // 
            // cmb_Web
            // 
            this.cmb_Web.FormattingEnabled = true;
            this.cmb_Web.Location = new System.Drawing.Point(223, 226);
            this.cmb_Web.Name = "cmb_Web";
            this.cmb_Web.Size = new System.Drawing.Size(145, 27);
            this.cmb_Web.TabIndex = 8;
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.Location = new System.Drawing.Point(230, 278);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(101, 24);
            this.rbtn_HoatDong.TabIndex = 9;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt Động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // dgrid_SanPham1
            // 
            this.dgrid_SanPham1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SanPham1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_SanPham1.Location = new System.Drawing.Point(0, 324);
            this.dgrid_SanPham1.Name = "dgrid_SanPham1";
            this.dgrid_SanPham1.RowHeadersWidth = 49;
            this.dgrid_SanPham1.RowTemplate.Height = 28;
            this.dgrid_SanPham1.Size = new System.Drawing.Size(800, 126);
            this.dgrid_SanPham1.TabIndex = 10;
            this.dgrid_SanPham1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SanPham1_CellClick);
            // 
            // rbtn_KhongHoatdong
            // 
            this.rbtn_KhongHoatdong.AutoSize = true;
            this.rbtn_KhongHoatdong.Location = new System.Drawing.Point(411, 278);
            this.rbtn_KhongHoatdong.Name = "rbtn_KhongHoatdong";
            this.rbtn_KhongHoatdong.Size = new System.Drawing.Size(148, 24);
            this.rbtn_KhongHoatdong.TabIndex = 11;
            this.rbtn_KhongHoatdong.TabStop = true;
            this.rbtn_KhongHoatdong.Text = "Không Hoạt Động";
            this.rbtn_KhongHoatdong.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(497, 68);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 28);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(497, 124);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 28);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(497, 187);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 28);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FrmSanPham1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rbtn_KhongHoatdong);
            this.Controls.Add(this.dgrid_SanPham1);
            this.Controls.Add(this.rbtn_HoatDong);
            this.Controls.Add(this.cmb_Web);
            this.Controls.Add(this.txt_Giaban);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham1";
            this.Text = "FrmSanPham1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Giaban;
        private System.Windows.Forms.ComboBox cmb_Web;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.DataGridView dgrid_SanPham1;
        private System.Windows.Forms.RadioButton rbtn_KhongHoatdong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}