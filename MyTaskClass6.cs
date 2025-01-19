using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass6
    {

        private double _y6;
        private double _e6;
        private double _x6;

        public MyTaskClass6(double y6, double e6, double x6)
        {
            _y6 = y6;
            _e6 = e6;
            _x6 = x6;
        }

        public void M()
        {
            Console.WriteLine($"M = {Math.Cos(2 * _y6) + 3.6 * Math.Pow(_e6, _x6)}");
        }
    }
}
