using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите стороны треугольников a, b, c, d, e, f");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double p = (a + b + c) / 2;
            double p2 = (a + b + c) / 2;
            double s =Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double s2 = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            CalmSquare(a, b, c, d, e, f);
            Console.ReadKey();
        }
        static void CalmSquare(double a, double b, double c, double d, double e, double f)
        {
            double p = (a + b + c) / 2;
            double p2 = (d + e + f) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double s2 = Math.Sqrt(p2 * (p2 - d) * (p2 - e) * (p2 - f));
            Console.WriteLine("s:{0:0.00},s2:{1:0.00}", s, s2);
            if (s == s2)
                Console.WriteLine("s равно s2");
            else if (s2 > s)
                Console.WriteLine("s2 больше s");
            else
                Console.WriteLine("s больше s2");

        }
        
    }
}         
