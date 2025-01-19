using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass21
    {
        private double _e21;
        private double _y21;
        private double _h21;

        public MyTaskClass21(double e21, double y21, double h21)
        {
            _e21 = e21;
            _y21 = y21;
            _h21 = h21;
        }

        public void P()
        {
            Console.WriteLine($"P = {Math.Pow(_e21, _y21 + 5.5) + 9.1 * Math.Pow(_h21, 3)}");
        }
    }
}
