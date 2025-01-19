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

                case 5:
                    double L5, x5;

                    Console.Write("Введите значение x: ");
                    x5 = Convert.ToDouble(Console.ReadLine());

                    //L5 = 1.51 * Math.Cos(Math.Pow(x5, 2)) + 2 * Math.Pow(x5, 3);
                    MyTaskClass5 myTaskClass5 = new MyTaskClass5(x5);
                    myTaskClass5.L();
                    break;

                case 6:
                    double M6, y6, e6, x6;

                    Console.Write("Введите значение y: ");
                    y6 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение e: ");
                    e6 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x6 = Convert.ToDouble(Console.ReadLine());

                    //M6 = Math.Cos(2 * y6) + 3.6 * Math.Pow(e6, x6);
                    MyTaskClass6 myTaskClass6 = new MyTaskClass6(y6, e6, x6);
                    myTaskClass6.M();
                    break;

                case 7:
                    double N7, m7;

                    Console.Write("Введите значение m: ");
                    m7 = Convert.ToDouble(Console.ReadLine());

                    //N7 = Math.Pow(m7, 2) + 2.8 * Math.Abs(m7) + 0.55;
                    MyTaskClass7 myTaskClass7 = new MyTaskClass7(m7);
                    myTaskClass7.N();
                    break;

                case 8:
                    double T8, y8;

                    Console.Write("Введите значение y: ");
                    y8 = Convert.ToDouble(Console.ReadLine());

                    //T8 = Math.Sqrt(Math.Abs(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4));
                    MyTaskClass8 myTaskClass8 = new MyTaskClass8(y8);
                    myTaskClass8.T();
                    break;

                case 9:
                    double V9, y9, x9;

                    Console.Write("Введите значение y: ");
                    y9 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x9 = Convert.ToDouble(Console.ReadLine());

                    //V9 = Math.Log(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));
                    MyTaskClass9 myTaskClass9 = new MyTaskClass9(y9, x9);
                    myTaskClass9.V();
                    break;

                case 10:
                    double U10, e10, y10, k10, x10;

                    Console.Write("Введите значение e: ");
                    e10 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение y: ");
                    y10 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение k: ");
                    k10 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x10 = Convert.ToDouble(Console.ReadLine());

                    //U10 = Math.Pow(e10, y10) + 7.355 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);
                    MyTaskClass10 myTaskClass10 = new MyTaskClass10(e10, y10, k10, x10);
                    myTaskClass10.U();
                    break;

                case 11:
                    double S11, y11, x11;

                    Console.Write("Введите значение y: ");
                    y11 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x11 = Convert.ToDouble(Console.ReadLine());

                    //S11 = 9.756 * Math.Pow(y11, 7) + 2 * Math.Tan(x11);
                    MyTaskClass11 myTaskClass11 = new MyTaskClass11(y11, x11);
                    myTaskClass11.S();
                    break;

                case 12:
                    double K12, t12, x12;

                    Console.Write("Введите значение t: ");
                    t12 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x12 = Convert.ToDouble(Console.ReadLine());

                    //K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;
                    MyTaskClass12 myTaskClass12 = new MyTaskClass12(t12, x12);
                    myTaskClass12.K();
                    break;

                case 13:
                    double E13, y13;

                    Console.Write("Введите значение y: ");
                    y13 = Convert.ToDouble(Console.ReadLine());

                    //E13 = Math.Sqrt(Math.Abs(3 * Math.Pow(y13, 2) + 0.5 * y13 + 4));
                    MyTaskClass13 myTaskClass13 = new MyTaskClass13(y13);
                    myTaskClass13.E();
                    break;

                case 14:
                    double R14, y14, e14, x14;

                    Console.Write("Введите значение y: ");
                    y14 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение e: ");
                    e14 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите значение x: ");
                    x14 = Convert.ToDouble(Console.ReadLine());

                    //R14 = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835) + Math.Pow(e14, x14));
                    MyTaskClass14 myTaskClass14 = new MyTaskClass14(y14, e14, x14);
                    myTaskClass14.R();
                    break;

                case 15:
                    double H15, y15;

                    Console.Write("Введите значение y: ");
                    y15 = Convert.ToDouble(Console.ReadLine());

                    //H15 = Math.Sin(Math.Pow(y15, 2)) - 2.8 * y15 + Math.Sqrt(Math.Abs(y15));
                    MyTaskClass15 myTaskClass15 = new MyTaskClass15(y15);
                    myTaskClass15.H();
                    break;

                case 16:
                    double S16, y16;

                    Console.Write("Введите значение y: ");
                    y16 = Convert.ToDouble(Console.ReadLine());

                    //S16 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2)) + 7.151);
                    MyTaskClass16 myTaskClass16 = new MyTaskClass16(y16);
                    myTaskClass16.S();
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
                    double F24, y24;

                    Console.WriteLine("Введите значение y");
                    y24 = Convert.ToDouble(Console.ReadLine());

                    //F = 2 * Math.Sin(0.214 * Math.Pow(y, 5) + 1);
                    
                    MyTaskClass24 myTaskClass24 = new MyTaskClass24(y24);
                    myTaskClass24.F();

                    break;

                case 25:
                    double G25, e25, y25, f25;

                    Console.WriteLine("Введите значение e");
                    e25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y25 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение f");
                    f25 = Convert.ToDouble(Console.ReadLine());

                    //G25 = Math.Pow(e25, 2 * y25) + Math.Sin(Math.Pow(f25, 2));
                    MyTaskClass25 myTaskClass25 = new MyTaskClass25(e25, y25, f25);
                    myTaskClass25.G();
                    break;

                case 26:
                    double Z26, p26;

                    Console.WriteLine("Введите значение p");
                    p26 = Convert.ToDouble(Console.ReadLine());

                    //Z26 = Math.Pow(Math.Sin(Math.Pow(p26, 2) + 0.4), 3);
                    MyTaskClass26 myTaskClass26 = new MyTaskClass26(p26);
                    myTaskClass26.Z();
                    break;

                case 27:
                    double W27, v27, e27, y27, x27;

                    Console.WriteLine("Введите значение v");
                    v27 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e27 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y27 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x27 = Convert.ToDouble(Console.ReadLine());

                    //W27 = 1.03 * v27 + Math.Pow(e27, 2 * y27) + Math.Tan(Math.Abs(x27));
                    MyTaskClass27 myTaskClass27 = new MyTaskClass27(v27, e27, y27, x27);
                    myTaskClass27.W();
                    break;

                case 28:
                    double T28, e28, y28, h28;

                    Console.WriteLine("Введите значение e");
                    e28 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y28 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение h");
                    h28 = Convert.ToDouble(Console.ReadLine());

                    //T28 = Math.Pow(e28, y28 + h28) + Math.Sqrt(Math.Abs(6.4 * y28));
                    MyTaskClass28 myTaskClass28 = new MyTaskClass28(e28, y28, h28);
                    myTaskClass28.T();
                    break;

                case 29:
                    double N29, y29;

                    Console.WriteLine("Введите значение y");
                    y29 = Convert.ToDouble(Console.ReadLine());

                    //N29 = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));
                    MyTaskClass29 myTaskClass29 = new MyTaskClass29(y29);
                    myTaskClass29.N();
                    break;

                case 30:
                    double W30, e30, y30, r30;

                    Console.WriteLine("Введите значение e");
                    e30 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y30 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите значение r");
                    r30 = Convert.ToDouble(Console.ReadLine());

                    //W30 = Math.Pow(e30, y30 + r30) + 7.2 * Math.Sin(r30);
                    MyTaskClass30 myTaskClass30 = new MyTaskClass30(e30, y30, r30);
                    myTaskClass30.W();
                    break;
            }
        }
    }
}