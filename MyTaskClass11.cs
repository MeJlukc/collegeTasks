using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass11
    {
        private double _y11;
        private double _x11;

        public MyTaskClass11(double y11, double x11)
        {
            _y11 = y11;
            _x11 = x11;
        }

        public void S()
        {
            Console.WriteLine($"S = {9.756 * Math.Pow(_y11, 7) + 2 * Math.Tan(_x11)}");
        }
    }
}
