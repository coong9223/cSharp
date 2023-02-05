namespace BaiThi_MOB104.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgrid_Nhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Hoadon = new System.Windows.Forms.Button();
            this.pb_Quayve = new System.Windows.Forms.PictureBox();
            this.btn_Khachhang = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_Trangchu = new System.Windows.Forms.Button();
            this.btn_Giohang = new System.Windows.Forms.Button();
            this.btn_Sanpham = new System.Windows.Forms.Button();
            this.btn_Danhmuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Manv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenNv = new System.Windows.Forms.TextBox();
            this.txt_Diachi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.date_Nhanvien = new System.Windows.Forms.DateTimePicker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_Nhanvien)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Quayve)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(497, 57);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(118, 43);
            this.btn_Timkiem.TabIndex = 1;
            this.btn_Timkiem.Text = "Tìm Kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Segoe UI", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Timkiem.Location = new System.Drawing.Point(48, 57);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(379, 42);
            this.txt_Timkiem.TabIndex = 0;
            this.txt_Timkiem.Text = "    Tìm Kiếm .....";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Timkiem);
            this.groupBox2.Controls.Add(this.Dgrid_Nhanvien);
            this.groupBox2.Controls.Add(this.txt_Timkiem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 640);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Dgrid_Nhanvien
            // 
            this.Dgrid_Nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrid_Nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgrid_Nhanvien.Location = new System.Drawing.Point(3, 131);
            this.Dgrid_Nhanvien.Name = "Dgrid_Nhanvien";
            this.Dgrid_Nhanvien.RowHeadersWidth = 49;
            this.Dgrid_Nhanvien.RowTemplate.Height = 28;
            this.Dgrid_Nhanvien.Size = new System.Drawing.Size(653, 506);
            this.Dgrid_Nhanvien.TabIndex = 0;
            this.Dgrid_Nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_Nhanvien_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Hoadon);
            this.groupBox4.Controls.Add(this.pb_Quayve);
            this.groupBox4.Controls.Add(this.btn_Khachhang);
            this.groupBox4.Controls.Add(this.btn_NhanVien);
            this.groupBox4.Controls.Add(this.btn_Trangchu);
            this.groupBox4.Controls.Add(this.btn_Giohang);
            this.groupBox4.Controls.Add(this.btn_Sanpham);
            this.groupBox4.Controls.Add(this.btn_Danhmuc);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(1008, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 640);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btn_Hoadon
            // 
            this.btn_Hoadon.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Hoadon.Location = new System.Drawing.Point(6, 412);
            this.btn_Hoadon.Name = "btn_Hoadon";
            this.btn_Hoadon.Size = new System.Drawing.Size(103, 60);
            this.btn_Hoadon.TabIndex = 27;
            this.btn_Hoadon.Text = "Hóa Đơn";
            this.btn_Hoadon.UseVisualStyleBackColor = true;
            this.btn_Hoadon.Click += new System.EventHandler(this.btn_Hoadon_Click);
            // 
            // pb_Quayve
            // 
            this.pb_Quayve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Quayve.Image = ((System.Drawing.Image)(resources.GetObject("pb_Quayve.Image")));
            this.pb_Quayve.Location = new System.Drawing.Point(16, 553);
            this.pb_Quayve.Name = "pb_Quayve";
            this.pb_Quayve.Size = new System.Drawing.Size(84, 75);
            this.pb_Quayve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Quayve.TabIndex = 19;
            this.pb_Quayve.TabStop = false;
            this.pb_Quayve.Click += new System.EventHandler(this.pb_Quayve_Click);
            // 
            // btn_Khachhang
            // 
            this.btn_Khachhang.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Khachhang.Location = new System.Drawing.Point(6, 146);
            this.btn_Khachhang.Name = "btn_Khachhang";
            this.btn_Khachhang.Size = new System.Drawing.Size(103, 60);
            this.btn_Khachhang.TabIndex = 25;
            this.btn_Khachhang.Text = "Khách Hàng";
            this.btn_Khachhang.UseVisualStyleBackColor = true;
            this.btn_Khachhang.Click += new System.EventHandler(this.btn_Khachhang_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.Location = new System.Drawing.Point(6, 80);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(103, 60);
            this.btn_NhanVien.TabIndex = 24;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_Trangchu
            // 
            this.btn_Trangchu.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Trangchu.Location = new System.Drawing.Point(6, 14);
            this.btn_Trangchu.Name = "btn_Trangchu";
            this.btn_Trangchu.Size = new System.Drawing.Size(103, 60);
            this.btn_Trangchu.TabIndex = 20;
            this.btn_Trangchu.Text = "Trang Chủ";
            this.btn_Trangchu.UseVisualStyleBackColor = true;
            this.btn_Trangchu.Click += new System.EventHandler(this.btn_Trangchu_Click);
            // 
            // btn_Giohang
            // 
            this.btn_Giohang.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Giohang.Location = new System.Drawing.Point(6, 346);
            this.btn_Giohang.Name = "btn_Giohang";
            this.btn_Giohang.Size = new System.Drawing.Size(103, 60);
            this.btn_Giohang.TabIndex = 23;
            this.btn_Giohang.Text = "Giỏ Hàng";
            this.btn_Giohang.UseVisualStyleBackColor = true;
            this.btn_Giohang.Click += new System.EventHandler(this.btn_Giohang_Click);
            // 
            // btn_Sanpham
            // 
            this.btn_Sanpham.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sanpham.Location = new System.Drawing.Point(6, 214);
            this.btn_Sanpham.Name = "btn_Sanpham";
            this.btn_Sanpham.Size = new System.Drawing.Size(103, 60);
            this.btn_Sanpham.TabIndex = 21;
            this.btn_Sanpham.Text = "Sản Phẩm";
            this.btn_Sanpham.UseVisualStyleBackColor = true;
            this.btn_Sanpham.Click += new System.EventHandler(this.btn_Sanpham_Click);
            // 
            // btn_Danhmuc
            // 
            this.btn_Danhmuc.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Danhmuc.Location = new System.Drawing.Point(6, 280);
            this.btn_Danhmuc.Name = "btn_Danhmuc";
            this.btn_Danhmuc.Size = new System.Drawing.Size(103, 60);
            this.btn_Danhmuc.TabIndex = 22;
            this.btn_Danhmuc.Text = "Danh Mục";
            this.btn_Danhmuc.UseVisualStyleBackColor = true;
            this.btn_Danhmuc.Click += new System.EventHandler(this.btn_Danhmuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // txt_Manv
            // 
            this.txt_Manv.Location = new System.Drawing.Point(126, 108);
            this.txt_Manv.Name = "txt_Manv";
            this.txt_Manv.Size = new System.Drawing.Size(200, 26);
            this.txt_Manv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "SĐT";
            // 
            // txt_TenNv
            // 
            this.txt_TenNv.Location = new System.Drawing.Point(126, 164);
            this.txt_TenNv.Name = "txt_TenNv";
            this.txt_TenNv.Size = new System.Drawing.Size(200, 26);
            this.txt_TenNv.TabIndex = 8;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(126, 317);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(200, 26);
            this.txt_Diachi.TabIndex = 9;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(126, 380);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 26);
            this.txt_SDT.TabIndex = 10;
            // 
            // date_Nhanvien
            // 
            this.date_Nhanvien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_Nhanvien.Location = new System.Drawing.Point(126, 214);
            this.date_Nhanvien.Name = "date_Nhanvien";
            this.date_Nhanvien.Size = new System.Drawing.Size(165, 26);
            this.date_Nhanvien.TabIndex = 12;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Xoa.Location = new System.Drawing.Point(3, 598);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(343, 39);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Sua.Location = new System.Drawing.Point(3, 559);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(343, 39);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Them.Location = new System.Drawing.Point(3, 520);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(343, 39);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(126, 261);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(59, 24);
            this.rbtn_Nam.TabIndex = 17;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(235, 261);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(47, 24);
            this.rbtn_Nu.TabIndex = 18;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_Nu);
            this.groupBox3.Controls.Add(this.rbtn_Nam);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.date_Nhanvien);
            this.groupBox3.Controls.Add(this.txt_SDT);
            this.groupBox3.Controls.Add(this.txt_Diachi);
            this.groupBox3.Controls.Add(this.txt_TenNv);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_Manv);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(659, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 640);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 640);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrid_Nhanvien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Quayve)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgrid_Nhanvien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Khachhang;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_Trangchu;
        private System.Windows.Forms.Button btn_Sanpham;
        private System.Windows.Forms.Button btn_Danhmuc;
        private System.Windows.Forms.Button btn_Giohang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenNv;
        private System.Windows.Forms.TextBox txt_Diachi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.DateTimePicker date_Nhanvien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_Quayve;
        private System.Windows.Forms.Button btn_Hoadon;
    }
}