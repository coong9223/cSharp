using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using bai_1._6_crud_ef.DomainClass;
using bai_1._6_crud_ef.services;
using bai_1._6_crud_ef.utilities;

namespace bai_1._6_crud_ef.views
{
    public partial class frmQLCuaHang : Form
    {
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
       

        public frmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCHServices();
            txt_ma.Enabled = false;//Khóa textbox mã lại
            rbtn_koHoatDong.Checked = true;
            LoadThanhPho();
            LoadDGridCH(null);
        }
        private QLCHServices _chService;

        private Guid _idWhenClick;



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
            dataGridView1.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
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
                QuocGia = txt_quocGia.Text
            };
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text = utility.ZenMaTuDong(txt_ten.Text) + _chService.GetAllCuaHangs(null).Count;
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = utility.VietHoaFullName(txt_ten.Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDGridCH(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _chService.GetAllCuaHang().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            txt_diaChi.Text = obj.DiaChi;
            cmb_thanhPho.SelectedItem = obj.ThanhPho;
            txt_quocGia.Text = obj.QuocGia;
        }

        private void rbtn_koHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_hoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_thanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_diaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_diaChi.Text)) return;
            txt_diaChi.Text = utility.VietHoaFullName(txt_diaChi.Text);
        }

        private void txt_quocGia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_quocGia.Text)) return;
            txt_quocGia.Text=utility.VietHoaFullName(txt_quocGia.Text);
        }
    }
}
