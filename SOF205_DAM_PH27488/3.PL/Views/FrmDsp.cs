using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using _2.BUS.iServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmDsp : Form
    {
        private iDspService iDspSer;
        Guid idClick;
        public FrmDsp()
        {
            InitializeComponent();
            iDspSer = new DongSpService();
            LoadDGrid(null);
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
            foreach(var x in iDspSer.GetAllDsp())
            {
                dataGridView1.Rows.Add(stt++,x.id, x.ma, x.ten);
            }
        }
        DongSpView GetDFromGuid()
        {
            return new DongSpView()
            {
                id = Guid.Empty,
                ma = txt_ma.Text,
                ten = txt_ten.Text,
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dLog = MessageBox.Show("Hmm?", "Confirm", MessageBoxButtons.YesNo);
            MessageBox.Show(iDspSer.Add(GetDFromGuid()));
            LoadDGrid(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dLog = MessageBox.Show("Hmm?", "Confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            temp.ma = txt_ma.Text;
            temp.ten = txt_ten.Text;
            MessageBox.Show(iDspSer.Update(temp));
            LoadDGrid(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dLog = MessageBox.Show("Hmm?", "Confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            MessageBox.Show(iDspSer.Delete(temp));
            LoadDGrid(null);
        }

        private void txt_timKiem_Click(object sender, EventArgs e)
        {
            txt_timKiem.Text = "";
        }

        private void txt_timKiem_Leave(object sender, EventArgs e)
        {
            txt_timKiem.Text = "tim kiem";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (e.RowIndex == -1) return;
            if (Row == iDspSer.GetAllDsp().Count) return;
            idClick = Guid.Parse(dataGridView1.Rows[Row].Cells[1].Value.ToString());
            var temp=iDspSer.GetAllDsp().FirstOrDefault(c=>c.id==idClick);
            txt_ma.Text = temp.ma;
            txt_ten.Text= temp.ten;
        }
    }
}
