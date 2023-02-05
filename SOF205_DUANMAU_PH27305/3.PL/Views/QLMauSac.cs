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
    public partial class QLMauSac : Form
    {
        private IMauSacService _iMauService;
        Guid _idWhenclick;
        public QLMauSac()
        {
            InitializeComponent();
            _iMauService = new MauSacService();
            LoadDgridMau(null);
            txt_ma.Enabled = false;
            dgrid_mausac.Columns[1].Visible = false;
        }
        private void LoadDgridMau(string input)
        {
            int stt = 1;
            dgrid_mausac.ColumnCount = 4;
            dgrid_mausac.Columns[0].Name = "STT";
            dgrid_mausac.Columns[1].Name = "Id";
            dgrid_mausac.Columns[2].Name = "Mã";
            dgrid_mausac.Columns[3].Name = "Tên";
            dgrid_mausac.Rows.Clear();

            foreach (var x in _iMauService.GetAll(input))
            {
                dgrid_mausac.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private MauSac GetDataFromGui()
        {
            return new MauSac()
            {
                Id = Guid.Empty,
                Ma = "MS" + Utility.GetNumber(4),
                Ten = txt_ten.Text
            };
        }

        private void dgrid_mausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iMauService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_mausac.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iMauService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iMauService.Add(GetDataFromGui()));
            LoadDgridMau(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iMauService.Update(temp));
            LoadDgridMau(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iMauService.Delete(temp));
            LoadDgridMau(null);
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
