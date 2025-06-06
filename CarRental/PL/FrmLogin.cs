using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Core.Common;

namespace CarRental.PL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                return;
            }
            var user = Program.PersonsManager.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Nuk ekziston nje perdorues me keto kredenciale");
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }
            Program.AuthorizedUser = user;
            if (user.Role == Constants.AdminRole)
            {
                var frm = new FrmAdmin();
                frm.Show();
                this.Hide();
            }
        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
