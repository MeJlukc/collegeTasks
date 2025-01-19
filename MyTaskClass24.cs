using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass24
    {

        private double _y24;

        public MyTaskClass24(double y24)
        {
            _y24 = y24;
        }

        public void F()
        {
            Console.WriteLine($"F = {2 * Math.Sin(0.214 * Math.Pow(_y24, 5) + 1)}");
        }
    }
}
