using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class OSearchDonor:IOCrude
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";
        public SqlDataAdapter Show()
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string q = "select Name,Date_of_birth,Sex,Age,Contact_Number,Blood_Group,House_No,Road_No,Post_Office,District,Days_given_blood from Dtable";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, connection);
            connection.Close();
            return sqlDataAdapter;

        }
        public SqlDataAdapter Search(EDonor eDonor,EAddress eAddress)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string q = "select Name,Date_of_birth,Sex,Age,Contact_Number,Blood_Group,House_No,Road_No,Post_Office,District,Days_given_blood from Dtable where District='"+eAddress.District+"'  and Blood_group='"+eDonor.BloodGroup+"' ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, connection);
            connection.Close();
            return sqlDataAdapter;

        }

        public int Insert(EAdmin eAdmin)
        {
            throw new NotImplementedException();
        }

        public int Insert(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }

        public int Insert(ERecipient eRecipient, EAddress eAddress)
        {
            throw new NotImplementedException();
        }


        public int Update(EDonor eDonor, EAddress eAddress)
        {
            throw new NotImplementedException();
        }
    }
}
