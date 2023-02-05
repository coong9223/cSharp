using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Services;
using BAI_1_6_CRUD_EF.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAI_1_6_CRUD_EF.Views
{
    public partial class FrmChucVu : Form
    {

        ChucVuService _cvService;
        Guid _idWhenClick;
        public FrmChucVu()
        {
            InitializeComponent();
            txt_Ma.Enabled = false;
            _cvService = new ChucVuService();
            LoadDgridChucVu(null);

        }

        private void LoadDgridChucVu(string input) {
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
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text
            };
        }

        private void dgrid_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _cvService.GetAllChucVu(null).Count) return;
            _idWhenClick = Guid.Parse(dgrid_ChucVu.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _cvService.GetAllChucVu().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cvService.Add(GetDataFromGui()));
            LoadDgridChucVu(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_cvService.Update(temp));
            LoadDgridChucVu(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_cvService.Delete(temp));
            LoadDgridChucVu(null);
            txt_Ma.Text = "";
            txt_Ten.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text)) return;
            LoadDgridChucVu(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "Tìm kiếm";
            LoadDgridChucVu(null);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ten.Text = Utility.VietHoaFullName(txt_Ten.Text);
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ma.Text = Utility.GenMa(txt_Ten.Text);
        }
    }
}
