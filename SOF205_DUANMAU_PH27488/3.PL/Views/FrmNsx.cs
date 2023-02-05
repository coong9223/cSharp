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
using _1.DAL.DomainClass;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmNsx : Form
    {
        private iNsxService iNsxService;
        Guid _idWhenClick;
        public FrmNsx()
        {
            InitializeComponent();
            iNsxService = new NsxService();
            LoadData(null);
        }
        private void LoadData(string input)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "Ma";
            dataGridView1.Columns[2].Name = "Ten";
            dataGridView1.Rows.Clear();
            foreach (var x in iNsxService.GetData())
            {
                dataGridView1.Rows.Add(stt++, x.ma,x.ten);
            }
        }
        public NsxView GetData()
        {
            NsxView nsxview=new NsxView()
            {
                Id=Guid.Empty,
                ma = textBox2.Text,
                ten = textBox3.Text,
            };
            return nsxview;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iNsxService.Add(GetData());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _idWhenClick;
            iNsxService.Delete(temp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _idWhenClick;
            iNsxService.Update(temp);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int Row = e.RowIndex;
            if (Row == iNsxService.GetData().Count)
            {
                return;
            }
            _idWhenClick=Guid.Parse(dataGridView1.Rows[Row].Cells[1].Value.ToString());
            var obj=iNsxService.GetData().FirstOrDefault(c=>c.Id==_idWhenClick);
            obj.ma = textBox2.Text;
            obj.ten = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }
    }
}
