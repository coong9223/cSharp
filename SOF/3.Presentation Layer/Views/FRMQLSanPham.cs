using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2.BUS.ViewModels;

namespace _3.Presentation_Layer.Views
{
    public partial class FRMQLSanPham : Form
    {
        private IQLSanPhamService _iQLSanPhamService;
        Guid _id;
        public FRMQLSanPham()
        {
            InitializeComponent();
            _iQLSanPhamService = new QLSanPhamService();

        }

        private void LoadDridSP()
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            dgrid_sanpham.ColumnCount = 7;
            dgrid_sanpham.Columns[0].Name = "STT";
            dgrid_sanpham.Columns[1].Name = "Id";
            dgrid_sanpham.Columns[2].Name = "Năm bảo hành";
            dgrid_sanpham.Columns[3].Name = "Số lượng tồn";
            dgrid_sanpham.Columns[4].Name = "Mô tả";
            dgrid_sanpham.Columns[5].Name = "Giá nhập";
            dgrid_sanpham.Columns[6].Name = "Giá bán";

            dgrid_sanpham.Rows.Clear();
            foreach (var s in _iQLSanPhamService.GetAll())
            {
                dgrid_sanpham.Rows.Add(stt++, s.IdChitietSp, s.NamBh,s.SoLuongTon, s.MoTa,s.GiaNhap,s.GiaBan);
            }

        }
        private ChiTietSanPhamView GetDataFromGui()
        {
            return new ChiTietSanPhamView()
            {
                IdChitietSp = Guid.Empty,
                NamBh = Convert.ToInt32(txt_NamBH.Text),
                SoLuongTon = Convert.ToInt32(txt_SLT.Text),
                MoTa = txt_MoTa.Text,
                GiaBan = Convert.ToDecimal(txt_GiaBan.Text),
                GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text), 

            };

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Muốn ko?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                MessageBox.Show(_iQLSanPhamService.Add(GetDataFromGui()));
                LoadDridSP();
            }    
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadDridSP();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _iQLSanPhamService.GetAll().Count)
            {
                return;
            }
            _id = Guid.Parse(dgrid_sanpham.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _iQLSanPhamService.GetAll().FirstOrDefault(x => x.IdChitietSp == _id);


        }
    }
}
