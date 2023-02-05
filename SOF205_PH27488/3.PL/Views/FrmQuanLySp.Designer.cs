//namespace _3.PL.Views
//{
//    partial class FrmQuanLySp
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.btn_them = new System.Windows.Forms.Button();
//            this.btn_xoa = new System.Windows.Forms.Button();
//            this.btn_sua = new System.Windows.Forms.Button();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label5 = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.txt_mota = new System.Windows.Forms.TextBox();
//            this.txt_nambh = new System.Windows.Forms.TextBox();
//            this.txt_dongsp = new System.Windows.Forms.TextBox();
//            this.txt_mau = new System.Windows.Forms.TextBox();
//            this.txt_ten = new System.Windows.Forms.TextBox();
//            this.txt_id = new System.Windows.Forms.TextBox();
//            this.txt_nsx = new System.Windows.Forms.TextBox();
//            this.label8 = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.dataGridView1.Location = new System.Drawing.Point(0, 290);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersWidth = 51;
//            this.dataGridView1.RowTemplate.Height = 29;
//            this.dataGridView1.Size = new System.Drawing.Size(800, 160);
//            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            // 
//            // btn_them
//            // 
//            this.btn_them.Location = new System.Drawing.Point(549, 71);
//            this.btn_them.Name = "btn_them";
//            this.btn_them.Size = new System.Drawing.Size(94, 29);
//            this.btn_them.TabIndex = 1;
//            this.btn_them.Text = "thêm";
//            this.btn_them.UseVisualStyleBackColor = true;
//            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
//            // 
//            // btn_xoa
//            // 
//            this.btn_xoa.Location = new System.Drawing.Point(549, 180);
//            this.btn_xoa.Name = "btn_xoa";
//            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
//            this.btn_xoa.TabIndex = 2;
//            this.btn_xoa.Text = "xóa";
//            this.btn_xoa.UseVisualStyleBackColor = true;
//            // 
//            // btn_sua
//            // 
//            this.btn_sua.Location = new System.Drawing.Point(549, 122);
//            this.btn_sua.Name = "btn_sua";
//            this.btn_sua.Size = new System.Drawing.Size(94, 29);
//            this.btn_sua.TabIndex = 3;
//            this.btn_sua.Text = "sửa";
//            this.btn_sua.UseVisualStyleBackColor = true;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(15, 63);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(22, 20);
//            this.label2.TabIndex = 5;
//            this.label2.Text = "id";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(15, 92);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(30, 20);
//            this.label3.TabIndex = 6;
//            this.label3.Text = "tên";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(15, 125);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(38, 20);
//            this.label4.TabIndex = 7;
//            this.label4.Text = "màu";
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.Location = new System.Drawing.Point(15, 160);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(30, 20);
//            this.label5.TabIndex = 8;
//            this.label5.Text = "nsx";
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Location = new System.Drawing.Point(15, 194);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(63, 20);
//            this.label6.TabIndex = 9;
//            this.label6.Text = "dòng sp";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(15, 227);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(59, 20);
//            this.label7.TabIndex = 10;
//            this.label7.Text = "năm bh";
//            // 
//            // txt_mota
//            // 
//            this.txt_mota.Location = new System.Drawing.Point(85, 257);
//            this.txt_mota.Name = "txt_mota";
//            this.txt_mota.Size = new System.Drawing.Size(290, 27);
//            this.txt_mota.TabIndex = 12;
//            // 
//            // txt_nambh
//            // 
//            this.txt_nambh.Location = new System.Drawing.Point(85, 224);
//            this.txt_nambh.Name = "txt_nambh";
//            this.txt_nambh.Size = new System.Drawing.Size(290, 27);
//            this.txt_nambh.TabIndex = 13;
//            // 
//            // txt_dongsp
//            // 
//            this.txt_dongsp.Location = new System.Drawing.Point(85, 191);
//            this.txt_dongsp.Name = "txt_dongsp";
//            this.txt_dongsp.Size = new System.Drawing.Size(290, 27);
//            this.txt_dongsp.TabIndex = 14;
//            // 
//            // txt_mau
//            // 
//            this.txt_mau.Location = new System.Drawing.Point(85, 122);
//            this.txt_mau.Name = "txt_mau";
//            this.txt_mau.Size = new System.Drawing.Size(290, 27);
//            this.txt_mau.TabIndex = 15;
//            // 
//            // txt_ten
//            // 
//            this.txt_ten.Location = new System.Drawing.Point(85, 89);
//            this.txt_ten.Name = "txt_ten";
//            this.txt_ten.Size = new System.Drawing.Size(290, 27);
//            this.txt_ten.TabIndex = 16;
//            // 
//            // txt_id
//            // 
//            this.txt_id.Location = new System.Drawing.Point(85, 56);
//            this.txt_id.Name = "txt_id";
//            this.txt_id.Size = new System.Drawing.Size(290, 27);
//            this.txt_id.TabIndex = 17;
//            // 
//            // txt_nsx
//            // 
//            this.txt_nsx.Location = new System.Drawing.Point(85, 158);
//            this.txt_nsx.Name = "txt_nsx";
//            this.txt_nsx.Size = new System.Drawing.Size(290, 27);
//            this.txt_nsx.TabIndex = 18;
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Location = new System.Drawing.Point(15, 264);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(48, 20);
//            this.label8.TabIndex = 19;
//            this.label8.Text = "mô tả";
//            // 
//            // FrmQuanLySp
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.label8);
//            this.Controls.Add(this.txt_nsx);
//            this.Controls.Add(this.txt_id);
//            this.Controls.Add(this.txt_ten);
//            this.Controls.Add(this.txt_mau);
//            this.Controls.Add(this.txt_dongsp);
//            this.Controls.Add(this.txt_nambh);
//            this.Controls.Add(this.txt_mota);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.label6);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.btn_sua);
//            this.Controls.Add(this.btn_xoa);
//            this.Controls.Add(this.btn_them);
//            this.Controls.Add(this.dataGridView1);
//            this.Name = "FrmQuanLySp";
//            this.Text = "FrmQuanLySp";
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Button btn_them;
//        private System.Windows.Forms.Button btn_xoa;
//        private System.Windows.Forms.Button btn_sua;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.TextBox txt_mota;
//        private System.Windows.Forms.TextBox txt_nambh;
//        private System.Windows.Forms.TextBox txt_dongsp;
//        private System.Windows.Forms.TextBox txt_mau;
//        private System.Windows.Forms.TextBox txt_ten;
//        private System.Windows.Forms.TextBox txt_id;
//        private System.Windows.Forms.TextBox txt_nsx;
//        private System.Windows.Forms.Label label8;
//    }
//}