using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass10
    {
        private double _e10;
        private double _y10;
        private double _k10;
        private double _x10;

        public MyTaskClass10(double e10, double y10, double k10, double x10)
        {
            _e10 = e10;
            _y10 = y10;
            _k10 = k10;
            _x10 = x10;
        }

        public void U()
        {
            Console.WriteLine($"U = {Math.Pow(_e10, _y10) + 7.355 * Math.Pow(_k10, 2) + Math.Pow(Math.Sin(_x10), 2)}");
        }
    }
}
