using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đề1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            if (trangthai == 0)
            {
                btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = true;
                txtmabn.Text = "";
                txtten.Text = "";
                rdonam.Checked = rdonu.Checked = false;
                txtdiachi.Text = "";
            }
            dgvbenhnhan.DataSource = Xuly.ExcuteQuery("SELECT Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien FROM BENH_NHAN");
        }
        void LoadBinding()
        {
            txtmabn.DataBindings.Add(new Binding("Text", dgvbenhnhan.DataSource, "Mabn"));
            txtten.DataBindings.Add(new Binding("Text", dgvbenhnhan.DataSource, "Tenbn"));
            dateTimePicker1.DataBindings.Add(new Binding("Text", dgvbenhnhan.DataSource, "Ngaysinh"));
            txtdiachi.DataBindings.Add(new Binding("Text", dgvbenhnhan.DataSource, "Diachi"));
            dateTimePicker2.DataBindings.Add(new Binding("Text", dgvbenhnhan.DataSource, "Ngaynhapvien"));
        }
        void NgatBinding()
        {
            txtmabn.DataBindings.Clear();
            txtten.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();
        }
        int trangthai = 0;

        private void btnthem_Click(object sender, EventArgs e)
        {
            trangthai = 1;
            btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = false;
            txtmabn.Text = "";
            txtten.Text = "";
            rdonam.Checked = rdonu.Checked = false;
            txtdiachi.Text = "";

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            LoadData();
            LoadBinding();
            trangthai = 2;
            btnsua.Enabled = btnthem.Enabled = false;
            txtmabn.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            trangthai = 3;
            NgatBinding();
            LoadData();
            LoadBinding();
            Xuly.ExcuteQuery("delete from BENH_NHAN where Mabn='" + txtmabn.Text + "'");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                trangthai = 0;
                string gt = "";
                if (rdonam.Checked)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }
                Xuly.ExcuteQuery("INSERT INTO BENH_NHAN(Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien)" +
                "VALUES ('" + txtmabn.Text + "','" + txtten.Text + "','" + dateTimePicker1.Value + "','" + gt + "','" + txtdiachi.Text + "','" + dateTimePicker2.Value + "')");
                LoadData();
            }
            if (trangthai == 2)
            {
                txtmabn.Enabled = true;
                trangthai = 0;
                string gt = "";
                if (rdonam.Checked)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }

                Xuly.ExcuteQuery("update BENH_NHAN set Tenbn = N'" + txtten.Text + "', Ngaysinh='" + dateTimePicker1.Value + "' , Gioitinh='" + gt + "' , Diachi='" 
                    + txtdiachi.Text + "' , Ngaynhapvien='" + dateTimePicker2.Value + "'where Mabn='" + txtmabn.Text + "'");
                LoadData();
            }
            if (trangthai == 4)
            {
                trangthai = 0;
                btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = btntimkiem.Enabled = true;
                txtmabn.Enabled = txtdiachi.Enabled = true;
                dgvbenhnhan.DataSource = Xuly.ExcuteQuery("SELECT Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien FROM BENH_NHAN WHERE Tenbn LIKE N'%" + txtten.Text + "%' AND Ngaynhapvien LIKE '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'");
            }
            LoadBinding();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            trangthai = 4;
            btnsua.Enabled = btnthem.Enabled = btnxoa.Enabled = btntimkiem.Enabled = false;
            txtmabn.Enabled = txtdiachi.Enabled = false;
            MessageBox.Show("Tích nút lưu để tìm kiếm", "Thông báo", MessageBoxButtons.OK);
        }
        private void txtten_TextChanged(object sender, EventArgs e)
        {
            dgvbenhnhan.DataSource = Xuly.ExcuteQuery("SELECT * FROM BENH_NHAN WHERE Tenbn LIKE N'%" + txtten.Text + "%' AND Ngaynhapvien = '" + dateTimePicker2.Value.ToString("MM-dd-yyyy") + "'");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
