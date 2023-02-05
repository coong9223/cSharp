namespace practices_cSharp3_bai2.View
{
    partial class Form1
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
            this.ma = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.TextBox();
            this.hd = new System.Windows.Forms.RadioButton();
            this.khd = new System.Windows.Forms.RadioButton();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(68, 39);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(472, 27);
            this.ma.TabIndex = 0;
            this.ma.TextChanged += new System.EventHandler(this.ma_TextChanged);
            // 
            // gia
            // 
            this.gia.Location = new System.Drawing.Point(68, 105);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(472, 27);
            this.gia.TabIndex = 2;
            this.gia.TextChanged += new System.EventHandler(this.gia_TextChanged);
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(68, 72);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(472, 27);
            this.ten.TabIndex = 3;
            this.ten.TextChanged += new System.EventHandler(this.ten_TextChanged);
            // 
            // hd
            // 
            this.hd.AutoSize = true;
            this.hd.Location = new System.Drawing.Point(68, 155);
            this.hd.Name = "hd";
            this.hd.Size = new System.Drawing.Size(47, 24);
            this.hd.TabIndex = 4;
            this.hd.TabStop = true;
            this.hd.Text = "hd";
            this.hd.UseVisualStyleBackColor = true;
            this.hd.CheckedChanged += new System.EventHandler(this.hd_CheckedChanged);
            // 
            // khd
            // 
            this.khd.AutoSize = true;
            this.khd.Location = new System.Drawing.Point(423, 155);
            this.khd.Name = "khd";
            this.khd.Size = new System.Drawing.Size(54, 24);
            this.khd.TabIndex = 5;
            this.khd.TabStop = true;
            this.khd.Text = "khd";
            this.khd.UseVisualStyleBackColor = true;
            this.khd.CheckedChanged += new System.EventHandler(this.khd_CheckedChanged);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(67, 241);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(94, 29);
            this.them.TabIndex = 6;
            this.them.Text = "them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(347, 241);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 29);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(199, 241);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(94, 29);
            this.sua.TabIndex = 9;
            this.sua.Text = "sua";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 138);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // webs
            // 
            this.webs.FormattingEnabled = true;
            this.webs.Location = new System.Drawing.Point(71, 193);
            this.webs.Name = "webs";
            this.webs.Size = new System.Drawing.Size(151, 28);
            this.webs.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.khd);
            this.Controls.Add(this.hd);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.gia);
            this.Controls.Add(this.ma);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.RadioButton hd;
        private System.Windows.Forms.RadioButton khd;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox webs;
    }
}