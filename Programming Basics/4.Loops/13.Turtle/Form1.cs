using System;
using Nakov.TurtleGraphics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nakov.TurtleGraphics.Turtle.Rotate(30);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);
            Nakov.TurtleGraphics.Turtle.Rotate(120);
            Nakov.TurtleGraphics.Turtle.Forward(200);

        }
    }
}
