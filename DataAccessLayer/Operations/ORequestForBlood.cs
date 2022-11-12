using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class ORequestForBlood:IOCrude
    {
        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";
        public int Insert(ERecipient eRecipient, EAddress eAddress)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into RTable (Name,Date_of_birth,Sex,Age,Nid_Number,Contact_Number,Blood_Group,House_No,Road_No,Post_Office,District,Need_Blood_Group,Blood_Quantity) values('" + eRecipient.Name + "','" + eRecipient.DateOfBirth + "','" + eRecipient.Sex + "','" + eRecipient.Age + "','" + eRecipient.NidNum + "','" + eRecipient.ContactNum + "','" + eRecipient.BloodGroup + "','" + eAddress.HouseNo + "','" + eAddress.RoadNo + "','" + eAddress.PostOffice + "','" + eAddress.District + "','" + eRecipient.NeedBloodGroup + "','" + eRecipient.BloodQuantity + "') ";

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

        public int Insert(EAdmin eAdmin)
        {
            throw new NotImplementedException();
        }

        public int Insert(EDonor eDonor, EAddress eAddress)
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
