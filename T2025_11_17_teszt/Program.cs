using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._11._17_teszt
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.Write("Adja meg az 'a' együtthatót: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Az 'a' együttható nem lehet nulla.");
            }
            try
            {
                Console.WriteLine("Másodfokú egyenlet megoldó program");
                Console.Write("Adja meg az 'a' együtthatót: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a 'b' együtthatót: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Adja meg a 'c' együtthatót: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.WriteLine("Nincs valós megoldás.");
                }
                else if (d == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Egy valós megoldás van: x = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);

                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"Két valós megoldás van: x1 = {x1}, x2 = {x2}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Hibás bemenet! Kérem, számot adjon meg.");
            }

            Console.WriteLine("Nyomjon meg egy gombot a kilépéshez...");
            Console.ReadKey();

        }
    }
}
