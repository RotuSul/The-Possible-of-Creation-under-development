using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows;
using System.Media;

namespace The_Possible_of_Creation
{
    public class GraficPixel3D
    {
        public void Grafic3D(System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black);

                Point point1 = new Point(0, 100);
                Point point2 = new Point(100, 0);
                e.Graphics.DrawLine(blackPen, point1, point2);

        }
    }
}
