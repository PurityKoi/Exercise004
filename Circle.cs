using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Circle
    {
       string Colour = " ";
       double Radius = new double();
        double pi = Math.PI;
       private double area = new double();

        //Class Constructor
        public Circle(string colour , double radius)
        {
            Colour = colour;
            Radius = radius;
        }

        //Property for area
        public double Area
        {
            get { return area = pi * Radius;}
            set
            {
            }
        }
    }
}
