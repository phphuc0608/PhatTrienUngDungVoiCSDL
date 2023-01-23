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
            dgvsach.DataSource = Xuly.ExcuteQuery("SELECT Masach,Tensach,Theloai,NamXB,Trangthai,MaNXB FROM SACH ");
            cbmanxb.DataSource = Xuly.ExcuteQuery("SELECT * from NXB");
            cbmanxb.DisplayMember = "MaNXB";
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = true;
            }

        }
        int trangthai = 0;
        void LoadBinding()
        {
            txtmasach.DataBindings.Add("Text", dgvsach.DataSource, "Masach");
            txttensach.DataBindings.Add("Text", dgvsach.DataSource, "Tensach");
            txttheloai.DataBindings.Add("Text", dgvsach.DataSource, "Theloai");
            txtnamxb.DataBindings.Add("Text", dgvsach.DataSource, "NamXB");
            txttrangthai.DataBindings.Add("Text", dgvsach.DataSource, "Trangthai");
            cbmanxb.DataBindings.Add("Text", dgvsach.DataSource, "MaNXB");
        }
        void NgatBinding()
        {
            txtmasach.DataBindings.Clear();
            txttensach.DataBindings.Clear();
            txttheloai.DataBindings.Clear();
            txtnamxb.DataBindings.Clear();
            txttrangthai.DataBindings.Clear();
            cbmanxb.DataBindings.Clear();

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmasach.Text =txtnamxb.Text= txttensach.Text=txttheloai.Text=txttrangthai.Text= "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = false;
            txtmasach.Enabled = true;
          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            txtmasach.Enabled = false;
            btnthem.Enabled = btnsua.Enabled =btnxoa.Enabled= false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("delete from SACH where Masach='" + txtmasach.Text + "'");
            LoadData();
            LoadBinding();
            trangthai = 0;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                Xuly.ExcuteQuery("INSERT INTO SACH(Masach,Tensach,Theloai,NamXB,MaNXB,Trangthai)"+
                                "VALUES ('"+txtmasach.Text+"','"+txttensach.Text+"','"+txttheloai.Text+"',"+txtnamxb.Text+",'"+cbmanxb.Text+"','"+txttrangthai.Text+"') ");
                MessageBox.Show("" + cbmanxb.Text, "", MessageBoxButtons.OK);
                trangthai = 0;
            }
            if (trangthai == 2)
            {
                MessageBox.Show(""+cbmanxb.Text,"",MessageBoxButtons.OK);
                Xuly.ExcuteQuery("UPDATE SACH SET Tensach='" + txttensach.Text + "',Theloai='" + txttheloai.Text + "',NamXB=" + txtnamxb.Text + ",MaNXB='" + cbmanxb.Text + "',Trangthai='" + txttrangthai.Text + "'"
                                      + "WHERE Masach='" + txtmasach.Text + "'");
                trangthai = 0;
            }
            LoadData();
            LoadBinding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdtensach.Checked)
            {
                dgvsach.DataSource = Xuly.ExcuteQuery("SELECT * FROM SACH WHERE Tensach LIKE N'%" + txttimkiem.Text + "%'");
            }
            else
            {
                dgvsach.DataSource = Xuly.ExcuteQuery("SELECT * FROM SACH WHERE NamXB = "+txttimkiem.Text);
            }

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvsach.DataSource = Xuly.ExcuteQuery("SELECT * FROM SACH WHERE Tensach LIKE N'%" + txttimkiem.Text + "%'");
        }

    }

}