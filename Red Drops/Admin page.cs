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
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
        }

        

        private void btnSearchOrSeeDonor_Click(object sender, EventArgs e)
        {
            new Search_Donor().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnBloodRequest_Click(object sender, EventArgs e)
        {
            new Blood_Request().Show();
            this.Hide();
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            new DeleteAccount().Show();
            this.Hide();

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            new AddAdmin().Show();
            this.Hide();
        }

        private void btnShowAdmin_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            OAdminPage oStudent = new OAdminPage();
            SqlDataAdapter sqlDataAdapter = oStudent.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void linklblDonorSignupTOHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new Login().Show();
            this.Hide();
        }
    }
    }

