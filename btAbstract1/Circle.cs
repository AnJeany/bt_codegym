﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btAbstract1
{
    public class Circle : Shape, IResizeable
    {
        private double radius = 1.0;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public void Resize(double percent)
        {
            percent = 2.9;
            radius *= percent;
            setRadius(radius);
        }

        public override string ToString()
        {
            return "A Circle with radius="
                    + getRadius()
                    + ", which is a subclass of "
                    + base.ToString();
        }


    }
}
