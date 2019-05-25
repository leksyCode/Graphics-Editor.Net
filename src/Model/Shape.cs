using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	public  class Shape
	{
		#region Constructors
		
		public Shape()
		{
		}
		
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}


        public Shape(Shape shape)
		{
            Type = shape.Type;
            this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;			
			this.FillColor =  shape.FillColor;
            this.BorderColor = shape.BorderColor;
            this.BorderWidth = shape.BorderWidth;
            this.Transparency = shape.Transparency;
            this.Rotation = shape.Rotation;
            this.IsSelected = shape.IsSelected;
        }
        #endregion

        #region Properties

        private string type;
        public virtual string Type
        {
            get { return type; }
            set { type = value; }
        }

        private bool isSelected;
        public virtual bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        /// <summary>
        /// Обхващащ правоъгълник на елемента.
        /// </summary>
        private RectangleF rectangle;		
		public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}


        /// <summary>
        /// Широчина на елемента.
        /// </summary>
        public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		
		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}
		
		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor;		
		public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}


        /// <summary>
        /// Цвят на граница.
        /// </summary>
        public virtual Color BorderColor { get; set; }

        private int borderWidth;
        public virtual int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; }
        }

        private int transparency;
        public virtual int Transparency
        {
            get { return transparency;  }
            set { transparency = value; }
        }

        private float rotation;
        public virtual float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }


        #endregion


        /// <summary>
        /// Проверка дали точка point принадлежи на елемента.
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns>Връща true, ако точката принадлежи на елемента и
        /// false, ако не пренадлежи</returns>
        public virtual bool Contains(PointF point)
		{
            return Rectangle.Contains(point.X, point.Y);           
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
            if (BorderWidth != 0)
            {
                grfx.DrawRectangle(new Pen(Color.FromArgb(Transparency, BorderColor), BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            }
            if (IsSelected == true)
            {
                grfx.DrawRectangle(new Pen(Color.Red), Rectangle.X - 3, Rectangle.Y - 3, Rectangle.Width + 6, Rectangle.Height + 6);
            }
            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
           
        }
		
	}
}
