using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class ODeleteAccount:IODeleteAccount
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";
        public int AdminDelete(EAdmin eAdmin)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "delete from ATable where Nid_Number= @Nid_Number and Password=@Password";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.Parameters.AddWithValue("@Nid_Number", eAdmin.NidNum);
                cmd.Parameters.AddWithValue("@Password", eAdmin.Password);

                check = cmd.ExecuteNonQuery();
                connection.Close();
                return check;
            }
            else
            {

                return check;
            }




        }

        public int DonorDelete(EDonor eDonor)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "delete from ATable where Nid_Number= @Nid_Number and Password=@Password";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.Parameters.AddWithValue("@Nid_Number", eDonor.NidNum);
                cmd.Parameters.AddWithValue("@Password", eDonor.Password);

                check = cmd.ExecuteNonQuery();
                connection.Close();
                return check;
            }
            else
            {

                return check;
            }




        }
    }
}
