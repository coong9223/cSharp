namespace Project_Template_SM22_Csharp.Views
{
    partial class FrmSanPham
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
            this.dgrid_SanPham = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.ck_Hoatdong = new System.Windows.Forms.CheckBox();
            this.ck_Khonghoatdong = new System.Windows.Forms.CheckBox();
            this.txt_Giaban = new System.Windows.Forms.TextBox();
            this.btn_cleck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(176, 50);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(120, 26);
            this.txt_Ma.TabIndex = 1;
            // 
            // dgrid_SanPham
            // 
            this.dgrid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_SanPham.Location = new System.Drawing.Point(0, 270);
            this.dgrid_SanPham.Name = "dgrid_SanPham";
            this.dgrid_SanPham.RowHeadersWidth = 49;
            this.dgrid_SanPham.RowTemplate.Height = 28;
            this.dgrid_SanPham.Size = new System.Drawing.Size(800, 180);
            this.dgrid_SanPham.TabIndex = 2;
            this.dgrid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SanPham_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(231, 226);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 28);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng Thái";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(176, 95);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(120, 26);
            this.txt_Ten.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(488, 226);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 28);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(374, 226);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 28);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // ck_Hoatdong
            // 
            this.ck_Hoatdong.AutoSize = true;
            this.ck_Hoatdong.Location = new System.Drawing.Point(212, 148);
            this.ck_Hoatdong.Name = "ck_Hoatdong";
            this.ck_Hoatdong.Size = new System.Drawing.Size(102, 24);
            this.ck_Hoatdong.TabIndex = 10;
            this.ck_Hoatdong.Text = "Hoạt Động";
            this.ck_Hoatdong.UseVisualStyleBackColor = true;
            // 
            // ck_Khonghoatdong
            // 
            this.ck_Khonghoatdong.AutoSize = true;
            this.ck_Khonghoatdong.Location = new System.Drawing.Point(383, 148);
            this.ck_Khonghoatdong.Name = "ck_Khonghoatdong";
            this.ck_Khonghoatdong.Size = new System.Drawing.Size(149, 24);
            this.ck_Khonghoatdong.TabIndex = 11;
            this.ck_Khonghoatdong.Text = "Không Hoạt Động";
            this.ck_Khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_Giaban
            // 
            this.txt_Giaban.Location = new System.Drawing.Point(458, 47);
            this.txt_Giaban.Name = "txt_Giaban";
            this.txt_Giaban.Size = new System.Drawing.Size(120, 26);
            this.txt_Giaban.TabIndex = 12;
            // 
            // btn_cleck
            // 
            this.btn_cleck.Location = new System.Drawing.Point(619, 226);
            this.btn_cleck.Name = "btn_cleck";
            this.btn_cleck.Size = new System.Drawing.Size(90, 28);
            this.btn_cleck.TabIndex = 13;
            this.btn_cleck.Text = "cleck";
            this.btn_cleck.UseVisualStyleBackColor = true;
            this.btn_cleck.Click += new System.EventHandler(this.btn_cleck_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cleck);
            this.Controls.Add(this.txt_Giaban);
            this.Controls.Add(this.ck_Khonghoatdong);
            this.Controls.Add(this.ck_Hoatdong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgrid_SanPham);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.DataGridView dgrid_SanPham;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.CheckBox ck_Hoatdong;
        private System.Windows.Forms.CheckBox ck_Khonghoatdong;
        private System.Windows.Forms.TextBox txt_Giaban;
        private System.Windows.Forms.Button btn_cleck;
    }
}