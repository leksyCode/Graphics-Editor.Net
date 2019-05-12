using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на дисплейната система.
	/// </summary>
	public class DisplayProcessor
	{
		#region Constructor
		
		public DisplayProcessor()
		{
		}
        public List<Shape> ShapeList { get; set; } = new List<Shape>();
        #endregion

        #region Drawing

        /// <summary>
        /// Прерисува всички елементи в shapeList върху e.Graphics
        /// </summary>
        public void ReDraw(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;            
            e.Graphics.ScaleTransform(MainForm.zoom, MainForm.zoom);
			Draw(e.Graphics);
		}
		
		/// <summary>
		/// Визуализация.
		/// Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
		/// </summary>
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		public virtual void Draw(Graphics grfx)
		{  
            foreach (Shape item in ShapeList){
				DrawShape(grfx, item);
			}
        }
		
		/// <summary>
		/// Визуализира даден елемент от изображението.
		/// </summary>
		/// <param name="grfx">Къде да се извърши визуализацията.</param>
		/// <param name="item">Елемент за визуализиране.</param>
		public virtual void DrawShape(Graphics grfx, Shape item)
        {
            //grfx.RotateTransform(item.Rotation);
            item.DrawSelf(grfx);
            //grfx.ResetTransform();

        }
		
		#endregion
	}
}
