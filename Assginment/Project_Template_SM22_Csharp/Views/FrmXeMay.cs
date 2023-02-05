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
    public partial class FrmXeMay : Form
    {
        private XeMayServices _chXeMayServices;
        public FrmXeMay()
        {
            InitializeComponent();
            _chXeMayServices = new XeMayServices();
            LoadSoLuong();
            LoadDate();
           
        }
        public void LoadSoLuong()
        {
            foreach (var item in _chXeMayServices.Getsoluong())
            {
                cmb_SoLuong.Items.Add(item);
            }
            cmb_SoLuong.SelectedIndex = 0;
            
        }
       public void LoadDate()
        {
            dgrid_XeMay.ColumnCount = 4;
            dgrid_XeMay.Columns[0].Name = "Mã";
            dgrid_XeMay.Columns[1].Name = "Tên";
            dgrid_XeMay.Columns[2].Name = "Số Lượng";
            dgrid_XeMay.Columns[3].Name = "Trạng Thái";

            dgrid_XeMay.Rows.Clear();
            foreach (var x in _chXeMayServices.GetXeMays())
            {
                dgrid_XeMay.Rows.Add(x.Ma,x.Ten,x.SoLuong,(x.TrangThai ==1 ? "Hoạt Động" : "KHông Hoạt Động"));
            }

            
        }
        private XeMay GetFormGuid()
        {
            return new XeMay
            {
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                SoLuong = cmb_SoLuong.SelectedIndex,
                TrangThai = null,
            };
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chXeMayServices.AddXeMayServices(GetFormGuid()));
            LoadDate();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chXeMayServices.UpdateXeMayServices(GetFormGuid()));
            LoadDate();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chXeMayServices.DeleteXeMayServices(GetFormGuid()));
            LoadDate();
        }

        private void btn_cleck_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_XeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row =e.RowIndex;
            if(row == _chXeMayServices.GetXeMays().Count)
            {
                return;

            }
            var Masm = dgrid_XeMay.Rows[row].Cells[0].Value.ToString();
            var obj= _chXeMayServices.GetXeMays().FirstOrDefault(c =>c.Ma.Equals(Masm));
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
            cmb_SoLuong.SelectedIndex=Convert.ToInt32(obj.SoLuong);

        }
    }
}
