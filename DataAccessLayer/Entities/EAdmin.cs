using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EAdmin : EPerson
    {
        private string password;

        public string Password
        {
            set;
            get;
        }
        
    }
}
