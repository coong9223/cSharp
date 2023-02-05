using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
    using _2.BUS.iServices;
    using _1.DAL.DomainClass;
    using System.Linq;
    using _2.BUS.Services;
    using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmQlNsx : Form
    {
        
        private iNsxService _iNsxService;
        Guid _idWhenClick;
        public FrmQlNsx()
        {
            InitializeComponent();
            _iNsxService =new NsxService();
            LoadDGrid(null);
        }

        private void LoadDGrid(string input)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "Id";
            dataGridView1.Columns[2].Name = "Mã";
            dataGridView1.Columns[3].Name = "tên";
            dataGridView1.Rows.Clear();
            foreach (var x in _iNsxService.GetAll())
            {
                dataGridView1.Rows.Add(stt++,x.Id,x.Ma,x.Ten) ;
            }
        }

        private Nsx GetDFromGuid()
        {
            return new Nsx()
            {
                Id = Guid.Empty,
                Ma=txt_ma.Text,
                Ten=txt_ten.Text,
            };
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iNsxService.Add(GetDFromGuid()));
            LoadDGrid(null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iNsxService.Update(temp));
            LoadDGrid(null);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iNsxService.Delete(temp));
            LoadDGrid(null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int row=e.RowIndex;
            if (row == _iNsxService.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dataGridView1.Rows[row].Cells[1].Value.ToString());
            var obj = _iNsxService.GetAll().FirstOrDefault(c => c.Id == _idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }
    }
}
