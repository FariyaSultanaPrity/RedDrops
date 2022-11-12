using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public interface IOCrude
    {
           SqlDataAdapter Show();
           int Insert(EAdmin eAdmin);
           int Insert(EDonor eDonor, EAddress eAddress);
           int Insert(ERecipient eRecipient, EAddress eAddress);
           SqlDataAdapter Search(EDonor eDonor,EAddress eAddress);
           int Update(EDonor eDonor,EAddress eAddress);
          
    }
}
