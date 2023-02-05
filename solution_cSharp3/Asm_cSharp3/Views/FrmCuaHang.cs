using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Asm_cSharp3.DomainClass;
using Asm_cSharp3.Context;
using Asm_cSharp3.Services;
using Asm_cSharp3.Repositories;
using Asm_cSharp3.Views;
using Asm_cSharp3.Utilities;

namespace Asm_cSharp3.Views
{
    public partial class FrmCuaHang : Form
    {
        private chServices _chServices;
        private CHUtilities _chUtilities;
        public Guid _idClick;
        public FrmCuaHang()
        {
            InitializeComponent();
            _chServices = new chServices();
            _chUtilities = new CHUtilities();
            txt_ma.Enabled = false;
            rbtn_hoatDong.Checked = true;
            LoadDGrid(null);
        }

        private void LoadThanhPho()
        {
            foreach(var x in _chServices.GetThanhPho())
            {
                cmb_thanhPho.Items.Add(x);
            }cmb_thanhPho.SelectedIndex = 0;
        }

        private void LoadDGrid(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int temp = type.GetProperties().Length;
            dataGridView1.ColumnCount = temp+1;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "ma";
            dataGridView1.Columns[2].Name = "ten";
            dataGridView1.Columns[3].Name = "diachi";
            dataGridView1.Columns[4].Name = "thanhpho";
            dataGridView1.Columns[5].Name = "quocgia";
            dataGridView1.Columns[6].Name = "trangthai";
            dataGridView1.Rows.Clear();
            foreach(var x in _chServices.GetAllCuaHang(input))
            {
                dataGridView1.Rows.Add(stt++, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }
            
        }
        private CuaHang GetDataGuid()
        {
            return new CuaHang
            {
                Id = Guid.NewGuid(),
                Ten = txt_ten.Text,
                Ma = txt_ma.Text,
                DiaChi = txt_diaChi.Text,
                ThanhPho = cmb_thanhPho.Text,
                QuocGia=txt_quocGia.Text,
            };
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text) == null) return;
            txt_ma.Text = _chUtilities.GenMaAuto(txt_ten.Text) + _chServices.GetAllCuaHang(null).Count;
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text) == null) return;
            txt_ten.Text = _chUtilities.VietHoaFull(txt_ten.Text);
        }


    }
}
