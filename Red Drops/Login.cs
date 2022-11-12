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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DonorSignUp().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Homepage().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                        OLogin oLogin = new OLogin();
                        eAdmin.NidNum = txtId.Text;
                        eAdmin.Password = txtPassword.Text;
                        int check = oLogin.AdminLogin(eAdmin);
                        if (check > 0)
                        {
                            MessageBox.Show("Successfully  Login!!");
                            new Admin_page().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!!Please enter valid Information");
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
                        OLogin oLogin = new OLogin();
                        eDonor.NidNum = txtId.Text;
                        eDonor.Password = txtPassword.Text;
                        int check = oLogin.DonorLogin(eDonor);
                        if (check > 0)
                        {
                            MessageBox.Show("Successfully  Login!!");
                            new Donor_Page().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!!Please enter valid Information");
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
