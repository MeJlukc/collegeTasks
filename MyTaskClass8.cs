using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass8
    {

        private double _y8;

        public MyTaskClass8(double y8)
        {
            _y8 = y8;
        }

        public void T()
        {
            Console.WriteLine($"T = {Math.Sqrt(Math.Abs(6 * Math.Pow(_y8, 2) - 0.1 * _y8 + 4))}");
        }
    }
}
