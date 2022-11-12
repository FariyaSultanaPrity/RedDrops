using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class EDonor:EPerson
    {
        private int givenBloodDays;
        private string password;

        public int GivenBloodDays
        {
            set;
            get;
        }
        public String Password
        {
            set;
            get;
        }
        public EDonor() : base()
        {

        }
        public EDonor(string Name, string DateOfBirth, EAddress Address, String Sex, int Age, string NidNum, string ContactNum, string BloodGroup,int GivenBloodays,string Password) : base(Name, DateOfBirth, Address,  Sex,Age,  NidNum, ContactNum,  BloodGroup )
        {
            this.GivenBloodDays = GivenBloodDays;
            this.Password = Password;
        }
    }
}
