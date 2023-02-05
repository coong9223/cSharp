using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLNsx : Form
    {
        private INsxService _iNsxService;
        Guid _idWhenclick;
        public QLNsx()
        {
            InitializeComponent();
            _iNsxService = new NsxService();
            LoadDgridNsx(null);
            txt_ma.Enabled = false;
            dgrid_nsx.Columns[1].Visible = false;
        }
        private void LoadDgridNsx(string input)
        {
            int stt = 1;
            dgrid_nsx.ColumnCount = 4;
            dgrid_nsx.Columns[0].Name = "STT";
            dgrid_nsx.Columns[1].Name = "Id";
            dgrid_nsx.Columns[2].Name = "Ma";
            dgrid_nsx.Columns[3].Name = "Ten";
            dgrid_nsx.Rows.Clear();

            foreach (var x in _iNsxService.GetAll(input))
            {
                dgrid_nsx.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private Nsx GetDataFromGui()
        {
            return new Nsx()
            {
                Id = Guid.Empty,
                Ma = "NSX" + Utility.GetNumber(4),
                Ten = txt_ten.Text
            };
        }

        private void dgrid_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iNsxService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_nsx.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iNsxService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iNsxService.Add(GetDataFromGui()));
            LoadDgridNsx(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iNsxService.Update(temp));
            LoadDgridNsx(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iNsxService.Delete(temp));
            LoadDgridNsx(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "Tìm Kiếm";
        }
    }
}
