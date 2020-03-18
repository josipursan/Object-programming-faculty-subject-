using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV2
{
    class Linija : GrafObj
    {
        public Point secondPoint 
        {
            get;
            set;
        }

        public Linija () {}

        public Linija(Pen pen, Point startPoint, Point secondPoint) : base (pen, startPoint)
        {
            this.secondPoint = secondPoint;
        }

        public override void DrawMovable(Point startPoint, Point endPoint, Pen pen, Form form)
        {
            ControlPaint.DrawReversibleLine(form.PointToScreen(startPoint), form.PointToScreen(endPoint), pen.Color);
        }

        public override void DrawGraphObj(Graphics graph, Pen pen, Point startPoint, Point endPoint)
        {
            graph.DrawLine(pen, startPoint, endPoint);
        }
    }
}
