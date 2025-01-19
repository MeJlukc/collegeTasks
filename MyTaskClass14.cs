using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass14
    {

        private double _y14;
        private double _e14;
        private double _x14;

        public MyTaskClass14(double y14, double e14, double x14)
        {
            _y14 = y14;
            _e14 = e14;
            _x14 = x14;
        }

        public void R()
        {
            Console.WriteLine($"R = {Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(_y14), 2) + 6.835) + Math.Pow(_e14, _x14))}");
        }
    }
}
