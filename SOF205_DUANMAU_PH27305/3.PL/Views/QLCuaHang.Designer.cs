namespace _3.PL.Views
{
    partial class QLCuaHang
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
            this.dgrid_CuaHang = new System.Windows.Forms.DataGridView();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.cmb_ThanhPho = new System.Windows.Forms.ComboBox();
            this.tbt_QuocGia = new System.Windows.Forms.TextBox();
            this.tbt_DiaChi = new System.Windows.Forms.TextBox();
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.tbt_Ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_CuaHang
            // 
            this.dgrid_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_CuaHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_CuaHang.Location = new System.Drawing.Point(0, 325);
            this.dgrid_CuaHang.Name = "dgrid_CuaHang";
            this.dgrid_CuaHang.RowTemplate.Height = 25;
            this.dgrid_CuaHang.Size = new System.Drawing.Size(1302, 485);
            this.dgrid_CuaHang.TabIndex = 11;
            this.dgrid_CuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CuaHang_CellClick);
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Location = new System.Drawing.Point(361, 282);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.Size = new System.Drawing.Size(438, 23);
            this.tbt_TimKiem.TabIndex = 12;
            this.tbt_TimKiem.Text = "Tìm Kiếm ...";
            this.tbt_TimKiem.Click += new System.EventHandler(this.tbt_TimKiem_Click);
            this.tbt_TimKiem.TextChanged += new System.EventHandler(this.tbt_TimKiem_TextChanged);
            this.tbt_TimKiem.Leave += new System.EventHandler(this.tbt_TimKiem_Leave);
            // 
            // cmb_ThanhPho
            // 
            this.cmb_ThanhPho.FormattingEnabled = true;
            this.cmb_ThanhPho.Location = new System.Drawing.Point(160, 154);
            this.cmb_ThanhPho.Name = "cmb_ThanhPho";
            this.cmb_ThanhPho.Size = new System.Drawing.Size(248, 23);
            this.cmb_ThanhPho.TabIndex = 22;
            // 
            // tbt_QuocGia
            // 
            this.tbt_QuocGia.Location = new System.Drawing.Point(160, 197);
            this.tbt_QuocGia.Name = "tbt_QuocGia";
            this.tbt_QuocGia.Size = new System.Drawing.Size(370, 23);
            this.tbt_QuocGia.TabIndex = 21;
            // 
            // tbt_DiaChi
            // 
            this.tbt_DiaChi.Location = new System.Drawing.Point(160, 110);
            this.tbt_DiaChi.Name = "tbt_DiaChi";
            this.tbt_DiaChi.Size = new System.Drawing.Size(370, 23);
            this.tbt_DiaChi.TabIndex = 20;
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(160, 69);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(370, 23);
            this.tbt_Ten.TabIndex = 19;
            // 
            // tbt_Ma
            // 
            this.tbt_Ma.Location = new System.Drawing.Point(160, 29);
            this.tbt_Ma.Name = "tbt_Ma";
            this.tbt_Ma.Size = new System.Drawing.Size(370, 23);
            this.tbt_Ma.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quốc Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thành Phố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(631, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(738, 25);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(848, 25);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(963, 25);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // QLCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 810);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cmb_ThanhPho);
            this.Controls.Add(this.tbt_QuocGia);
            this.Controls.Add(this.tbt_DiaChi);
            this.Controls.Add(this.tbt_Ten);
            this.Controls.Add(this.tbt_Ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_TimKiem);
            this.Controls.Add(this.dgrid_CuaHang);
            this.Name = "QLCuaHang";
            this.Text = "QLCuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_CuaHang;
        private System.Windows.Forms.TextBox tbt_TimKiem;
        private System.Windows.Forms.ComboBox cmb_ThanhPho;
        private System.Windows.Forms.TextBox tbt_QuocGia;
        private System.Windows.Forms.TextBox tbt_DiaChi;
        private System.Windows.Forms.TextBox tbt_Ten;
        private System.Windows.Forms.TextBox tbt_Ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_clear;
    }
}