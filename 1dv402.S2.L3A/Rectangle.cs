using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L3A
{
     class Rectangle : Shape
    {
         //public egenskap som overridar Shapes metod och får ut area
         public override double Area
         {
             get { return Length * Width; }
         }
         //public egenskap som overridar Shapes metod och får ut omkrets
         public override double Perimeter
         {
             get { return 2 * Length + 2 * Width; }
         }
         //
         public Rectangle(double length, double width): base
             (length, width){ }
    }
}
