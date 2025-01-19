using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass4
    {

        private double _a4;
        private double _t4;

        public MyTaskClass4(double a4, double t4)
        {
            _a4 = a4;
            _t4 = t4;
        }

        public void D()
        {
            Console.WriteLine($"D = {9.8 * Math.Pow(_a4, 2) + 5.52 * Math.Cos(Math.Pow(_t4, 5))}");
        }
    }
}
