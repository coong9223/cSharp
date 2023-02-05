using Project_Template_SM22_Csharp.DomainModels;
using Project_Template_SM22_Csharp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Template_SM22_Csharp.Views
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienServices _chNhanVienServices;
        public FrmNhanVien()
        {
            InitializeComponent();
            _chNhanVienServices = new NhanVienServices();
            LoadDate();
        }
         public void LoadDate()
        {
            dgrid_NhanVien.ColumnCount = 4;
            dgrid_NhanVien.Columns[0].Name = "Mã";
            dgrid_NhanVien.Columns[0].Name = "Mã";
            dgrid_NhanVien.Columns[0].Name = "Mã";
            dgrid_NhanVien.Columns[0].Name = "Mã";
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in _chNhanVienServices.GetNhanViens())
            {
                dgrid_NhanVien.Rows.Add(x.Ma, x.Ten, x.Sdt, x.DiaChi);
            }
        }
        private NhanVien GetFormGruid()
        {
            return new NhanVien
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                Sdt = txt_Sdt.Text,
                DiaChi = txt_Diachi.Text,
            };
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chNhanVienServices.AddNhanVienServices(GetFormGruid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
