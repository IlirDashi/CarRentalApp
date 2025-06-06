namespace CarRental.PL.Users
{
    partial class FrmAddEditUSer
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCel = new MaskedTextBox();
            cbxRole = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 23);
            txtName.TabIndex = 0;
            
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(316, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Anullo";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(132, 263);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(195, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Ruaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 7;
            label1.Text = "Emri i Plote";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Nr.Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 11;
            label5.Text = "Roli";
            // 
            // txtCel
            // 
            txtCel.Location = new Point(12, 76);
            txtCel.Mask = "(355) 60 0000 000";
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(315, 23);
            txtCel.TabIndex = 12;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Location = new Point(12, 232);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(315, 23);
            cbxRole.TabIndex = 13;
            // 
            // FrmAddEditUSer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 315);
            Controls.Add(cbxRole);
            Controls.Add(txtCel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "FrmAddEditUSer";
            Text = "FrmAddEditUSer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtCel;
        private ComboBox cbxRole;
    }
}