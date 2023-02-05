using BaiThi_MOB104.Context;
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
    public partial class FrmDangNhap : Form
    {
        private TaiKhoanServices _chTaiKhoanServices;
        public FrmDangNhap()
        {
            InitializeComponent();
            _chTaiKhoanServices = new TaiKhoanServices();
        }

    

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            //if (_chTaiKhoanServices.GetTaiKhoans().Where(c => c.TenTk == txt_Tentaikhoan && c.Pass == txt_Matkhau).Count() > 0)
            //{

            MessageBox.Show("Đăng nhập thành công");
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Nhập mk  sai ");

            //}


        }

        private void llb_DangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy f = new FrmDangKy();
            f.Show();
            this.Hide();
        }
    }
}
