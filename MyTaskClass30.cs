using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass30
    {

        private double _e30;
        private double _y30;
        private double _r30;

        public MyTaskClass30(double e30, double y30, double r30)
        {
            _e30 = e30;
            _y30 = y30;
            _r30 = r30;
        }

        public void W()
        {
            Console.WriteLine($"W = {Math.Pow(_e30, _y30 + _r30) + 7.2 * Math.Sin(_r30)}");
        }
    }
}
