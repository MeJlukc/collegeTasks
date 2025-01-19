using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass9
    {

        private double _y9;
        private double _x9;

        public MyTaskClass9(double y9, double x9)
        {
            _y9 = y9;
            _x9 = x9;
        }

        public void V()
        {
            Console.WriteLine($"V = {Math.Log(_y9 + 0.95) + Math.Sin(Math.Pow(_x9, 4))}");
        }
    }
}
