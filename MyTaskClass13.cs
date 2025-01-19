using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass13
    {
        private double _y13;

        public MyTaskClass13(double y13)
        {
            _y13 = y13;
        }

        public void E()
        {
            Console.WriteLine($"E = {Math.Sqrt(Math.Abs(3 * Math.Pow(_y13, 2) + 0.5 * _y13 + 4))}");
        }
    }
}
