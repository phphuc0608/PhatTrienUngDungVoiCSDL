using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoaData();
            LoadBinding();
        }
        void LoaData()
        {
            dgvkh.DataSource = Xuly.ExcuteQuery(" SELECT MaKH,TenKH,CMND,Quoctich,Gioitinh,Maphong FROM KHACH_HANG");
            cbmaphong.DataSource = Xuly.ExcuteQuery("Select * FROM PHONG");
            cbmaphong.DisplayMember = "Maphong";
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radonam.Checked = radonu.Checked = true;
            }


        }
        void LoadBinding()
        {
            txtmakh.DataBindings.Add("Text", dgvkh.DataSource, "MaKH");
            txttenkh.DataBindings.Add("Text", dgvkh.DataSource, "TenKH");
            txtcmnd.DataBindings.Add("Text", dgvkh.DataSource, "CMND");
            txtquoctich.DataBindings.Add("Text", dgvkh.DataSource, "Quoctich");
            cbmaphong.DataBindings.Add("Text", dgvkh.DataSource, "Maphong");

        }
        void NgatBinding()
        {
            txtmakh.DataBindings.Clear();
            txttenkh.DataBindings.Clear();
            txtcmnd.DataBindings.Clear();
            txtquoctich.DataBindings.Clear();
            cbmaphong.DataBindings.Clear();
        }
        int trangthai = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txttenkh.Text = txtcmnd.Text = txtquoctich.Text = "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radonam.Checked = radonu.Checked = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radonam.Checked = radonu.Checked = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("delete from KHACH_HANG WHERE MaKH=" + txtmakh.Text);
            trangthai = 0;
            LoaData();
            LoadBinding();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                string gt = "";
                if (radonam.Checked)
                {
                    gt = "0";
                }
                else
                {
                    gt = "1";
                }
                Xuly.ExcuteQuery("INSERT INTO KHACH_HANG(TenKH,CMND,Quoctich,Gioitinh,Maphong ) "
                            + "VALUES ('" + txttenkh.Text + "','" + txtcmnd.Text + "','" + txtquoctich.Text + "'," + gt + ",'" + cbmaphong.Text + "')");
            }
            if (trangthai == 2)
            {
                string gt = "";
                if (radonam.Checked)
                {
                    gt = "0";
                }
                else
                {
                    gt = "1";
                }
                Xuly.ExcuteQuery("UPDATE KHACH_HANG SET TenKH='" + txttenkh.Text + "',CMND='" + txtcmnd.Text + "',Quoctich='" + txtquoctich.Text + "',Gioitinh=" + gt + ",Maphong='" + cbmaphong.Text + "' WHERE  MaKH='" + txtmakh.Text + "'");
            }
            trangthai = 0;
            LoaData();
            LoadBinding();


        }

        private void btntim_Click(object sender, EventArgs e)
        {
            NgatBinding();
            dgvkh.DataSource = Xuly.ExcuteQuery("select * from kh where TenKH LIKE '%" + txttim.Text + "%'");

        }
    }
}
