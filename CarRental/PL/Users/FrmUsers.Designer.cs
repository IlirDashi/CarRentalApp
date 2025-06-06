namespace CarRental.PL.Users
{
    partial class FrmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            dgUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(133, 49);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "SHTO";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(151, 12);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(133, 49);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "MODIFIKO";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(290, 12);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(133, 49);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "FSHIJ";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(12, 67);
            dgUsers.Name = "dgUsers";
            dgUsers.Size = new Size(628, 294);
            dgUsers.TabIndex = 3;
            dgUsers.CellContentClick += dgUsers_CellContentClick;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 367);
            Controls.Add(dgUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Name = "FrmUsers";
            Text = "FrmUsers";
            Load += FrmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private DataGridView dgUsers;
    }
}