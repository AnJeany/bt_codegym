using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoiNhietDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahreheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        FToC(fahrenheit);
                        break;
                    case 2:
                        Console.WriteLine("Enter celcius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        CToF(celsius);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

            void FToC (double f)
            {             
                double c = (double)(5.0 / 9) * (f - 32);
                Console.WriteLine("Fahrenheit to Celsius: " + Math.Round(c,1));
            }
            void CToF (double c)
            {
                double f = (double) ((9.0/5) * c) + 32;
                Console.WriteLine("Celsius to Fahrenheit: " + Math.Round(f, 1));
            }
        }
    }
}
