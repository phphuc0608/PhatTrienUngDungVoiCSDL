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
    public partial class Cau5 : Form
    {
        public Cau5()
        {
            InitializeComponent();
            loadDgvDeTai();
        }
        public void loadDgvDeTai()
        {
            dgvDeTai.DataSource = Database.Query("SELECT * FROM DeTai", new Dictionary<string, object>());
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string strQuery = "SELECT * FROM dbo.ufTimKiemDeTai(@tenDT,@tenGV)";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            if (chbTenDT.Checked)
            {
                prm.Add("@tenDT", txbTenDT.Text);
                
            }
            else
            {
                prm.Add("@tenDT", "");
                
            }
            
            if (chbTenGV.Checked)
            {
                prm.Add("@tenGV", txbTenGV.Text);
            }
            else
            {
                prm.Add("tenGV", "");
            }
            
            DataTable table = Database.Query(strQuery, prm);
            dgvDeTai.DataSource = table;
        }
    }
}
