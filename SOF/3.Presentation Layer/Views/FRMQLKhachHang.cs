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
    public partial class FRMQLKhachHang : Form
    {
        IKhachHangService _ikhachHangService;
        Guid _idWhenClick;
        public FRMQLKhachHang()
        {
            InitializeComponent();
            _ikhachHangService = new KhachHangService();
        }
        private  KhachHangView GetData()
        {
            return new KhachHangView()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_Ten.Text,
                TenDem = txt_TenDem.Text,
                Ho = txt_Ho.Text,
                NgaySinh = dtp_NgaySinh.Value,
                Sdt = txt_Sdt.Text,
                DiaChi= txt_DiaChi.Text,
                ThanhPho = txt_ThanhPho.Text,
                QuocGia = txt_QuocGia.Text,
                MatKhau = txt_MatKhau.Text,
            };
        }
        public void LoadDgridKH(string input)
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 9;

            dgrid_KhachHang.Columns[0].Name = "STT";
            dgrid_KhachHang.Columns[1].Name = "Id";
            dgrid_KhachHang.Columns[2].Name = "Họ tên";
            dgrid_KhachHang.Columns[3].Name = "Ngày sinh";
            dgrid_KhachHang.Columns[4].Name = "Sdt";
            dgrid_KhachHang.Columns[5].Name = "Dia Chi";
            dgrid_KhachHang.Columns[6].Name = "Thành Phố";
            dgrid_KhachHang.Columns[7].Name = "Quốc Gia";
            dgrid_KhachHang.Columns[8].Name = "Mật khẩu";

            dgrid_KhachHang.Rows.Clear();
            foreach (var s in _ikhachHangService.GetAll(input))
            {
                dgrid_KhachHang.Rows.Add(stt++,s.Id,s.Ho +" " + s.TenDem +" "+s.Ten,s.NgaySinh,s.Sdt,s.DiaChi,s.ThanhPho,s.QuocGia,s.MatKhau);
            }     

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Muốn ko?", "Chắc Chắn?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dg==DialogResult.Yes)
            {
                if (txt_Sdt.Text.Length != 10 || !txt_Sdt.Text.StartsWith("0"))
                {
                    MessageBox.Show("Sai");
                }
                else
                {
                    if (txt_MatKhau.Text.Length < 8)
                    {
                        MessageBox.Show("Pass phải lớn hơn 8 kí tự");
                    }
                    else
                    {
                        MessageBox.Show(_ikhachHangService.Add(GetData()));
                        LoadDgridKH(null);

                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Muốn ko?", "Chắc Chắn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                if (txt_Sdt.Text.Length != 10 || !txt_Sdt.Text.StartsWith("0"))
                {
                    MessageBox.Show("Sai");
                }
                else
                {
                    if (txt_MatKhau.Text.Length < 8)
                    {
                        MessageBox.Show("Pass phải lớn hơn 8 kí tự");
                    }
                    else
                    {
                        MessageBox.Show(_ikhachHangService.Update(temp));
                        LoadDgridKH(null);

                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Muốn ko?", "Chắc Chắn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var temp = GetData();
            temp.Id = _idWhenClick;
            if (dg == DialogResult.Yes)
            {
                    MessageBox.Show(_ikhachHangService.Delete(temp));
                    LoadDgridKH(null);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadDgridKH(null);
        }

        private void dgrid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            if (RowIndex == -1)
            {
                return;
            }
            if(RowIndex == _ikhachHangService.GetAll().Count)
            {
                return;
            }
            _idWhenClick = Guid.Parse(dgrid_KhachHang.Rows[RowIndex].Cells[1].Value.ToString());
            var obj = _ikhachHangService.GetAll().FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ma.Text = obj.Ma;
            txt_Ho.Text = obj.Ho;
            txt_TenDem.Text = obj.TenDem;
            txt_Ten.Text = obj.Ten;
            dtp_NgaySinh.Value = obj.NgaySinh;
            txt_Sdt.Text = obj.Sdt;
            txt_DiaChi.Text = obj.DiaChi;
            txt_ThanhPho.Text = obj.ThanhPho;
            txt_QuocGia.Text = obj.QuocGia;
            txt_MatKhau.Text = obj.MatKhau;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            FRMQLKhachHang Kh = new FRMQLKhachHang();
            Kh.Show();
            this.Dispose(false);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKiem.Text) )
            {
                return;
            }
            LoadDgridKH(txt_TimKiem.Text);
        }

        private void txt_TimKiem_Leave(object sender, EventArgs e)
        {
            LoadDgridKH(null);
        }

        private void txt_TimKiem_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Text = "";
        }
    }
}
