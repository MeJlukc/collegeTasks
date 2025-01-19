using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyTaskClass2
    {
        private double _p;
        private double _y2;
        private double _e;

        public MyTaskClass2(double p, double y2, double e)
        {
            _p = p;
            _y2 = y2;
            _e = e;
        }
        public void K()
        {
            Console.WriteLine($"K: {Math.Log(Math.Pow(_p, 2) + Math.Pow(_y2, 3)) + Math.Pow(_e, _p)}");

        }
    }
 }
