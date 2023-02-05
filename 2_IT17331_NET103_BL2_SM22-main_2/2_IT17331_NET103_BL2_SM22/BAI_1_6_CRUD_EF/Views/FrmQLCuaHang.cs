using BAI_1_6_CRUD_EF.DomainClass;
using BAI_1_6_CRUD_EF.Services;
using BAI_1_6_CRUD_EF.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BAI_1_6_CRUD_EF.Views
{
    public partial class FrmQLCuaHang : Form
    {
        //Toàn bộ biến toàn cục sẽ code trên đầu và có dấu _ và private
        private QLCuaHangService _chService;
        private Guid _idWhenClick;


        public FrmQLCuaHang()
        {
            InitializeComponent();
            _chService = new QLCuaHangService();
            txt_Ma.Enabled = false;
            LoadThanhPho();
            LoadDGridCH(null);

        }


        private void LoadThanhPho()
        {
            foreach (var x in _chService.GetAllThanhPhos())
            {
                cmb_TP.Items.Add(x);
            }
            cmb_TP.SelectedIndex = 0;// Hiển thị giá trị mặc định
        }

        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            int slThuocTinh = type.GetProperties().Length;
            //Đếm só lượng thuộc tính mà đối tượng cửa hàng có

            dgrid_CuaHang.ColumnCount = slThuocTinh;
            //Cộng 1 vì muốn thêm 1 cột sô thứ tự
            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "ID";
            dgrid_CuaHang.Columns[2].Name = "Mã";
            dgrid_CuaHang.Columns[3].Name = "Tên";
            dgrid_CuaHang.Columns[4].Name = "Địa chỉ";
            dgrid_CuaHang.Columns[5].Name = "Thành phố";
            dgrid_CuaHang.Columns[6].Name = "Quốc gia";
            dgrid_CuaHang.Rows.Clear();
            //Xóa data mỗi lần call vào phương thức này

            foreach (var x in _chService.GetAllCuaHangs(input))
            {
                dgrid_CuaHang.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia);
            }

        }

        private CuaHang GetDataFromGuid()
        {

            return new CuaHang()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                ThanhPho = cmb_TP.Text,
                DiaChi = txt_DiaChi.Text,
                QuocGia = txt_QuocGia.Text
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGuid()));
            LoadDGridCH(null);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGuid();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDGridCH(null);
        }

        private void dgrid_CuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _chService.GetAllCuaHangs(null).Count) return;
            //2. Lấy được khóa chính trên grid
            _idWhenClick = Guid.Parse(dgrid_CuaHang.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _chService.GetAllCuaHangs().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
            txt_DiaChi.Text = obj.DiaChi;
            cmb_TP.SelectedItem = obj.ThanhPho;
            txt_QuocGia.Text = obj.QuocGia;
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ma.Text = Utility.ZenMaTuDong(txt_Ten.Text) + _chService.GetAllCuaHangs(null).Count;

        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text)) return;
            txt_Ten.Text = Utility.VietHoaFullName(txt_Ten.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_DiaChi.Text = "";
            cmb_TP.SelectedItem = 0;
            txt_QuocGia.Text = "";
        }

        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DiaChi.Text)) return;
            txt_DiaChi.Text = Utility.VietHoaFullName(txt_DiaChi.Text);
        }

        private void txt_QuocGia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_QuocGia.Text)) return;
            txt_QuocGia.Text = Utility.VietHoaFullName(txt_QuocGia.Text);
        }
    }
}
