using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class FrmSanPham : Form
    {
        private SanPhamServices _chSanPhamServices;
        public FrmSanPham()
        {
            InitializeComponent();
            _chSanPhamServices = new SanPhamServices();
            LoadDate();

           
        }

        public void LoadDate()
        {
            dgrid_SanPham.ColumnCount = 4;
            dgrid_SanPham.Columns[0].Name = "Mã";
            dgrid_SanPham.Columns[1].Name = "Tên";
            dgrid_SanPham.Columns[2].Name = "Gía Bán";
            dgrid_SanPham.Columns[3].Name = "Trạng thái";
            dgrid_SanPham.Rows.Clear();

            foreach (var x in _chSanPhamServices.GetSanPhams())
            {
                dgrid_SanPham.Rows.Add(x.Ma, x.Ten, x.GiaBan, (x.TrangThai == 1 ? "Hoạt Dộng": "Không Hoạt Động"));
            }
        }
        private SanPham GetFormGruid()
        {
            return new SanPham
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                GiaBan = Convert.ToDecimal(txt_Giaban.Text),
                TrangThai = ck_Hoatdong.Checked ? 1 : 0,
            };
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

        private void dgrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row == _chSanPhamServices.GetSanPhams().Count) {
                return;
            
            }
            var Masp = dgrid_SanPham.Rows[row].Cells[0].Value.ToString();
            var obj= _chSanPhamServices.GetSanPhams().FirstOrDefault(c=>c.Ma.Equals(Masp));
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text=obj.Ten;
            txt_Giaban.Text = Convert.ToString(obj.GiaBan);
            ck_Khonghoatdong.Checked = true;
            if (obj.TrangThai == 1)
            {
                ck_Hoatdong.Checked = true;
                return;
            }


        }

        private void btn_cleck_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = null;
            txt_Ten.Text = null;
            txt_Giaban.Text=null;

        }
    }
}
