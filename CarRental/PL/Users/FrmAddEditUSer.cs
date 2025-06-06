using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Core;

namespace CarRental.PL.Users
{
    public partial class FrmAddEditUSer : Form
    {
        Person _editingUser = null;
        public FrmAddEditUSer(int id = 0)
        {
            InitializeComponent();
            if (id > 0)
            {
                _editingUser = Program.PersonsManager.GetById(id);
                FillUserInfo();
            }
        }
        private void FillUserInfo()
        {
            txtName.Text = _editingUser.FullName;
            txtCel.Text = _editingUser.PhoneNo;
            txtEmail.Text = _editingUser.Email;
            cbxRole.SelectedItem = _editingUser.Role;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isInserting = false;
            if (_editingUser == null)
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Ploteso fjalekalimin");
                    _editingUser = new Person()
                    {
                        Email = txtEmail.Text,
                        FullName = txtName.Text,
                        Password = txtPassword.Text,
                        PhoneNo = txtCel.Text,
                        Role = cbxRole.SelectedItem.ToString()
                    };
                    Program.PersonsManager.AddPerson(_editingUser);
                }
                else
                {
                    string password = null;
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        password = txtPassword.Text;
                    }
                    Program.PersonsManager.Update(_editingUser.Id, new Person
                    {
                        Email = txtEmail.Text,
                        FullName = txtName.Text,
                        Password = txtPassword.Text, // or just password, check again
                        PhoneNo = txtCel.Text,
                        Role = cbxRole.SelectedItem.ToString()
                    });
                }
                Close();
            }

           
        }
    }
}
