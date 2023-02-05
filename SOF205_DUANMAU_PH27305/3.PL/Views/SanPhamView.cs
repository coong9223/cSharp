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
using System.Windows.Forms.VisualStyles;

namespace _3.PL.Views
{
    public partial class SanPhamView : Form
    {
        private IQLSanPhamService _iQLSanPhamView;
        private IDongSpService _iDongSpService;
        private IMauSacService _iMauSacService;
        private INsxService _iNsxService;
        private ISanPhamService _iSanPhamService;
        Guid _idWhenclick;
        public SanPhamView()
        {
            InitializeComponent();
            _iQLSanPhamView = new QLSanPhamService();
            _iDongSpService = new DongSpService();
            _iMauSacService = new MauSacService();
            _iNsxService = new NsxService();
            _iSanPhamService = new SanPhamService();
            LoadCmb();
            LoadDgridSP();
        }
        private void LoadCmb()
        {
            foreach (var x in _iSanPhamService.GetAll())
            {
                cmb_tensp.Items.Add(x.Ten);
            }
            cmb_tensp.SelectedIndex = 0;

            foreach (var x in _iDongSpService.GetAll())
            {
                cmb_dongsanpham.Items.Add(x.Ten);
            }
            cmb_dongsanpham.SelectedIndex = 0;

            foreach (var x in _iMauSacService.GetAll())
            {
                cmb_mausac.Items.Add(x.Ten);
            }
            cmb_mausac.SelectedIndex = 0;

            foreach (var x in _iNsxService.GetAll())
            {
                cmb_nhasanxuat.Items.Add(x.Ten);
            }
            cmb_nhasanxuat.SelectedIndex = 0;
        }
        private void LoadDgridSP()
        {
            int stt = 1;
            dgrid_sanpham.ColumnCount = 8;
            dgrid_sanpham.Columns[0].Name = "STT";
            dgrid_sanpham.Columns[1].Name = "Id";
            dgrid_sanpham.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_sanpham.Columns[3].Name = "Màu";
            dgrid_sanpham.Columns[4].Name = "Tên NSX";
            dgrid_sanpham.Columns[5].Name = "Tên Dòng SP";
            dgrid_sanpham.Columns[6].Name = "Năm BH";
            dgrid_sanpham.Columns[7].Name = "Mô tả";
            dgrid_sanpham.Rows.Clear();

            foreach (var x in _iQLSanPhamView.GetAll())
            {
                dgrid_sanpham.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.MauSac.Ten, x.Nsx.Ten, x.DongSp.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa);
            }
        }
        private QLSanPhamView GetDataFromGui()
        {
            QLSanPhamView spv = new QLSanPhamView();
            spv.SanPham = _iSanPhamService.GetById(_iSanPhamService.GetIdByName(cmb_tensp.Text));
            spv.MauSac = _iMauSacService.GetById(_iMauSacService.GetIdFromTen(cmb_mausac.Text));
            spv.Nsx = _iNsxService.GetById(_iNsxService.GetIdFromTen(cmb_nhasanxuat.Text));
            spv.DongSp = _iDongSpService.GetById(_iDongSpService.GetIdFromTen(cmb_dongsanpham.Text));
            spv.ChiTietSp = new ChiTietSp()
            {
                IdSp = spv.SanPham.Id,
                IdNsx = spv.Nsx.Id,
                IdMauSac = spv.MauSac.Id,
                IdDongSp = spv.DongSp.Id,
                NamBh = Convert.ToInt32(txt_nambh.Text),
                SoLuongTon = Convert.ToInt32(txt_soluong.Text),
                GiaNhap = Convert.ToDecimal(txt_gianhap.Text),
                GiaBan = Convert.ToDecimal(txt_giaban.Text),
                MoTa = richtxt_mota.Text
            };
            return spv;
        }

        private void dgrid_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iQLSanPhamView.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_sanpham.Rows[rowIndex].Cells[1].Value.ToString());
            var spv = _iQLSanPhamView.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == _idWhenclick);
            cmb_tensp.SelectedIndex = _iSanPhamService.GetAll().FindIndex(c=>c.Id == spv.SanPham.Id);
            cmb_dongsanpham.SelectedIndex = _iDongSpService.GetAll().FindIndex(c => c.Id == spv.DongSp.Id);
            cmb_mausac.SelectedIndex = _iMauSacService.GetAll().FindIndex(c => c.Id == spv.MauSac.Id);
            cmb_nhasanxuat.SelectedIndex = _iNsxService.GetAll().FindIndex(c => c.Id == spv.Nsx.Id);
            txt_soluong.Text = spv.ChiTietSp.SoLuongTon.ToString();
            txt_gianhap.Text = spv.ChiTietSp.GiaNhap.ToString();
            txt_giaban.Text = spv.ChiTietSp.GiaBan.ToString();
            txt_nambh.Text = spv.ChiTietSp.NamBh.ToString();
            richtxt_mota.Text = spv.ChiTietSp.MoTa;
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iQLSanPhamView.Add(GetDataFromGui()));
            LoadDgridSP();
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.ChiTietSp.Id = _idWhenclick;
            MessageBox.Show(_iQLSanPhamView.Update(temp));
            LoadDgridSP();
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.ChiTietSp.Id = _idWhenclick;
            MessageBox.Show(_iQLSanPhamView.Delete(temp));
            LoadDgridSP();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_tensp.SelectedIndex = 0;
            txt_soluong.Text = "";
            txt_gianhap.Text = "";
            txt_giaban.Text = "";
            txt_nambh.Text = "";
            cmb_dongsanpham.SelectedIndex = 0;
            cmb_mausac.SelectedIndex = 0;
            cmb_nhasanxuat.SelectedIndex = 0;
            richtxt_mota.Text = "";
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {

        }
    }
}
