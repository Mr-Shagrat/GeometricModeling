using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling.Entities
{
    public class Rect
    {

        private Pen pen;
        private Vector firstPoint;
        private Vector secondPoint;
        private double thickness;

        public Rect(Pen pen): this(Vector.Zero, Vector.Zero, pen)
        {
        }

        public Rect(Vector firstPoint, Vector secondPoint, Pen pen) {
            FirstPosition = firstPoint;
            SecondPosition = secondPoint;
            this.pen = (Pen) pen.Clone();
            this.thickness = 0.0;
        }

        public double Thickness { get { return thickness; } set {  thickness = value; } }
        public Vector FirstPosition { get { return firstPoint; } set { firstPoint = value; } }
        public Vector SecondPosition { get { return secondPoint; } set { secondPoint = value; } }
        public Pen Pen { get { return pen; } set { pen = value; } }
    }
}
