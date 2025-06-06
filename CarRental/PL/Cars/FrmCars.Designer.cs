namespace CarRental.PL.Cars
{
    partial class FrmCars
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
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(133, 49);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "SHTO";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(151, 12);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(133, 49);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "MODIFIKO";
            btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(290, 12);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(133, 49);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "FSHIJ";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(12, 81);
            dgUsers.Name = "dgUsers";
            dgUsers.Size = new Size(628, 294);
            dgUsers.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.download_solid;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(464, 11);
            button1.Name = "button1";
            button1.Size = new Size(87, 50);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.file_import_solid;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(557, 12);
            button2.Name = "button2";
            button2.Size = new Size(81, 50);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 387);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Name = "FrmCars";
            Text = "FrmCars";
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private DataGridView dgUsers;
        private Button button1;
        private Button button2;
    }
}