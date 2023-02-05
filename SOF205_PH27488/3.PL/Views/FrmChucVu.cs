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
    public partial class FrmChucVu : Form
    {
        private iChucVuService iChucVuService;
        Guid _idWhenClick;
        public FrmChucVu()
        {
            InitializeComponent();
            iChucVuService = new ChucVuService();
            LoadDFromGuid(null);
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
            foreach (var x in iChucVuService.GetAll())
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private ChucVu GetDFromGuid()
        {
            return new ChucVu
            {
                Id = _idWhenClick,
                Ma = txt_ma.Text,
                Ten = txt_ten.Text
            };
        }


        private void btn_remove_Click(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(iChucVuService.Delete(temp));
            LoadDFromGuid(null);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int RowIndex = e.RowIndex;
            if (RowIndex == iChucVuService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());
            var temp = GetDFromGuid();
            txt_ma.Text = temp.Ma;
            txt_ten.Text = temp.Ten;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(iChucVuService.Add(GetDFromGuid()));
            LoadDFromGuid(null);
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(iChucVuService.Update(temp));
            LoadDFromGuid(null);
        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            var temp = GetDFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(iChucVuService.Delete(temp));
            LoadDFromGuid(null);
        }
    }
}
