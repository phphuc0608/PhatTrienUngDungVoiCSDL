using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hienThiDuLieu();
        }
        public void hienThiDuLieu()
        {
            dgv_hocVien.DataSource = Database.Query("select * from HocVien", new Dictionary<string, object>());
        }

        private void but_them_Click(object sender, EventArgs e)
        {
            string command = "exec spThemHocVien @maHV,@tenHV,@ngaySinh,@tel,@maLop,@ngayVao";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@maHV", txt_maHV.Text);
            parameters.Add("@tenHV", txt_tenHV.Text);
            parameters.Add("@ngaySinh", dtp_ngaySinh.Value);
            parameters.Add("@tel", txt_tel.Text);
            parameters.Add("@maLop", txt_maLop.Text);
            parameters.Add("@ngayVao", dtp_ngayVao.Value);
            try
            {
                Database.Execute(command, parameters);
                hienThiDuLieu();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void but_xoa_Click(object sender, EventArgs e)
        {
            string command = "delete HocVien where MaHV = @maHV;";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHV", dgv_hocVien.CurrentRow.Cells[0].Value.ToString());
            Database.Execute(command, parameter);
            hienThiDuLieu();
        }
        
        private void but_sua_Click(object sender, EventArgs e)
        {
            string command = "exec spSuaHocVien @maHV,@tenHV,@ngaySinh,@tel,@maLop,@ngayVao";
            Dictionary<string, object> parameter = new Dictionary<string, object>();
            parameter.Add("@maHV", dgv_hocVien.CurrentRow.Cells["MaHV"].Value.ToString());
            parameter.Add("@tenHV", txt_tenHV.Text);
            parameter.Add("@ngaySinh", dtp_ngaySinh.Value);
            parameter.Add("@tel", txt_tel.Text);
            parameter.Add("@maLop", txt_maLop.Text);
            parameter.Add("@ngayVao", dtp_ngayVao.Value);
            try
            {
                Database.Execute(command, parameter);
                hienThiDuLieu();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv_hocVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_maLop.Text = dgv_hocVien.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
            txt_tenHV.Text = dgv_hocVien.Rows[e.RowIndex].Cells["TenHV"].Value.ToString();
            txt_tel.Text = dgv_hocVien.Rows[e.RowIndex].Cells["Tel"].Value.ToString();
            txt_maHV.Text = dgv_hocVien.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();
            dtp_ngaySinh.Value = (DateTime)dgv_hocVien.Rows[e.RowIndex].Cells["NgaySinh"].Value;
            dtp_ngayVao.Value = (DateTime)dgv_hocVien.Rows[e.RowIndex].Cells["NgayVao"].Value;
        }
    }
}
