using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricModeling
{
    public static class GraphicsExtension
    {
        private static float Height;
        private static float XScroll;
        private static float YScroll;
        private static float ScaleFactor;

        public static void SetParameters(this System.Drawing.Graphics g, float height, float xscroll, float yscroll, float scaleFactor)
        {
            XScroll = xscroll;
            YScroll = yscroll;
            ScaleFactor = scaleFactor;
            Height = height;
        }

        public static void SetTransform(this System.Drawing.Graphics g)
        {
            g.PageUnit = System.Drawing.GraphicsUnit.Millimeter;
            g.TranslateTransform(0, Height);
            g.ScaleTransform(ScaleFactor, -ScaleFactor);
            g.TranslateTransform(-XScroll / ScaleFactor, YScroll / ScaleFactor);
        }

        public static void DrawPoint(this System.Drawing.Graphics g, System.Drawing.Pen pen, Entities.Point point)
        {
            g.SetTransform();
            System.Drawing.PointF p = point.Position.ToPointF;
            g.DrawEllipse(pen, p.X - 1, p.Y - 1, 2, 2);
            g.ResetTransform();
        }

        public static void DrawLine(this System.Drawing.Graphics g, System.Drawing.Pen pen, Entities.Line line)
        {
            g.SetTransform();
            //BresenhamAlgoritm.Bresenham4Line(g, pen, (int)line.StartPosition.X, (int)line.StartPosition.Y, (int)line.EndPosition.X, (int)line.EndPosition.Y);
            g.DrawLine(pen, line.StartPosition.ToPointF, line.EndPosition.ToPointF);
            g.ResetTransform();
        }


        public static void DrawCircle(this System.Drawing.Graphics g, System.Drawing.Pen pen, Entities.Circle circle)
        {
            float x = (float)(circle.Center.X - circle.Radius);
            float y = (float)(circle.Center.Y - circle.Radius);
            float d = (float)circle.Diameter;

            g.SetTransform();
            g.DrawEllipse(pen, x, y, d, d);
            g.ResetTransform();
        }

        public static void DrawRect(this System.Drawing.Graphics g, System.Drawing.Pen pen, Entities.Rect rect)
        {
            float x = (float)Math.Min(rect.FirstPosition.X, rect.SecondPosition.X);
            float y = (float)Math.Min(rect.FirstPosition.Y, rect.SecondPosition.Y);
            float w = (float)Math.Abs(rect.FirstPosition.X - rect.SecondPosition.X);
            float h = (float)Math.Abs(rect.FirstPosition.Y - rect.SecondPosition.Y);

            g.SetTransform();
            g.DrawRectangle(pen, x, y, w, h);
            g.ResetTransform();
        }
    }
}
