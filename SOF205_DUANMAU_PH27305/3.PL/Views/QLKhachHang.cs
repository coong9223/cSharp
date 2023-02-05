using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLKhachHang : Form
    {
        private IKhachHangService _iKhachHangService;
        Guid _idWhenclick;
        public QLKhachHang()
        {
            InitializeComponent();
            _iKhachHangService = new KhachHangService();
            LoadDgridKhachHang(null);
        }
        private void LoadDgridKhachHang(string input)
        {
            int stt = 1;
            dgrid_khachhang.ColumnCount = 10;
            dgrid_khachhang.Columns[0].Name = "Stt";
            dgrid_khachhang.Columns[1].Name = "Id";
            dgrid_khachhang.Columns[2].Name = "Mã";
            dgrid_khachhang.Columns[3].Name = "Họ và Tên";
            dgrid_khachhang.Columns[4].Name = "Ngày sinh";
            dgrid_khachhang.Columns[5].Name = "Sđt";
            dgrid_khachhang.Columns[6].Name = "Địa chỉ";
            dgrid_khachhang.Columns[7].Name = "Thành phố";
            dgrid_khachhang.Columns[8].Name = "Quốc gia";
            dgrid_khachhang.Columns[9].Name = "Mật khẩu";
            dgrid_khachhang.Rows.Clear();

            foreach (var x in _iKhachHangService.GetAll(input))
            {
                dgrid_khachhang.Rows.Add(stt++, x.Id, x.Ma, x.Ho + x.TenDem + x.Ten, x.NgaySinh, x.Sdt, x.DiaChi, x.ThanhPho, x.QuocGia, x.MatKhau);
            }
        }
        private KhachHang GetDataFromGui()
        {
            return new KhachHang()
            {
                Id = Guid.Empty,
                Ma = "KH" + Utility.GetNumber(4),
                Ho = txt_ho.Text,
                TenDem = txt_tendem.Text,
                Ten = txt_ten.Text,
                NgaySinh = dtPicker_ngaysinh.Value,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Text,
                ThanhPho = txt_thanhpho.Text,
                QuocGia = txt_quocgia.Text,
                MatKhau = txt_matkhau.Text,
            };
        }

        private void dgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iKhachHangService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_khachhang.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iKhachHangService.GetAll().FirstOrDefault(x => x.Id == _idWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ho.Text = obj.Ho;
            txt_tendem.Text = obj.TenDem;
            txt_ten.Text = obj.Ten;
            dtPicker_ngaysinh.Value = obj.NgaySinh.Value;
            txt_sdt.Text = obj.Sdt;
            txt_diachi.Text = obj.DiaChi;
            txt_thanhpho.Text = obj.ThanhPho;
            txt_quocgia.Text = obj.QuocGia;
            txt_matkhau.Text = obj.MatKhau;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iKhachHangService.Add(GetDataFromGui()));
            LoadDgridKhachHang(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iKhachHangService.Update(temp));
            LoadDgridKhachHang(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iKhachHangService.Delete(temp));
            LoadDgridKhachHang(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ho.Text = "";
            txt_tendem.Text = "";
            txt_ten.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            txt_thanhpho.Text = "";
            txt_quocgia.Text = "";
            txt_matkhau.Text = "";
            dtPicker_ngaysinh.Value = DateTime.Now;
        }
    }
}
