using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Drops
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DonorSignUp().Show();
            this.Hide();
        }

       
       

       

       

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            new About_Us().Show();
            this.Hide();
        }

        private void btnRequestForBlood_Click(object sender, EventArgs e)
        {   
            new Request_For_Blood().Show();
            this.Hide();
        }

        private void btnDonateBlood_Click(object sender, EventArgs e)
        {
            new DonorSignUp().Show();
           
            this.Hide();
        

        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
           
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_page().Show();
            this.Hide();
        }

        
    }
}
