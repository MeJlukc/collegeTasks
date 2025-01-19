using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class MyTaskClass1
    {
        private double _t;
        private double _l;

        public MyTaskClass1(double t, double l)
        {
            _t = t;
            _l = l;

        }
        public void R()
        {
            Console.WriteLine($"R: {3 * Math.Pow(_t, 2) + Math.Pow(_l, 5) + 4.9}");
        }
    }
}
