using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Circle: IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius <= 0) throw new Exception();
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
