using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass5
    {

        private double _x5;

        public MyTaskClass5(double x5)
        {
            _x5 = x5;
        }

        public void L()
        {
            Console.WriteLine($"L = {1.51 * Math.Cos(Math.Pow(_x5, 2)) + 2 * Math.Pow(_x5, 3)}");
        }
    }
}
