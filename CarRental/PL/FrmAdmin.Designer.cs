namespace CarRental.PL
{
    partial class FrmAdmin
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
            btnProducts = new PictureBox();
            btnReports = new PictureBox();
            btnUsers = new PictureBox();
            btnExit = new PictureBox();
            btnClients = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClients).BeginInit();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Image = Properties.Resources.warehouse_solid;
            btnProducts.Location = new Point(48, 46);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(188, 113);
            btnProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            btnProducts.TabIndex = 6;
            btnProducts.TabStop = false;
            // 
            // btnReports
            // 
            btnReports.Image = Properties.Resources.chart_simple_solid;
            btnReports.Location = new Point(48, 222);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(188, 113);
            btnReports.SizeMode = PictureBoxSizeMode.StretchImage;
            btnReports.TabIndex = 7;
            btnReports.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.Image = Properties.Resources.users_gear_solid;
            btnUsers.Location = new Point(577, 46);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(188, 113);
            btnUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUsers.TabIndex = 10;
            btnUsers.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.power_off_solid;
            btnExit.Location = new Point(577, 222);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 113);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 11;
            btnExit.TabStop = false;
            // 
            // btnClients
            // 
            btnClients.Image = Properties.Resources.users_solid;
            btnClients.Location = new Point(314, 46);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(188, 113);
            btnClients.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClients.TabIndex = 12;
            btnClients.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 169);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 13;
            label1.Text = "Produkte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 169);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 14;
            label2.Text = "Kliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 348);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 16;
            label4.Text = "Raporte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, 169);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 17;
            label5.Text = "Perdorues";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(658, 348);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 18;
            label6.Text = "Dil";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClients);
            Controls.Add(btnExit);
            Controls.Add(btnUsers);
            Controls.Add(btnReports);
            Controls.Add(btnProducts);
            Name = "FrmAdmin";
            Text = "Form1";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)btnProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnProducts;
        private PictureBox btnReports;
        private PictureBox btnUsers;
        private PictureBox btnExit;
        private PictureBox btnClients;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}