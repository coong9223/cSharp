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
    public partial class FrmQLCuaHang : Form
    {
        QLCuaHangService _chService;
        Guid _idWhenClick;
        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangService();
            tbt_Ma.Enabled = false;
            LoadThanhPho();
            LoadDgridCH(null);
        }
        private void LoadThanhPho()
        {
            foreach (var item in _chService.GetAllThanhPhos())
            {
                cmb_ThanhPho.Items.Add(item);
            }
            cmb_ThanhPho.SelectedIndex = 0;
        }
        private void LoadDgridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuoTinh = type.GetProperties().Length;
            dgrid_CuaHang.ColumnCount = slThuoTinh;
            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "Id";
            dgrid_CuaHang.Columns[2].Name = "Mã";
            dgrid_CuaHang.Columns[3].Name = "Tên";
            dgrid_CuaHang.Columns[4].Name = "Địa Chỉ";
            dgrid_CuaHang.Columns[5].Name = "Thành Phố";
            dgrid_CuaHang.Columns[6].Name = "Quốc Gia";
            dgrid_CuaHang.Rows.Clear();

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgrid_CuaHang.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }
        }
        private CuaHang GetDataFromGui()
        {
            return new CuaHang()
            {
                Id = Guid.Empty,
                Ma = tbt_Ma.Text,
                Ten = tbt_Ten.Text,
                ThanhPho = cmb_ThanhPho.Text,
                DiaChi = tbt_DiaChi.Text,
                QuocGia = tbt_QuocGia.Text
            };
        }

        private void dgrid_CuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            _idWhenClick = Guid.Parse(dgrid_CuaHang.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(x => x.Id == _idWhenClick);
            tbt_Ma.Text = obj.Ma;
            tbt_Ten.Text = obj.Ten;
            tbt_DiaChi.Text = obj.DiaChi;
            cmb_ThanhPho.SelectedItem = obj.ThanhPho;
            tbt_QuocGia.Text = obj.QuocGia;
        }

        private void tbt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ten.Text)) return;
            tbt_Ma.Text = Utility.GenMaTuDong(tbt_Ten.Text) + _chService.GetAllCuaHangs(null).Count;
        }

        private void tbt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ten.Text)) return;
            tbt_Ten.Text = Utility.VietHoaFullName(tbt_Ten.Text);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDgridCH(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDgridCH(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDgridCH(null);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
            tbt_DiaChi.Text = "";
            cmb_ThanhPho.SelectedItem = 0;
            tbt_QuocGia.Text = "";
        }

        private void tbt_QuocGia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_QuocGia.Text)) return;
            tbt_QuocGia.Text = Utility.VietHoaFullName(tbt_QuocGia.Text);
        }

        private void tbt_DiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_DiaChi.Text)) return;
            tbt_DiaChi.Text = Utility.VietHoaFullName(tbt_DiaChi.Text);
        }
    }
}
