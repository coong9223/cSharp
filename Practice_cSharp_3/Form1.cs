using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_cSharp_3.Repositories;
using Practice_cSharp_3.Services;
using Practice_cSharp_3.DomainClass;
using Practice_cSharp_3.Views;

namespace Practice_cSharp_3
{
    public partial class Form1 : Form
    {
        PracticesSer _PracticesSer;
        public Form1()
        {
            InitializeComponent();
            _PracticesSer = new PracticesSer();
            rbtn_hd.Enabled = true;
            ////LoadWebSite();
            ////LoadData();
        }
        public void LoadWebSite()
        {
            foreach(var x in _PracticesSer.GetAllWebsites())
            {
                cmb_website.Items.Add(x);
            }
            cmb_website.SelectedIndex = 0;
        }

        public SanPham GetData()
        {
            return new SanPham()
            {
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                GiaBan = Convert.ToDecimal(txt_giaban),
            };
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ma";
            dataGridView1.Columns[1].Name = "ten";
            dataGridView1.Columns[2].Name = "giaban";
            dataGridView1.Columns[3].Name = "trangthai";
            dataGridView1.Columns[4].Name = "website";
            dataGridView1.Rows.Clear();
            foreach (var x in _PracticesSer.GetAllSps())
            {
                dataGridView1.Rows.Add(x.Ma, x.Ten, x.GiaBan, x.TrangThai, x.Website);
            }
        }

        private void txt_ma_Leave(object sender, EventArgs e)
        {
            
        }

        private void them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_PracticesSer.AddSp(GetData()));
            LoadData();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_PracticesSer.Update(GetData()));
            LoadData();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_PracticesSer.DeleteSp(GetData()));
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == _PracticesSer.GetAllSps().Count) return;
            var ma = dataGridView1.Rows[index].Cells[0].Value.ToString();
            var obj = _PracticesSer.GetAllSps().FirstOrDefault(x => x.Ma.Equals(ma));
            txt_ten.Text = obj.Ten;
            txt_giaban.Text = Convert.ToString(obj.GiaBan);
        }

        private void rbtn_hd_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_hd.Checked==true) rbtn_khd.Checked = false;
        }

        private void rbtn_khd_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_khd.Checked==true) rbtn_hd.Checked = false;
        }
    }
}
