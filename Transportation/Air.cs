using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    internal  abstract class Air:Itransportation
    {
        public int fixed_ = 10;
        public int Mass(Data data)
        {
            return data.Weight;
        }
        public abstract int Price(Data data);
    }
}
