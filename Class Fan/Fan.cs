using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Fan
{
    internal class Fan
    {
        int SLOW = 1;
        int MEDIUM = 2;
        int FAST = 3;
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "Blue";

        public int Slow { get; set; }
        public int Fast { get; set; }
        public int Medium { get; set; }
        public int Speed { get; set; }
        public bool On { set; get; }
        public double Radius { get; set; }
        public string Color { get; set; }

        public Fan()
        {

        }

        public void ToString(int Speed, int Radius, string Color, bool On)
        {
            if (on)
            {
                Console.WriteLine($" Fan: Speed is {Speed}    Radius is {Radius}   Color is {Color} Fan is on");
            }
            else
            {
                Console.WriteLine($" Fan: Speed is {Speed}    Radius is {Radius}   Color is {Color} Fan is off");
            }
        }


    }
}
