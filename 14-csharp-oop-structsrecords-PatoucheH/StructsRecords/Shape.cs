using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsRecords
{
    public record Shape
    {
        public Point Center;
        public double Radius;

        public Shape(Point center, double radius)
        {
            Center = center; 
            Radius = radius;
        }
    }
}
