using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class ERecipient:EPerson
    {
        
        private string needBloodGroup;
        private int bloodQuantity;

        public int BloodQuantity
        {
            set;
            get;
        }
        public String NeedBloodGroup
        {
            set;
            get;
        }
        public ERecipient() : base()
        {

        }
        public ERecipient(string Name, string DateOfBirth, EAddress Address, String Sex, int Age, string NidNum, string ContactNum, string BloodGroup, string NeedBloodGroup ,int BloodQuantity ) : base(Name, DateOfBirth, Address, Sex, Age, NidNum, ContactNum, BloodGroup)
        {
            this.NeedBloodGroup=NeedBloodGroup;
            this.BloodQuantity = BloodQuantity;
        

            }
    }
}
