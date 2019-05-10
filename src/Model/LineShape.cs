using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    class LineShape : Shape
    {
        public PointF P1 { get; set; }
        public PointF P2 { get; set; }

        public LineShape()
        {

        }

        public LineShape(PointF p1, PointF p2, int penwidth, int transparency)
        {
            P1 = p1;
            P2 = p2;
            BorderWidth = penwidth;
            Transparency = transparency;
        }

        public LineShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        public override bool Contains(PointF point)
        {
            float result = (point.X / MainForm.zoom - P1.X) / (P2.X - P1.X) - (point.Y / MainForm.zoom - P1.Y) / (P2.Y - P1.Y);
            if (result < 0.02 && result > -0.02)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            grfx.DrawLine(new Pen(Color.FromArgb(Transparency, FillColor), BorderWidth+1), P1, P2);
        }
    }  
}
