using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.ToString(10,10,"Yellow",true);
            Fan fan2 = new Fan();
            fan2.ToString(5, 5, "Blue", false);
        }
    }
}
