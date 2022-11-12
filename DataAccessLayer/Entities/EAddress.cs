using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EAddress
    {
        private int houseNo;
        private int roadNo;
        private string postOffice;
        private string district;


        public int HouseNo
        {
            set;
            get;
        }
        public int RoadNo
        {
            set;
            get;
        }
        public string PostOffice
        {
            set;
            get;
        }
        public string District
        {
            set;
            get;
        }
    }
}
