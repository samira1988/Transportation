using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    internal class ClassicAir:Air
    {
        public override int Price(Data data)
        {
           return this.Mass(data) * fixed_ ;
        }
    }
}
