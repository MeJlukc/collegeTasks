using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class MyTaskClass28
    {

        private double _e28;
        private double _y28;
        private double _h28;

        public MyTaskClass28(double e28, double y28, double h28)
        {
            _e28 = e28;
            _y28 = y28;
            _h28 = h28;
        }

        public void T()
        {
            Console.WriteLine($"T = {Math.Pow(_e28, _y28 + _h28) + Math.Sqrt(Math.Abs(6.4 * _y28))}");
        }
    }
}
