using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDgvDeTai();
        }
        public void loadDgvDeTai()
        {
            dgvDeTai.DataSource = Database.Query("SELECT * FROM DeTai", new Dictionary<string, object>());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string cmd = "EXEC spThemDeTai @maDT,@tenDT,@ngayBD,@ngayKT,@hoTT,@maGV";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@maDT",txbMaDeTai.Text);
            prm.Add("@tenDT",txbTenDeTai.Text);
            prm.Add("@ngayBD", dtpNgayBD.Value);
            prm.Add("@ngayKT", dtpNgayKT.Value);
            prm.Add("@hoTT", txbHoTT.Text);
            prm.Add("@maGV", txbMaGV.Text);
            try
            {
                Database.Execute(cmd, prm);
                loadDgvDeTai();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string cmd = "EXEC spSuaDeTai @maDT,@tenDT,@ngayBD,@ngayKT,@hoTT,@maGV";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@maDT", dgvDeTai.CurrentRow.Cells["colMaDeTai"].Value.ToString());
            prm.Add("@tenDT", txbTenDeTai.Text);
            prm.Add("@ngayBD", dtpNgayBD.Value);
            prm.Add("@ngayKT", dtpNgayKT.Value);
            prm.Add("@hoTT", txbHoTT.Text);
            prm.Add("@maGV", txbMaGV.Text);
            try
            {
                Database.Execute(cmd, prm);
                loadDgvDeTai();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string cmd = "DELETE DeTai WHERE MaDT = @maDT";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@maDT", dgvDeTai.CurrentRow.Cells[0].Value.ToString());
            Database.Execute(cmd, prm);
            loadDgvDeTai();
        }

        private void dgvDeTai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbMaDeTai.Text = dgvDeTai.Rows[e.RowIndex].Cells["colMaDetai"].Value.ToString();
            txbTenDeTai.Text = dgvDeTai.Rows[e.RowIndex].Cells["colTenDT"].Value.ToString();
            dtpNgayBD.Value = (DateTime)dgvDeTai.Rows[e.RowIndex].Cells["colNgayBD"].Value;
            dtpNgayKT.Value = (DateTime)dgvDeTai.Rows[e.RowIndex].Cells["colNgayKT"].Value;
            txbHoTT.Text = dgvDeTai.Rows[e.RowIndex].Cells["colHoTT"].Value.ToString();
            txbMaGV.Text = dgvDeTai.Rows[e.RowIndex].Cells["colMaGV"].Value.ToString();
        }

        private void btnFrmTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cau5 frm = new Cau5();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txbMaDeTai.Text = "";
            txbTenDeTai.Text = "";
            txbHoTT.Text = "";
            txbMaGV.Text = "";
        }
    }
}
