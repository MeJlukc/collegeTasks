using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass26
    {

        private double _p26;

        public MyTaskClass26(double p26)
        {
            _p26 = p26;
        }

        public void Z()
        {
            Console.WriteLine($"Z = {Math.Pow(Math.Sin(Math.Pow(_p26, 2) + 0.4), 3)}");
        }
    }
}
