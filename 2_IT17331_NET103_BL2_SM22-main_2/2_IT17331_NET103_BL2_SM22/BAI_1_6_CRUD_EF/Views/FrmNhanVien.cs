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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BAI_1_6_CRUD_EF.Views
{
    public partial class FrmNhanVien : Form
    {


        private NhanVienService _nvService;
        private Guid _idWhenClick;


        public FrmNhanVien()
        {
            InitializeComponent();
            _nvService = new NhanVienService();
            txt_Ma.Enabled = false;
            rbtn_Nam.Checked = true;
            LoadGridNV(null);
            LoadCV();
            LoadCH();
            LoadTT();
            LoadBC();
            cmb_TT.SelectedIndex = 0;
            cmb_ChucVu.SelectedIndex = -1;
            cmb_CH.SelectedIndex = -1;
            txt_Pass.PasswordChar = '*';

        }


        private void LoadGridNV(string input)
        {
            int stt = 1;
            Type type = typeof(NhanVien);
            int slThuocTinh = type.GetProperties().Length;
            dgrid_NhanVien.ColumnCount = slThuocTinh;
            dgrid_NhanVien.Columns[0].Name = "STT";
            dgrid_NhanVien.Columns[1].Name = "ID";
            dgrid_NhanVien.Columns[2].Name = "Mã";
            dgrid_NhanVien.Columns[3].Name = "Tên đầy đủ";
            dgrid_NhanVien.Columns[4].Name = "Giới tính";
            dgrid_NhanVien.Columns[5].Name = "Ngày sinh";
            dgrid_NhanVien.Columns[6].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[7].Name = "SĐT";
            dgrid_NhanVien.Columns[8].Name = "Mật khẩu";
            dgrid_NhanVien.Columns[9].Name = "Tên của hàng";
            dgrid_NhanVien.Columns[10].Name = "Tên chức vụ";
            dgrid_NhanVien.Columns[11].Name = "Tên người gửi báo cáo";
            dgrid_NhanVien.Columns[12].Name = "Trạng thái";
            dgrid_NhanVien.Rows.Clear();


            foreach (var x in _nvService.GetAllNhanViens(input))
            {
                var tencv = "";
                if (!string.IsNullOrEmpty(x.IdCv.ToString()))
                {
                    tencv = _nvService.GetChucVu().FirstOrDefault(c => c.Id == x.IdCv).Ten;
                }
                var tench = "";
                if (!string.IsNullOrEmpty(x.IdCh.ToString()))
                {
                    tench = _nvService.GetCuaHang().FirstOrDefault(c => c.Id == x.IdCh).Ten;
                }
                var stttruongphong = -1;
                var tentruongphong = "";
                if (!string.IsNullOrEmpty(x.IdGuiBc.ToString()))
                {
                    stttruongphong = _nvService.GetNhanVienTheoCV("TP").FindIndex(c => c.Id == x.IdGuiBc);
                    tentruongphong = _nvService.GetNhanVienTheoCV("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).Ho + _nvService.GetNhanVienTheoCV("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).TenDem + _nvService.GetNhanVienTheoCV("TP").FirstOrDefault(c => c.Id == x.IdGuiBc).Ten;
                }

                dgrid_NhanVien.Rows.Add(stt++, x.Id, x.Ma, x.Ho + x.TenDem + x.Ten, x.GioiTinh == "Nam" ? "Nam" : "Nữ", x.NgaySinh, x.DiaChi, x.Sdt, x.MatKhau, tench, tencv, tentruongphong, x.TrangThai);

            }
        }



        private void LoadCV()
        {
            foreach (var item in _nvService.GetChucVu())
            {
                cmb_ChucVu.Items.Add(item.Ma + " - " + item.Ten);
                cmb_LocCV.Items.Add(item.Ma);
            }
        }

        private void LoadCH()
        {
            foreach (var item in _nvService.GetCuaHang())
            {
                cmb_CH.Items.Add(item.Ma + " - " + item.Ten);
                cmb_LocCH.Items.Add(item.Ma);
            }
        }

        private void LoadTT()
        {
            foreach (var item in _nvService.TrangThai())
            {
                cmb_TT.Items.Add(item);
            }
        }



        private void LoadBC()
        {
            foreach (var item in _nvService.GetNhanVienTheoCV("TP"))
            {
                cmb_BC.Items.Add(item.Ten);
            }

        }

        private NhanVien GetDataFromGuid()
        {
            return new NhanVien()
            {

                Id = Guid.NewGuid(),
                Ma = txt_Ma.Text,
                Ho = txt_Ho.Text,
                TenDem = txt_TenDem.Text,
                Ten = txt_Ten.Text,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtp_NgaySinh.Value,
                DiaChi = txt_DiaChi.Text,
                Sdt = txt_Sdt.Text,
                MatKhau = txt_Pass.Text,
                IdCh = /*null*/
                _nvService.GetCuaHang()[cmb_CH.SelectedIndex].Id
                ,
                IdCv = /*null*/
                _nvService.GetChucVu()[cmb_ChucVu.SelectedIndex].Id
                ,
                IdGuiBc = /*null*/
                _nvService.GetNhanVienTheoCV("TP")[cmb_BC.SelectedIndex].Id

                ,
                TrangThai = cmb_TT.Text == "Hoạt động" ? 1 : 0,
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var r = new Regex(@"0(1\d{9}|9\d{8})");
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            {
                MessageBox.Show("Không được để tróng địa chỉ");
            }
            else {
                if (!r.IsMatch(txt_Sdt.Text) || string.IsNullOrEmpty(txt_Sdt.Text))
                {

                    MessageBox.Show("Không đúng định dạng hoặc không được để trống");

                }
                else
                {
                    if (txt_Pass.Text.Length <= 3)
                    {
                        MessageBox.Show("Mật khẩu phải từ 3 ký tự trở lên");
                    }
                    else
                    {
                        MessageBox.Show(_nvService.Add(GetDataFromGuid()));
                    }
                }
            }
            LoadGridNV(null);

        }






        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_nvService.Update(temp));
            LoadGridNV(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_nvService.Delete(temp));
            LoadGridNV(null);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text)) return;
            LoadGridNV(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "Tìm kiếm";
            LoadGridNV(null);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _nvService.GetAllNhanViens(null).Count) return;
            // 2. lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dgrid_NhanVien.Rows[rowIndex].Cells[1].Value.ToString());
            // 3. tìm đối tượng theo id
            var obj = _nvService.GetAllNhanViens().FirstOrDefault(c => c.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ho.Text = obj.Ho;
            txt_TenDem.Text = obj.TenDem;
            txt_Ten.Text = obj.Ten;
            if (obj.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
                rbtn_Nu.Checked = true;
            dtp_NgaySinh.Value = obj.NgaySinh.Value;
            txt_DiaChi.Text = obj.DiaChi;
            txt_Sdt.Text = obj.Sdt;
            txt_Pass.Text = obj.MatKhau;

            if (obj.TrangThai == 0)
            {
                cmb_TT.SelectedIndex = 0;
            }
            else cmb_TT.SelectedIndex = 1;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ho.Text = "";
            txt_TenDem.Text = "";
            txt_Ten.Text = "";
            rbtn_Nam.Checked = true;
            dtp_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = "";
            txt_Sdt.Text = "";
            txt_Pass.Text = "";
            cmb_ChucVu.SelectedIndex = -1;
            //cmb_BC.SelectedIndex = 0;
            cmb_TT.SelectedIndex = 0;
        }

        private void txt_Ho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ho.Text)) return;
            txt_Ho.Text = Utility.GetVietHoaChuCaiDau(txt_Ho.Text);
        }

        private void txt_TenDem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDem.Text)) return;
            txt_TenDem.Text = Utility.GetVietHoaChuCaiDau(txt_TenDem.Text);
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ten.Text = Utility.GetVietHoaChuCaiDau(txt_Ten.Text);
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            var a = txt_Ho.Text + txt_TenDem.Text + txt_Ten.Text;
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ma.Text = _nvService.CheckMa(Utility.ZenMaTuDong(a));
        }

        private void cmb_LocCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LocCV.SelectedIndex == -1)
            {
                LoadGridNV(null);
            }
            LoadGridNV(Convert.ToString(_nvService.GetChucVu().FirstOrDefault(c => c.Ma == cmb_LocCV.Text).Id));
        }

        private void cmb_LocCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LocCH.SelectedIndex == -1)
            {
                LoadGridNV(null);
            }
            LoadGridNV(Convert.ToString(_nvService.GetCuaHang().FirstOrDefault(c => c.Ma == cmb_LocCH.Text).Id));
        }
    }
}
