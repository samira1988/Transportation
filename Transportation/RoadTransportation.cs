using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    internal class RoadTransportation:Itransportation
    {
        public int fixed_price = 2;
        public int Mass(Data data)
        {
            return data.Mass;   
        }
        public int Price(Data data)
        {
            return fixed_price * Mass(data);
        }
    }
}
