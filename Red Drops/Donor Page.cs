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
    public partial class Donor_Page : Form
    {
        public Donor_Page()
        {
            InitializeComponent();
        }

        private void btnDLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnDUpdateNeeded_Click(object sender, EventArgs e)
        {
            new DonorSignUp().Show();
            this.Hide();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DeleteAccount().Show();
            this.Hide();
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
