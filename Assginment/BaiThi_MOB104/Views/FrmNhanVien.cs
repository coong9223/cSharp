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
    public partial class FrmNhanVien : Form
    {
        private NhanVienServices _ChNhanVienServices;
        public FrmNhanVien()
        {
            InitializeComponent();
            _ChNhanVienServices = new NhanVienServices();
            rbtn_Nam.Checked = true;
            LoadDate();
        }


        public void LoadDate()
        {
            Dgrid_Nhanvien.ColumnCount = 6;
            Dgrid_Nhanvien.Columns[0].Name = "Mã Nhân Viên";
            Dgrid_Nhanvien.Columns[1].Name = "Tên Nhân Viên";
            Dgrid_Nhanvien.Columns[2].Name = "Ngày Sinh";
            Dgrid_Nhanvien.Columns[3].Name = "Giới Tính";
            Dgrid_Nhanvien.Columns[4].Name = "Địa Chỉ";
            Dgrid_Nhanvien.Columns[5].Name = "SĐT";
            Dgrid_Nhanvien.Rows.Clear();

            foreach (var x in _ChNhanVienServices.GetNhanViens())
            {
                Dgrid_Nhanvien.Rows.Add(x.Ma, x.Ten, x.NgaySinh, (x.GioiTinh == "Nam" ? "Nam" : "Nữ"), x.DiaChi, x.Sdt);
            }

        }
        private NhanVien GetFormGruid()
        {
            return new NhanVien
            {
                Ma = txt_Manv.Text,
                Ten = txt_TenNv.Text,
                NgaySinh = date_Nhanvien.Value,
                GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
                DiaChi = txt_Diachi.Text,
                Sdt = txt_SDT.Text,
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ChNhanVienServices.AddNhanVienServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ChNhanVienServices.UpdateNhanVienServices(GetFormGruid()));
            LoadDate();
        }

        private void Dgrid_Nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row == _ChNhanVienServices.GetNhanViens().Count)
            {
                return;
            };
            var Manv = Dgrid_Nhanvien.Rows[Row].Cells[0].Value.ToString();
            var obj = _ChNhanVienServices.GetNhanViens().FirstOrDefault(c => c.Ma.Equals(Manv));
            txt_Manv.Text = obj.Ma;
            txt_TenNv.Text = obj.Ten;
            date_Nhanvien.Value = (DateTime)obj.NgaySinh;

            rbtn_Nu.Checked = true;
            if (obj.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
                return;
            }
            txt_Diachi.Text = obj.DiaChi;
            txt_SDT.Text = obj.Sdt;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ChNhanVienServices.DeleteNhanVienServices(GetFormGruid()));
            LoadDate();
        }

        private void pb_Quayve_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
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
