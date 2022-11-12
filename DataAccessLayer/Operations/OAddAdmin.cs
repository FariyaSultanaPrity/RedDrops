using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
   public class OAddAdmin:IOCrude
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";

       

        public int Insert(EAdmin eAdmin)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into ATable (Name,Nid_Number,Contact_Number,Password) values('" + eAdmin.Name + "','" + eAdmin.NidNum + "','" + eAdmin.ContactNum + "','" + eAdmin.Password + "') ";

                SqlCommand cmd = new SqlCommand(q, connection);
                check = cmd.ExecuteNonQuery();

                connection.Close();

                return check;


            }
            else
            {
                return check;
            }
        }

       

        public int Insert(ERecipient eRecipient, EAddress eAddress)
        {
            throw new NotImplementedException();
        }
        int IOCrude.Insert(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }


        public SqlDataAdapter Search(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        public SqlDataAdapter Show()
        {
            throw new NotImplementedException();
        }

       

        public int Update(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        
    }
}
