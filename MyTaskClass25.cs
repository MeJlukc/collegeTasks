using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass25
    {

        private double _e25;
        private double _y25;
        private double _f25;

        public MyTaskClass25(double e25, double y25, double f25)
        {
            _e25 = e25;
            _y25 = y25;
            _f25 = f25;
        }

        public void G()
        {
            Console.WriteLine($"G = {Math.Pow(_e25, 2 * _y25) + Math.Sin(Math.Pow(_f25, 2))}");
        }
    }
}
