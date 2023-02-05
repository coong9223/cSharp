using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class HoaDonView : Form
    {
        private IQLHoaDonService _iQlHoadonService;
        private IKhachHangService _iKhachhangService;
        private INhanVienService _iNhanVienService;
        private IHoaDonService _iHoadonService;
        private IHoaDonChiTietSerivce _iHoadonChitietService;
        private IQLSanPhamService _iQlSanphamService;
        private ISanPhamService _iSanphamService;
        Guid _idWhenclick;
        public HoaDonView()
        {
            InitializeComponent();
            _iQlHoadonService = new QLHoaDonService();
            _iKhachhangService = new KhachHangService();
            _iNhanVienService = new NhanVienService();
            _iHoadonService = new HoaDonService();
            _iHoadonChitietService = new HoaDonChiTietService();
            _iQlSanphamService = new QLSanPhamService();
            _iSanphamService = new SanPhamService();
            Loadcmb();
            LoadDgridHoadon();
            dgrid_hoadon.Columns[1].Visible = false;            
        }
        private void Loadcmb()
        {
            foreach (var x in _iHoadonService.GetAll())
            {
                cmb_hoadon.Items.Add(x.Ma);
            }
            cmb_hoadon.SelectedIndex = 0;

            foreach (var x in _iNhanVienService.GetAll())
            {
                cmb_nhanvien.Items.Add(x.Id);
            }
            cmb_nhanvien.SelectedIndex = 0;

            foreach (var x in _iKhachhangService.GetAll())
            {
                cmb_khachhang.Items.Add(x.Id);
            }
            cmb_khachhang.SelectedIndex = 0;

            foreach (var x in _iHoadonService.TrangThai())
            {
                cmb_tinhtrang.Items.Add(x);
            }
            cmb_tinhtrang.SelectedIndex = 0;

            foreach (var x in _iQlSanphamService.GetAll())
            {
                cmb_sanpham.Items.Add(x.ChiTietSp.Id);
            }
            
        }
        private void LoadDgridHoadon()
        {
            int stt = 1;
            dgrid_hoadon.ColumnCount = 15;
            dgrid_hoadon.Columns[0].Name = "Mã";
            dgrid_hoadon.Columns[1].Name = "Id";
            dgrid_hoadon.Columns[2].Name = "Tên khách hàng";
            dgrid_hoadon.Columns[3].Name = "Tên nhân viên";
            dgrid_hoadon.Columns[4].Name = "Ngày tạo";
            dgrid_hoadon.Columns[5].Name = "Ngày thanh toán";
            dgrid_hoadon.Columns[6].Name = "Ngày ship";
            dgrid_hoadon.Columns[7].Name = "Ngày nhận";
            dgrid_hoadon.Columns[8].Name = "Tên người nhận";
            dgrid_hoadon.Columns[9].Name = "Địa chỉ";
            dgrid_hoadon.Columns[10].Name = "Sđt";
            dgrid_hoadon.Columns[11].Name = "Tên sản phẩm";
            dgrid_hoadon.Columns[12].Name = "Số lượng";
            dgrid_hoadon.Columns[13].Name = "Đơn giá";
            dgrid_hoadon.Columns[14].Name = "Trạng thái";
            dgrid_hoadon.Rows.Clear();

            foreach (var x in _iQlHoadonService.GetAll())
            {
                dgrid_hoadon.Rows.Add(x.HoaDon.Ma, x.HoaDon.Id, x.KhachHang.Ten, x.NhanVien.Ten, x.HoaDon.NgayTao, x.HoaDon.NgayThanhToan, x.HoaDon.NgayShip, x.HoaDon.NgayNhan, x.HoaDon.TenNguoiNhan, x.HoaDon.DiaChi, x.HoaDon.Sdt, x.QLSanPhamView.SanPham.Ten, x.HoaDonChiTiet.SoLuong,x.HoaDonChiTiet.DonGia,x.HoaDon.TinhTrang);
            }
        }
        private QLHoaDonView GetDataFromGui()
        {
            QLHoaDonView hdview = new QLHoaDonView();
            // gán giá trị cho hóa đơn rỗng
            hdview.HoaDon = _iHoadonService.GetByMa(cmb_hoadon.Text);
            hdview.HoaDon.IdKh = Guid.Parse(cmb_khachhang.Text);
            hdview.HoaDon.IdNv = Guid.Parse(cmb_nhanvien.Text);
            hdview.HoaDon.NgayTao = dtpicker_ngaytao.Value;
            hdview.HoaDon.NgayThanhToan = dtpicker_ngaythanhtoan.Value;
            hdview.HoaDon.NgayShip = dtpicker_ngayship.Value;
            hdview.HoaDon.NgayNhan = dtpicker_ngaynhan.Value;
            hdview.HoaDon.TinhTrang = cmb_tinhtrang.SelectedIndex;
            hdview.HoaDon.TenNguoiNhan = txt_tenNguoinhan.Text;
            hdview.HoaDon.DiaChi = txt_diachi.Text;
            hdview.HoaDon.Sdt = txt_sdt.Text;
            // tạo hóa đơn chi tiết
            hdview.HoaDonChiTiet = new HoaDonChiTiet()
            {
                IdHoaDon = hdview.HoaDon.Id,
                IdChiTietSp = Guid.Parse(cmb_sanpham.Text),
                DonGia = decimal.Parse(txt_dongia.Text),
                SoLuong = int.Parse(txt_soluong.Text)
            };

            return hdview;
        }

        private void cmb_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_dongia.Text = _iQlSanphamService.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == Guid.Parse(cmb_sanpham.Text)).ChiTietSp.GiaBan.ToString();
        }
        private void dgrid_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iQlHoadonService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_hoadon.Rows[rowIndex].Cells[1].Value.ToString());
            var hdv = _iQlHoadonService.GetAll().FirstOrDefault(c => c.HoaDon.Id == _idWhenclick);
            cmb_hoadon.Text = hdv.HoaDon.Ma;
            cmb_khachhang.Text = hdv.KhachHang.Id.ToString();
            cmb_nhanvien.Text = hdv.NhanVien.Id.ToString();
            txt_tenNguoinhan.Text = hdv.HoaDon.TenNguoiNhan;
            txt_diachi.Text = hdv.HoaDon.DiaChi;
            txt_sdt.Text = hdv.HoaDon.Sdt;
            cmb_tinhtrang.SelectedIndex = hdv.HoaDon.TinhTrang.Value;
            cmb_sanpham.Text = hdv.QLSanPhamView.ChiTietSp.Id.ToString();
            txt_dongia.Text = hdv.HoaDonChiTiet.DonGia.ToString();
            txt_soluong.Text = hdv.HoaDonChiTiet.SoLuong.ToString();
            dtpicker_ngaytao.Value = hdv.HoaDon.NgayTao.Value;
            dtpicker_ngaythanhtoan.Value = hdv.HoaDon.NgayThanhToan.Value;
            dtpicker_ngayship.Value = hdv.HoaDon.NgayShip.Value;
            dtpicker_ngaynhan.Value = hdv.HoaDon.NgayNhan.Value;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQlHoadonService.Add(GetDataFromGui()));
            LoadDgridHoadon();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.HoaDon.Id = _idWhenclick;
            MessageBox.Show(_iQlHoadonService.Update(temp));
            LoadDgridHoadon();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.HoaDon.Id = _idWhenclick;
            MessageBox.Show(_iQlHoadonService.Delete(temp));
            LoadDgridHoadon();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
