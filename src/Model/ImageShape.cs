using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.src.Model
{
    class ImageShape : Shape
    {

        public string Path { get; set; }

        public ImageShape()
        {
        }


        public ImageShape(Shape shape) : base(shape)
        {

        }

        public ImageShape(string path, RectangleShape rectangle) : base(rectangle)
        {
            Path = path;
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

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>

        public override void DrawSelf(Graphics grfx)
        {            
            if (BorderWidth != 0)
            {
                grfx.DrawRectangle(new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            }
            if (IsSelected == true)
            {
                grfx.DrawRectangle(new Pen(Color.Red), Rectangle.X - 3, Rectangle.Y - 3, Rectangle.Width + 6, Rectangle.Height + 6);
            }
            grfx.DrawImage(Image.FromFile(Path), Rectangle);
        }
    }
}
