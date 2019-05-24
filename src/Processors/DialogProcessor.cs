using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties
        /// <summary>
        /// Избран елемент.
        /// </summary>
        public Shape Selection { get; set; }
        public List<Shape> Selections { get; set; } = new List<Shape>();
        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        public bool IsDragging { get; set; }

        public bool IsDrawingNewShape { get; set; }
        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        public PointF LastLocation { get; set; }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>

        public void AddShape(Shape shape)
        {
            if (shape.FillColor == Color.Empty)
            {               
                shape.FillColor = MainForm.FillColor;
            }
            if (shape.BorderColor == Color.Empty)
            {
                shape.BorderColor = MainForm.BorderColor;
            }
            shape.Type = shape.GetType().Name;           
            ShapeList.Add(shape);
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p">p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
            if (Selection != null)
            {
                Selection.Location = new PointF(Selection.Location.X + p.X - LastLocation.X, Selection.Location.Y + p.Y - LastLocation.Y);
                LastLocation = p;          
            }
        }

        public void SetFillColor(Color color)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.FillColor = color;
                }
            }
        }

        public void SetBorderColor(Color color)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.BorderColor = color;
                }        
            }
        }

        public void SetNewWidth(int width)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.Width = width;
                }
            }
        }

        public void SetNewHeight(int height)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.Height = height;
                }
                
            }
        }

        public void SetNewBorderWidth(int borderWidth, Color updateColor)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.BorderWidth = borderWidth;
                    item.BorderColor = updateColor;
                }
            }
        }

        public void SetNewTransparency(int transparency)
        {
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                     item.Transparency = transparency;
                }
            }
        }

        public void SetNewRotation(float rotation)
        {  
            if (Selections != null)
            {
                foreach (var item in Selections)
                {
                    item.Rotation = rotation;
                }
            }
        }
    }
}
