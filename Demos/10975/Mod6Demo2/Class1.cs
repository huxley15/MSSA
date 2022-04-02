using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo2
{
    struct Address
    {
        public int AptNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }


        public Address(int aptno,string streetname,string city,string state)
        {
            this.AptNo = aptno;
            this.StreetName = streetname;
            this.City = city;
            this.State = state;
        }
    }
}
