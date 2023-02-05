using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
using System.Windows.Forms.VisualStyles;

namespace _3.PL.Views
{
    public partial class NhanVienView : Form
    {
        private IQLNhanVienService _iQLNhanVienService;
        private IChucVuService _iChucVuService;
        private ICuaHangService _iCuaHangService;
        Guid _idWhenclick;
        public NhanVienView()
        {
            InitializeComponent();
            _iQLNhanVienService = new QLNhanVienService();
            _iChucVuService = new ChucVuService();
            _iCuaHangService = new CuaHangService();
            LoadCmb();
            LoadDgridNhanVien(null);
        }
        private void LoadCmb()
        {
            foreach (var item in _iChucVuService.GetAll())
            {
                cmb_ChucVu.Items.Add(item.Ma + " " + item.Ten);
                cmb_LocChucVu.Items.Add(item.Ma);
            }

            foreach (var item in _iCuaHangService.GetAll())
            {
                cmb_CuaHang.Items.Add(item.Ma + " " + item.Ten);
                cmb_LocMaCuaHang.Items.Add(item.Ma);
            }

            foreach (var item in _iQLNhanVienService.TrangThai())
            {
                cmb_TrangThai.Items.Add(item);
            }

            //foreach (var item in _nvService.GetAllNhanVienTheoChucVu("TP"))
            //{
            //    cmb_BaoCao.Items.Add(item.Ma + " " + item.Ten);
            //}
        }
        private void LoadDgridNhanVien(string input)
        {
            int stt = 1;
            dgrid_NhanVien.ColumnCount = 13;
            dgrid_NhanVien.Columns[0].Name = "STT";
            dgrid_NhanVien.Columns[1].Name = "Id";
            dgrid_NhanVien.Columns[2].Name = "Mã";
            dgrid_NhanVien.Columns[3].Name = "Tên Đầy Đủ";
            dgrid_NhanVien.Columns[4].Name = "Giới Tính";
            dgrid_NhanVien.Columns[5].Name = "Ngày Sinh";
            dgrid_NhanVien.Columns[6].Name = "Địa Chỉ";
            dgrid_NhanVien.Columns[7].Name = "SĐT";
            dgrid_NhanVien.Columns[8].Name = "Mật Khẩu";
            dgrid_NhanVien.Columns[9].Name = "Tên Cửa Hàng";
            dgrid_NhanVien.Columns[10].Name = "Tên Chức Vụ";
            dgrid_NhanVien.Columns[11].Name = "Tên Người Gửi Báo Cáo";
            dgrid_NhanVien.Columns[12].Name = "Trạng Thái";
            dgrid_NhanVien.Rows.Clear();

            foreach (var x in _iQLNhanVienService.GetAll())
            {
                dgrid_NhanVien.Rows.Add(stt++, x.NhanVien.Id, x.NhanVien.Ma, x.NhanVien.Ho + x.NhanVien.TenDem + x.NhanVien.Ten, x.NhanVien.GioiTinh == "Nam" ? "Nam" : "Nữ", x.NhanVien.NgaySinh, x.NhanVien.DiaChi, x.NhanVien.Sdt, x.NhanVien.MatKhau, x.CuaHang.Ten, x.ChucVu.Ten, x.NhanVien.IdGuiBc, x.NhanVien.TrangThai == 0 ? "Không hoạt động" : "Hoạt động");
            }
        }
        private QLNhanVienView GetDataFromGui()
        {
            QLNhanVienView nvv = new QLNhanVienView();
            nvv.ChucVu = _iChucVuService.GetById(_iChucVuService.GetIdByName(cmb_ChucVu.Text));
            nvv.CuaHang = _iCuaHangService.GetById(_iCuaHangService.GetIdByName(cmb_CuaHang.Text));
            //nvv.NhanVien.IdGuiBc = ;
            nvv.NhanVien = new NhanVien()
            {
                Id = Guid.Empty,
                Ma = tbt_Ma.Text + Utility.GetNumber(4),
                Ho = tbt_Ho.Text,
                TenDem=tbt_TenDem.Text,
                Ten=tbt_Ten.Text,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtPicker_NgaySinh.Value,
                DiaChi = tbt_DiaChi.Text,
                Sdt = tbt_SDT.Text,
                MatKhau = tbt_MatKhau.Text,
                IdCv = nvv.ChucVu.Id,
                IdCh = nvv.CuaHang.Id,
                IdGuiBc = null,
                TrangThai = cmb_TrangThai.Text == "Hoạt Động" ? 1 : 0,
            };
            return nvv;
        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iQLNhanVienService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_NhanVien.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iQLNhanVienService.GetAll().FirstOrDefault(x => x.NhanVien.Id == _idWhenclick);
            tbt_Ma.Text = obj.NhanVien.Ma;
            tbt_Ho.Text = obj.NhanVien.Ho;
            tbt_TenDem.Text = obj.NhanVien.TenDem;
            tbt_Ten.Text = obj.NhanVien.Ten;
            if (obj.NhanVien.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else rbtn_Nu.Checked = true;
            tbt_DiaChi.Text = obj.NhanVien.DiaChi;
            tbt_SDT.Text = obj.NhanVien.Sdt;
            dtPicker_NgaySinh.Value = obj.NhanVien.NgaySinh.Value;
            cmb_ChucVu.SelectedIndex = _iChucVuService.GetAll().FindIndex(c => c.Id == obj.NhanVien.IdCv);
            cmb_CuaHang.SelectedIndex = _iCuaHangService.GetAll().FindIndex(c => c.Id == obj.NhanVien.IdCh);
            //cmb_BaoCao.SelectedIndex = ;
            tbt_MatKhau.Text = obj.NhanVien.MatKhau;
            if (obj.NhanVien.TrangThai == 0)
            {
                cmb_TrangThai.SelectedIndex = 0;
            }
            else cmb_TrangThai.SelectedIndex = 1;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQLNhanVienService.Add(GetDataFromGui()));
            LoadDgridNhanVien(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.NhanVien.Id = _idWhenclick;
            MessageBox.Show(_iQLNhanVienService.Update(temp));
            LoadDgridNhanVien(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.NhanVien.Id = _idWhenclick;
            MessageBox.Show(_iQLNhanVienService.Delete(temp));
            LoadDgridNhanVien(null);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Text = "";
            tbt_Ho.Text = "";
            tbt_TenDem.Text = "";
            tbt_Ten.Text = "";
            rbtn_Nam.Checked = true;
            tbt_DiaChi.Text = "";
            tbt_SDT.Text = "";
            tbt_MatKhau.Text = "";
            dtPicker_NgaySinh.Value = DateTime.Now;
            cmb_ChucVu.SelectedIndex = -1;
            cmb_BaoCao.SelectedIndex = -1;
            cmb_CuaHang.SelectedIndex = -1;
            cmb_TrangThai.SelectedIndex = 0;
            cmb_LocChucVu.Text = "Lọc chức vụ";
            cmb_LocMaCuaHang.Text = "Lọc mã cửa hàng";
            LoadDgridNhanVien(null);
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
