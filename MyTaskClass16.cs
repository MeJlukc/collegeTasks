using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass16
    {

        private double _y16;

        public MyTaskClass16(double y16)
        {
            _y16 = y16;
        }

        public void S()
        {
            Console.WriteLine($"S = {Math.Sqrt(Math.Cos(4 * Math.Pow(_y16, 2)) + 7.151)}");
        }
    }
}
