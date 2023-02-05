using BAI_1_6_CRUD_EF_DBFIRST.DomainModels;
using BAI_1_6_CRUD_EF_DBFIRST.Services;
using BAI_1_6_CRUD_EF_DBFIRST.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAI_1_6_CRUD_EF_DBFIRST.Views
{
    public partial class FrmQLChucVu : Form
    {
        QLChucVuService _cvService;
        Guid _idWhenClick;
        public FrmQLChucVu()
        {
            InitializeComponent();
            tbt_Ma.Enabled = false;
            _cvService = new QLChucVuService();
            LoadDgridChucVu(null);
        }
        private void LoadDgridChucVu(string input)
        {
            int stt = 1;
            Type type = typeof(ChucVu);
            int slgThuocTinh = type.GetProperties().Length;
            dgrid_ChucVu.ColumnCount = slgThuocTinh;
            dgrid_ChucVu.Columns[0].Name = "STT";
            dgrid_ChucVu.Columns[1].Name = "ID";
            dgrid_ChucVu.Columns[2].Name = "Mã Chức Vụ";
            dgrid_ChucVu.Columns[3].Name = "Tên Chức Vụ";
            dgrid_ChucVu.Rows.Clear();
            foreach (var x in _cvService.GetAllChucVu(input))
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
            if (e.RowIndex == -1)return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _cvService.GetAllChucVu(null).Count) return;
            _idWhenClick = Guid.Parse(dgrid_ChucVu.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _cvService.GetAllChucVu().FirstOrDefault(x => x.Id == _idWhenClick);
            tbt_Ma.Text = obj.Ma;
            tbt_Ten.Text = obj.Ten;
        }

        private void tbt_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cvService.Add(GetDataFromGui()));
            LoadDgridChucVu(null);
        }

        private void tbt_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_cvService.Update(temp));
            LoadDgridChucVu(null);
        }

        private void tbt_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_cvService.Delete(temp));
            LoadDgridChucVu(null);
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
        }

        private void tbt_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
        }

        private void tbt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_TimKiem.Text)) return;
            LoadDgridChucVu(tbt_TimKiem.Text);
        }

        private void tbt_TimKiem_Leave(object sender, EventArgs e)
        {
            tbt_TimKiem.Text = "Tìm kiếm .......";
            LoadDgridChucVu(null);
        }

        private void tbt_TimKiem_Click(object sender, EventArgs e)
        {
            tbt_TimKiem.Clear();
        }

        private void tbt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ten.Text)) return;
            tbt_Ma.Text = Utility.GenMa2(tbt_Ten.Text);
        }

        private void tbt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ten.Text)) return;
            tbt_Ten.Text = Utility.VietHoaFullName(tbt_Ten.Text);
        }
    }
}
