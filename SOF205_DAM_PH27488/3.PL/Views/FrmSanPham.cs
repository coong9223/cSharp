using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.iServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private iSanPhamService iSanPhamSer;
        Guid idClick;
        public FrmSanPham()
        {
            InitializeComponent();
            iSanPhamSer = new SanPhamService();
            LoadDGrid(null);
        }
        public SanPhamView GetDFromGuid()
        {
            return new SanPhamView()
            {
                id = Guid.Empty,
                ma = txt_ma.Text,
                ten = txt_ten.Text,
            };
        }
        void LoadDGrid(string input)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "id";
            dataGridView1.Columns[2].Name = "ma";
            dataGridView1.Columns[3].Name = "ten";
            dataGridView1.Rows.Clear();
            foreach(var x in iSanPhamSer.GetAllSp(input))
            {
                dataGridView1.Rows.Add(stt++,x.id, x.ma, x.ten);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ya sure?", "Confirm", MessageBoxButtons.YesNo);
            MessageBox.Show(iSanPhamSer.Add(GetDFromGuid()));
            LoadDGrid(null);
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (e.RowIndex == -1) return;
            if (Row == iSanPhamSer.GetAllSp().Count) return;
            idClick = Guid.Parse(dataGridView1.Rows[Row].Cells[1].Value.ToString());
            var obj = iSanPhamSer.GetAllSp().FirstOrDefault(c => c.id==idClick);
            txt_ma.Text=obj.ma;
            txt_ten.Text=obj.ten;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ya sure?", "Confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            MessageBox.Show(iSanPhamSer.Update(temp));
            LoadDGrid(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ya sure?", "Confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            MessageBox.Show(iSanPhamSer.Delete(temp));
            LoadDGrid(null);
        }



        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timKiem.Text))
            {
                return;
            }
            LoadDGrid(txt_timKiem.Text);
        }

        private void txt_timKiem_Leave(object sender, EventArgs e)
        {
            txt_timKiem.Text = "Tim Kiem";
            LoadDGrid(null);
        }

        private void txt_timKiem_Click(object sender, EventArgs e)
        {
            txt_timKiem.Text = "";
        }
    }
}
