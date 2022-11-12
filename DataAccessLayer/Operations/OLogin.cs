using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OLogin : IOLogin
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";

        public int AdminLogin(EAdmin eAdmin)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "select * from ATable where Nid_Number='" + eAdmin.NidNum + "' and Password='" + eAdmin.Password + "'";

                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                check = dt.Rows.Count;

                connection.Close();

                return check;


            }
            else
            {
                return check;
            }
        }

       

        public int DonorLogin(EDonor eDonor)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "select * from DTable where Nid_Number='" + eDonor.NidNum + "' and Password='" + eDonor.Password + "'";

                SqlCommand cmd = new SqlCommand(q, connection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                check = dt.Rows.Count;

                connection.Close();

                return check;


            }
            else
            {
                return check;
            }
        }

        public int DonorLogin()
        {
            throw new NotImplementedException();
        }
    }
}

