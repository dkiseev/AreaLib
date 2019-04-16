using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Triangle : IFigure
    {
        private double aSide;
        private double bSide;
        private double cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            var sides = new[] { aSide, bSide, cSide }.OrderBy(item => item).ToArray();
            if(sides.Any(item=> item <= 0) || sides[0]+ sides[1] <= sides[2]) throw new Exception();
            this.aSide = sides[0];
            this.bSide = sides[1];
            this.cSide = sides[2];
        }

        public double GetArea()
        {
            double halfPerimetr = (aSide + bSide + cSide) / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - aSide) * (halfPerimetr - bSide) * (halfPerimetr - cSide));
        }

        public double ASide
        {
            get { return aSide; }
        }

        public double BSide
        {
            get { return bSide; }
        }

        public double CSide
        {
            get { return cSide; }
        }

    }
}
