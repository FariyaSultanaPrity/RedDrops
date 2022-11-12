
namespace Red_Drops
{
    partial class DeleteAccount
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.linklblDonorSignupTOHome = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectUserType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Red_Drops.Properties.Resources.resized_image_Promo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Red_Drops.Properties.Resources.rsz_2pic;
            this.pictureBox2.Location = new System.Drawing.Point(1699, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 133);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.BackColor = System.Drawing.SystemColors.Info;
            this.lblDeleteAccount.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(708, 110);
            this.lblDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(470, 79);
            this.lblDeleteAccount.TabIndex = 82;
            this.lblDeleteAccount.Text = "Delete Account";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(848, 571);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 48);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Text = "Confirm";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(656, 431);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(297, 46);
            this.txtPassword.TabIndex = 86;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(656, 334);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(297, 48);
            this.txtId.TabIndex = 85;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(355, 422);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(195, 31);
            this.lblPassword.TabIndex = 84;
            this.lblPassword.Text = "Enter Password:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(441, 334);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(109, 31);
            this.lblId.TabIndex = 83;
            this.lblId.Text = "Enter Id:";
            // 
            // linklblDonorSignupTOHome
            // 
            this.linklblDonorSignupTOHome.BackColor = System.Drawing.Color.RosyBrown;
            this.linklblDonorSignupTOHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblDonorSignupTOHome.Location = new System.Drawing.Point(1612, 846);
            this.linklblDonorSignupTOHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblDonorSignupTOHome.Name = "linklblDonorSignupTOHome";
            this.linklblDonorSignupTOHome.Size = new System.Drawing.Size(101, 40);
            this.linklblDonorSignupTOHome.TabIndex = 88;
            this.linklblDonorSignupTOHome.TabStop = true;
            this.linklblDonorSignupTOHome.Text = "Back ";
            this.linklblDonorSignupTOHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDonorSignupTOHome_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1043, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 89;
            this.label1.Text = "Select User Type:";
            // 
            // cmbSelectUserType
            // 
            this.cmbSelectUserType.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Donor"});
            this.cmbSelectUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectUserType.FormattingEnabled = true;
            this.cmbSelectUserType.Items.AddRange(new object[] {
            "Admin",
            "Donor"});
            this.cmbSelectUserType.Location = new System.Drawing.Point(1270, 383);
            this.cmbSelectUserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSelectUserType.Name = "cmbSelectUserType";
            this.cmbSelectUserType.Size = new System.Drawing.Size(359, 33);
            this.cmbSelectUserType.TabIndex = 90;
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1849, 916);
            this.Controls.Add(this.cmbSelectUserType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblDonorSignupTOHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDeleteAccount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteAccount";
            this.Text = "Delete Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.LinkLabel linklblDonorSignupTOHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectUserType;
    }
}