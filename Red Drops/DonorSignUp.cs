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
    public partial class DonorSignUp : Form
    {
        public DonorSignUp()
        {
            InitializeComponent();
        }

        private void linklblDBackToUserCatagorySelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
        }

        public void btnInsert_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePickerDDob.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - dob;
            txtDAge.Text = (timeSpan.TotalDays / 365).ToString("0");

            if (string.IsNullOrWhiteSpace(txtDName.Text))
            {
                MessageBox.Show("Enter  Name !!!");
                txtDName.Select();
            }
            else if (dateTimePickerDDob.Value == null)
            {
                MessageBox.Show("Select Date of birth !!!");
                dateTimePickerDDob.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbDSex.Text))
            {
                MessageBox.Show("Select Sex !!!");
                cmbDSex.Select();
            }

            else if (string.IsNullOrWhiteSpace(txtDNidNum.Text))
            {
                MessageBox.Show("Enter  Nid Number !!!");
                txtDNidNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDContactNum.Text))
            {
                MessageBox.Show("Enter  Contact Number !!!");
                txtDContactNum.Select();
            }
            
            else if (string.IsNullOrWhiteSpace(cmbDBloodGroup.Text))
            {
                MessageBox.Show("Select Your Blood Group !!!");
                cmbDBloodGroup.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDHouseNo.Text))
            {
                MessageBox.Show("Enter  House Number !!!");
                txtDHouseNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDRoadNo.Text))
            {
                MessageBox.Show("Enter  Road Number !!!");
                txtDRoadNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDPO.Text))
            {
                MessageBox.Show("Enter  Post Office !!!");
                txtDPO.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbDDistrict.Text))
            {
                MessageBox.Show("Select Your District !!!");
                cmbDDistrict.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDPassword.Text))
            {
                MessageBox.Show("Set Password !!!");
                txtDPassword.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDays.Text))
            {
                MessageBox.Show("Enter  how long ago you gave blood !!!");
                txtDays.Select();
            }
            else
            {
                try
                {
                    EDonor eDonor = new EDonor();
                    EAddress eAddress = new EAddress();
                    ODonorSignUp oDonorSignUp = new ODonorSignUp();
                    eDonor.Name = this.txtDName.Text;
                    eDonor.DateOfBirth = this.dateTimePickerDDob.Text;
                    eDonor.Sex = this.cmbDSex.Text;
                    eDonor.Age = int.Parse(txtDAge.Text);
                    eDonor.NidNum = this.txtDNidNum.Text;
                    eDonor.ContactNum = this.txtDContactNum.Text;
                    eDonor.BloodGroup = this.cmbDBloodGroup.Text;
                    eAddress.HouseNo = int.Parse(this.txtDHouseNo.Text);
                    eAddress.RoadNo = int.Parse(this.txtDRoadNo.Text);
                    eAddress.PostOffice = this.txtDPO.Text;
                    eAddress.District = this.cmbDDistrict.Text;
                    eDonor.Password = this.txtDPassword.Text;
                    eDonor.GivenBloodDays = int.Parse(this.txtDays.Text);
                    int check = oDonorSignUp.Insert(eDonor, eAddress);
                    if (check > 0)
                    {
                        MessageBox.Show("Successfully Activated Your Account! \n Please Login now as an USER!");
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted!!Please insert valid Information");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }



        private void linklblBlood_RequestTOAdminControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Homepage().Show();
            this.Hide();


        }



        private void txtDAge_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Do not enter age .Age will be automatically calculated.";
        }

        private void txtDAge_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtDPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Please enter a strong password.";
        }

        private void txtDPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePickerDDob.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - dob;
            txtDAge.Text = (timeSpan.TotalDays / 365).ToString("0");

            if (string.IsNullOrWhiteSpace(txtDName.Text))
            {
                MessageBox.Show("Enter  Name !!!");
                txtDName.Select();
            }
            else if (dateTimePickerDDob.Value == null)
            {
                MessageBox.Show("Select Date of birth !!!");
                dateTimePickerDDob.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbDSex.Text))
            {
                MessageBox.Show("Select Sex !!!");
                cmbDSex.Select();
            }

            else if (string.IsNullOrWhiteSpace(txtDNidNum.Text))
            {
                MessageBox.Show("Enter  Nid Number !!!");
                txtDNidNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDContactNum.Text))
            {
                MessageBox.Show("Enter  Contact Number !!!");
                txtDContactNum.Select();
            }
            
            else if (string.IsNullOrWhiteSpace(cmbDBloodGroup.Text))
            {
                MessageBox.Show("Select Your Blood Group !!!");
                cmbDBloodGroup.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDHouseNo.Text))
            {
                MessageBox.Show("Enter  House Number !!!");
                txtDHouseNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDRoadNo.Text))
            {
                MessageBox.Show("Enter  Road Number !!!");
                txtDRoadNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDPO.Text))
            {
                MessageBox.Show("Enter  Post Office !!!");
                txtDPO.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbDDistrict.Text))
            {
                MessageBox.Show("Select Your District !!!");
                cmbDDistrict.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDPassword.Text))
            {
                MessageBox.Show("Set Password !!!");
                txtDPassword.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDays.Text))
            {
                MessageBox.Show("Enter  how long ago you gave blood !!!");
                txtDays.Select();
            }
            else
            {
                try
                {
                    EDonor eDonor = new EDonor();
                    EAddress eAddress = new EAddress();
                    ODonorSignUp oDonorSignUp = new ODonorSignUp();
                    eDonor.Name = this.txtDName.Text;
                    eDonor.DateOfBirth = this.dateTimePickerDDob.Text;
                    eDonor.Sex = this.cmbDSex.Text;
                    eDonor.Age = int.Parse(txtDAge.Text);
                    eDonor.NidNum = this.txtDNidNum.Text;
                    eDonor.ContactNum = this.txtDContactNum.Text;
                    eDonor.BloodGroup = this.cmbDBloodGroup.Text;
                    eAddress.HouseNo = int.Parse(this.txtDHouseNo.Text);
                    eAddress.RoadNo = int.Parse(this.txtDRoadNo.Text);
                    eAddress.PostOffice = this.txtDPO.Text;
                    eAddress.District = this.cmbDDistrict.Text;
                    eDonor.Password = this.txtDPassword.Text;
                    eDonor.GivenBloodDays = int.Parse(this.txtDays.Text);
                    int check = oDonorSignUp.Update(eDonor, eAddress);
                    if (check > 0)
                    {
                        MessageBox.Show("Successfully Updated!");
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Updated!!Please insert valid Information");
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

