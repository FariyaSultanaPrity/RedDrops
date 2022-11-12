
namespace Red_Drops
{
    partial class Admin_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBloodRequest = new System.Windows.Forms.Button();
            this.btnSearchOrSeeDonor = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnShowAdmin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklblDonorSignupTOHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Control";
            // 
            // btnBloodRequest
            // 
            this.btnBloodRequest.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBloodRequest.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodRequest.Location = new System.Drawing.Point(4, 170);
            this.btnBloodRequest.Name = "btnBloodRequest";
            this.btnBloodRequest.Size = new System.Drawing.Size(311, 45);
            this.btnBloodRequest.TabIndex = 81;
            this.btnBloodRequest.Text = "See All Blood Request";
            this.btnBloodRequest.UseVisualStyleBackColor = false;
            this.btnBloodRequest.Click += new System.EventHandler(this.btnBloodRequest_Click);
            // 
            // btnSearchOrSeeDonor
            // 
            this.btnSearchOrSeeDonor.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearchOrSeeDonor.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrSeeDonor.Location = new System.Drawing.Point(310, 170);
            this.btnSearchOrSeeDonor.Name = "btnSearchOrSeeDonor";
            this.btnSearchOrSeeDonor.Size = new System.Drawing.Size(294, 45);
            this.btnSearchOrSeeDonor.TabIndex = 82;
            this.btnSearchOrSeeDonor.Text = "Search/See Donor";
            this.btnSearchOrSeeDonor.UseVisualStyleBackColor = false;
            this.btnSearchOrSeeDonor.Click += new System.EventHandler(this.btnSearchOrSeeDonor_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1448, 170);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(269, 45);
            this.btnLogout.TabIndex = 83;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(623, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 348);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.Visible = false;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddAdmin.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.Location = new System.Drawing.Point(599, 170);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(287, 45);
            this.btnAddAdmin.TabIndex = 85;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdmin.Location = new System.Drawing.Point(1161, 170);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(287, 45);
            this.btnDeleteAdmin.TabIndex = 86;
            this.btnDeleteAdmin.Text = "Delete Admin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnShowAdmin
            // 
            this.btnShowAdmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnShowAdmin.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAdmin.Location = new System.Drawing.Point(881, 170);
            this.btnShowAdmin.Name = "btnShowAdmin";
            this.btnShowAdmin.Size = new System.Drawing.Size(287, 45);
            this.btnShowAdmin.TabIndex = 87;
            this.btnShowAdmin.Text = "Show All Admin";
            this.btnShowAdmin.UseVisualStyleBackColor = false;
            this.btnShowAdmin.Click += new System.EventHandler(this.btnShowAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Red_Drops.Properties.Resources.rsz_2pic;
            this.pictureBox2.Location = new System.Drawing.Point(1606, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 133);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Red_Drops.Properties.Resources.resized_image_Promo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // linklblDonorSignupTOHome
            // 
            this.linklblDonorSignupTOHome.BackColor = System.Drawing.Color.RosyBrown;
            this.linklblDonorSignupTOHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblDonorSignupTOHome.LinkColor = System.Drawing.Color.Black;
            this.linklblDonorSignupTOHome.Location = new System.Drawing.Point(1601, 724);
            this.linklblDonorSignupTOHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblDonorSignupTOHome.Name = "linklblDonorSignupTOHome";
            this.linklblDonorSignupTOHome.Size = new System.Drawing.Size(99, 44);
            this.linklblDonorSignupTOHome.TabIndex = 89;
            this.linklblDonorSignupTOHome.TabStop = true;
            this.linklblDonorSignupTOHome.Text = "Back ";
            this.linklblDonorSignupTOHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDonorSignupTOHome_LinkClicked);
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1772, 791);
            this.Controls.Add(this.linklblDonorSignupTOHome);
            this.Controls.Add(this.btnShowAdmin);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearchOrSeeDonor);
            this.Controls.Add(this.btnBloodRequest);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Admin_page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBloodRequest;
        private System.Windows.Forms.Button btnSearchOrSeeDonor;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnShowAdmin;
        private System.Windows.Forms.LinkLabel linklblDonorSignupTOHome;
    }
}