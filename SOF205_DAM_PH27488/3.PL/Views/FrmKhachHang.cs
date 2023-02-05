using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.iServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        private iKhachHangService iKhSer;
        Guid idClick;
        public FrmKhachHang()
        {
            InitializeComponent();
            iKhSer = new KhachHangService();
            LoadDGrid(null);
            LoadThanhPho();
            LoadQuocGia();
        }
        public void LoadThanhPho()
        {
            foreach(var x in iKhSer.GetThanhPho())
            {
                cmb_thanhPho.Items.Add(x);
            }
            cmb_thanhPho.SelectedIndex = 0; 
        }
        public void LoadQuocGia()
        {
            foreach (var x in iKhSer.GetQuocGia())
            {
                cmb_quocGia.Items.Add(x);
            }
            cmb_quocGia.SelectedIndex = 0;
        }
        public void LoadDGrid(string input)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "stt";
            dataGridView1.Columns[1].Name = "id";
            dataGridView1.Columns[2].Name = "ma";
            dataGridView1.Columns[3].Name = "ho va ten";
            dataGridView1.Columns[4].Name = "sdt";
            dataGridView1.Columns[5].Name = "dia chi";
            dataGridView1.Columns[6].Name = "thanh pho";
            dataGridView1.Columns[7].Name = "quoc gia";
            dataGridView1.Columns[8].Name = "mat khau";
            dataGridView1.Rows.Clear();
            foreach (var x in iKhSer.GetAllKh(input))
            {
                dataGridView1.Rows.Add(stt++, x.id, x.ma, x.ho + " " + x.tenDem + " " + x.ten, x.sdt, x.diaChi, x.thanhPho, x.quocGia, x.matKhau);
            }
        }
        public KhachHangView GetDFromGuid()
        {
            return new KhachHangView()
            {
                ma = txt_ma.Text,
                ten = txt_ten.Text,
                tenDem = txt_tenDem.Text,
                ho = txt_ho.Text,
                ngSinh = dt_ngSinh.Value,
                sdt = txt_sdt.Text,
                thanhPho = cmb_thanhPho.Text,
                quocGia = cmb_quocGia.Text,
                matKhau = txt_matKhau.Text,
            };
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("ya sure?", "confirm", MessageBoxButtons.YesNo);
            MessageBox.Show(iKhSer.Add(GetDFromGuid()));
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("ya sure?", "confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            temp.ma = txt_ma.Text;
            temp.ten = txt_ten.Text;
            temp.tenDem = txt_tenDem.Text;
            temp.ho = txt_ho.Text;
            temp.ngSinh = dt_ngSinh.Value;
            temp.sdt = txt_sdt.Text;
            temp.diaChi = txt_diaChi.Text;
            temp.thanhPho = cmb_thanhPho.Text;
            temp.quocGia = cmb_quocGia.Text;
            temp.matKhau = txt_matKhau.Text;
            MessageBox.Show(iKhSer.Update(temp));
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("ya sure?", "confirm", MessageBoxButtons.YesNo);
            var temp = GetDFromGuid();
            temp.id = idClick;
            MessageBox.Show(iKhSer.Update(temp));
        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
            LoadDGrid(null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Row = e.RowIndex;
            if (e.RowIndex == -1) return;
            if (Row == iKhSer.GetAllKh().Count) return;
            idClick = Guid.Parse(dataGridView1.Rows[Row].Cells[1].Value.ToString());
            var temp = iKhSer.GetAllKh().FirstOrDefault(c => c.id == idClick);
            temp.id = idClick;
            txt_ma.Text = temp.ma;
            txt_ten.Text = temp.ten;
            txt_tenDem.Text = temp.tenDem;
            txt_ho.Text = temp.ho;
            dt_ngSinh.Value = temp.ngSinh;
            txt_sdt.Text = temp.sdt;
            txt_diaChi.Text = temp.diaChi;
            cmb_thanhPho.Text = temp.thanhPho;
            cmb_quocGia.Text = temp.quocGia;
            txt_matKhau.Text = temp.matKhau;
        }
    }
}
