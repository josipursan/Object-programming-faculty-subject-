using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV2
{
    class Kruznica : Elipsa
    {
        public Kruznica () {}

        public Kruznica (Rectangle kvadar, Pen pen)
        {
            this.pen = pen;
            this.rectangle = kvadar;
        }

        public override void DrawMovable(Point startPoint, Point endPoint, Pen pen, Form form)
        {
            ControlPaint.DrawReversibleFrame(form.RectangleToScreen(rectangle), pen.Color, FrameStyle.Dashed);
        }

        public override void DrawGraphObj(Graphics graph, Pen pen, Point startPoint, Point endPoint)
        {
            graph.DrawEllipse(pen, rectangle);
        }
    }
}
