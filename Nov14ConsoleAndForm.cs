using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using static System.Console;

namespace ConsoleAndForm
{
    class Program
    {
        static Rectangle rect = new Rectangle(0, 0, 100, 100);
        static int x = 0;
        static int y = 0;
        static int dx = 5;
        static int dy = 5;
        static Timer tm = new Timer();
        static LinearGradientBrush lgb = new LinearGradientBrush(new Point(x, y), new Point(x + 100, y + 100), Color.Red, Color.Black);
        static Pen pen = new Pen(lgb, 4);
        static Form form = new Form();

        static void Main(string[] args)
        {
            form.Width = 700;
            form.Height = 500;
            tm.Interval = 100;
            tm.Tick += Tm_Tick;
            form.Paint += Form_Paint;
            pen.DashStyle = DashStyle.Dot;
            tm.Start();
            lgb.WrapMode = WrapMode.TileFlipX;
            Application.Run(form);

            
        }

        private static void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, rect);
            g.FillEllipse(lgb, rect);
        }

        private static void Tm_Tick(object sender, EventArgs e)
        {
            if(x+ 100 > form.Width || x<0)
            {
                dx = -dx;
            }
            if (y +100 > form.Height || y < 0)
            {
                dy = -dy;
            }
            x += dx;
            y += dy;
            rect = new Rectangle(x, y,100,100);
            form.Invalidate();

        }
    }
}