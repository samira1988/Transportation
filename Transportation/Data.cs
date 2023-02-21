using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    internal class Data
    {
        public int Mass { get; set; }
        public int Weight { get; set; }
        public Data(int mass, int weight)
        {
            Mass = mass;
            Weight = weight;
        }
    }
}
