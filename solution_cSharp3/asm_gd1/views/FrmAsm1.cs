using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using asm_gd1.services;
using System.Linq;
using asm_gd1.DomainClass;
using asm_gd1.utilities;

namespace asm_gd1.views
{
    public partial class FrmAsm1 : Form
    {
        private AsmServices _AsmService;
        private List<CuaHang> _lstCuaHang;

        private Guid _idWhenClick;
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        public FrmAsm1()
        {
            InitializeComponent();
            _AsmService = new AsmServices();
            txt_ma.Enabled = false;//Khóa textbox mã lại
            rbtn_nam.Checked = true;
            _lstCuaHang= new List<CuaHang>();
            LoadCH();
            LoadMaCH();
            LoadDGridCH(null);
        }
        private void LoadCH()
        {
            foreach (var x in _AsmService.GetAllCH())
            {
                cmb_cuaHang.Items.Add(x);
            }
            cmb_cuaHang.SelectedIndex = 0;//Hiển thị giá trị mặc định
        }

        private void LoadMaCH()
        {
            foreach (var x in _AsmService.GetAllMaCH())
            {
                cmb_locMaCuaHang.Items.Add(x);
            }
            cmb_locMaCuaHang.SelectedIndex = 0;//Hiển thị giá trị mặc định
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(NhanVien);
            int slThuoTinh = type.GetProperties().Length;//Đếm số lượng thuộc tính mà đối tượng cửa hàng có.
            dataGridView1.ColumnCount = slThuoTinh + 1;//Cộng 1 là vì muốn thêm 1 cột số thứ tự
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Id";
            dataGridView1.Columns[2].Name = "Mã";
            dataGridView1.Columns[3].Name = "Họ Tên";
            dataGridView1.Columns[4].Name = "Giới tính";
            dataGridView1.Columns[5].Name = "Ng sinh";
            dataGridView1.Columns[6].Name = "Địa chỉ";
            dataGridView1.Columns[7].Name = "IdCH";
            dataGridView1.Columns[8].Name = "IdCV";
            dataGridView1.Columns[9].Name = "IdGuiBC";
            dataGridView1.Columns[10].Name = "Trạng thái";
            dataGridView1.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _AsmService.GetAlls(input))
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.DiaChi, x.IdCh, x.IdCv, x.IdGuiBc, x.TrangThai) ;
            }
        }

        private NhanVien GetDataFromGui()
        {
            return new NhanVien()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                Ho = txt_ho.Text,
                TenDem = txt_tenDem.Text,
                Ten = txt_ten.Text,
                GioiTinh = rbtn_nam.Checked ? "nam" : "nữ",
                NgaySinh = picker_datetime.Value,
                DiaChi = txt_DiaChi.Text,
                
                Sdt = txt_sdt.Text,
            };
        }

        private void txt_ho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ho.Text)) return;
            txt_ho.Text = utility.VietHoaFullName(txt_ho.Text);
        }

        private void txt_tenDem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenDem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenDem.Text)) return;
            txt_tenDem.Text = utility.VietHoaFullName(txt_tenDem.Text);
        }



        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = utility.VietHoaFullName(txt_ten.Text);
        }

        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DiaChi.Text)) return;
            txt_DiaChi.Text = utility.VietHoaFullName(txt_DiaChi.Text);
        }

        private void txt_sdt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sdt.Text)) return;
            txt_sdt.Text = utility.VietHoaFullName(txt_sdt.Text);
        }

        private void txt_ngsinh_Leave(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_AsmService.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_AsmService.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_AsmService.Delete(temp));
            LoadDGridCH(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ho.Text = "";
            txt_tenDem.Text = "";
            txt_ten.Text = "";
            txt_DiaChi.Text = "";
            txt_sdt.Text = "";
            picker_datetime.Value = DateTime.Now;
            rbtn_nam.Checked = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _AsmService.GetAlls(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _AsmService.GetAlls().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ho.Text = obj.Ho;
            txt_tenDem.Text = obj.TenDem;
            txt_ten.Text = obj.Ten;
            txt_DiaChi.Text = obj.DiaChi;
            DateTime? txt_ngsinh = obj.NgaySinh;
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {

        }

        private void txt_ma_Leave(object sender, EventArgs e)
        {
            txt_ma.Text = utility.GetVietHoaChuCaiDau(txt_ten.Text) + utility.GetChuCaiDau(txt_ho.Text).ToLower() + utility.GetChuCaiDau(txt_tenDem.Text).ToLower();
        }
    }
}

