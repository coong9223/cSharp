using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using _1.DAL.DomainClass;
using _2.BUS.iServices;
using _2.BUS.Services;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private iSanPhamService _iSanPhamService;
        Guid _idWhenClick;
        public FrmSanPham()
        {
            InitializeComponent();
            _iSanPhamService=new SanPhamService();
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
            foreach (var x in _iSanPhamService.GetAll())
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }

        private SanPham GetDFromGuid()
        {
            return new SanPham
            {
                Id = Guid.Empty,
                Ma=txt_ma.Text,
                Ten=txt_ten.Text,
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int RowIndex = e.RowIndex;
            if(RowIndex == _iSanPhamService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _iSanPhamService.GetAll().FirstOrDefault(c => c.Id == _idWhenClick);
            obj.Ma = txt_ma.Text;
            obj.Ten = txt_ten.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iSanPhamService.Add(GetDFromGuid()));
            LoadDGrid(null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iSanPhamService.Update(temp));
            LoadDGrid(null);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_iSanPhamService.Delete(temp));
            LoadDGrid(null);
        }
    }
}
