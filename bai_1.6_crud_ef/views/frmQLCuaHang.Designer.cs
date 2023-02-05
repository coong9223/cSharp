namespace bai_1._6_crud_ef.views
{
    partial class frmQLCuaHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.rbtn_koHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_check = new System.Windows.Forms.RadioButton();
            this.rbtn_hoatDong = new System.Windows.Forms.RadioButton();
            this.cmb_thanhPho = new System.Windows.Forms.ComboBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_quocGia = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(2, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(870, 163);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sua.Location = new System.Drawing.Point(2, 97);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(293, 75);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_them.Location = new System.Drawing.Point(2, 22);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(293, 75);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // rbtn_koHoatDong
            // 
            this.rbtn_koHoatDong.AutoSize = true;
            this.rbtn_koHoatDong.Location = new System.Drawing.Point(223, 214);
            this.rbtn_koHoatDong.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_koHoatDong.Name = "rbtn_koHoatDong";
            this.rbtn_koHoatDong.Size = new System.Drawing.Size(144, 24);
            this.rbtn_koHoatDong.TabIndex = 15;
            this.rbtn_koHoatDong.TabStop = true;
            this.rbtn_koHoatDong.Text = "không hoạt động";
            this.rbtn_koHoatDong.UseVisualStyleBackColor = true;
            this.rbtn_koHoatDong.CheckedChanged += new System.EventHandler(this.rbtn_koHoatDong_CheckedChanged);
            // 
            // rbtn_check
            // 
            this.rbtn_check.AutoSize = true;
            this.rbtn_check.Location = new System.Drawing.Point(91, 263);
            this.rbtn_check.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_check.Name = "rbtn_check";
            this.rbtn_check.Size = new System.Drawing.Size(122, 24);
            this.rbtn_check.TabIndex = 14;
            this.rbtn_check.TabStop = true;
            this.rbtn_check.Text = "đang kiểm tra";
            this.rbtn_check.UseVisualStyleBackColor = true;
            this.rbtn_check.CheckedChanged += new System.EventHandler(this.rbtn_check_CheckedChanged);
            // 
            // rbtn_hoatDong
            // 
            this.rbtn_hoatDong.AutoSize = true;
            this.rbtn_hoatDong.Location = new System.Drawing.Point(91, 214);
            this.rbtn_hoatDong.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_hoatDong.Name = "rbtn_hoatDong";
            this.rbtn_hoatDong.Size = new System.Drawing.Size(99, 24);
            this.rbtn_hoatDong.TabIndex = 13;
            this.rbtn_hoatDong.TabStop = true;
            this.rbtn_hoatDong.Text = "hoạt động";
            this.rbtn_hoatDong.UseVisualStyleBackColor = true;
            this.rbtn_hoatDong.CheckedChanged += new System.EventHandler(this.rbtn_hoatDong_CheckedChanged);
            // 
            // cmb_thanhPho
            // 
            this.cmb_thanhPho.FormattingEnabled = true;
            this.cmb_thanhPho.Location = new System.Drawing.Point(92, 135);
            this.cmb_thanhPho.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_thanhPho.Name = "cmb_thanhPho";
            this.cmb_thanhPho.Size = new System.Drawing.Size(394, 28);
            this.cmb_thanhPho.TabIndex = 12;
            this.cmb_thanhPho.SelectedIndexChanged += new System.EventHandler(this.cmb_thanhPho_SelectedIndexChanged);
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(91, 66);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(395, 27);
            this.txt_ten.TabIndex = 11;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            this.txt_ten.Leave += new System.EventHandler(this.txt_ten_Leave);
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(91, 102);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(395, 27);
            this.txt_diaChi.TabIndex = 10;
            this.txt_diaChi.TextChanged += new System.EventHandler(this.txt_diaChi_TextChanged);
            this.txt_diaChi.Leave += new System.EventHandler(this.txt_diaChi_Leave);
            // 
            // txt_quocGia
            // 
            this.txt_quocGia.Location = new System.Drawing.Point(91, 171);
            this.txt_quocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quocGia.Name = "txt_quocGia";
            this.txt_quocGia.Size = new System.Drawing.Size(395, 27);
            this.txt_quocGia.TabIndex = 7;
            this.txt_quocGia.TextChanged += new System.EventHandler(this.txt_quocGia_TextChanged);
            this.txt_quocGia.Leave += new System.EventHandler(this.txt_quocGia_Leave);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(91, 34);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(395, 27);
            this.txt_ma.TabIndex = 6;
            this.txt_ma.TextChanged += new System.EventHandler(this.txt_ma_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clear.Location = new System.Drawing.Point(2, 247);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(293, 75);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xoa.Location = new System.Drawing.Point(2, 172);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(293, 75);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(577, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(297, 296);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "điều khiển";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "tên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "thành phố";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "trạng thái";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_koHoatDong);
            this.groupBox1.Controls.Add(this.rbtn_check);
            this.groupBox1.Controls.Add(this.rbtn_hoatDong);
            this.groupBox1.Controls.Add(this.cmb_thanhPho);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_quocGia);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(577, 296);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhập thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "quốc gia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.txt_timKiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 296);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(874, 219);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "danh sách";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(267, 24);
            this.txt_timKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(395, 27);
            this.txt_timKiem.TabIndex = 8;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // frmQLCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQLCuaHang";
            this.Text = "frmQLCuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RadioButton rbtn_koHoatDong;
        private System.Windows.Forms.RadioButton rbtn_check;
        private System.Windows.Forms.RadioButton rbtn_hoatDong;
        private System.Windows.Forms.ComboBox cmb_thanhPho;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_quocGia;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_timKiem;
    }
}