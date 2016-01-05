using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {    
           while (true)
            {
                // Vuvejdane na stoinostie za a, b, c
                double a = Convert.ToDouble(Console.ReadLine()); // stoinost na parametura "a"
                double b = Convert.ToDouble(Console.ReadLine()); // stoinost na parametura "b"
                double c = Convert.ToDouble(Console.ReadLine()); // Stoinost na parametura "c"
                // smqtane na Deskriminantata
                double D = (b * b) - (4 * a * c);
                // Smqtane na y1, y2
                double y1 = ((-b) + (Math.Sqrt(D))) / 2 * a;
                double y2 = ((-b) - (Math.Sqrt(D))) / 2 * a;
                // Otpechatvane na rezultatite 
                if (y1 > 0 & y2 > 0)
                {
                    Console.WriteLine("x1=" + "" + Math.Sqrt(y1));
                    Console.WriteLine("x2=" + "" + (-(Math.Sqrt(y1))));
                    Console.WriteLine("x3=" + "" + Math.Sqrt(y2));
                    Console.WriteLine("x4=" + "" + (-(Math.Sqrt(y2))));
                }
                if (y1 < 0 & y2 > 0)
                {
                    Console.WriteLine("x1=" + "" + Math.Sqrt(y2));
                    Console.WriteLine("x2=" + "" + (-(Math.Sqrt(y2))));
                }
                if (y2 < 0 & y1 > 0)
                {
                    Console.WriteLine("x1=" + "" + Math.Sqrt(y1));
                    Console.WriteLine("x2=" + "" + (-(Math.Sqrt(y1))));
                }
                if (y1 == 0 & y2 > 0)
                {
                    Console.WriteLine("x1=x2" + "" + 0);
                    Console.WriteLine("x3=" + "" + Math.Sqrt(y2));
                    Console.WriteLine("x4=" + "" + (-(Math.Sqrt(y2))));
                }
                if (y2 == 0 & y1 > 0)
                {
                    Console.WriteLine("x1=" + "" + Math.Sqrt(y1));
                    Console.WriteLine("x2=" + "" + (-(Math.Sqrt(y1))));
                    Console.WriteLine("x3=x4" + "" + 0);
                }
                if ((y1 < 0 & y2 < 0) || (D < 0))
                {
                    Console.WriteLine("Nqma reshenie.");
                }
                if ((y2 == 0 & y1 == 0) || (y1 == 0 & y2 == 0))
                {
                    Console.WriteLine("x1=x2=x3=x4=" + "" + 0);
                }
                if ((y2 == 0 & y1 < 0) || (y1 == 0 & y2 < 0))
                {
                    Console.WriteLine("x1=x2=" + "" + 0);
                    
                }
            }
        }
    }
}
