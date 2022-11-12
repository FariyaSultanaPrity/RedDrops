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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string usertype = cmbSelectUserType.Text;
            if (usertype == "Admin")
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Enter  User Id !!!");
                    txtId.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Enter your Password !!!");
                    txtPassword.Select();
                }
                else if (string.IsNullOrWhiteSpace(cmbSelectUserType.Text))
                {
                    MessageBox.Show("Select User Type !!!");
                    cmbSelectUserType.Select();
                }
                else
                {
                    try
                    {
                        EAdmin eAdmin = new EAdmin();
                        ODeleteAccount oDeleteAccount = new ODeleteAccount();
                        eAdmin.NidNum = txtId.Text;
                        eAdmin.Password = txtPassword.Text;
                        int check = oDeleteAccount.AdminDelete(eAdmin);
                        if (check > 0)
                        {
                            MessageBox.Show("Successfully  Deleted!!");
                            new Login().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" Failed!!Please enter valid Information");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Enter  User Id !!!");
                    txtId.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Enter your Password !!!");
                    txtPassword.Select();
                }
                else if (string.IsNullOrWhiteSpace(cmbSelectUserType.Text))
                {
                    MessageBox.Show("Select User Type !!!");
                    cmbSelectUserType.Select();
                }
                else
                {
                    try
                    {
                        EDonor eDonor = new EDonor();
                        ODeleteAccount oDeleteAccount = new ODeleteAccount();
                        eDonor.NidNum = txtId.Text;
                        eDonor.Password = txtPassword.Text;
                        int check = oDeleteAccount.DonorDelete(eDonor);
                        if (check > 0)
                        {
                            MessageBox.Show("Successfully Deleted!!");
                            new Donor_Page().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(" Failed!!Please enter valid Information");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }

                }
            }
        }
    }
}
