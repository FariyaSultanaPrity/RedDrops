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
    public partial class Blood_Request : Form
    {
        public Blood_Request()
        {
            InitializeComponent();
        }

        private void linklblBlood_RequestTOAdminControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_page().Show();
            this.Hide();
        }

        private void btnSeeAllBloodRequest_Click(object sender, EventArgs e)
        {
            dataGridViewAllBloodRequest.Visible = true;
           
            OBloodRequest oBloodRequest = new OBloodRequest();
            SqlDataAdapter sqlDataAdapter = oBloodRequest.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewAllBloodRequest.DataSource = dataTable;

        }
    }
}
