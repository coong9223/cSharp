namespace _3.PL.Views
{
    partial class QLKhachHang
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
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgrid_khachhang = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtPicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_tendem = new System.Windows.Forms.TextBox();
            this.txt_ho = new System.Windows.Forms.TextBox();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_thanhpho = new System.Windows.Forms.TextBox();
            this.txt_quocgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(348, 306);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(603, 23);
            this.txt_timkiem.TabIndex = 98;
            this.txt_timkiem.Text = "Tìm Kiếm ...";
            // 
            // dgrid_khachhang
            // 
            this.dgrid_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_khachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_khachhang.Location = new System.Drawing.Point(0, 335);
            this.dgrid_khachhang.Name = "dgrid_khachhang";
            this.dgrid_khachhang.RowTemplate.Height = 25;
            this.dgrid_khachhang.Size = new System.Drawing.Size(1305, 480);
            this.dgrid_khachhang.TabIndex = 97;
            this.dgrid_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_khachhang_CellClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(532, 251);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 36);
            this.btn_clear.TabIndex = 96;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(376, 251);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 36);
            this.btn_xoa.TabIndex = 95;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(232, 251);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(96, 36);
            this.btn_sua.TabIndex = 94;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(79, 251);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 36);
            this.btn_them.TabIndex = 93;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtPicker_ngaysinh
            // 
            this.dtPicker_ngaysinh.Location = new System.Drawing.Point(120, 188);
            this.dtPicker_ngaysinh.Name = "dtPicker_ngaysinh";
            this.dtPicker_ngaysinh.Size = new System.Drawing.Size(319, 23);
            this.dtPicker_ngaysinh.TabIndex = 85;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(946, 8);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(245, 23);
            this.txt_matkhau.TabIndex = 82;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(482, 53);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(245, 23);
            this.txt_diachi.TabIndex = 81;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(482, 11);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(245, 23);
            this.txt_sdt.TabIndex = 80;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(120, 148);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(245, 23);
            this.txt_ten.TabIndex = 79;
            // 
            // txt_tendem
            // 
            this.txt_tendem.Location = new System.Drawing.Point(120, 102);
            this.txt_tendem.Name = "txt_tendem";
            this.txt_tendem.Size = new System.Drawing.Size(245, 23);
            this.txt_tendem.TabIndex = 78;
            // 
            // txt_ho
            // 
            this.txt_ho.Location = new System.Drawing.Point(120, 56);
            this.txt_ho.Name = "txt_ho";
            this.txt_ho.Size = new System.Drawing.Size(245, 23);
            this.txt_ho.TabIndex = 77;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(120, 11);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(245, 23);
            this.txt_ma.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(822, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 74;
            this.label12.Text = "Mật Khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 71;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 70;
            this.label8.Text = "Quốc gia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 66;
            this.label4.Text = "Tên Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 100;
            this.label6.Text = "Thành phố";
            // 
            // txt_thanhpho
            // 
            this.txt_thanhpho.Location = new System.Drawing.Point(482, 99);
            this.txt_thanhpho.Name = "txt_thanhpho";
            this.txt_thanhpho.Size = new System.Drawing.Size(245, 23);
            this.txt_thanhpho.TabIndex = 101;
            // 
            // txt_quocgia
            // 
            this.txt_quocgia.Location = new System.Drawing.Point(482, 145);
            this.txt_quocgia.Name = "txt_quocgia";
            this.txt_quocgia.Size = new System.Drawing.Size(245, 23);
            this.txt_quocgia.TabIndex = 102;
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 815);
            this.Controls.Add(this.txt_quocgia);
            this.Controls.Add(this.txt_thanhpho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dgrid_khachhang);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtPicker_ngaysinh);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_tendem);
            this.Controls.Add(this.txt_ho);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dgrid_khachhang;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtPicker_ngaysinh;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_tendem;
        private System.Windows.Forms.TextBox txt_ho;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_thanhpho;
        private System.Windows.Forms.TextBox txt_quocgia;
    }
}