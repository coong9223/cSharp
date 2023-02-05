namespace BAI_1_6_CRUD_EF_DBFIRST.Views
{
    partial class FrmQLChucVu
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
            this.tbt_Ten = new System.Windows.Forms.TextBox();
            this.tbt_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tbt_Clear = new System.Windows.Forms.Button();
            this.tbt_Xoa = new System.Windows.Forms.Button();
            this.tbt_Sua = new System.Windows.Forms.Button();
            this.tbt_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgrid_ChucVu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbt_Ten);
            this.groupBox1.Controls.Add(this.tbt_Ma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Liệu";
            // 
            // tbt_Ten
            // 
            this.tbt_Ten.Location = new System.Drawing.Point(183, 114);
            this.tbt_Ten.Name = "tbt_Ten";
            this.tbt_Ten.Size = new System.Drawing.Size(299, 29);
            this.tbt_Ten.TabIndex = 3;
            this.tbt_Ten.TextChanged += new System.EventHandler(this.tbt_Ten_TextChanged);
            this.tbt_Ten.Leave += new System.EventHandler(this.tbt_Ten_Leave);
            // 
            // tbt_Ma
            // 
            this.tbt_Ma.Location = new System.Drawing.Point(183, 57);
            this.tbt_Ma.Name = "tbt_Ma";
            this.tbt_Ma.Size = new System.Drawing.Size(299, 29);
            this.tbt_Ma.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.tbt_Clear);
            this.groupBox2.Controls.Add(this.tbt_Xoa);
            this.groupBox2.Controls.Add(this.tbt_Sua);
            this.groupBox2.Controls.Add(this.tbt_Them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(729, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 227);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều Khiển";
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(3, 177);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(454, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbt_Clear
            // 
            this.tbt_Clear.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbt_Clear.Location = new System.Drawing.Point(3, 139);
            this.tbt_Clear.Name = "tbt_Clear";
            this.tbt_Clear.Size = new System.Drawing.Size(454, 38);
            this.tbt_Clear.TabIndex = 3;
            this.tbt_Clear.Text = "Clear";
            this.tbt_Clear.UseVisualStyleBackColor = true;
            this.tbt_Clear.Click += new System.EventHandler(this.tbt_Clear_Click);
            // 
            // tbt_Xoa
            // 
            this.tbt_Xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbt_Xoa.Location = new System.Drawing.Point(3, 101);
            this.tbt_Xoa.Name = "tbt_Xoa";
            this.tbt_Xoa.Size = new System.Drawing.Size(454, 38);
            this.tbt_Xoa.TabIndex = 2;
            this.tbt_Xoa.Text = "Xóa";
            this.tbt_Xoa.UseVisualStyleBackColor = true;
            this.tbt_Xoa.Click += new System.EventHandler(this.tbt_Xoa_Click);
            // 
            // tbt_Sua
            // 
            this.tbt_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbt_Sua.Location = new System.Drawing.Point(3, 63);
            this.tbt_Sua.Name = "tbt_Sua";
            this.tbt_Sua.Size = new System.Drawing.Size(454, 38);
            this.tbt_Sua.TabIndex = 1;
            this.tbt_Sua.Text = "Sửa";
            this.tbt_Sua.UseVisualStyleBackColor = true;
            this.tbt_Sua.Click += new System.EventHandler(this.tbt_Sua_Click);
            // 
            // tbt_Them
            // 
            this.tbt_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbt_Them.Location = new System.Drawing.Point(3, 25);
            this.tbt_Them.Name = "tbt_Them";
            this.tbt_Them.Size = new System.Drawing.Size(454, 38);
            this.tbt_Them.TabIndex = 0;
            this.tbt_Them.Text = "Thêm";
            this.tbt_Them.UseVisualStyleBackColor = true;
            this.tbt_Them.Click += new System.EventHandler(this.tbt_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbt_TimKiem);
            this.groupBox3.Controls.Add(this.dgrid_ChucVu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1189, 403);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // tbt_TimKiem
            // 
            this.tbt_TimKiem.Location = new System.Drawing.Point(421, 25);
            this.tbt_TimKiem.Name = "tbt_TimKiem";
            this.tbt_TimKiem.Size = new System.Drawing.Size(299, 29);
            this.tbt_TimKiem.TabIndex = 4;
            this.tbt_TimKiem.Text = "Tìm Kiếm ...";
            this.tbt_TimKiem.Click += new System.EventHandler(this.tbt_TimKiem_Click);
            this.tbt_TimKiem.TextChanged += new System.EventHandler(this.tbt_TimKiem_TextChanged);
            this.tbt_TimKiem.Leave += new System.EventHandler(this.tbt_TimKiem_Leave);
            // 
            // dgrid_ChucVu
            // 
            this.dgrid_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ChucVu.Location = new System.Drawing.Point(3, 105);
            this.dgrid_ChucVu.Name = "dgrid_ChucVu";
            this.dgrid_ChucVu.RowTemplate.Height = 25;
            this.dgrid_ChucVu.Size = new System.Drawing.Size(1183, 295);
            this.dgrid_ChucVu.TabIndex = 0;
            this.dgrid_ChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChucVu_CellClick);
            // 
            // FrmQLChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmQLChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQLChucVu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbt_Ten;
        private System.Windows.Forms.TextBox tbt_Ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button tbt_Clear;
        private System.Windows.Forms.Button tbt_Xoa;
        private System.Windows.Forms.Button tbt_Sua;
        private System.Windows.Forms.Button tbt_Them;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbt_TimKiem;
        private System.Windows.Forms.DataGridView dgrid_ChucVu;
    }
}