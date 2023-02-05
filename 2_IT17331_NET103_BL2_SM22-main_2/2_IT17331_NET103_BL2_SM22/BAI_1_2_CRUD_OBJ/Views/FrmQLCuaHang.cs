using BAI_1_2_CRUD_OBJ.Models;
using BAI_1_2_CRUD_OBJ.Services;
using BAI_1_2_CRUD_OBJ.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_2_CRUD_OBJ.Views
{
    public partial class FrmQLCuaHang : Form
    {
        // toàn bộ biến toàn cục code trên đầu và có dấu "_" và private

        private QLCuaHangService _chService;
        private Guid _idWhenClick;

        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangService();
            txt_ma.Enabled = false; // khóa textbox mã lại
            rbtn_khonghoatdong.Checked = true;
            LoadThanhPho();
            LoadDGridCH(null);
        }

        private void LoadThanhPho()
        {
            foreach (var x in _chService.GetAllThanhPhos())
            {
                cmb_thanhpho.Items.Add(x);
                cmb_thanhpho.SelectedIndex = 0; // giá trị mặc định
            }
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuocTinh = type.GetProperties().Length; // đếm số lượng thuộc tính mà đối tượng cửa hàng có
            dgrid_Cuahangs.ColumnCount = slThuocTinh + 1; // +1 vì có thêm 1 cột số thứ tự
            dgrid_Cuahangs.Columns[0].Name = "STT";
            dgrid_Cuahangs.Columns[1].Name = "Id";
            dgrid_Cuahangs.Columns[2].Name = "Mã";
            dgrid_Cuahangs.Columns[3].Name = "Tên";
            dgrid_Cuahangs.Columns[4].Name = "Địa chỉ";
            dgrid_Cuahangs.Columns[5].Name = "Thành Phố";
            dgrid_Cuahangs.Columns[6].Name = "Quốc Gia";
            dgrid_Cuahangs.Columns[7].Name = "Trạng Thái";
            dgrid_Cuahangs.Rows.Clear(); // xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgrid_Cuahangs.Rows.Add(stt++,x.Id,x.Ma,x.Ten,x.DiaChi,x.ThanhPho,x.QuocGia,x.Status == 1 ? "hoạt động" : x.Status == 0 ? "không hoạt động" : "sửa chữa");
            }
        }

        private CuaHang GetDataFromGui()
        {
            return new CuaHang() 
            { 
                Id = Guid.Empty, 
                Ma = txt_ma.Text, 
                Ten = txt_ten.Text,
                DiaChi = txt_ten.Text, 
                ThanhPho = cmb_thanhpho.Text, 
                QuocGia = txt_quocgia.Text, 
                Status = rbtn_hoatdong.Checked ? 1 : rbtn_khonghoatdong.Checked ? 0 : 2
            };
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text = Utility.ZenMaTuDong(txt_ten.Text) + _chService.GetAllCuaHangs(null).Count;
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = Utility.VietHoaFullName(txt_ten.Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void dgrid_Cuahangs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            // 2. lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dgrid_Cuahangs.Rows[rowIndex].Cells[1].Value.ToString());
            // 3. tìm đối tượng theo id
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(c => c.Id == _idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
            txt_diachi.Text = obj.DiaChi;
            cmb_thanhpho.SelectedItem = obj.ThanhPho;
            txt_quocgia.Text = obj.QuocGia;
          
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

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text)) return;
            LoadDGridCH(txt_timkiem.Text);
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "tìm kiếm";
            LoadDGridCH(null);
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Clear();
        }
    }
}
