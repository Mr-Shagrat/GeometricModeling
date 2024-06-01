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
{
    public partial class GeometricModeling : Form
    {
        public GeometricModeling()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private System.Drawing.Point firstCorner;
        private List<Entities.Point> points = new List<Entities.Point>();
        private List<Entities.Line> lines = new List<Entities.Line>();
        private Vector currentPosition;
        private Vector firstPoint;
        private int ClickNum = 1;
        private int ClickZoom = 1;
        private bool active_drawing = false;
        private bool active_zoom = false;
        private Pen pen = new Pen(Color.Black, 0);
        private float XScroll;
        private float YScroll;
        private float ScaleFactor = 1.0f;
        private SizeF drawingSize = new SizeF(297, 210);

        //Эвент на движения курсора по рабочей области и отображение в label1 значение курсора по Х и У
        private void drawing_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            coordinate.Text = string.Format("{0,0:F3}, {1,0:F3}, {2,0:F3}", currentPosition.X, currentPosition.Y, currentPosition.Z);
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
            return new Vector((Pixel_to_Mn(point.X) + XScroll) / ScaleFactor, (Pixel_to_Mn(drawing.Height - point.Y) - YScroll) / ScaleFactor);
        }

        //Конвертация пикселей в милиметры
        private float Pixel_to_Mn(float pixel)
        {
            return pixel * 25.4f / DPI;
        }

        private void drawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (active_zoom)
                {
                    firstCorner = e.Location;
                    ClickZoom++;
                }
                if (active_drawing && !active_zoom)
                {
                    switch (ClickNum)
                    {
                        case 1:
                            firstPoint = currentPosition;
                            ClickNum++;
                            break;
                        case 2:
                            lines.Add(new Entities.Line(firstPoint, currentPosition, pen));
                            firstPoint = currentPosition;
                            break;
                    }
                }
                drawing.Refresh();

            }
        }

        private void drawing_Paint(object sender, PaintEventArgs e)
        {
            Pen extpen = new Pen(Color.Gray, 0);
            extpen.DashPattern = new float[] { 1.0f, 2.0f };

            e.Graphics.SetParameters(Pixel_to_Mn(drawing.Height), XScroll, YScroll, ScaleFactor);

            //line
            if (lines.Count > 0)
            {
                foreach (Entities.Line l in lines)
                {
                    e.Graphics.DrawLine(l.Pen, l);
                }
            }

            //lines 

                    if (ClickNum == 2)
                    {
                        Entities.Line line = new Entities.Line(firstPoint, currentPosition, pen);
                        e.Graphics.DrawLine(extpen, line);
                    }
       
        }

        #region Zoom
        private void SetZoomInOut(int index)
        {
            float scale = (index == 0) ? 1 / 1.25f : 1.25f;

            ScaleFactor *= scale;

            float width = drawing.ClientSize.Width * scale;
            float height = drawing.ClientSize.Height * scale;

            float wl = (drawing.ClientSize.Width - width) / 2;
            float hl = (drawing.ClientSize.Height - height) / 2;

            XScroll = XScroll * scale - Pixel_to_Mn(wl);
            YScroll = YScroll * scale + Pixel_to_Mn(hl);

            SetScrollBarValues();
        }
        #endregion

        #region cancel btn
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            active_drawing = false;
            drawing.Cursor = Cursors.Default;
            ClickNum = 1;
        }
        #endregion

        #region line btn
        private void lineBtn_Click(object sender, EventArgs e)
        {
            active_drawing = true;
            drawing.Cursor = Cursors.Cross;
        }
        #endregion

        #region line type
        private void straightLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void dashLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        private void dashDotLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void dashDotDotLine_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }
        #endregion

        #region line width
        private void halfDefaultWeight_Click(object sender, EventArgs e)
        {
            pen.Width = 0f;
        }

        private void defaultWeight_Click(object sender, EventArgs e)
        {
            pen.Width = 0.5f;

        }

        private void halfBoldWeight_Click(object sender, EventArgs e)
        { 
            pen.Width = 0.75f;
        }

        private void boldWeight_Click(object sender, EventArgs e)
        {
            pen.Width = 1f;
        }
        #endregion

        #region ScrollBar
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            XScroll = (sender as HScrollBar).Value;
            drawing.Refresh();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            YScroll = (sender as VScrollBar).Value;
            drawing.Refresh();
        }

        private void SetScrollBarValues()
        {
            float width = Math.Max(0, drawingSize.Width * ScaleFactor - Pixel_to_Mn(drawing.ClientSize.Width)) + 50 * ScaleFactor;
            float height = Math.Max(0, drawingSize.Height * ScaleFactor - Pixel_to_Mn(drawing.ClientSize.Height)) + 59 * ScaleFactor;

            hScrollBar.Maximum = (int)width;
            hScrollBar.Minimum = -(int)(50 * ScaleFactor);

            vScrollBar.Maximum = (int)(59 * ScaleFactor);
            vScrollBar.Minimum = -(int)height;

            try
            {
                hScrollBar.Minimum = (int)Math.Min(XScroll, hScrollBar.Minimum);
                hScrollBar.Maximum = (int)Math.Max(XScroll, hScrollBar.Maximum);
                vScrollBar.Minimum = (int)Math.Min(XScroll, vScrollBar.Minimum);
                vScrollBar.Maximum = (int)Math.Max(XScroll, vScrollBar.Maximum);

                hScrollBar.Value = (int)XScroll;
                vScrollBar.Value = (int)YScroll;
            }
            catch { }
            drawing.Refresh();
        }
        #endregion

        #region Zoom btn
        private void ZoomBtn_Click(object sender, EventArgs e)
        {
            var item = sender as RibbonButton;
            int index = zoomPanel.Items.IndexOf(item);
            SetZoomInOut(index);
        }
        #endregion

    }
}
