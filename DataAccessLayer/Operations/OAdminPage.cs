using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OAdminPage:IOCrude
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";

       

        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string q = "select Name,Contact_Number from Atable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, connection);
            connection.Close();
            return sqlDataAdapter;

        }

        public int Update(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        int IOCrude.Insert(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        public void Insert(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        public int Insert(EAdmin eAdmin)
        {
            throw new NotImplementedException();
        }

        public int Insert(ERecipient eRecipient, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        public SqlDataAdapter Search(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

    }
}
