using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass29
    {

        private double _y29;

        public MyTaskClass29(double y29)
        {
            _y29 = y29;
        }

        public void N()
        {
            Console.WriteLine($"N = {3 * Math.Pow(_y29, 2) + Math.Sqrt(Math.Abs(_y29 + 1))}");
        }
    }
}
