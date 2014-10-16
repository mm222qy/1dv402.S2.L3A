using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L3A
{
    enum ShapeType { Ellipse = 1, Rectangle = 2 }
    abstract class Shape
    {
        private double _length;
        private double _width;

        abstract public double Area
        {
            get;
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _length = value;
            }
        }
        abstract public double Perimeter
        {
            get;
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _width = value;
            }
        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override string ToString()
        {
            return string.Format("Längd : {0,10} \nBredd  : {1,10} \nOmkrets: {2,10:f2} \nArea  : {3,10:f2}", Length, Width, Perimeter, Area);
        }
    }
}
