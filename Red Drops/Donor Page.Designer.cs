
namespace Red_Drops
{
    partial class Donor_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDUpdateNeeded = new System.Windows.Forms.Button();
            this.btnDLogout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklblDonorSignupTOHome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Name = "label1";
            // 
            // btnDUpdateNeeded
            // 
            resources.ApplyResources(this.btnDUpdateNeeded, "btnDUpdateNeeded");
            this.btnDUpdateNeeded.Name = "btnDUpdateNeeded";
            this.btnDUpdateNeeded.UseVisualStyleBackColor = true;
            this.btnDUpdateNeeded.Click += new System.EventHandler(this.btnDUpdateNeeded_Click);
            // 
            // btnDLogout
            // 
            resources.ApplyResources(this.btnDLogout, "btnDLogout");
            this.btnDLogout.Name = "btnDLogout";
            this.btnDLogout.UseVisualStyleBackColor = true;
            this.btnDLogout.Click += new System.EventHandler(this.btnDLogout_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Red_Drops.Properties.Resources.rsz_2pic;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Red_Drops.Properties.Resources.resized_image_Promo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // linklblDonorSignupTOHome
            // 
            this.linklblDonorSignupTOHome.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.linklblDonorSignupTOHome, "linklblDonorSignupTOHome");
            this.linklblDonorSignupTOHome.Name = "linklblDonorSignupTOHome";
            this.linklblDonorSignupTOHome.TabStop = true;
            this.linklblDonorSignupTOHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDonorSignupTOHome_LinkClicked);
            // 
            // Donor_Page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.linklblDonorSignupTOHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDLogout);
            this.Controls.Add(this.btnDUpdateNeeded);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Donor_Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDUpdateNeeded;
        private System.Windows.Forms.Button btnDLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel linklblDonorSignupTOHome;
    }
}