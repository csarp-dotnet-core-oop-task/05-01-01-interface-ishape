using System;
using System.Collections.Generic;
using System.Text;

using GeometriaiAlakzatokProjekt.Model.Interfaces;

namespace GeometriaiAlakzatokProjekt.Model
{
    class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return radius * radius * Math.PI;
        }

        public double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
    }
}
