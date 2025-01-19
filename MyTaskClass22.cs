using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass22
    {
        private double _u22;
        private double _y22;
        private double _x22;

        public MyTaskClass22(double u22, double y22, double x22)
        {
            _u22 = u22;
            _y22 = y22;
            _x22 = x22;
        }

        public void T()
        {
            Console.WriteLine($"T = {Math.Sin(2 * _u22) * Math.Log(2 * Math.Pow(_y22, 2) + Math.Sqrt(_x22))}");
        }
    }
}
