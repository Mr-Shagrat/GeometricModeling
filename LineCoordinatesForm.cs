using GeometricModeling.Entities;
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
    public partial class LineCoordinatesForm : Form
    {
        public LineCoordinatesForm()
        {
            InitializeComponent();
        }

        public Vector firstPoint { get; private set; }
        public Vector secondPoint { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            firstPoint = new Vector(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text));
            secondPoint = new Vector(Double.Parse(textBox3.Text), Double.Parse(textBox4.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
