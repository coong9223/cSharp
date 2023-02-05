using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using _2.BUS.iServices;
using _2.BUS.Services;
using _1.DAL.DomainClass;

namespace _3.PL.Views
{
    public partial class FrmDongSp : Form
    {
        private iDongSpService _iDongSpService;
        Guid _idWhenClick;
        public FrmDongSp()
        {
            InitializeComponent();
            _iDongSpService = new DongSpService();
        }

        private void LoadDFromGuid(string input)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "id";
            dataGridView1.Columns[2].Name = "mã";
            dataGridView1.Columns[3].Name = "tên";
            dataGridView1.Rows.Clear();
            foreach(var x in _iDongSpService.GetAll())
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private DongSp GetDFromGuid()
        {
            return new DongSp
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                Ten=txt_ten.Text,
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int RowIndex = e.RowIndex;
            if (RowIndex == _iDongSpService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _iDongSpService.GetAll().FirstOrDefault(c=>c.Id==_idWhenClick);
            obj.Ma = txt_ma.Text;
            obj.Ten = txt_ten.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iDongSpService.Add(GetDFromGuid()));
            LoadDFromGuid(null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iDongSpService.Update(temp));
            LoadDFromGuid(null);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iDongSpService.Delete(temp));
            LoadDFromGuid(null);
        }
    }
}
