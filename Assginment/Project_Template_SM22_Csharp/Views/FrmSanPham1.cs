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
    public partial class FrmSanPham1 : Form
    {
        private SanPham1Services _chSanPham1Services;
        public FrmSanPham1()
        {
            InitializeComponent();
            _chSanPham1Services = new SanPham1Services();
            rbtn_HoatDong.Checked = true;
            LoadWeb();
            LoadDate();
        }
        public void LoadWeb()
        {
            foreach (var item in _chSanPham1Services.GetWebs())
            {
                cmb_Web.Items.Add(item);
            }
            cmb_Web.SelectedIndex = 0;
        }
        public void LoadDate()
        {
            dgrid_SanPham1.ColumnCount = 5;
            dgrid_SanPham1.Columns[0].Name = "Mã";
            dgrid_SanPham1.Columns[1].Name = "Tên";
            dgrid_SanPham1.Columns[2].Name = "Gía Bán";
            dgrid_SanPham1.Columns[3].Name = "Trạng Thái";
            dgrid_SanPham1.Columns[4].Name = "Web";
            dgrid_SanPham1.Rows.Clear();
            foreach (var x in _chSanPham1Services.GetSanPhams())
            {
                dgrid_SanPham1.Rows.Add(x.Ma, x.Ten, x.GiaBan, (x.TrangThai ==1 ? "Hoạt Động" : "Không Hoạt Động"), x.Website);
            }
        }
        private SanPham GetFormGruid()
        {
            return new SanPham
            {
                Ma = txt_Ma.Text,
                Ten=txt_Ten.Text,
                GiaBan = Convert.ToDecimal(txt_Giaban.Text),
                TrangThai = rbtn_HoatDong.Checked ? 1 : 0,
                //Website=null,


            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPham1Services.AddSanPham1Services(GetFormGruid()));
            LoadDate();


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPham1Services.UpdateSanPham1Services(GetFormGruid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chSanPham1Services.DeleteSanPham1Services(GetFormGruid()));
            LoadDate();
        }

        private void dgrid_SanPham1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row == _chSanPham1Services.GetSanPhams().Count)
            {
                return;
            }
            var Masp = dgrid_SanPham1.Rows[row].Cells[0].Value.ToString();
            var obj = _chSanPham1Services.GetSanPhams().FirstOrDefault(c=>c.Ma.Equals(Masp));
            txt_Ma.Text=obj.Ma;
            txt_Ten.Text = obj.Ten;
            txt_Giaban.Text = Convert.ToString(obj.GiaBan);
            //cmb_Web.SelectedIndex = Convert.ToInt32(obj.Website);
            rbtn_KhongHoatdong.Checked = true;
            if (obj.TrangThai == 1)
            {
                rbtn_HoatDong.Checked = true;
                return;
            }

        }
    }
}
