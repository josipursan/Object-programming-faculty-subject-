using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV2
{
    
    class Poligon : GrafObj
    {
        public List<Point> polygonPoints = new List<Point>();

        public Poligon() {}

        public Poligon (Pen pen)
        {
            this.pen = pen;
        }

        public override void DrawMovable(Point startPoint, Point endPoint, Pen pen, Form form) {}

        public override void DrawGraphObj(Graphics graph, Pen pen, Point startPoint, Point endPoint)
        {
            graph.DrawPolygon(pen, polygonPoints.ToArray());
        }

    }
}
