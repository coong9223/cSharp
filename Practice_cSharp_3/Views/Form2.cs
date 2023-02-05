using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Practice_cSharp_3.Repositories;
using Practice_cSharp_3.Services;
using Practice_cSharp_3.DomainClass;
using System.Windows.Forms;
using System.Linq;

namespace Practice_cSharp_3.Views
{
    public partial class Form2 : Form
    {
        PracticesSer _PracticesSer;
        public Form2()
        {
            InitializeComponent();
            _PracticesSer = new PracticesSer(); 

        }
        public void LoadWebSite()
        {
            foreach (var x in _PracticesSer.GetAllWebsites())
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x=e.RowIndex;
            if (x == _PracticesSer.GetAllSps().Count)
            {
                return;
            }

            var ma = dataGridView1.Rows[x].Cells[0].Value.ToString();
            var obj = _PracticesSer.GetAllSps().FirstOrDefault(x => x.Ma.Equals(ma));
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            txt_giaban.Text = Convert.ToString(obj.GiaBan);
        }
    }
}
