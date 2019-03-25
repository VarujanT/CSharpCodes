using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseDown(object o, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                g.DrawEllipse(Pens.Red, e.X, e.Y, 100, 100);
                g.FillEllipse(Brushes.Green, e.X, e.Y, 100, 100);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                g.DrawEllipse(Pens.Red, e.X-50, e.Y-50, 100, 100);
                g.FillEllipse(Brushes.Green, e.X-50, e.Y-50, 100, 100);
            }
            else if(e.Button == MouseButtons.Right)
            {
                g.DrawRectangle(Pens.Red, e.X - 50, e.Y - 50, 100, 100);
                g.FillRectangle(Brushes.Green, e.X - 50, e.Y - 50, 100, 100);
            }
        }
    }
}