using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass20
    {
        private double _e20;
        private double _k20;
        private double _y20;
        private double _x20;

        public MyTaskClass20(double e20, double k20, double y20, double x20)
        {
            _e20 = e20;
            _k20 = k20;
            _y20 = y20;
            _x20 = x20;
        }   

        public void U()
        {
            Console.WriteLine($"U = Math.Pow(e20, k20 + y20) + Math.Tan(x20) * Math.Sqrt(y20);");
        }
    }
}
