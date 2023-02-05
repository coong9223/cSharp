using _2.BUS.Services;
using _2.BUS.IServices;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2.BUS.ViewModels;

namespace _3.Presentation_Layer.Views
{
    public partial class FRMQLNsx : Form
    {
        IQLNsxService _iNsxservice;
        Guid _idWhenClick;
        public FRMQLNsx()
        {
            InitializeComponent();
            _iNsxservice = new NsxService();
        }
        public NsxView GetData()
        {
            return new NsxView()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
            };
        }
        public void LoadDgridNsx(string input)
        {
            int stt = 1;
            dgrid_Nsx.ColumnCount = 4;
            dgrid_Nsx.Columns[0].Name = "STT";
            dgrid_Nsx.Columns[1].Name = "Id";
            dgrid_Nsx.Columns[2].Name = "Mã";
            dgrid_Nsx.Columns[3].Name = "Tên";

            dgrid_Nsx.Rows.Clear();
            foreach (var item in _iNsxservice.GetAll(input))
            {
                dgrid_Nsx.Rows.Add(stt++, item.Id, item.Ma, item.Ten);
            }

        }
        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thêm ko?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_iNsxservice.Add(GetData()));
                LoadDgridNsx(null);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn sửa ko?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_iNsxservice.Update(temp));
                LoadDgridNsx(null);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn xóa ko?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_iNsxservice.Delete(temp));
                LoadDgridNsx(null);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadDgridNsx(null);
        }

        private void dgrid_Nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == -1)
            {
                return;
            }
            if (RowIndex == _iNsxservice.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_Nsx.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _iNsxservice.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ten.Text = obj.Ten;
        }
    }
}
