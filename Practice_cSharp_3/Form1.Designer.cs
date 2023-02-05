namespace Practice_cSharp_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.rbtn_hd = new System.Windows.Forms.RadioButton();
            this.rbtn_khd = new System.Windows.Forms.RadioButton();
            this.cmb_website = new System.Windows.Forms.ComboBox();
            this.them = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Website ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "trangThai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "giaBan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ten";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(184, 35);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(421, 27);
            this.txt_ma.TabIndex = 5;
            this.txt_ma.Leave += new System.EventHandler(this.txt_ma_Leave);
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(184, 111);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(421, 27);
            this.txt_giaban.TabIndex = 7;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(184, 71);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(421, 27);
            this.txt_ten.TabIndex = 8;
            // 
            // rbtn_hd
            // 
            this.rbtn_hd.AutoSize = true;
            this.rbtn_hd.Location = new System.Drawing.Point(184, 164);
            this.rbtn_hd.Name = "rbtn_hd";
            this.rbtn_hd.Size = new System.Drawing.Size(99, 24);
            this.rbtn_hd.TabIndex = 9;
            this.rbtn_hd.TabStop = true;
            this.rbtn_hd.Text = "hoat dong";
            this.rbtn_hd.UseVisualStyleBackColor = true;
            this.rbtn_hd.CheckedChanged += new System.EventHandler(this.rbtn_hd_CheckedChanged);
            // 
            // rbtn_khd
            // 
            this.rbtn_khd.AutoSize = true;
            this.rbtn_khd.Location = new System.Drawing.Point(390, 164);
            this.rbtn_khd.Name = "rbtn_khd";
            this.rbtn_khd.Size = new System.Drawing.Size(119, 24);
            this.rbtn_khd.TabIndex = 10;
            this.rbtn_khd.TabStop = true;
            this.rbtn_khd.Text = "ko hoat dong";
            this.rbtn_khd.UseVisualStyleBackColor = true;
            this.rbtn_khd.CheckedChanged += new System.EventHandler(this.rbtn_khd_CheckedChanged);
            // 
            // cmb_website
            // 
            this.cmb_website.FormattingEnabled = true;
            this.cmb_website.Location = new System.Drawing.Point(184, 217);
            this.cmb_website.Name = "cmb_website";
            this.cmb_website.Size = new System.Drawing.Size(421, 28);
            this.cmb_website.TabIndex = 11;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(47, 281);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(94, 29);
            this.them.TabIndex = 12;
            this.them.Text = "them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(497, 281);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 29);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(338, 281);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 29);
            this.xoa.TabIndex = 14;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(184, 281);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(94, 29);
            this.sua.TabIndex = 15;
            this.sua.Text = "sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 134);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.them);
            this.Controls.Add(this.cmb_website);
            this.Controls.Add(this.rbtn_khd);
            this.Controls.Add(this.rbtn_hd);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.RadioButton rbtn_hd;
        private System.Windows.Forms.RadioButton rbtn_khd;
        private System.Windows.Forms.ComboBox cmb_website;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
