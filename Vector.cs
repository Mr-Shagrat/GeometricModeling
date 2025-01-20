using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling
{
    public class Vector
    {
        private double x;
        private double y;   
        private double z;

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
            Z = 0.0;
        }

        public Vector(double x, double y, double z) : this(x, y)
        {
            Z = z;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public System.Drawing.PointF ToPointF
        {
            get
            {
                return new System.Drawing.PointF((float) X, (float) Y);
            }
        }

        public static Vector Zero
        {
            get { return new Vector(0.0, 0.0, 0.0);}
        }

        public double DistanceForm(Vector v) {
            double dx = v.X - X;
            double dy = v.Y - Y;
            double dz = v.Z- Z;

            return Math.Sqrt(dx * dx  + dy * dy + dz * dz);
        }
    }
}
