using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass15
    {

        private double _y15;

        public MyTaskClass15(double y15)
        {
            _y15 = y15;
        }

        public void H()
        {
            Console.WriteLine($"H = {Math.Sin(Math.Pow(_y15, 2)) - 2.8 * _y15 + Math.Sqrt(Math.Abs(_y15))}");
        }
    }
}
