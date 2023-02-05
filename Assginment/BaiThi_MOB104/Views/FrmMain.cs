using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiThi_MOB104.Views
{
    public partial class FrmMain : Form
    {
        bool isThoat = true;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_QLNhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien f = new FrmNhanVien();
            f.Show();
            this.Hide();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Hide();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void btn_QLKhachhang_Click(object sender, EventArgs e)
        {
            FrmKhachHang f = new FrmKhachHang();
            f.Show();
            this.Hide();
        }

        private void btn_QLDanhmuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc f = new FrmDanhMuc();
            f.Show();
            this.Hide();
        }

        private void btn_QLSanpham_Click(object sender, EventArgs e)
        {
            FrmSanPham f = new FrmSanPham();
            f.Show();
            this.Hide();
        }

        private void btn_QLHoadon_Click(object sender, EventArgs e)
        {
            FrmHoaDon f = new FrmHoaDon();
            f.Show();
            this.Hide();
        }

        private void btn_QLGiohang_Click(object sender, EventArgs e)
        {
            FrmGioHang f = new FrmGioHang();
            f.Show();
            this.Hide();
        }
    }
}
