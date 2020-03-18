using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV2
{
    class Kvadar : Linija
    {
        public Rectangle kvadar;
        public Point endPoint;

        public Kvadar() {}

        public Kvadar(Pen pen, Point startPoint, Point secondPoint, Rectangle kvadar) : base(pen, startPoint, secondPoint)
        {
            this.kvadar = kvadar;
        }

        public Kvadar(Rectangle rectangle, Pen pen)
        {
            this.kvadar = rectangle;
            this.pen = pen;
        }

        public Kvadar(Pen pen, Point startPoint, Point secondPoint, Point finalPoint) : base(pen, startPoint, secondPoint)
        {
            this.endPoint = finalPoint;
        }

        public override void DrawMovable(Point startPoint, Point endPoint, Pen pen, Form form)
        {
            ControlPaint.DrawReversibleFrame(form.RectangleToScreen(kvadar), pen.Color, FrameStyle.Dashed);
        }

        public override void DrawGraphObj(Graphics graph, Pen pen, Point startPoint, Point endPoint)
        {
            graph.DrawRectangle(pen, kvadar);
        }

    }
}
