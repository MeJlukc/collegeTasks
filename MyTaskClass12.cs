using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass12
    {

        private double _t12;
        private double _x12;

        public MyTaskClass12(double t12, double x12)
        {
            _t12 = t12;
            _x12 = x12;
        }

        public void K()
        {
            Console.WriteLine($"K = {7 * Math.Pow(_t12, 2) + 3 * Math.Sin(Math.Pow(_x12, 3)) + 9.2}");
        }
    }
}
