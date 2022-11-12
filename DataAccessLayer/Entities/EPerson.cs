using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EPerson
    {
        private string name;
        private string dateOfBirth;
       public EAddress address;
        private string sex;
        private int age;
        private string nidNum;
        private string contactNum;
        private string bloodGroup;

        public string Name
        {
            set;
            get;
        }
        public string DateOfBirth
        {
            set;
            get;
        }
        public EAddress Address
        {
            set;
            get;
        }
        public string Sex
        {
            set;
            get;
        }
        public int Age
        {
            set;
            get;
        }
        public string NidNum
        {
            set;
            get;
        }
        public string ContactNum
        {
            set;
            get;
        }
        public string BloodGroup
        {
            set;
            get;
        }

        public EPerson()
        {

        }

        public EPerson(string Name, string NidNumber, string ContactNum)
        {
            this.Name = Name;
            this.NidNum= NidNum;
            this.ContactNum = ContactNum;


        }
        public EPerson(string Name, string DateOfBirth,EAddress Address,String Sex,int Age, string NidNum, string ContactNum, string BloodGroup)
        {
            this.Name = Name;
            this.NidNum = NidNum;
            this.ContactNum = ContactNum;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Sex = Sex;
            this.Age = Age;
            this.BloodGroup = BloodGroup;

        }
    }
}
