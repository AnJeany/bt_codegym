using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doi_tien_te
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usd = float.Parse(Console.ReadLine());
            float change = usd * 23000;
            Console.WriteLine(change);
        }
    }
}
