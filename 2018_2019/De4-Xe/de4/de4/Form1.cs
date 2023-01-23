using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace de4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SBR3HCP\SQLEXPRESS;Initial Catalog=De4;Integrated Security=True");
        private void taidl()
        {
            con.Open();
            string sql = "select maxe,tenxe,laixe,phuxe,socho,case tinhtrang when 1 then N'Xe đi' else N'Xe chờ' end as tinhtrang from xe";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvxe.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taidl();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            con.Open();
            string add = "insert into xe values(@maxe,@tenxe,@laixe,@phuxe,@socho,@tinhtrang)";
            SqlCommand cmd = new SqlCommand(add, con);
            cmd.Parameters.AddWithValue("maxe", txtmaxe.Text);
            cmd.Parameters.AddWithValue("tenxe", txttenxe.Text);
            cmd.Parameters.AddWithValue("laixe", txtlaixe.Text);
            cmd.Parameters.AddWithValue("phuxe", txtphuxe.Text);
            cmd.Parameters.AddWithValue("socho", txtsocho.Text);
            if (rdxedi.Checked == true)
                cmd.Parameters.AddWithValue("tinhtrang", 1);
            else
                cmd.Parameters.AddWithValue("tinhtrang", 0);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            taidl();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            con.Open();
            string sua = "update xe set tenxe=@tenxe,laixe=@laixe,phuxe=@phuxe,socho=@socho,tinhtrang=@tinhtrang where maxe=@maxe";
            SqlCommand cmd = new SqlCommand(sua, con);
            cmd.Parameters.AddWithValue("maxe", txtmaxe.Text);
            cmd.Parameters.AddWithValue("tenxe", txttenxe.Text);
            cmd.Parameters.AddWithValue("laixe", txtlaixe.Text);
            cmd.Parameters.AddWithValue("phuxe", txtphuxe.Text);
            cmd.Parameters.AddWithValue("socho", txtsocho.Text);
            if (rdxedi.Checked == true)
                cmd.Parameters.AddWithValue("tinhtrang", 1);
            else
                cmd.Parameters.AddWithValue("tinhtrang", 0);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            taidl();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string xoa = "delete from nhattrinh where maxe=@maxe ; delete from xe where maxe=@maxe";
            SqlCommand cmd = new SqlCommand(xoa, con);
            cmd.Parameters.AddWithValue("maxe", txtmaxe.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            taidl();
            txtmaxe.Text = "";
            txttenxe.Text = "";
            txtlaixe.Text = "";
            txtphuxe.Text = "";
            txtsocho.Text = "";
            rdxedi.Checked = false;
            rdxecho.Checked = false;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Chắc không", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }

        private void dgvxe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvxe.CurrentRow.Index;
            txtmaxe.Text = dgvxe.Rows[index].Cells[0].Value.ToString();
            txttenxe.Text = dgvxe.Rows[index].Cells[1].Value.ToString();
            txtlaixe.Text = dgvxe.Rows[index].Cells[2].Value.ToString();
            txtphuxe.Text = dgvxe.Rows[index].Cells[3].Value.ToString();
            txtsocho.Text = dgvxe.Rows[index].Cells[4].Value.ToString();
            if (dgvxe.Rows[index].Cells[5].Value.ToString() == "Xe đi")
                rdxedi.Checked = true;
            else
                rdxecho.Checked = true;
        }
        private void timkiem()
        {
            con.Open();
            string tk = String.Empty;
            if (txttklaixe.Text == String.Empty)
                tk = "select maxe,tenxe,laixe,phuxe,socho,case tinhtrang when 1 then N'Xe đi' else N'Xe chờ' end as tinhtrang from xe where tenxe like N'%" + txttkten.Text + "%'";
            else if (txttkten.Text == String.Empty)
                tk = "select maxe,tenxe,laixe,phuxe,socho,case tinhtrang when 1 then N'Xe đi' else N'Xe chờ' end as tinhtrang from xe where laixe like N'%" + txttklaixe.Text + "%'";
            else
                tk = "select maxe,tenxe,laixe,phuxe,socho,case tinhtrang when 1 then N'Xe đi' else N'Xe chờ' end as tinhtrang from xe where tenxe like N'%" + txttkten.Text + "%' and laixe like N'%" + txttklaixe.Text + "%'";
            SqlCommand cmd = new SqlCommand(tk, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvxe.DataSource = dt;
        }

        private void txttkten_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void txttklaixe_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
    }
}
