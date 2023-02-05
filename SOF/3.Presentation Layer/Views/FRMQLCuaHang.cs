using _2.BUS.Services;
using _2.BUS.IServices;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2.BUS.ViewModels;

namespace _3.Presentation_Layer.Views
{
    public partial class FRMQLCuaHang : Form
    {
        ICuaHangService _iCuaHangService;
        Guid _idWhenClick;
        public FRMQLCuaHang()
        {
            InitializeComponent();
            _iCuaHangService = new CuaHangService();    
        }
        public CuaHangView GetData()
        {
            return new CuaHangView()
            {
                Id= Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                DiaChi= txt_Dc.Text,
                ThanhPho = txt_TP.Text,
                QuocGia = txt_QG.Text,
            };
        }
        public void LoadDgridCuaHang(string input)
        {
            int stt = 1;
            dgrid_CuaHang.ColumnCount = 7;

            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "Id";
            dgrid_CuaHang.Columns[2].Name = "Ma";
            dgrid_CuaHang.Columns[3].Name = "Ten";
            dgrid_CuaHang.Columns[4].Name = "DiaChi";
            dgrid_CuaHang.Columns[5].Name = "Thanh Pho";
            dgrid_CuaHang.Columns[6].Name = "Quoc Gia";

            dgrid_CuaHang.Rows.Clear();
            foreach (var item in _iCuaHangService.GetAll(input))
            {
                dgrid_CuaHang.Rows.Add(stt++,item.Id,item.Ma,item.Ten,item.DiaChi,item.ThanhPho,item.QuocGia);
            }  
        }
       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Có muốn ko?","xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                MessageBox.Show(_iCuaHangService.Add(GetData()));
                LoadDgridCuaHang(null);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Có muốn ko?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_iCuaHangService.Update(temp));
                LoadDgridCuaHang(null);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Có muốn ko?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_iCuaHangService.Delete(temp));
                LoadDgridCuaHang(null);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadDgridCuaHang(null);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text))
            {
                return;
            }
            LoadDgridCuaHang(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = " ";
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            LoadDgridCuaHang(null);
        }

        private void dgrid_CuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == -1)
            {
                return;
            }
            if(RowIndex == _iCuaHangService.GetAll().Count)
            {
                return ;
            }
            _idWhenClick = Guid.Parse(dgrid_CuaHang.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _iCuaHangService.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
            txt_Dc.Text = obj.DiaChi;
            txt_TP.Text = obj.ThanhPho;
            txt_QG.Text = obj.QuocGia;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

            FRMQLCuaHang NewForm = new FRMQLCuaHang();
            NewForm.Show();
            this.Dispose(false);
        }
    }
       
}
