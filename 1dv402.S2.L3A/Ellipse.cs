using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L3A
{
    class Ellipse : Shape
    {
        //overridar abstracta metoden Area i Shape
        public override double Area
        {
            
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }
        //overridar abstracta metoden Perimeter i Shape
        public override double Perimeter
        {
           
            get { return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2)); }
        }
        //konstruktor som anropar basklassens konstruktor för att få ut längd och bredd
        public Ellipse(double length, double width): base
            (length, width) { }

    }
}
