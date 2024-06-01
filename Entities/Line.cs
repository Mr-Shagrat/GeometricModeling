using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling.Entities
{
    public class Line
    {
        private Vector startPosition;
        private Vector endPosition;
        private double thickness;

        public Line(): this(Vector.Zero, Vector.Zero) { }

        public Line(Vector startPosition, Vector endPosition)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
            Thickness = 0.0;
        }

        public Vector StartPosition { get { return startPosition; } set {  startPosition = value; } }
        public Vector EndPosition { get { return endPosition; } set { endPosition = value; } }
        public double Thickness { get { return thickness; } set { thickness = value; } }
    }
}
