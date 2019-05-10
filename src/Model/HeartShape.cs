using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    class HeartShape : Shape
    {
        public HeartShape()
        {

        }

        public HeartShape(Shape shape)
        {

        }

        public HeartShape(RectangleShape rectangle) : base(rectangle)
        {

        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width / 2, Rectangle.Height / 2));
            path.AddEllipse(new RectangleF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y, Rectangle.Width / 2, Rectangle.Height / 2));
            PointF[] points = {new PointF(Rectangle.X, Rectangle.Y + Rectangle.Height / 3.5f),
                    new PointF( Rectangle.X + Rectangle.Width / 2, Rectangle.Bottom),
                    new PointF(Rectangle.Right, Rectangle.Y + Rectangle.Height / 3.5f)};

            if (BorderWidth != 0)
            {
                grfx.DrawPath(new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth), path);
                grfx.DrawPolygon(new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth), points);
            }
            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Transparency, FillColor)), points);
            grfx.FillPath(new SolidBrush(Color.FromArgb(Transparency, FillColor)), path);
           


        }

    }
}
