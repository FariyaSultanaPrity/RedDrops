using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    public interface IODeleteAccount
    {
        int AdminDelete(EAdmin eAdmin);
        int DonorDelete(EDonor eDonor);
    }
}
