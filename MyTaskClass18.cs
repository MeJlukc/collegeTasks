using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass18
    {
        private double _y18;

        public MyTaskClass18(double y18)
        {
            _y18 = y18;
        }

        public void Z()
        {
            Console.WriteLine($"Z = {3 * Math.Pow(_y18, 2) + Math.Sqrt(Math.Pow(_y18, 3) + 1)}");
        }
    }
}
