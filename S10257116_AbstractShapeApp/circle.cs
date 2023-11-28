using shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Circle : Shape, IComparable<Circle>
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(string colour, double radius) : base("Circle", colour)
        {
            Radius = radius;
        }
        public override double FindArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }
        public override double FindPerimeter()
        {
            double perimeter = Math.PI * (2 * Radius);
            return perimeter;
        }
        public override string ToString()
        {
            return base.ToString() + $" Radius: {Radius}";
        }
        public int CompareTo(Circle circle) 
        { 
            return Radius.CompareTo(circle.Radius);
        }
    }
}

