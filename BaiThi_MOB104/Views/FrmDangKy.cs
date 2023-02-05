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
    public partial class FrmDangKy : Form
    {
        private TaiKhoanServices _chTaiKhoanServices;
        public FrmDangKy()
        {
            InitializeComponent();
            _chTaiKhoanServices = new TaiKhoanServices();   
        }
        private TaiKhoan GetFormGruid()
        {
            return new TaiKhoan
            {
                TenTk = txt_Tentaikhoan.Text,
                Pass = txt_Matkhau.Text,
                Sdt = txt_SDT.Text,
            };
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chTaiKhoanServices.AddTaiKhoanServices(GetFormGruid()));
        }

        private void llb_DangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
