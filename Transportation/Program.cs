using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(10, 10);
            RoadTransportation R = new RoadTransportation();
            Console.WriteLine("tHE PRICE OF ROAD IS " + R.Price(data));
            Console.ReadLine();
        }
    }
}
