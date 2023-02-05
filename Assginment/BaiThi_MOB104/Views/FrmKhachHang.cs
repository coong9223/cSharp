using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiThi_MOB104.Views
{
    public partial class FrmKhachHang : Form
    {
        private KhachHangServices _chKhachHangServices;
        public FrmKhachHang()
        {
            InitializeComponent();
            _chKhachHangServices = new KhachHangServices();
            LoadDate();
        }
        public void LoadDate()
        {
            Dgrid_KhachHang.ColumnCount = 6;
            Dgrid_KhachHang.Columns[0].Name = "Mã khách hàng";
            Dgrid_KhachHang.Columns[1].Name = "Tên Khách Hàng";
            Dgrid_KhachHang.Columns[2].Name = "Ngày Sinh";
            Dgrid_KhachHang.Columns[3].Name = "Giới Tính";
            Dgrid_KhachHang.Columns[4].Name = "Địa Chỉ";
            Dgrid_KhachHang.Columns[5].Name = "SĐT";
            Dgrid_KhachHang.Rows.Clear();


            foreach (var x in _chKhachHangServices.GetKhachHangs())
            {
                Dgrid_KhachHang.Rows.Add(x.Ma, x.Ten, x.NgaySinh, (x.GioiTinh == "Nam" ? "Nam" : "Nữ"), x.DiaChi, x.Sdt);
            }
        }
        private KhachHang GetFormGruid()
        {
            return new KhachHang
            {
                Ma = txt_Makh.Text,
                Ten = txt_Tenkh.Text,
                NgaySinh = date_KhachHang.Value,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                DiaChi = txt_Diachi.Text,
                Sdt = txt_SDT.Text,
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chKhachHangServices.AddKhachHangServices(GetFormGruid()));
            LoadDate();
        }

        private void pb_Quayve_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void Dgrid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row == _chKhachHangServices.GetKhachHangs().Count)
            {
                return;
            };
            var Makh = Dgrid_KhachHang.Rows[Row].Cells[0].Value.ToString();
            var obj = _chKhachHangServices.GetKhachHangs().FirstOrDefault(c => c.Ma.Equals(Makh));
            txt_Makh.Text = obj.Ma;
            txt_Tenkh.Text = obj.Ten;
            date_KhachHang.Value = (DateTime)obj.NgaySinh;

            rbtn_Nu.Checked = true;
            if (obj.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
                return;
            }
            txt_Diachi.Text = obj.DiaChi;
            txt_SDT.Text = obj.Sdt;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chKhachHangServices.UpdateKhachHangServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chKhachHangServices.DeleteKhachHangServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.Show();
            this.Hide();
        }

        private void btn_Khachhang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.Show();
            this.Hide();
        }

        private void btn_Sanpham_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            f.Show();
            this.Hide();
        }

        private void btn_Danhmuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc f = new FrmDanhMuc();
            f.Show();
            this.Hide();
        }

        private void btn_Giohang_Click(object sender, EventArgs e)
        {
            FrmGioHang f = new FrmGioHang();
            f.Show();
            this.Hide();
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            f.Show();
            this.Hide();
        }
    }
}
