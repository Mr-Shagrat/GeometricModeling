using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling.Entities
{
    public class Line
    {
        private Vector startPosition;
        private Vector endPosition;
        private Pen pen;
        private double thickness;

        public Line(Pen pen): this(Vector.Zero, Vector.Zero, pen) { }

        public Line(Vector startPosition, Vector endPosition, Pen pen)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
            Pen = (Pen) pen.Clone();  
            Thickness = 0.0;
        }

        public Vector StartPosition { get { return startPosition; } set {  startPosition = value; } }
        public Vector EndPosition { get { return endPosition; } set { endPosition = value; } }
        public Pen Pen { get { return pen; } set { pen = value; } }
        public double Thickness { get { return thickness; } set { thickness = value; } }
    }
}
