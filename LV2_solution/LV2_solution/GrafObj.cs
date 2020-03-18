using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LV2
{
    public abstract class GrafObj
    {
        public Point firstPoint
        {
            get;
            set;
        }

        public Color color
        {
            get;
            set;
        }

        public Pen pen
        {
            get;
            set;
        }

        public GrafObj() {}

        public GrafObj(Pen pen, Point point)
        {
            this.pen = pen;
            this.firstPoint = point;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public Color GetColor()
        {
            return this.color;
        }

        public Point getStartingPoint()
        {
            return this.firstPoint;
        }

        public virtual void DrawMovable(Point startPoint, Point endPoint, Pen pen, Form form) {}
        public virtual void DrawGraphObj(Graphics graph, Pen pen, Point startPoint, Point endPoint) {}

    }
}
