using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV2
{
    class Elipsa : GrafObj
    {
        public Rectangle rectangle;

        public Elipsa () {}

        public Elipsa(Rectangle kvadar, Pen pen)
        {
            this.rectangle = kvadar;
            this.pen = pen;
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
