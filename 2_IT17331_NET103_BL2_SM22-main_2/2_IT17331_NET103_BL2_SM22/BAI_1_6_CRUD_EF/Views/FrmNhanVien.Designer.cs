namespace BAI_1_6_CRUD_EF.Views
{
    partial class FrmNhanVien
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
            this.label = new System.Windows.Forms.GroupBox();
            this.cmb_LocCH = new System.Windows.Forms.ComboBox();
            this.cmb_LocCV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_CH = new System.Windows.Forms.ComboBox();
            this.cmb_BC = new System.Windows.Forms.ComboBox();
            this.cmb_TT = new System.Windows.Forms.ComboBox();
            this.cmb_ChucVu = new System.Windows.Forms.ComboBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenDem = new System.Windows.Forms.TextBox();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.label.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.SandyBrown;
            this.label.Controls.Add(this.cmb_LocCH);
            this.label.Controls.Add(this.cmb_LocCV);
            this.label.Controls.Add(this.label13);
            this.label.Controls.Add(this.cmb_CH);
            this.label.Controls.Add(this.cmb_BC);
            this.label.Controls.Add(this.cmb_TT);
            this.label.Controls.Add(this.cmb_ChucVu);
            this.label.Controls.Add(this.dtp_NgaySinh);
            this.label.Controls.Add(this.btn_Clear);
            this.label.Controls.Add(this.btn_Xoa);
            this.label.Controls.Add(this.btn_Sua);
            this.label.Controls.Add(this.btn_Them);
            this.label.Controls.Add(this.rbtn_Nu);
            this.label.Controls.Add(this.rbtn_Nam);
            this.label.Controls.Add(this.txt_DiaChi);
            this.label.Controls.Add(this.txt_TenDem);
            this.label.Controls.Add(this.txt_Sdt);
            this.label.Controls.Add(this.txt_Ten);
            this.label.Controls.Add(this.txt_Ma);
            this.label.Controls.Add(this.txt_Ho);
            this.label.Controls.Add(this.txt_Pass);
            this.label.Controls.Add(this.label12);
            this.label.Controls.Add(this.label11);
            this.label.Controls.Add(this.label10);
            this.label.Controls.Add(this.label9);
            this.label.Controls.Add(this.label8);
            this.label.Controls.Add(this.label7);
            this.label.Controls.Add(this.label6);
            this.label.Controls.Add(this.label5);
            this.label.Controls.Add(this.label4);
            this.label.Controls.Add(this.label3);
            this.label.Controls.Add(this.label2);
            this.label.Controls.Add(this.label1);
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1409, 401);
            this.label.TabIndex = 0;
            this.label.TabStop = false;
            this.label.Text = "Nhập liệu";
            // 
            // cmb_LocCH
            // 
            this.cmb_LocCH.FormattingEnabled = true;
            this.cmb_LocCH.Location = new System.Drawing.Point(898, 366);
            this.cmb_LocCH.Name = "cmb_LocCH";
            this.cmb_LocCH.Size = new System.Drawing.Size(151, 28);
            this.cmb_LocCH.TabIndex = 61;
            this.cmb_LocCH.Text = "Lọc theo cửa hàng";
            this.cmb_LocCH.SelectedIndexChanged += new System.EventHandler(this.cmb_LocCH_SelectedIndexChanged);
            // 
            // cmb_LocCV
            // 
            this.cmb_LocCV.FormattingEnabled = true;
            this.cmb_LocCV.Location = new System.Drawing.Point(710, 366);
            this.cmb_LocCV.Name = "cmb_LocCV";
            this.cmb_LocCV.Size = new System.Drawing.Size(151, 28);
            this.cmb_LocCV.TabIndex = 60;
            this.cmb_LocCV.Text = "Lọc theo chức vụ";
            this.cmb_LocCV.SelectedIndexChanged += new System.EventHandler(this.cmb_LocCV_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(668, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Trạng thái";
            // 
            // cmb_CH
            // 
            this.cmb_CH.FormattingEnabled = true;
            this.cmb_CH.Location = new System.Drawing.Point(1071, 150);
            this.cmb_CH.Name = "cmb_CH";
            this.cmb_CH.Size = new System.Drawing.Size(151, 28);
            this.cmb_CH.TabIndex = 58;
            // 
            // cmb_BC
            // 
            this.cmb_BC.FormattingEnabled = true;
            this.cmb_BC.Location = new System.Drawing.Point(751, 256);
            this.cmb_BC.Name = "cmb_BC";
            this.cmb_BC.Size = new System.Drawing.Size(218, 28);
            this.cmb_BC.TabIndex = 57;
            // 
            // cmb_TT
            // 
            this.cmb_TT.FormattingEnabled = true;
            this.cmb_TT.Location = new System.Drawing.Point(751, 303);
            this.cmb_TT.Name = "cmb_TT";
            this.cmb_TT.Size = new System.Drawing.Size(218, 28);
            this.cmb_TT.TabIndex = 56;
            // 
            // cmb_ChucVu
            // 
            this.cmb_ChucVu.FormattingEnabled = true;
            this.cmb_ChucVu.Location = new System.Drawing.Point(751, 208);
            this.cmb_ChucVu.Name = "cmb_ChucVu";
            this.cmb_ChucVu.Size = new System.Drawing.Size(218, 28);
            this.cmb_ChucVu.TabIndex = 55;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(751, 154);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(263, 27);
            this.dtp_NgaySinh.TabIndex = 54;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(583, 366);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear.TabIndex = 53;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(468, 366);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 52;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(353, 366);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 51;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(239, 366);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 50;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(423, 257);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(50, 24);
            this.rbtn_Nu.TabIndex = 49;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(318, 257);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(62, 24);
            this.rbtn_Nam.TabIndex = 48;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(751, 55);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(471, 27);
            this.txt_DiaChi.TabIndex = 46;
            // 
            // txt_TenDem
            // 
            this.txt_TenDem.Location = new System.Drawing.Point(318, 156);
            this.txt_TenDem.Name = "txt_TenDem";
            this.txt_TenDem.Size = new System.Drawing.Size(222, 27);
            this.txt_TenDem.TabIndex = 45;
            this.txt_TenDem.Leave += new System.EventHandler(this.txt_TenDem_Leave);
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Location = new System.Drawing.Point(751, 103);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(218, 27);
            this.txt_Sdt.TabIndex = 44;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(318, 208);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(222, 27);
            this.txt_Ten.TabIndex = 43;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged);
            this.txt_Ten.Leave += new System.EventHandler(this.txt_Ten_Leave);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(318, 58);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(222, 27);
            this.txt_Ma.TabIndex = 42;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(318, 106);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(222, 27);
            this.txt_Ho.TabIndex = 41;
            this.txt_Ho.Leave += new System.EventHandler(this.txt_Ho_Leave);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(1071, 103);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(151, 27);
            this.txt_Pass.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1020, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "CH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1020, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Pass";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(668, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Báo cáo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tên đệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Họ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txt_TimKiem);
            this.groupBox2.Controls.Add(this.dgrid_NhanVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1409, 378);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(67, 26);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(361, 27);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.Text = "Tìm kiếm";
            this.txt_TimKiem.Click += new System.EventHandler(this.txt_TimKiem_Click);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave);
            // 
            // dgrid_NhanVien
            // 
            this.dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_NhanVien.Location = new System.Drawing.Point(3, 59);
            this.dgrid_NhanVien.Name = "dgrid_NhanVien";
            this.dgrid_NhanVien.RowHeadersWidth = 51;
            this.dgrid_NhanVien.RowTemplate.Height = 29;
            this.dgrid_NhanVien.Size = new System.Drawing.Size(1403, 316);
            this.dgrid_NhanVien.TabIndex = 0;
            this.dgrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_NhanVien_CellClick);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 779);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox label;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenDem;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgrid_NhanVien;
        private System.Windows.Forms.ComboBox cmb_ChucVu;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_CH;
        private System.Windows.Forms.ComboBox cmb_BC;
        private System.Windows.Forms.ComboBox cmb_TT;
        private System.Windows.Forms.ComboBox cmb_LocCH;
        private System.Windows.Forms.ComboBox cmb_LocCV;
    }
}