using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricModeling
{//9 10 5 11 23 24 25
    public partial class GeometricModeling : Form
    {
        public GeometricModeling()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private List<Entities.Point> points = new List<Entities.Point>();
        private List<Entities.Line> lines = new List<Entities.Line>();
        private Vector currentPosition;
        private Vector firstPoint;
        private int ClickNum = 1;
        private int DrawIndex = -1;
        private bool active_drawing = false;

        //Эвент на движения курсора по рабочей области и отображение в label1 значение курсора по Х и У
        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            label1.Text = string.Format("x = {0}, y = {1}", e.Location.X, e.Location.Y);
            label2.Text = string.Format("x = {0,0:F3}, y = {1,0:F3}", currentPosition.X, currentPosition.Y);
            drawing.Refresh();
        }

        //Получение DPI экрана
        private float DPI
        {
            get
            {
                using (var g = CreateGraphics())
                    return g.DpiX;
            }
        }

        //Конвертация 
        private Vector PointToCartesian(Point point)
        {
            return new Vector(Pixel_to_Mn(point.X), Pixel_to_Mn(drawing.Height - point.Y));
        }

        //Конвертация пикселей в милиметры
        private float Pixel_to_Mn(float pixel)
        {
            return pixel * 25.4f / DPI;
        }

        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && active_drawing)
            {
                switch (DrawIndex)
                {

                    case 0: //point
                        points.Add(new Entities.Point(currentPosition));
                        break;
                    case 1: //line
                        switch (ClickNum)
                        {
                            case 1:
                                firstPoint = currentPosition;
                                ClickNum++;
                                break;
                            case 2:
                                lines.Add(new Entities.Line(firstPoint, currentPosition));
                                firstPoint = currentPosition;
                                break;
                        }
                        break;
                }
                drawing.Refresh();

            }
        }

        private void drawing_Paint(object sender, PaintEventArgs e)
        {
            Pen extpen = new Pen(Color.Gray, 0);
            extpen.DashPattern = new float[] { 1.0f, 2.0f };

            e.Graphics.SetParameters(Pixel_to_Mn(drawing.Height));

            //point
            if (points.Count > 0)
            {
                foreach(Entities.Point p in points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.Red), p);
                }
            }

            //line
            if (lines.Count > 0)
            {
                foreach (Entities.Line l in lines)
                {
                    e.Graphics.DrawLine(new Pen(Color.Green), l);
                }
            }

            //lines 
            switch(DrawIndex)
            {
                case 1:
                    if (ClickNum == 2)
                    {
                        Entities.Line line = new Entities.Line(firstPoint, currentPosition);
                        e.Graphics.DrawLine(extpen, line);
                    }
                    break;
            }
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 0;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            DrawIndex = 1;
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawIndex = -1;
            active_drawing = false;
            drawing.Cursor = Cursors.Default;
            ClickNum = 1;
        }
    }
}
