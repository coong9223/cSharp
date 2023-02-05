using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lab1234_ChucVu.services;
using lab1234_ChucVu.DomainClass;
using lab1234_ChucVu.utilities;
using System.Linq;

namespace lab1234_ChucVu.views
{
    public partial class FrmChucVu : Form
    {
        private CVServices _cvServices;
        private Guid idWhenClick;
        //Scaffold-DbContext 'Data Source=CONGPC;Initial Catalog=FINALASS_FPOLYSHOP_SM22_BL2_DUNGNA29;Persist Security Info=True;User ID=congnguyen;Password=1' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context FpolyDBContext -Contextdir Context -DataAnnotations -Force
        public FrmChucVu()
        {
            InitializeComponent();
            _cvServices = new CVServices();
            txt_ma.Enabled = false;
            LoadDGridCH(null);
            
        }
        private void LoadDGridCH(string input)
        {
            int stt = 1;
            Type type = typeof(ChucVu);
            int slThuoTinh = type.GetProperties().Length;//Đếm số lượng thuộc tính mà đối tượng cửa hàng có.
            dataGridView1.ColumnCount = slThuoTinh + 1;//Cộng 1 là vì muốn thêm 1 cột số thứ tự
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Id";
            dataGridView1.Columns[2].Name = "Mã";
            dataGridView1.Columns[3].Name = "Tên";
            dataGridView1.Rows.Clear();//Xóa data mỗi lần call vào phương thức này

            foreach (var x in _cvServices.GetAlls(input))
            {
                dataGridView1.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }
        private ChucVu GetDataFromGui()
        {
            return new ChucVu()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                Ten = txt_ten.Text,
            };
        }

        private void txt_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ma.Text = utility.ZenMaTuDong(txt_ten.Text) + _cvServices.GetAlls(null).Count;
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text)) return;
            txt_ten.Text = utility.VietHoaFullName(txt_ten.Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_cvServices.Add(GetDataFromGui()));
            LoadDGridCH(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = idWhenClick;
            MessageBox.Show(_cvServices.Update(temp));
            LoadDGridCH(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = idWhenClick;
            MessageBox.Show(_cvServices.Delete(temp));
            LoadDGridCH(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Id = idWhenClick;
            MessageBox.Show(_cvServices.Clear(temp));
            LoadDGridCH(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.Lấy được row index khi người dùng bấm
            int rowIndex = e.RowIndex;
            if (rowIndex == _cvServices.GetAlls(null).Count) return;
            //2. Lấy được khóa chính trên grid
            idWhenClick = Guid.Parse(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());

            //3. TÌm đối tượng theo id
            var obj = _cvServices.GetAlls().FirstOrDefault(x => x.Id == idWhenClick);
            txt_ma.Text = obj.Ma;
            txt_ten.Text = obj.Ten;
        }
    }
}

