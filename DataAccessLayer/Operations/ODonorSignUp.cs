using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public class ODonorSignUp:IOCrude
    {


        private static string conString = "Data Source=LAPTOP-BT6NTPUC;Initial Catalog=Redrops;Integrated Security=True";

        public int Insert(EDonor eDonor, EAddress eAddress)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into DTable (Name,Date_of_birth,Sex,Age,Nid_Number,Contact_Number,Blood_Group,House_No,Road_No,Post_Office,District,Password,Days_given_blood) values('" + eDonor.Name + "','" + eDonor.DateOfBirth + "','" + eDonor.Sex + "','" + eDonor.Age + "','" + eDonor.NidNum + "','" + eDonor.ContactNum + "','" + eDonor.BloodGroup + "','" + eAddress.HouseNo + "','" + eAddress.RoadNo + "','" + eAddress.PostOffice + "','" + eAddress.District + "','" + eDonor.Password + "','" + eDonor.GivenBloodDays + "') ";

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

       

       
       

        public int Update(EDonor eDonor,EAddress eAddress)
        {
            SqlConnection connection = new SqlConnection(conString);

            connection.Open();
            int check = 0;
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string q = "Update DTable set Name=@Name,Date_of_birth=@Date_of_birth,Sex=@Sex,Age=@Age,Nid_Number=@Nid_Number,Contact_Number=@Contact_Number,Blood_Group=@Blood_Group,House_No=@House_No,Road_No=@House_No,Post_Office=@Post_Office,District=@District,Password=@Password,Days_given_blood=@Days_given_blood where Nid_Number=@Nid_Number";
                SqlCommand cmd = new SqlCommand(q, connection);
                cmd.Parameters.AddWithValue("@Name", eDonor.Name);
                cmd.Parameters.AddWithValue("@Date_of_birth", eDonor.DateOfBirth);
                cmd.Parameters.AddWithValue("@Sex", eDonor.Sex); 
                cmd.Parameters.AddWithValue("@Age", eDonor.Age);
                cmd.Parameters.AddWithValue("@Nid_Number", eDonor.NidNum);
                cmd.Parameters.AddWithValue("@Contact_Number", eDonor.ContactNum);
                cmd.Parameters.AddWithValue("@Blood_Group", eDonor.BloodGroup);
                cmd.Parameters.AddWithValue("@House_No", eAddress.HouseNo);
                cmd.Parameters.AddWithValue("@Road_No", eAddress.RoadNo);
                cmd.Parameters.AddWithValue("@Post_Office", eAddress.PostOffice);
                cmd.Parameters.AddWithValue("@District", eAddress.District);
                cmd.Parameters.AddWithValue("@Password", eDonor.Password);
                cmd.Parameters.AddWithValue("@Days_given_blood", eDonor.GivenBloodDays);

                check = cmd.ExecuteNonQuery();
                connection.Close();

                return check;


            }
            else
            {
                return check;
            }

        }

       

        int IOCrude.Insert(EAdmin eAdmin)
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

        public SqlDataAdapter Show()
        {
            throw new NotImplementedException();
        }



    }
}
