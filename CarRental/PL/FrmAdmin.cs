using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.PL
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_CLick(object sender, EventArgs e)
        {
            var frm = new FrmClients();
            frm.ShowDialog();
        }

        private void btnVendors_CLick(object sender, EventArgs e)
        {
            var frm = new FrmVendors();
            frm.ShowDialog();
        }

        private void btnProducts_CLick(object sender, EventArgs e)
        {
            var frm = new FrmProducts();
            frm.ShowDialog();
        }
        private void btnReports_CLick(object sender, EventArgs e)
        {
            var frm = new FrmReports();
            frm.ShowDialog();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
