using DataAccessLayer.Entities;
using DataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Drops
{
    public partial class Search_Donor : Form
    {
        public Search_Donor()
        {
            InitializeComponent();
        }

        private void linklblSearchDonorTOAdminControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_page().Show();
            this.Hide();
        }

        private void btnSearchDonor_Click(object sender, EventArgs e)
        {
            EDonor eDonor = new EDonor();
            EAddress eAddress = new EAddress();

            eAddress.District = this.cmbSearchingAddress.Text;
            eDonor.BloodGroup = this.cmbSearchingBloodGroup.Text;
            dataGridViewSelectingDonor.Visible = true;
            OSearchDonor oSearchDonor = new OSearchDonor();
            SqlDataAdapter sqlDataAdapter = oSearchDonor.Search(eDonor,eAddress);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSelectingDonor.DataSource = dataTable;
        }

        private void btnSeeDonor_Click(object sender, EventArgs e)
        {
            dataGridViewSelectingDonor.Visible = true;
           

            OSearchDonor oSearchDonor = new OSearchDonor();
            SqlDataAdapter sqlDataAdapter = oSearchDonor.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSelectingDonor.DataSource = dataTable;
        }
    }
}
