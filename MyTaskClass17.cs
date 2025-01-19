using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass17
    {
        private double _y17;

        public MyTaskClass17(double y17)
        {
            _y17 = y17;
        }

        public void N()
        {
            Console.WriteLine($"N = {3 * Math.Pow(_y17, 2) + Math.Sqrt(_y17 + 1)}");
        }
    }
}
