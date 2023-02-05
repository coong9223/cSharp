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
    public partial class QLDongSp : Form
    {
        private IDongSpService _iDongSpService;
        private Guid _idWhenclick;
        public QLDongSp()
        {
            InitializeComponent();
            _iDongSpService = new DongSpService();
            LoadDongSp(null);
            dgrid_dongsp.Columns[1].Visible = false;
            txt_ma.Enabled = false;
        }
        private void LoadDongSp(string input)
        {
            int stt = 1;
            dgrid_dongsp.ColumnCount = 4;
            dgrid_dongsp.Columns[0].Name = "STT";
            dgrid_dongsp.Columns[1].Name = "Id";
            dgrid_dongsp.Columns[2].Name = "Mã";
            dgrid_dongsp.Columns[3].Name = "Tên";
            dgrid_dongsp.Rows.Clear();

            foreach (var x in _iDongSpService.GetAll(input))
            {
                dgrid_dongsp.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private DongSp GetDataFromGui()
        {
            return new DongSp()
            {
                Id = Guid.Empty,
                Ma = "DSp" + Utility.GetNumber(4),
                Ten = txt_ten.Text
            };
        }

        private void dgrid_dongsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iDongSpService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_dongsp.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iDongSpService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iDongSpService.Add(GetDataFromGui()));
            LoadDongSp(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iDongSpService.Update(temp));
            LoadDongSp(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iDongSpService.Delete(temp));
            LoadDongSp(null);
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
