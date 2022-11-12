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
    public partial class Request_For_Blood : Form
    {
        public Request_For_Blood()
        {
            InitializeComponent();
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Homepage().Show();
            this.Hide();
        }

        
        private void btnRSubmit_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePickerRDob.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - dob;
            txtRAge.Text = (timeSpan.TotalDays / 365).ToString("0");

            if (string.IsNullOrWhiteSpace(txtRName.Text))
            {
                MessageBox.Show("Enter  Name !!!");
                txtRName.Select();
            }
            else if (dateTimePickerRDob.Value == null)
            {
                MessageBox.Show("Select Date of birth !!!");
                dateTimePickerRDob.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbRSex.Text))
            {
                MessageBox.Show("Select Sex !!!");
                cmbRSex.Select();
            }

            else if (string.IsNullOrWhiteSpace(txtRNidNum.Text))
            {
                MessageBox.Show("Enter  Nid Number !!!");
                txtRNidNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtRContactNum.Text))
            {
                MessageBox.Show("Enter  Contact Number !!!");
                txtRContactNum.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbRBloodGroup.Text))
            {
                MessageBox.Show("Select Your Blood Group !!!");
                cmbRBloodGroup.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtRHouseNo.Text))
            {
                MessageBox.Show("Enter  House Number !!!");
                txtRHouseNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtRRoadNo.Text))
            {
                MessageBox.Show("Enter  Road Number !!!");
                txtRRoadNo.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtRPO.Text))
            {
                MessageBox.Show("Enter  Post Office !!!");
                txtRPO.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbRDistrict.Text))
            {
                MessageBox.Show("Select Your District !!!");
                cmbRDistrict.Select();
            }
            else if (string.IsNullOrWhiteSpace(cmbNeedBloodGroup.Text))
            {
                MessageBox.Show("Select blood group which you need !!!");
                cmbNeedBloodGroup.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtBloodQuantity.Text))
            {
                MessageBox.Show("Enter  how many blood bad do you need !!!");
                txtBloodQuantity.Select();
            }
            else
            {
                try
                {

                    ERecipient eRecipient = new ERecipient();
                    EAddress eAddress = new EAddress();
                    ORequestForBlood oRequestForBlood = new ORequestForBlood();
                    eRecipient.Name = this.txtRName.Text;
                    eRecipient.DateOfBirth = this.dateTimePickerRDob.Text;
                    eRecipient.Sex = this.cmbRSex.Text;
                    eRecipient.Age = int.Parse(txtRAge.Text);
                    eRecipient.NidNum = this.txtRNidNum.Text;
                    eRecipient.ContactNum = this.txtRContactNum.Text;
                    eRecipient.BloodGroup = this.cmbRBloodGroup.Text;
                    eAddress.HouseNo = int.Parse(this.txtRHouseNo.Text);
                    eAddress.RoadNo = int.Parse(this.txtRRoadNo.Text);
                    eAddress.PostOffice = this.txtRPO.Text;
                    eAddress.District = this.cmbRDistrict.Text;
                    eRecipient.NeedBloodGroup = this.cmbNeedBloodGroup.Text;
                    eRecipient.BloodQuantity = int.Parse(this.txtBloodQuantity.Text);
                    int check = oRequestForBlood.Insert(eRecipient, eAddress);
                    if (check > 0)
                    {
                        MessageBox.Show("Successfully registered!! We will contact with you as soon as possible");
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed!!Please insert valid Information");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }

            }
        }

        private void txtRAge_MouseHover_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Do not enter age .Age will be automatically calculated.";
        }

        private void txtRAge_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
