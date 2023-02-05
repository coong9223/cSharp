using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class QLChucVu : Form
    {
        private IChucVuService _iChucVuService;
        Guid _idWhenclick;
        public QLChucVu()
        {
            InitializeComponent();
            _iChucVuService = new ChucVuService();
            LoadDgridChucVu(null);
        }
        private void LoadDgridChucVu(string input)
        {
            int stt = 1;
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = "STT";
            dgrid_ChucVu.Columns[1].Name = "ID";
            dgrid_ChucVu.Columns[2].Name = "Mã Chức Vụ";
            dgrid_ChucVu.Columns[3].Name = "Tên Chức Vụ";
            dgrid_ChucVu.Rows.Clear();

            foreach (var x in _iChucVuService.GetAll(input))
            {
                dgrid_ChucVu.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private ChucVu GetDataFromGui()
        {
            return new ChucVu()
            {
                Id = Guid.Empty,
                Ma = tbt_Ma.Text,
                Ten = tbt_Ten.Text
            };
        }

        private void dgrid_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iChucVuService.GetAll(null).Count) return;
            _idWhenclick = Guid.Parse(dgrid_ChucVu.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iChucVuService.GetAll().FirstOrDefault(x => x.Id == _idWhenclick);
            tbt_Ma.Text = obj.Ma;
            tbt_Ten.Text = obj.Ten;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iChucVuService.Add(GetDataFromGui()));
            LoadDgridChucVu(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iChucVuService.Update(temp));
            LoadDgridChucVu(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iChucVuService.Delete(temp));
            LoadDgridChucVu(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
        }

        private void tbt_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void tbt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbt_TimKiem_Leave(object sender, EventArgs e)
        {

        }
    }
}
