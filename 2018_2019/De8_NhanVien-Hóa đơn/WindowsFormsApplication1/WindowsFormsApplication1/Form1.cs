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
            LoadData();
            LoadBinding();
        }
        void LoadData()
        {
            dgvnv.DataSource = Xuly.ExcuteQuery("select MaNV,TenNV,Ngaysinh,Phai,Diachi,SDT from NHAN_VIEN");
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radonam.Checked = radonu.Checked = txtmanv.Enabled = true;
            }
        }
        void LoadBinding()
        {
            txtmanv.DataBindings.Add("Text", dgvnv.DataSource, "MaNV");
            txttennv.DataBindings.Add("Text", dgvnv.DataSource, "TenNV");
            dtngaysinh.DataBindings.Add("Text", dgvnv.DataSource, "Ngaysinh");
            txtdiachi.DataBindings.Add("Text", dgvnv.DataSource, "Diachi");
            txtsdt.DataBindings.Add("Text", dgvnv.DataSource, "SDT");
        }
        void NgatBinding()
        {
            txtmanv.DataBindings.Clear();
            txttennv.DataBindings.Clear();
            dtngaysinh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        int trangthai = 0;

        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmanv.Text = txttennv.Text = txtdiachi.Text = txtsdt.Text = "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled =btntim.Enabled= radonam.Checked = radonu.Checked = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radonam.Checked = radonu.Checked =txtmanv.Enabled =false;
            LoadBinding();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("DELETE FROM NHAN_VIEN WHERE MaNV='"+txtmanv.Text+"'");
            trangthai = 0;
            LoadData();
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
                    gt = "Nam";
                }
                else {
                    gt = "Nu";
                }
                Xuly.ExcuteQuery("insert into NHAN_VIEN (MaNV,TenNV,Ngaysinh,Phai,Diachi,SDT)"
                            +"values ('"+txtmanv.Text+"','"+txttennv.Text+"','"+dtngaysinh.Value+"','"+gt+"','"+txtdiachi.Text+"','"+txtsdt.Text+"')");
            }
            if (trangthai == 2)
            { 
                string gt = "";
                if (radonam.Checked)
                {
                    gt = "Nam";
                }
                else {
                    gt = "Nu";
                }
                Xuly.ExcuteQuery("UPDATE NHAN_VIEN SET TenNV='"+txttennv.Text+"',Ngaysinh='"+dtngaysinh.Value+"',Phai='"+gt+"',Diachi='"+txtdiachi.Text+"',SDT='"+txtsdt.Text+"' WHERE MaNV='"+txtmanv.Text+"'");
            }
            trangthai = 0;
            LoadData();
            LoadBinding();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (radoten.Checked)
            {
                dgvnv.DataSource = Xuly.ExcuteQuery("select *from nv where TenNV LIKE '%"+txttim.Text+"%'");
            }
            if (radongaysinh.Checked)
            {
                dgvnv.DataSource = Xuly.ExcuteQuery("select *from nv where Ngaysinh ='"+txttim.Text+"'");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
