using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Core;

namespace CarRental.PL.Users
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
            FillUsers();
        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddEditUSer();
            frm.FormClosed += FrmAddEditUSer_FormClosed;
            frm.Show();
        }

        private void FrmAddEditUSer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FillUsers();
        }

        private void FillUsers()
        {
            dgUsers.DataSource = null;
            dgUsers.DataSource = Program.PersonsManager.GetAll();
            dgUsers.Columns[nameof(Person.Id)].Visible = false;
            dgUsers.Columns[nameof(Person.Password)].Visible = false;
            dgUsers.Columns[nameof(Person.FullName)].HeaderText = "Emri";
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 1)
            {

                btnEditUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
            else
            {
                btnEditUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgUsers.SelectedRows[0].Cells[nameof(Person.Id)].Value.ToString());
            var frm = new FrmAddEditUSer(id);
            frm.FormClosed += FrmAddEditUSer_FormClosed;
            frm.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgUsers.SelectedRows[0].Cells[nameof(Person.Id)].Value.ToString());
            var user = Program.PersonsManager.GetById(id);
            var confirmResult = MessageBox.Show("Jeni i sigurte qe doni te fshini perdoruesin: "
                                + user.FullName, "Kujdes!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Program.PersonsManager.Delete(user);
                FillUsers();
            }
        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
