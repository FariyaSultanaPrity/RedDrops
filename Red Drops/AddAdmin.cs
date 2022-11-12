using DataAccessLayer.Entities;
using DataAccessLayer.Operations;
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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_page().Show();
            this.Hide();
        }

        private void btnAInsert_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAName.Text))
            {
                MessageBox.Show("Enter  Name !!!");
                txtAName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtANidNum.Text))
            {
                MessageBox.Show("Enter  Nid Number !!!");
                txtANidNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAContactNum.Text))
            {
                MessageBox.Show("Enter  Contact Number !!!");
                txtAContactNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAPassword.Text))
            {
                MessageBox.Show("Set Password !!!");
                txtAPassword.Select();
            }
            else
            {
                try
                {

                    EAdmin eAdmin = new EAdmin();
                    OAddAdmin oAddAdmin = new OAddAdmin();
                    eAdmin.Name = this.txtAName.Text;
                    eAdmin.NidNum = this.txtANidNum.Text;
                    eAdmin.ContactNum = this.txtAContactNum.Text;
                    eAdmin.Password = this.txtAPassword.Text;

                    int check = oAddAdmin.Insert(eAdmin);
                    if (check > 0)
                    {
                        MessageBox.Show("Successfully Added!");
                        new Admin_page().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted!!Please insert valid Information");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
        }
        }
    }
}
