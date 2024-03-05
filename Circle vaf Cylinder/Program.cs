using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_vaf_Cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder("red", 5.0, 6.0);
            cylinder.Area();
            Console.WriteLine(cylinder);

        }
    }
}
