using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass19
    {
        private double _n;
        private double _y;
        private double _g;

        public MyTaskClass19(double n, double y, double g)
        {
            _n = n;
            _y = y;
            _g = g;
        }

        public void P()
        {
            Console.WriteLine($"P = {_n * Math.Sqrt(Math.Pow(_y, 3) + 1.09 * _g)}");
        }
    }
}
