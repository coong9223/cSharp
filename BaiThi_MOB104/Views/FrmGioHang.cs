using BaiThi_MOB104.DomainModels;
using BaiThi_MOB104.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiThi_MOB104.Views
{
    public partial class FrmGioHang : Form
    {
        private GioHangServices _chGioHangServices;
        public FrmGioHang()
        {
            InitializeComponent();
            _chGioHangServices = new GioHangServices();
            LoaDate();
        }
        public void LoaDate()
        {
            Dgrid_GioHang.ColumnCount = 7;
            Dgrid_GioHang.Columns[0].Name = "Mã sản Phẩm";
            Dgrid_GioHang.Columns[1].Name = "Tên sản phẩm";
            Dgrid_GioHang.Columns[2].Name = "Số Lượng";
            Dgrid_GioHang.Columns[3].Name = "Địa Chỉ";
            Dgrid_GioHang.Columns[4].Name = "SĐT";
            Dgrid_GioHang.Columns[5].Name = "Ghi chú";
            Dgrid_GioHang.Columns[6].Name = "Tổng tiền";
            Dgrid_GioHang.Rows.Clear();
            foreach (var x in _chGioHangServices.GetGioHangs())
            {
                Dgrid_GioHang.Rows.Add(x.Masp,x.Tensp,x.GiaBan,x.SoLuongTon,x.DanhMuc,(x.TrangThai== "Còn Hàng" ? "Còn Hàng" : "Hết Hàng"));
            }
       
        }
        private GioHang GetFromGruid()
        {
            return new GioHang
            {
                Masp = txt_Masp.Text,
                Tensp = txt_Tensp.Text,
                //GiaBan = Convert.ToDecimal(txt_Giaban.Text),
                //SoLuongTon =Convert.ToInt32(txt_Soluong.Text),
               
                
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

        private void btn_Mua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
