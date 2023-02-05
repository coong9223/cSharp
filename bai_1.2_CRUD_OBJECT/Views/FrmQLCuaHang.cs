using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using bai_1._2_CRUD_OBJECT.Models;
using bai_1._2_CRUD_OBJECT.Repositories;
using bai_1._2_CRUD_OBJECT.Services;
using bai_1._2_CRUD_OBJECT.Utilities;

namespace bai_1._2_CRUD_OBJECT.Views
{
    public partial class FrmQLCuaHang : Form
    {



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private QLCuaHangServices _chService;

        private Guid _idWhenClick;

        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangServices();
            txt_ma.Enabled = false;//Khóa textbox mã lại
            rbtn_koHoatDong.Checked = true;
            LoadThanhPho();
            LoadDGridCH(null);
        }

        private void LoadThanhPho()
        {
            foreach (var x in _chService.GetAllThanhPhos())
            {
                cmb_thanhPho.Items.Add(x);
            }
            cmb_thanhPho.SelectedIndex = 0;//Hiển thị giá trị mặc định
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuoTinh = type.GetProperties().Length;//Đếm số lượng thuộc tính mà đối tượng cửa hàng có.
            dataGridView1.ColumnCount = slThuoTinh + 1;//Cộng 1 là vì muốn thêm 1 cột số thứ tự
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Id";
            dataGridView1.Columns[2].Name = "Mã";
            dataGridView1.Columns[3].Name = "Tên";
            dataGridView1.Columns[4].Name = "Địa Chỉ";
            dataGridView1.Columns[5].Name = "Thành Phố";
            dataGridView1.Columns[6].Name = "Quốc Gia";
            dataGridView1.Columns[7].Name = "Trạng Thái";
            dataGridView1.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia, (x.Status == 1 ? "Hoạt động" : x.Status == 0 ? " Không hoạt động" : "Sửa chữa"));
            }
        }

        private CuaHang GetDataFromGui()
        {
            return new CuaHang()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
                ThanhPho = cmb_thanhPho.Text,
                DiaChi = txt_diaChi.Text,
                QuocGia = txt_quocGia.Text,
                Status = (rbtn_hoatDong.Checked ? 1 : rbtn_koHoatDong.Checked ? 0 : 2)
            };
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text = Utility.ZenMaTuDong(txt_ten.Text) + _chService.GetAllCuaHangs(null).Count;
        }


        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void dgrid_CuaHangs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            txt_diaChi.Text = obj.DiaChi;
            cmb_thanhPho.SelectedItem = obj.ThanhPho;
            txt_quocGia.Text = obj.QuocGia;
            if (obj.Status == 1)
            {
                rbtn_hoatDong.Checked = true;
            }
            else if (obj.Status == 0)
            {
                rbtn_koHoatDong.Checked = true;
                return;
            }

            rbtn_check.Checked = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDGridCH(null);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timKiem.Text)) return;
            LoadDGridCH(txt_timKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            txt_timKiem.Text = "Tìm kiếm .......";
            LoadDGridCH(null);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_timKiem.Clear();
        }
    }
}
