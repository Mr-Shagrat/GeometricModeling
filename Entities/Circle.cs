using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling.Entities
{
    public class Circle
    {
        private Vector center;
        private Pen pen;
        private double radius;
        private double thickness;

        public Circle(Pen pen): this(Vector.Zero, 1.0, pen) { }

        public Circle(Vector center, double radius, Pen pen)
        {
            this.center = center;
            this.radius = radius;
            Pen = (Pen) pen.Clone();  
            Thickness = 0.0;
        }

        public Vector Center { get { return center; } set { center = value; } }
        public Pen Pen { get { return pen; } set { pen = value; } }
        public double Thickness { get { return thickness; } set { thickness = value; } }
        public double Radius { get { return radius; } set { radius = value; } }
        public double Diameter { get { return radius * 2.0; } }
    }
}
