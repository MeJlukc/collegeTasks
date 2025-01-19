using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass23
    {
        private double _e23;
        private double _y23;
        private double _f;

        public MyTaskClass23(double e23, double y23, double f)
        {
            _e23 = e23;
            _y23 = y23;
            _f = f;
        }

        public void G()
        {
            Console.WriteLine($"G = {Math.Pow(_e23, 2 * _y23) + Math.Sin(_f)}");
        }
    }
}
