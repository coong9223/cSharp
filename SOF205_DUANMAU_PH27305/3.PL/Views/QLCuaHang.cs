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
    public partial class QLCuaHang : Form
    {
        private ICuaHangService _iCuaHangService;
        Guid _idWhenclick;
        public QLCuaHang()
        {
            InitializeComponent();
            _iCuaHangService = new CuaHangService();
            LoadThanhPhos();
            LoadDgridCH(null);
        }
        private void LoadThanhPhos()
        {
            foreach (var x in _iCuaHangService.GetThanhPhos())
            {
                cmb_ThanhPho.Items.Add(x);
            }
        }
        private void LoadDgridCH(string input)
        {
            int stt = 1;
            dgrid_CuaHang.ColumnCount = 7;
            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "Id";
            dgrid_CuaHang.Columns[2].Name = "Mã";
            dgrid_CuaHang.Columns[3].Name = "Tên";
            dgrid_CuaHang.Columns[4].Name = "Địa Chỉ";
            dgrid_CuaHang.Columns[5].Name = "Thành Phố";
            dgrid_CuaHang.Columns[6].Name = "Quốc Gia";
            dgrid_CuaHang.Rows.Clear();

            foreach (var x in _iCuaHangService.GetAll(input))
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
            if (rowIndex == _iCuaHangService.GetAll(null).Count) return;
            _idWhenclick = Guid.Parse(dgrid_CuaHang.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iCuaHangService.GetAll().FirstOrDefault(x => x.Id == _idWhenclick);
            tbt_Ma.Text = obj.Ma;
            tbt_Ten.Text = obj.Ten;
            tbt_DiaChi.Text = obj.DiaChi;
            cmb_ThanhPho.SelectedItem = obj.ThanhPho;
            tbt_QuocGia.Text = obj.QuocGia;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iCuaHangService.Add(GetDataFromGui()));
            LoadDgridCH(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iCuaHangService.Update(temp));
            LoadDgridCH(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iCuaHangService.Delete(temp));
            LoadDgridCH(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = "";
            tbt_Ten.Text = "";
            tbt_DiaChi.Text = "";
            cmb_ThanhPho.SelectedItem = 0;
            tbt_QuocGia.Text = "";
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
