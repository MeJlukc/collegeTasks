using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// Ярослав Соломатин П23-2.2
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");
            Console.WriteLine("1-30");
            int sw = Convert.ToInt32(Console.ReadLine());


            switch (sw)
            {
                case 1:
                    double R, t, l;

                    Console.Write("Введите значение t: ");
                    t = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение l: ");
                    l = Convert.ToDouble(Console.ReadLine());

                    //R = 3 * Math.Pow(t, 2) + Math.Pow(l, 5) + 4.9;
                    //Console.WriteLine($"R: {R}");
                    MyTaskClass1 myTaskClass1 = new MyTaskClass1(t, l);
                    myTaskClass1.R();
                    break;

                case 2:
                    double K, p, y2, e;

                    Console.Write("Введите значение p: ");
                    p = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y2 = Convert.ToDouble(Console.ReadLine());
            
                    Console.Write("Введите значение e: ");
                    e = Convert.ToDouble(Console.ReadLine());

                    //K = Math.Log(Math.Pow(p, 2) + Math.Pow(y2, 3)) + Math.Pow(e, p);
                    //Console.WriteLine($"K: {K}");
                    MyTaskClass2 myTaskClass2 = new MyTaskClass2(p, y2, e);
                    myTaskClass2.K();
                    break;

                case 3:
                    double G, n3, y3;

                    Console.Write("Введите значение n: ");
                    n3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y3 = Convert.ToDouble(Console.ReadLine());

                    //G = n3 * (y3 + 3.5) + Math.Sqrt(y3);
                    //Console.WriteLine($"G = {G}")
                    MyTaskClass3 myTaskClass3 = new MyTaskClass3(n3, y3);
                    myTaskClass3.G();
                    break;

                case 4:
                    double D, a4, t4;

                    Console.Write("Введите значение a: ");
                    a4 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение t: ");
                    t4 = Convert.ToDouble(Console.ReadLine());

                    //D = 9.8 * Math.Pow(a4, 2) + 5.52 * Math.Cos(Math.Pow(t4, 5));
                    //Console.WriteLine($"D = {D}");
                    MyTaskClass4 myTaskClass4 = new MyTaskClass4(a4, t4);
                    myTaskClass4.D();
                    break;

                case 17:
                    double N, y17;

                    Console.Write("Введите значение y: ");
                    y17 = Convert.ToDouble(Console.ReadLine());

                    //N = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);
                    MyTaskClass17 myTaskClass17 = new MyTaskClass17(y17);
                    myTaskClass17.N();
                    break;

                case 18:
                    double Z, y18;

                    Console.Write("Введите значение y: ");
                    y18 = Convert.ToDouble(Console.ReadLine());

                    //Z = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y18, 3) + 1);
                    MyTaskClass18 myTaskClass18 = new MyTaskClass18(y18);
                    myTaskClass18.Z();
                    break;

                case 19:
                    double P, n, y, g;

                    Console.Write("Введите значение n: ");
                    n = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение g: ");
                    g = Convert.ToDouble(Console.ReadLine());

                    //P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);
                    //Console.WriteLine($"P: {P}");

                    MyTaskClass19 myTaskClass19 = new MyTaskClass19(n, y, g);
                    myTaskClass19.P();
                    break;

                case 20:
                    double U, e20, k20, y20, x20;

                    Console.Write("Введите значение e: ");
                    e20 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение k: ");
                    k20 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y20 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x20 = Convert.ToDouble(Console.ReadLine());

                    //U = Math.Pow(e20, k20 + y20) + Math.Tan(x20) * Math.Sqrt(y20);
                    MyTaskClass20 myTaskClass20 = new MyTaskClass20(e20, k20, y20, x20);
                    myTaskClass20.U();
                    break;

                case 21:
                    double P21, e21, y21, h21;

                    Console.Write("Введите значение e: ");
                    e21 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y21 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение h: ");
                    h21 = Convert.ToDouble(Console.ReadLine());

                    //P21 = Math.Pow(e21, y21 + 5.5) + 9.1 * Math.Pow(h21, 3);
                    MyTaskClass21 myTaskClass21 = new MyTaskClass21(e21, y21, h21);
                    myTaskClass21.P();
                    break;

                case 22:
                    double T22, u22, y22, x22;

                    Console.Write("Введите значение 2: ");
                    u22 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y22 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x22 = Convert.ToDouble(Console.ReadLine());

                    //T22 = Math.Sin(2 * u22) * Math.Log(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));
                    MyTaskClass22 myTaskClass22 = new MyTaskClass22(u22, y22, x22);
                    myTaskClass22.T();
                    break;

                case 23:
                    double G23, e23, y23, f;

                    Console.Write("Введите значение e: ");
                    e23 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y23 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение f: ");
                    f = Convert.ToDouble(Console.ReadLine());

                    //G23 = Math.Pow(e23, 2 * y23) + Math.Sin(f23);
                    MyTaskClass23 myTaskClass23 = new MyTaskClass23(e23, y23, f);
                    myTaskClass23.G();
                    break;

                case 24:
                    double F24, y;


                    break;
            }
        }
    }
}