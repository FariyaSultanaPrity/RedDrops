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
    public partial class About_Us : Form
    {
        public About_Us()
        {
            InitializeComponent();
        }

        private void About_Us_Load(object sender, EventArgs e)
        {

        }

        private void linklblHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Homepage().Show();
            this.Hide();
        }

        
    }
}
