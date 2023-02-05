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
    public partial class FrmDanhMuc : Form
    {
        private DanhMucServices _chDanhMucServices;
        public FrmDanhMuc()
        {
            InitializeComponent();
            _chDanhMucServices = new DanhMucServices();
            //LoadDate();
        }
        public void LoadDate()
        {
            Dgrid_DanhMuc.ColumnCount = 2;
            Dgrid_DanhMuc.Columns[0].Name = "Mã Danh Mục";
            Dgrid_DanhMuc.Columns[1].Name = "Tên Danh Mục";
            Dgrid_DanhMuc.Rows.Clear();

            foreach (var x in _chDanhMucServices.GetDongSps())
            {
                Dgrid_DanhMuc.Rows.Add(x.Ma, x.Ten);
            }


        }
        private DongSp GetFormGruid()
        {
            return new DongSp
            {
                Ma = txt_MaDM.Text,
                Ten = txt_TenDM.Text,

            };
        }

        private void pb_Quayve_Click(object sender, EventArgs e)
        {
            FrmMain f = new FrmMain();
            f.Show();
            this.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chDanhMucServices.AddDanhMucServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chDanhMucServices.UpdateDanhMucServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chDanhMucServices.DeleteDanhMucServices(GetFormGruid()));
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

        private void Dgrid_DanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row == _chDanhMucServices.GetDongSps().Count)
            {
                return;
            };
            var Manv = Dgrid_DanhMuc.Rows[Row].Cells[0].Value.ToString();
            var obj = _chDanhMucServices.GetDongSps().FirstOrDefault(c => c.Ma.Equals(Manv));
            txt_MaDM.Text = obj.Ma;
            txt_TenDM.Text = obj.Ten;


        }
    }
}
