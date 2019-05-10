using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    class EllipseShape : Shape
    {
        public EllipseShape()
        {

        }

        public EllipseShape(Shape shape)
        {

        }

        public EllipseShape(RectangleShape rectangle) : base(rectangle)
        {
            
        }


        public override bool Contains(PointF point)
        {
            int a = (int)Width / 2, b = (int)Height / 2;
            Point centreOfEllipse = new Point((int)(Location.X + a), (int)(Location.Y + b));
            int left = (int)(Math.Pow((point.X - centreOfEllipse.X), 2) / Math.Pow(a, 2));
            int right = (int)(Math.Pow((point.Y - centreOfEllipse.Y), 2) / Math.Pow(b, 2));
            if (left + right <= 0)
            {
                return true;   
            }
            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {           
            if (BorderWidth != 0)
            {
                grfx.DrawEllipse(new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth), Rectangle);
            }
            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle);
        }
    }
}
