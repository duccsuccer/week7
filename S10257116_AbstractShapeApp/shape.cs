using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    abstract class Shape
    {
        private string colour;
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Shape(string type, string colour)
        {
            Type = type;
            Colour = colour;
        }
        public abstract double FindArea();
        public abstract double FindPerimeter();
        public override string ToString()
        {
            return $"Type: {Type}, Colour: {Colour}";
        }
    }
}
    
