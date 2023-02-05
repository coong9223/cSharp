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
    public partial class FrmQLNhanVien : Form
    {
        QLNhanVienService _nvService;
        Guid _idWhenClick;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            _nvService = new QLNhanVienService();
            tbt_Ma.Enabled = false;
            LoadDgridNhanVien(null);
            LoadChucVu();
            LoadCuaHang();
            LoadCbxBaoCao();
            LoadTrangThai();
            rbtn_Nam.Checked = true;
            cmb_ChucVu.SelectedIndex = -1;
            cmb_CuaHang.SelectedIndex = -1;
            cmb_TrangThai.SelectedIndex = 0;
            cmb_BaoCao.SelectedIndex = -1;
            tbt_MatKhau.PasswordChar = '*';
        }
        private void LoadDgridNhanVien(string input)
        {
            int stt = 1;
            Type type = typeof(NhanVien);
            int slThuocTinh = type.GetProperties().Length;
            dgrid_NhanVien.ColumnCount = slThuocTinh - 6;
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

            foreach (var x in _nvService.GetAllNhanVien(input))
            {
                var tencv = "";
                if (!string.IsNullOrEmpty(x.IdCv.ToString()))
                {
                    tencv = _nvService.GetChucVus().FirstOrDefault(c => c.Id == x.IdCv).Ten;
                }
                var tench = "";
                if (!string.IsNullOrEmpty(x.IdCh.ToString()))
                {
                    tench = _nvService.GetCuaHangs().FirstOrDefault(c => c.Id == x.IdCh).Ten;
                }
                var stttruongphong = -1;
                var tentruongphong = "";
                if (!string.IsNullOrEmpty(x.IdGuiBc.ToString()))
                {
                    stttruongphong = _nvService.GetAllNhanVienTheoChucVu("TP").FindIndex(c => c.Id == x.IdGuiBc);
                    tentruongphong = _nvService.GetAllNhanVienTheoChucVu("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).Ho + _nvService.GetAllNhanVienTheoChucVu("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).TenDem + _nvService.GetAllNhanVienTheoChucVu("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).Ten;
                }
                dgrid_NhanVien.Rows.Add(stt++, x.Id, x.Ma, x.Ho + x.TenDem + x.Ten, x.GioiTinh == "Nam" ? "Nam" : "Nữ", x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, tench, tencv, tentruongphong, x.TrangThai == 0 ? "Không hoạt động" : "Hoạt động");
            }
        }
        private void LoadChucVu()
        {
            foreach (var item in _nvService.GetChucVus())
            {
                cmb_ChucVu.Items.Add(item.Ma + " " + item.Ten);
                cmb_LocChucVu.Items.Add(item.Ma);
            }
        }
        private void LoadCuaHang()
        {
            foreach (var item in _nvService.GetCuaHangs())
            {
                cmb_CuaHang.Items.Add(item.Ma + " " + item.Ten);
                cmb_LocMaCuaHang.Items.Add(item.Ma);
            }
        }
        private void LoadCbxBaoCao()
        {
            foreach (var item in _nvService.GetAllNhanVienTheoChucVu("TP"))
            {
                cmb_BaoCao.Items.Add(item.Ma + " " + item.Ten);
            }
        }
        private void LoadTrangThai()
        {
            foreach (var item in _nvService.TrangThai())
            {
                cmb_TrangThai.Items.Add(item);
            }
        }
        private NhanVien GetDataFromGui()
        {
            //var Id = Guid.Empty;
            //var Ma = tbt_Ma.Text;
            //var Ho = tbt_Ho.Text;
            //var TenDem = tbt_TenDem.Text;
            //var Ten = tbt_Ten.Text;
            //var GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ";
            //var NgaySinh = dtPicker_NgaySinh.Value;
            //var DiaChi = tbt_DiaChi.Text;
            //var Sdt = tbt_SDT.Text;
            //var MatKhau = tbt_MatKhau.Text;
            //var IdCv = _nvService.GetChucVus()[cmb_ChucVu.SelectedIndex].Id;
            //var IdCh = _nvService.GetCuaHangs()[cmb_CuaHang.SelectedIndex].Id;
            //var IdGuiBc = _nvService.GetAllNhanVienTheoChucVu("TP")[cmb_BaoCao.SelectedIndex].Id;
            //var TrangThai = cmb_TrangThai.Text == "Hoạt Động" ? 1 : 0;
            //return null;
            return new NhanVien()
            {
                Id = Guid.Empty,
                Ma = tbt_Ma.Text,
                Ho = tbt_Ho.Text,
                TenDem = tbt_TenDem.Text,
                Ten = tbt_Ten.Text,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtPicker_NgaySinh.Value,
                DiaChi = tbt_DiaChi.Text,
                Sdt = tbt_SDT.Text,
                MatKhau = tbt_MatKhau.Text,
                IdCv = _nvService.GetChucVus()[cmb_ChucVu.SelectedIndex].Id,
                IdCh = _nvService.GetCuaHangs()[cmb_CuaHang.SelectedIndex].Id,
                IdGuiBc = _nvService.GetAllNhanVienTheoChucVu("TP")[cmb_BaoCao.SelectedIndex].Id,
                TrangThai = cmb_TrangThai.Text == "Hoạt Động" ? 1 : 0,
            };
        }
        private bool validNhanvien(NhanVien nv)
        {
            if(string.IsNullOrEmpty(tbt_Ho.Text) || string.IsNullOrEmpty(tbt_Ten.Text))
            {
                MessageBox.Show("Không được để họ hoặc tên rỗng");
                return false;
            }
            if (cmb_ChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("mời bạn chọn chức vụ");
                return false;
            }
            if (cmb_BaoCao.SelectedIndex == -1)
            {
                MessageBox.Show("mời bạn chọn người gửi báo cáo");
                return false;
            }
            if (cmb_CuaHang.SelectedIndex == -1)
            {
                MessageBox.Show("mời bạn chọn cửa hàng");
                return false;
            }
            int x;
            if (nv.MatKhau.Length == 0)
            {
                MessageBox.Show("mật khẩu không được để trống");
                return false;
            }
            else if (nv.MatKhau.Length < 3)
            {
                MessageBox.Show("mật khẩu phải từ 3 kí tự trở lên");
                return false;
            }
            if (nv.DiaChi == "")
            {
                MessageBox.Show("địa chỉ không được để trống");
                return false; 
            }
            if (nv.Sdt.Length == 0)
            {
                MessageBox.Show("số điện thoại không được để trống");
                return false; 
            }
            if (!int.TryParse(nv.Sdt, out x)) 
            {
                MessageBox.Show("nhập đúng định dạng số điện thoại");
                return false; 
            }
            if (x < 0)
            {
                MessageBox.Show("kiểm tra dấu trừ ở số điện thoại");
                return false;
            }
            if (nv.Sdt.Length > 10)
            {
                MessageBox.Show("số điện thoại chỉ được 10 chữ số");
                return false;
            }
            if (!nv.Sdt.StartsWith('0')) 
            {
                MessageBox.Show("số điện thoại phải bắt đầu là 0");
                return false; 
            }
            return true;
        }
        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _nvService.GetAllNhanVien(null).Count) return;
            _idWhenClick = Guid.Parse(dgrid_NhanVien.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _nvService.GetAllNhanVien().FirstOrDefault(x => x.Id == _idWhenClick);
            tbt_Ma.Text = obj.Ma;
            tbt_Ho.Text = obj.Ho;
            tbt_TenDem.Text = obj.TenDem;
            tbt_Ten.Text = obj.Ten;
            if (obj.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else rbtn_Nu.Checked = true;
            tbt_DiaChi.Text = obj.DiaChi;
            tbt_SDT.Text = obj.Sdt;
            dtPicker_NgaySinh.Value = obj.NgaySinh.Value;
            cmb_ChucVu.SelectedIndex = _nvService.GetChucVus().FindIndex(c => c.Id == obj.IdCv);
            int a = _nvService.GetAllNhanVienTheoChucVu("TP").FindIndex(c => c.Id == obj.IdGuiBc);
            cmb_BaoCao.SelectedIndex = a == -1 ? 0 : a;
            tbt_MatKhau.Text = obj.MatKhau;
            cmb_CuaHang.SelectedIndex = _nvService.GetCuaHangs().FindIndex(c => c.Id == obj.IdCh);
            if (obj.TrangThai == 0)
            {
                cmb_TrangThai.SelectedIndex = 0;
            }
            else cmb_TrangThai.SelectedIndex = 1;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            //var temp = GetDataFromGui();
            //temp.Ma = _nvService.checkMaTrung(temp.Ma);
            //MessageBox.Show(_nvService.Add(temp));
            if (validNhanvien(GetDataFromGui()))
            {
                if(MessageBox.Show("bạn có chắc muốn thực hiện hành động?", "Thêm nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(_nvService.Add(GetDataFromGui()));
                    LoadDgridNhanVien(null);
                }
            }
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (validNhanvien(GetDataFromGui()))
            {
                if (MessageBox.Show("bạn có chắc muốn thực hiện hành động?", "Sửa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var temp = GetDataFromGui();
                    temp.Id = _idWhenClick;
                    MessageBox.Show(_nvService.Update(temp));
                    LoadDgridNhanVien(null);
                }
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (validNhanvien(GetDataFromGui()))
            {
                if (MessageBox.Show("bạn có chắc muốn thực hiện hành động?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var temp = GetDataFromGui();
                    temp.Id = _idWhenClick;
                    MessageBox.Show(_nvService.Delete(temp));
                    LoadDgridNhanVien(null);
                }
            }
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
        private void tbt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_TimKiem.Text)) return;
            LoadDgridNhanVien(tbt_TimKiem.Text);
        }
        private void tbt_TimKiem_Leave(object sender, EventArgs e)
        {
            tbt_TimKiem.Text = "Tìm kiếm ...";
        }
        private void tbt_TimKiem_Click(object sender, EventArgs e)
        {
            tbt_TimKiem.Clear();
        }
        private void tbt_TenDem_TextChanged(object sender, EventArgs e)
        {
            var x = tbt_Ho.Text + tbt_TenDem.Text + tbt_Ten.Text;
            if (string.IsNullOrEmpty(tbt_TenDem.Text)) return;
            //tbt_Ma.Text = _nvService.checkMaTrung(Utility.GenMaTuDong(x));
            tbt_Ma.Text = Utility.GenMaTuDong(x) + _nvService.GetAllNhanVien().Count;
        }

        private void tbt_Ho_TextChanged(object sender, EventArgs e)
        {
            var x = tbt_Ho.Text + tbt_TenDem.Text + tbt_Ten.Text;
            if (string.IsNullOrEmpty(tbt_Ho.Text)) return;
            //tbt_Ma.Text = _nvService.checkMaTrung(Utility.GenMaTuDong(x));
            tbt_Ma.Text = Utility.GenMaTuDong(x) + _nvService.GetAllNhanVien().Count;
        }
        private void tbt_Ten_TextChanged(object sender, EventArgs e)
        {
            var x = tbt_Ho.Text + tbt_TenDem.Text + tbt_Ten.Text;
            if (string.IsNullOrEmpty(tbt_Ten.Text)) return;
            //tbt_Ma.Text = _nvService.checkMaTrung(Utility.GenMaTuDong(x));
            tbt_Ma.Text = Utility.GenMaTuDong(x) + _nvService.GetAllNhanVien().Count;
        }
        private void tbt_Ho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ho.Text)) return;
            tbt_Ho.Text = Utility.VietHoaChuCaiDau(tbt_Ho.Text);
        }
        private void tbt_TenDem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ho.Text)) return;
            tbt_TenDem.Text = Utility.VietHoaFullName(tbt_TenDem.Text);
        }
        private void tbt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Ho.Text)) return;
            tbt_Ten.Text = Utility.VietHoaChuCaiDau(tbt_Ten.Text);
        }
        private void cmb_LocChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LocChucVu.SelectedIndex == -1) LoadDgridNhanVien(null);
            LoadDgridNhanVien(Convert.ToString(_nvService.GetChucVus().FirstOrDefault(c => c.Ma == cmb_LocChucVu.Text).Id));
            cmb_LocMaCuaHang.Text = "Lọc mã cửa hàng";
        }
        private void cmb_LocMaCuaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LocMaCuaHang.SelectedIndex == -1) LoadDgridNhanVien(null);
            LoadDgridNhanVien(Convert.ToString(_nvService.GetCuaHangs().FirstOrDefault(c => c.Ma == cmb_LocMaCuaHang.Text).Id));
            cmb_LocChucVu.Text = "Lọc chức vụ";
        }

        private void tbt_DiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_DiaChi.Text)) return;
            tbt_DiaChi.Text = Utility.VietHoaFullName(tbt_DiaChi.Text);
        }
    }
}
