using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

       

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point, DoubleBufferedPanel vPort)
        {
            for (int i = vPort.ShapeList.Count - 1; i >= 0; i--)
            {
                if (vPort.ShapeList[i].Contains(point))
                {
                    return vPort.ShapeList[i];
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

        public string ShowDialog(string text, string caption)
        {
            // Universal dialog form            
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,                
            };            
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text};
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close();};
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
