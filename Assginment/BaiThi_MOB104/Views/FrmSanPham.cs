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
    public partial class FrmSanPham : Form
    {
        private SanPhamServices _chSanPhamServices;
        private GioHangServices _chGioHangServices;
        public FrmSanPham()
        {
            InitializeComponent();
            _chSanPhamServices = new SanPhamServices();
            _chGioHangServices = new GioHangServices();
            LoadDate();
            rbtn_Conhang.Checked = true;
        }

        public void LoadDate()
        {
            Dgrid_SanPham.ColumnCount = 6;
            Dgrid_SanPham.Columns[0].Name = "Mã Sản Phẩm";
            Dgrid_SanPham.Columns[1].Name = "Tên Sản Phẩm";
            Dgrid_SanPham.Columns[2].Name = "Gía Bán";
            Dgrid_SanPham.Columns[3].Name = "Số Lượng";
            Dgrid_SanPham.Columns[4].Name = "Danh Mục";
            Dgrid_SanPham.Columns[5].Name = "Trạng Thái";
            Dgrid_SanPham.Rows.Clear();

            foreach (var x in _chSanPhamServices.GetSanPhams())
            {
                Dgrid_SanPham.Rows.Add(x.Ma, x.Ten, x.GiaBan, x.SoLuongTon, x.DanhMuc, (x.TrangThai == "Còn Hàng" ? "Còn Hàng" : "Hết Hàng"));
            }
        }

       private SanPham GetFormGruid()
        {
            return new SanPham
            {
              
                Ma = txt_Masp.Text,
                Ten=txt_Tensp.Text,
                //GiaBan = Convert.ToDecimal(txt_Giaban.Text),
                //SoLuongTon =Convert.ToInt32(txt_Soluong.Text),
                DanhMuc = cmb_DanhMuc.Text,
                TrangThai = rbtn_Conhang.Checked ? "Còn Hàng" : "Hết Hàng",


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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPhamServices.AddSanPhamServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPhamServices.UpdateSanPhamServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPhamServices.DeleteSanPhamServices(GetFormGruid()));
            LoadDate();
        }

        private void Dgrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (Row == _chSanPhamServices.GetSanPhams().Count)
            {
                return;
            };
            var Masp = Dgrid_SanPham.Rows[Row].Cells[0].Value.ToString();
            var obj = _chSanPhamServices.GetSanPhams().FirstOrDefault(c => c.Ma.Equals(Masp));
            txt_Masp.Text = obj.Ma;
            txt_Tensp.Text = obj.Ten;

            //txt_Giaban.Text = (ToDecimal)obj.GiaBan;
            //txt_Soluong.Text = obj.SoLuongTon;

            rbtn_Hethang.Checked = true;
            if (obj.TrangThai == "Còn Hàng")
            {
                rbtn_Conhang.Checked = true;
                return;
            }


        }

        private void btn_Muahang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mua Hàng Thành Công");
        }

        private void btn_Themvaogiohang_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(_chGioHangServices.AddGioHangServices(GetFormGruid()));
            MessageBox.Show("Thêm Giỏ Hàng Thành Công");
        }
    }
}
