﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_codegym
{
    internal class pt_bac_mot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("The solution is: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            }
            Console.ReadLine();
        }
    }
}
