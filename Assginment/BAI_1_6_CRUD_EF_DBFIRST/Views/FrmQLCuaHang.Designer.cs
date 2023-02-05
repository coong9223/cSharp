namespace BAI_1_6_CRUD_EF_DBFIRST.Views
{
    partial class FrmQLCuaHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrid_CuaHang = new System.Windows.Forms.DataGridView();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_ThanhPho);
            this.groupBox1.Controls.Add(this.tbt_QuocGia);
            this.groupBox1.Controls.Add(this.tbt_DiaChi);
            this.groupBox1.Controls.Add(this.tbt_Ten);
            this.groupBox1.Controls.Add(this.tbt_Ma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Liệu";
            // 
            // cmb_ThanhPho
            // 
            this.cmb_ThanhPho.FormattingEnabled = true;
            this.cmb_ThanhPho.Location = new System.Drawing.Point(167, 160);
            this.cmb_ThanhPho.Name = "cmb_ThanhPho";
            this.cmb_ThanhPho.Size = new System.Drawing.Size(248, 29);
            this.cmb_ThanhPho.TabIndex = 9;
            // 
            // tbt_QuocGia
            // 
            this.tbt_QuocGia.Location = new System.Drawing.Point(167, 203);
            this.tbt_QuocGia.Name = "tbt_QuocGia";
            this.tbt_QuocGia.Size = new System.Drawing.Size(370, 29);
            this.tbt_QuocGia.TabIndex = 8;
            this.tbt_QuocGia.Leave += new System.EventHandler(this.tbt_QuocGia_Leave);
            // 
            // tbt_DiaChi
            // 
            this.tbt_DiaChi.Location = new System.Drawing.Point(167, 116);
            this.tbt_DiaChi.Name = "tbt_DiaChi";
            this.tbt_DiaChi.Size = new System.Drawing.Size(370, 29);
            this.tbt_DiaChi.TabIndex = 7;
            this.tbt_DiaChi.Leave += new System.EventHandler(this.tbt_DiaChi_Leave);
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(167, 75);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(370, 29);
            this.tbt_Ten.TabIndex = 6;
            this.tbt_Ten.TextChanged += new System.EventHandler(this.tbt_Ten_TextChanged);
            this.tbt_Ten.Leave += new System.EventHandler(this.tbt_Ten_Leave);
            // 
            // tbt_Ma
            // 
            this.tbt_Ma.Location = new System.Drawing.Point(167, 35);
            this.tbt_Ma.Name = "tbt_Ma";
            this.tbt_Ma.Size = new System.Drawing.Size(370, 29);
            this.tbt_Ma.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quốc Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành Phố";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(822, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều Khiển";
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(3, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(362, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Clear.Location = new System.Drawing.Point(3, 118);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(362, 31);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 87);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(362, 31);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sua.Location = new System.Drawing.Point(3, 56);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(362, 31);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Location = new System.Drawing.Point(3, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(362, 31);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrid_CuaHang);
            this.groupBox3.Controls.Add(this.tbt_TimKiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1190, 394);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // dgrid_CuaHang
            // 
            this.dgrid_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_CuaHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_CuaHang.Location = new System.Drawing.Point(3, 71);
            this.dgrid_CuaHang.Name = "dgrid_CuaHang";
            this.dgrid_CuaHang.RowTemplate.Height = 25;
            this.dgrid_CuaHang.Size = new System.Drawing.Size(1184, 320);
            this.dgrid_CuaHang.TabIndex = 10;
            this.dgrid_CuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CuaHang_CellClick);
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Location = new System.Drawing.Point(384, 16);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.Size = new System.Drawing.Size(438, 29);
            this.tbt_TimKiem.TabIndex = 9;
            this.tbt_TimKiem.Text = "Tìm Kiếm ...";
            // 
            // FrmQLCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmQLCuaHang";
            this.Text = "FrmQLCuaHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_CuaHang;
        private System.Windows.Forms.TextBox tbt_TimKiem;
    }
}