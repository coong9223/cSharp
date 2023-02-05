namespace Project_Template_SM22_Csharp.Views
{
    partial class FrmXeMay
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
            this.btn_cleck = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_XeMay = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_SoLuong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_XeMay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cleck
            // 
            this.btn_cleck.Location = new System.Drawing.Point(622, 301);
            this.btn_cleck.Name = "btn_cleck";
            this.btn_cleck.Size = new System.Drawing.Size(90, 28);
            this.btn_cleck.TabIndex = 25;
            this.btn_cleck.Text = "cleck";
            this.btn_cleck.UseVisualStyleBackColor = true;
            this.btn_cleck.Click += new System.EventHandler(this.btn_cleck_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(377, 301);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 28);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(491, 301);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 28);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(179, 170);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(120, 26);
            this.txt_Ten.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(234, 301);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(90, 28);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(179, 125);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(120, 26);
            this.txt_Ma.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã ";
            // 
            // dgrid_XeMay
            // 
            this.dgrid_XeMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_XeMay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_XeMay.Location = new System.Drawing.Point(0, 387);
            this.dgrid_XeMay.Name = "dgrid_XeMay";
            this.dgrid_XeMay.RowHeadersWidth = 49;
            this.dgrid_XeMay.RowTemplate.Height = 28;
            this.dgrid_XeMay.Size = new System.Drawing.Size(855, 137);
            this.dgrid_XeMay.TabIndex = 26;
            this.dgrid_XeMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_XeMay_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số Lượng";
            // 
            // cmb_SoLuong
            // 
            this.cmb_SoLuong.FormattingEnabled = true;
            this.cmb_SoLuong.Location = new System.Drawing.Point(541, 118);
            this.cmb_SoLuong.Name = "cmb_SoLuong";
            this.cmb_SoLuong.Size = new System.Drawing.Size(145, 27);
            this.cmb_SoLuong.TabIndex = 28;
            // 
            // FrmXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 524);
            this.Controls.Add(this.cmb_SoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgrid_XeMay);
            this.Controls.Add(this.btn_cleck);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmXeMay";
            this.Text = "FrmXeMay";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_XeMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cleck;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_XeMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_SoLuong;
    }
}