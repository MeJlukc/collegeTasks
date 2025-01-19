using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass3
    {

        private double _n3;
        private double _y3;

        public MyTaskClass3(double n3, double y3)
        {
            _n3 = n3;
            _y3 = y3;
        }

        public void G()
        {
            Console.WriteLine($"G = {_n3 * (_y3 + 3.5) + Math.Sqrt(_y3)}");
        }
    }
}