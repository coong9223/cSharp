﻿using _1.DAL.DomainModels;
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
    public partial class QLSanPham : Form
    {
        private ISanPhamService _iSanPhamService;
        Guid _idWhenclick;
        public QLSanPham()
        {
            InitializeComponent();
            _iSanPhamService = new SanPhamService();
            LoadDgridSp(null);
        }
        private void LoadDgridSp(string input)
        {
            int stt = 1;
            dgrid_sp.ColumnCount = 4;
            dgrid_sp.Columns[0].Name = "STT";
            dgrid_sp.Columns[1].Name = "Id";
            dgrid_sp.Columns[2].Name = "Ma";
            dgrid_sp.Columns[3].Name = "Ten";
            dgrid_sp.Rows.Clear();

            foreach (var x in _iSanPhamService.GetAll(input))
            {
                dgrid_sp.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private SanPham GetDataFromGui()
        {
            return new SanPham()
            {
                Id = Guid.Empty,
                Ma = "SP" + Utility.GetNumber(4),
                Ten = txt_ten.Text
            };
        }

        private void dgrid_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (rowIndex == _iSanPhamService.GetAll().Count) return;
            _idWhenclick = Guid.Parse(dgrid_sp.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _iSanPhamService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iSanPhamService.Add(GetDataFromGui()));
            LoadDgridSp(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iSanPhamService.Update(temp));
            LoadDgridSp(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenclick;
            MessageBox.Show(_iSanPhamService.Delete(temp));
            LoadDgridSp(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "Tìm Kiếm";
        }
    }
}
