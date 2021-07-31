using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class Rectangle
    {
        public string Colour = " ";
        public double Height = new double();
       public  double Width = new double();
        private double area = new double();

       //Class Constructor
    public Rectangle(string colour, double height, double width)
        {
            Colour = colour;
            Height = height;
            Width = width;
            
        }

        //Property for area
        public double Area
        {
            get { return area = Height* Width; }
            set
            {
                
            }
        }

    }

}
