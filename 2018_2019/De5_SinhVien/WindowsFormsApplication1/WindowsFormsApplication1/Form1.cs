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
            dgvsinhvien.DataSource = Xuly.ExcuteQuery("SELECT MaSV,Hoten, Ngaysinh,Gioitinh,Quequan,Malop FROM SINH_VIEN");
            cbmalop.DataSource = Xuly.ExcuteQuery("SELECT * FROM LOP");
            cbmalop.DisplayMember = "Malop";
            if (trangthai == 0)
            {

                btnthem.Enabled = btnxoa.Enabled = btnsua.Enabled = bnttim.Enabled = radonam.Checked = radonu.Checked = true;

            }
        }
        void LoadBInding()
        {
            txtmasv.DataBindings.Add("Text", dgvsinhvien.DataSource, "MaSV");
            txtten.DataBindings.Add("Text", dgvsinhvien.DataSource, "Hoten");
            date.DataBindings.Add("Text", dgvsinhvien.DataSource, "Ngaysinh");
            txtquequan.DataBindings.Add("Text", dgvsinhvien.DataSource, "Quequan");
            cbmalop.DataBindings.Add("Text", dgvsinhvien.DataSource, "Malop");


        }
        void NgatBinding()
        {
            txtmasv.DataBindings.Clear();
            txtten.DataBindings.Clear();
             date.DataBindings.Clear();
            txtquequan.DataBindings.Clear();
            cbmalop.DataBindings.Clear();
        }
        int trangthai = 0;

       

        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmasv.Text = txtquequan.Text = txtten.Text = "";
            btnthem.Enabled = btnxoa.Enabled = btnsua.Enabled = bnttim.Enabled =radonam.Checked=radonu.Checked= false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnxoa.Enabled = btnsua.Enabled = bnttim.Enabled =  radonam.Checked = radonu.Checked = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("DELETE from SINH_VIEN WHERE MaSV='" + txtmasv.Text + "'");
            LoadData();
            LoadBInding();

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
                else {
                    gt = "1";
                }
                Xuly.ExcuteQuery("INSERT INTO SINH_VIEN(MaSV, Hoten,Ngaysinh,Gioitinh,Quequan,Malop)"
                                +"VALUES ('"+txtmasv.Text+"','"+txtten.Text+"','"+date.Value+"',"+gt+",'"+txtquequan.Text+"','"+cbmalop.Text+"')");
            }
            if (trangthai == 2)
            { 
                string gt = "";
                if (radonam.Checked)
                {
                    gt = "0";
                }
                else {
                    gt = "1";
                }
                Xuly.ExcuteQuery("UPDATE SINH_VIEN SET  Hoten='"+txtten.Text+"',Ngaysinh='"+date.Value+"',Gioitinh="+gt+",Quequan='"+txtquequan.Text+"',Malop='"+cbmalop.Text+"' "
                                  + "WHERE MaSV='"+txtmasv.Text+"'");
            }
            trangthai = 0;
            LoadData();
            LoadBInding();
        }

        private void bnttim_Click(object sender, EventArgs e)
        {
            NgatBinding();
            dgvsinhvien.DataSource = Xuly.ExcuteQuery("SELECT *FROM ten WHERE Hoten LIKE '%"+txttim.Text+"%'");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
