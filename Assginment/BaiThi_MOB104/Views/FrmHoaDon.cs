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
    public partial class FrmHoaDon : Form
    {
        private HoaDonServices _chHoaDonServices;
        public FrmHoaDon()
        {
            InitializeComponent();
            _chHoaDonServices = new HoaDonServices();
            LoadDate();
            rbtn_Dathanhtoan.Checked=true;
        }
        public void LoadDate()
        {
            Dgrid_HoaDon.ColumnCount = 8;
            Dgrid_HoaDon.Columns[0].Name = "Mã Hóa Đơn";
            Dgrid_HoaDon.Columns[1].Name = "Mã Nhân Viên";
            Dgrid_HoaDon.Columns[2].Name = "tên Khách Hàng";
            Dgrid_HoaDon.Columns[3].Name = "Tên Sản Phẩm";
            Dgrid_HoaDon.Columns[4].Name = "số lượng";
            Dgrid_HoaDon.Columns[5].Name = "Trạng Thái";
            Dgrid_HoaDon.Columns[6].Name = "Ngày Tạo";
            Dgrid_HoaDon.Columns[7].Name = "Tổng tiền";


            Dgrid_HoaDon.Rows.Clear();
            foreach (var x in _chHoaDonServices.GetHoaDons())
            {
                Dgrid_HoaDon.Rows.Add(x.Ma, x.Manv, x.TenNguoiNhan, x.Tensp, x.SoLuong, (x.TrangThai == 1 ? "Đã Thanh Toán" : "Chưa Thanh Toán"), x.NgayTao, x.TongTien);
            }
        }
        private HoaDon GetFormGruid()
        {
            return new HoaDon
            {
                IdKh=null,
                IdNv=null,
                Ma = txt_Mahd.Text,
                Manv = txt_Manv.Text,
                NgayTao = date_HoaDon.Value,
                NgayThanhToan = null,
                NgayShip=null,
                NgayNhan=null,
                TinhTrang=null,
                TenNguoiNhan =txt_Tenkh.Text,
                Tensp = txt_Tensp.Text,
                //SoLuong=Convert.ToInt32(txt_Soluong.Text),
                TrangThai=rbtn_Dathanhtoan.Checked ? 1:0,
                //TongTien=Convert.ToDecimal(txt_Tongtien.Text),
                DiaChi=null,
                Sdt=null,

            };
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

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chHoaDonServices.AddHoaDonServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chHoaDonServices.UpdateHoaDonServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chHoaDonServices.DeleteHoaDonServices(GetFormGruid()));
            LoadDate();
        }

        private void Dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row == _chHoaDonServices.GetHoaDons().Count)
            {
                return;
            };
            var Ma = Dgrid_HoaDon.Rows[Row].Cells[0].Value.ToString();
            var obj = _chHoaDonServices.GetHoaDons().FirstOrDefault(c => c.Ma.Equals(Ma));

            txt_Mahd.Text = obj.Ma;
            txt_Manv.Text =  obj.Manv;
            txt_Tenkh.Text = obj.TenNguoiNhan;
            txt_Tensp.Text = obj.Tensp;
            //txt_Soluong.Text =(int)obj.SoLuong;
            date_HoaDon.Value = (DateTime)obj.NgayTao;
            //txt_Tongtien.Text =(decimal)obj.TongTien;

            rbtn_Chuathanhtoan.Checked = true;
            if (obj.TrangThai == 1)
            {
                rbtn_Dathanhtoan.Checked = true;
                return;
            }
        }
    }
}
