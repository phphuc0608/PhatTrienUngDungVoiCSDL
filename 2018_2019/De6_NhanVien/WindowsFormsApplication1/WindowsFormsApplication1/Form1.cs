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
        }
        void LoadData()
        {
            dgvnhanvien.DataSource = Xuly.ExcuteQuery("select MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT,MaPB from NHAN_VIEN");
            cbmapb.DataSource = Xuly.ExcuteQuery("SELECT *FROM PHONG_BAN");
            cbmapb.DisplayMember = "MaPB";
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = txtmanv.Enabled = true;
            }
        }
        void LoadBinding()
        {
            txtmanv.DataBindings.Add("Text", dgvnhanvien.DataSource, "MaNV");
            txtennv.DataBindings.Add("Text", dgvnhanvien.DataSource, "TenNV");
            dtngaysinh.DataBindings.Add("Text", dgvnhanvien.DataSource, "NGaysinh");
            txtphai.DataBindings.Add("Text", dgvnhanvien.DataSource, "Phai");
            txtque.DataBindings.Add("Text", dgvnhanvien.DataSource, "Quequan");
            txtsdt.DataBindings.Add("Text", dgvnhanvien.DataSource, "SDT");
            cbmapb.DataBindings.Add("Text", dgvnhanvien.DataSource, "MaPB");
        }
        void NgatBinding()
        {
            txtmanv.DataBindings.Clear();
            txtennv.DataBindings.Clear();
            dtngaysinh.DataBindings.Clear();
            txtphai.DataBindings.Clear();
            txtque.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            cbmapb.DataBindings.Clear();
        }
        int trangthai = 0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmanv.Text = txtennv.Text = txtphai.Text = txtque.Text = txtsdt.Text = dtngaysinh.Text = cbmapb.Text = "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled =txtmanv.Enabled= false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("DELETE FROM NHAN_VIEN WHERE MaNV ='" + txtmanv.Text + "'");
            LoadData();
            LoadBinding();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                Xuly.ExcuteQuery("INSERT INTO NHAN_VIEN (MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT,MaPB)"
                 + "VALUES ('"+txtmanv.Text+"','"+txtennv.Text+"','"+dtngaysinh.Text+"','"+txtphai.Text+"','"+txtque.Text+"','"+txtsdt.Text+"','"+cbmapb.Text+"')");
            }
            if (trangthai == 2)
            {
                Xuly.ExcuteQuery("UPDATE NHAN_VIEN SET TenNV='"+txtennv.Text+"', NGaysinh='"+dtngaysinh.Text+"', Phai='"+txtphai.Text+"', Quequan='"+txtque.Text+"',SDT='"+txtsdt.Text+"',MaPB='"+cbmapb.Text+"'"
                                + "WHERE MaNV ='"+txtmanv.Text+"'");
            }
            trangthai = 0;
            LoadData();
            LoadBinding();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if(radotennv.Checked)
            {
                dgvnhanvien.DataSource = Xuly.ExcuteQuery("select * from nv where TenNV LIKE '%" + txttim.Text + "%'");
            }
            if (radoque.Checked)
            {
                dgvnhanvien.DataSource = Xuly.ExcuteQuery("select * from nv where Quequan ='" + txttim.Text + "'");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
