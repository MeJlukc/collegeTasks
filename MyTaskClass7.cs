using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass7
    {

        private double _m7;

        public MyTaskClass7(double m7)
        {
            _m7 = m7;
        }

        public void N()
        {
            Console.WriteLine($"N = {Math.Pow(_m7, 2) + 2.8 * Math.Abs(_m7) + 0.55}");
        }
    }
}
