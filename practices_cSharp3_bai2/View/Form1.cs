using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using practices_cSharp3_bai2.DomainClass;
using practices_cSharp3_bai2.Ser;
using practices_cSharp3_bai2.View;

namespace practices_cSharp3_bai2.View
{
    public partial class Form1 : Form
    {
        Sers ser;
        public Form1()
        {
            InitializeComponent();
            ser=new Sers();
            LoadWeb();
            LoadData();
        }
        public void LoadWeb()
        {
            foreach(var x in ser.GetWeb())
            {
                webs.Items.Add(x);
            }
            webs.SelectedIndex = 0;
        }
        public SanPham GetData()
        {
            return new SanPham()
            {
                Ma = ma.Text,
                Ten = ten.Text,
                TrangThai = hd.Checked ? 1 : 0,
                GiaBan=Convert.ToDecimal(gia.Text),
                Website=webs.Text,
            };
        }

        public void LoadData()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ma";
            dataGridView1.Columns[1].Name = "ten";
            dataGridView1.Columns[2].Name = "gia";
            dataGridView1.Columns[3].Name = "tus";
            dataGridView1.Columns[4].Name = "web";
            dataGridView1.Rows.Clear();
            foreach(var x in ser.GetAlSps())
            {
                dataGridView1.Rows.Add(x.Ma,x.Ten,x.GiaBan,x.TrangThai,x.Website);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ser.Addsps(GetData()));
            LoadData();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ser.Upsps(GetData()));
            LoadData();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ser.Delsps(GetData()));
            LoadData();
        }

        

        private void ma_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ma.Text)) return;
        }

        private void ten_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void hd_CheckedChanged(object sender, EventArgs e)
        {
            if(hd.Checked==true)khd.Checked=false;
        }

        private void khd_CheckedChanged(object sender, EventArgs e)
        {
            if (khd.Checked == true) hd.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x == ser.GetAlSps().Count)
            {
                return;
            }
            var ma1 = dataGridView1.Rows[x].Cells[0].Value.ToString();
            var obj = ser.GetAlSps().FirstOrDefault(c => c.Ma.Equals(ma));
            ten.Text = obj.Ten;
            ma.Text = obj.Ma;
            gia.Text = Convert.ToString(obj.GiaBan);
        }
    }
}
