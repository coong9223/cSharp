using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using All_cSharp3.DomainClass;
using All_cSharp3.Utilities;
using All_cSharp3.Context;
using All_cSharp3.Services;

namespace All_cSharp3.Views
{
    public partial class FrmCuaHang : Form
    {
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force

        private CuaHangServices _chService;

        private Guid _idWhenClick;
        public FrmCuaHang()
        {
            _chService = new CuaHangServices();
            txt_ma.Enabled = false;
            rbtn_hoatDong.Checked = true;
            LoadDTGridView(null);
            LoadThanhPho();
            InitializeComponent();
        }

        public void LoadThanhPho()
        {
            foreach(var x in _chService.GetAllThanhPhos())//khi x = 1 giá trị trong getallthanhpho, thêm x vào cmb_thanhPho
            {
                cmb_thanhPho.Items.Add(x);
            }
            cmb_thanhPho.SelectedIndex = 0; 
        }

        public void LoadDTGridView(string input)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text=CuaHangUtilities.GenMaAuTo(txt_ten.Text)+_chService.GetAllCuaHangs(null).Count;
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = CuaHangUtilities.VietHoaTuDong(txt_ten.Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chService.Add(GetDataFromGui()));
            LoadDTGridView(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Update(temp));
            LoadDTGridView(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = _idWhenClick;
            MessageBox.Show(_chService.Delete(temp));
            LoadDTGridView(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_diaChi.Text = "";
            cmb_thanhPho.SelectedIndex = 0;
            rbtn_hoatDong.Checked = true;
            txt_quocGia.Text = "";
        }

    }
}
