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
            dgvxe.DataSource = Xuly.ExcuteQuery("select Maxe,Tenxe,Laixe,Phuxe,Socho,Tinhtrang from XE");
            if (trangthai == 0)
            {
                btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radoxedi.Checked = radoxecho.Checked = true;
            }
        }
        void LoadBinding()
        {
            txtmaxe.DataBindings.Add("Text", dgvxe.DataSource, "Maxe");
            txttenxe.DataBindings.Add("Text", dgvxe.DataSource, "Tenxe");
            txtlaixe.DataBindings.Add("Text", dgvxe.DataSource, "Laixe");
            txtphuxe.DataBindings.Add("Text", dgvxe.DataSource, "Phuxe");
            txtsocho.DataBindings.Add("Text", dgvxe.DataSource, "Socho");

        }
        void NgatBinding()
        {
            txtmaxe.DataBindings.Clear();
            txttenxe.DataBindings.Clear();
            txtlaixe.DataBindings.Clear();
            txtphuxe.DataBindings.Clear();
            txtsocho.DataBindings.Clear();

        }
        int trangthai=0;
        private void btnthem_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 1;
            txtmaxe.Text = txttenxe.Text = txtlaixe.Text = txtphuxe.Text = txtsocho.Text = "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radoxedi.Checked = radoxecho.Checked = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 2;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = btntim.Enabled = radoxedi.Checked = radoxecho.Checked = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            NgatBinding();
            trangthai = 3;
            Xuly.ExcuteQuery("DELETE FROM XE WHERE Maxe='"+txtmaxe.Text+"'");
            trangthai = 0;
            LoaData();
            LoadBinding();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (trangthai == 1)
            {
                string tt = "";
                if (radoxecho.Checked)
                {
                    tt = "0";
                }
                else 
                {
                    tt = "1";

                }
                Xuly.ExcuteQuery("INSERT INTO XE(Maxe,Tenxe,Laixe,Phuxe,Socho,Tinhtrang)"
                            +"VALUES ('"+txtmaxe.Text+"','"+txttenxe.Text+"','"+txtlaixe.Text+"','"+txtphuxe.Text+"',"+txtsocho.Text+","+tt+")");
            }
            if (trangthai == 2)
            {
                string tt = "";
                if (radoxedi.Checked)
                {
                    tt = "0";
                }
                else
                {
                    tt = "1";

                }
                Xuly.ExcuteQuery("UPDATE XE SET Tenxe='"+txttenxe.Text+"',Laixe='"+txtlaixe.Text+"',Phuxe='"+txtphuxe.Text+"',Socho="+txtsocho.Text+",Tinhtrang="+tt+" WHERE Maxe='"+txtmaxe.Text+"'");
            }
            trangthai = 0;
            LoaData();
            LoadBinding();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            NgatBinding();
            if (radotenxe.Checked)
            {
                dgvxe.DataSource = Xuly.ExcuteQuery("select * from timkiem where Tenxe LIKE '%"+txttim.Text+"%' ");

            }
            if (radolaixe.Checked)
            {
                dgvxe.DataSource = Xuly.ExcuteQuery("select * from timkiem where laixe like '%"+txttim.Text+"%'");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
