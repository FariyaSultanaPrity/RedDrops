
namespace Red_Drops
{
    partial class Blood_Request
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
            this.btnSeeAllBloodRequest = new System.Windows.Forms.Button();
            this.dataGridViewAllBloodRequest = new System.Windows.Forms.DataGridView();
            this.linklblBlood_RequestTOAdminControl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBloodRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeAllBloodRequest
            // 
            this.btnSeeAllBloodRequest.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSeeAllBloodRequest.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllBloodRequest.Location = new System.Drawing.Point(285, 125);
            this.btnSeeAllBloodRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeAllBloodRequest.Name = "btnSeeAllBloodRequest";
            this.btnSeeAllBloodRequest.Size = new System.Drawing.Size(192, 150);
            this.btnSeeAllBloodRequest.TabIndex = 3;
            this.btnSeeAllBloodRequest.Text = "See All Blood Request";
            this.btnSeeAllBloodRequest.UseVisualStyleBackColor = false;
            this.btnSeeAllBloodRequest.Click += new System.EventHandler(this.btnSeeAllBloodRequest_Click);
            // 
            // dataGridViewAllBloodRequest
            // 
            this.dataGridViewAllBloodRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllBloodRequest.Location = new System.Drawing.Point(184, 315);
            this.dataGridViewAllBloodRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAllBloodRequest.Name = "dataGridViewAllBloodRequest";
            this.dataGridViewAllBloodRequest.RowHeadersWidth = 51;
            this.dataGridViewAllBloodRequest.RowTemplate.Height = 24;
            this.dataGridViewAllBloodRequest.Size = new System.Drawing.Size(1444, 469);
            this.dataGridViewAllBloodRequest.TabIndex = 4;
            this.dataGridViewAllBloodRequest.Visible = false;
            // 
            // linklblBlood_RequestTOAdminControl
            // 
            this.linklblBlood_RequestTOAdminControl.AutoSize = true;
            this.linklblBlood_RequestTOAdminControl.BackColor = System.Drawing.SystemColors.Info;
            this.linklblBlood_RequestTOAdminControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblBlood_RequestTOAdminControl.Location = new System.Drawing.Point(1480, 858);
            this.linklblBlood_RequestTOAdminControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblBlood_RequestTOAdminControl.Name = "linklblBlood_RequestTOAdminControl";
            this.linklblBlood_RequestTOAdminControl.Size = new System.Drawing.Size(250, 29);
            this.linklblBlood_RequestTOAdminControl.TabIndex = 5;
            this.linklblBlood_RequestTOAdminControl.TabStop = true;
            this.linklblBlood_RequestTOAdminControl.Text = "Back to Admin Control";
            this.linklblBlood_RequestTOAdminControl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblBlood_RequestTOAdminControl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Red_Drops.Properties.Resources.resized_image_Promo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
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
            this.pictureBox2.Location = new System.Drawing.Point(1605, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 133);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // Blood_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1757, 898);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linklblBlood_RequestTOAdminControl);
            this.Controls.Add(this.dataGridViewAllBloodRequest);
            this.Controls.Add(this.btnSeeAllBloodRequest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Blood_Request";
            this.Text = "Blood_Request";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllBloodRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeeAllBloodRequest;
        private System.Windows.Forms.DataGridView dataGridViewAllBloodRequest;
        private System.Windows.Forms.LinkLabel linklblBlood_RequestTOAdminControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}