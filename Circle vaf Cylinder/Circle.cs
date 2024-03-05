using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_vaf_Cylinder
{
    public abstract class Circle
    {
        private string color;
        private double radius;

        public string GetColor ()
        {
            return color;
        }

        public void SetColor (string color)
        {
            this.color = color;
        }

        public double GetRadius ()
        { 
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            radius = 10.0;
            color = "red";
        }

        public Circle(string color, double radius)
        {
            this.color = color;
            this.radius = radius;
        }

        public abstract double Area();

        public override string ToString()
        {
            return "Color is: " + GetColor() +" radius is: " + GetRadius();
        }
    }

    public class Cylinder : Circle
    {
        private double height;
        public Cylinder(string color, double radius, double height) : base(color, radius)
        {
            this.height = height;
        }

        public override double Area()
        {
            return GetRadius() * GetRadius() * height * Math.PI;
        }

        public override string ToString()
        {
            return "Area is " + Area();
        }

    }
}
