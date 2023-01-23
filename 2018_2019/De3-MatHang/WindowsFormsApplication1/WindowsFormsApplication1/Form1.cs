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
        void LoadSoluong50()
        {
            dgvmathang.DataSource = Xuly.ExcuteQuery("SELECT Tenhang , TenCongty , Ngaynhap  FROM MAT_HANG AS a , NHA_CUNGCAP AS b, PHIEU_NHAP AS c "+
                                                    "WHERE a.MaCongty = b.MaCongty AND c.Mahang = a.Mahang AND Soluongnhap > 50 ");
        }
        void LoadData()
        {
            dgvmathang.DataSource = Xuly.ExcuteQuery("SELECT Mahang,Tenhang,Donvi,Soluong,MaCongty FROM MAT_HANG ");
            cbmacongty.DataSource = Xuly.ExcuteQuery("SELECT * FROM NHA_CUNGCAP ");
            cbmacongty.DisplayMember = "MaCongty";
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntimkiem.Enabled=txtmahnag.Enabled=true;
            }
        }
        void LoadBinding()
        {
            txtmahnag.DataBindings.Add("Text", dgvmathang.DataSource, "Mahang");
            txttenhang.DataBindings.Add("Text", dgvmathang.DataSource, "Tenhang");
            txtdonvi.DataBindings.Add("Text", dgvmathang.DataSource, "Donvi");
            txtsoluong.DataBindings.Add("Text", dgvmathang.DataSource, "Soluong");
            cbmacongty.DataBindings.Add("Text", dgvmathang.DataSource, "MaCongty");
        }
        void NgatBinding()
        {
            txtmahnag.DataBindings.Clear();
            txttenhang.DataBindings.Clear();
            txtdonvi.DataBindings.Clear();
            txtsoluong.DataBindings.Clear();
            cbmacongty.DataBindings.Clear();
        }
        int trangthai = 0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmahnag.Text = txttenhang.Text = txtdonvi.Text = txtdongia.Text = txtsoluong.Text = cbmacongty.Text = "";//
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled =btntimkiem.Enabled= false;
            //
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled =btntimkiem.Enabled=txtmahnag.Enabled= false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("DELETE FROM MAT_HANG WHERE Mahang='" + txtmahnag.Text + "'");
            trangthai = 0;
            LoadData();
            LoadBinding();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                Xuly.ExcuteQuery("INSERT INTO MAT_HANG (Mahang,Tenhang,Donvi,Soluong,MaCongty)"
                                + "VALUES ('" + txtmahnag.Text + "','" + txttenhang.Text + "'," + txtdonvi.Text + "," + txtsoluong.Text + ",'" + cbmacongty.Text + "')");
                trangthai = 0;
            }
            if (trangthai == 2)
            {
                Xuly.ExcuteQuery("UPDATE MAT_HANG SET Tenhang='" + txttenhang.Text + "',Donvi=" + txtdonvi.Text + ",Soluong=" + txtsoluong.Text + ",MaCongty='" + cbmacongty.Text + "' WHERE Mahang='" + txtmahnag.Text + "'");
              }
            trangthai = 0;
            LoadData();
            LoadBinding();


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (radioButton1.Checked)
            {
                dgvmathang.DataSource =Xuly.ExcuteQuery("SELECT * FROM HANG WHERE Tenhang LIKE '%" + txttim.Text + "%'");
                MessageBox.Show(""+txttim.Text,"");
            }
            else {

                dgvmathang.DataSource =  Xuly.ExcuteQuery("SELECT * FROM HANG WHERE Soluong = " + txttim.Text + "");
            }
            
            
        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            dgvmathang.DataSource = Xuly.ExcuteQuery("SELECT * FROM HANG WHERE Tenhang LIKE '%" + txttim.Text + "%'");
           // dgvmathang.DataSource = Xuly.ExcuteQuery("SELECT * FROM HANG WHERE Soluong = " + txttim.Text + "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
