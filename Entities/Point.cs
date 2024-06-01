using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling.Entities
{
    public class Point
    {

        private Vector position;
        private double thickness;

        public Point()
        {
            Position = Vector.Zero;
            Thickness = 0.0;
        }

        public Point(Vector position) {
            Position = position;
            Thickness = 0.0;
        }

        public double Thickness { get { return thickness; } set {  thickness = value; } }
        public Vector Position { get { return position; } set { position = value; } }

    }
}
