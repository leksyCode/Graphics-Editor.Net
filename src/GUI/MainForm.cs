using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Draw.src.Common;

namespace Draw
{
    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        public static Color FillColor { get; set; } = new Color();
        public static Color BorderColor { get; set; } = new Color();
        public static Shape ShapeToDraw { get; set; } = new RectangleShape();
        public static int viewPortStaticWidth, viewPortStaticHeight;
        public static float zoom = 1;
        private Point _p, _p2;
        private Rectangle _r;
        int penWidth;

        public static List<Button> layoutButtons = new List<Button>();

        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        private DialogProcessor dialogProcessor = new DialogProcessor();

        public MainForm()
        {
            InitializeComponent();
        }

        private void viewPort_Load(object sender, EventArgs e)
        {
            viewPort.MouseWheel += new MouseEventHandler(viewPort_MouseWheel);
            viewPort.KeyPress += new KeyPressEventHandler(ViewPort_KeyPress);
            viewPortStaticWidth = viewPort.Width;
            viewPortStaticHeight = viewPort.Height;
        }      

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            if (dialogProcessor.IsDrawingNewShape)
            {
                // visualization of the drawing effects on a given rectangle (border) of shape
                if (ShapeToDraw is EllipseShape)
                {
                    e.Graphics.DrawEllipse(new Pen(Color.FromArgb(95, BorderColor), penWidth), _r);
                    e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(95, FillColor)), _r);
                }
                else if (ShapeToDraw is HeartShape)
                {
                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(new RectangleF(_r.X, _r.Y, _r.Width / 2, _r.Height / 2));
                    path.AddEllipse(new RectangleF(_r.X + _r.Width / 2, _r.Y, _r.Width / 2, _r.Height / 2));
                    PointF[] points = {new PointF(_r.X, _r.Y + _r.Height / 3.5f),
                    new PointF( _r.X + _r.Width / 2, _r.Bottom),
                    new PointF(_r.Right, _r.Y + _r.Height / 3.5f)};

                    e.Graphics.DrawPolygon(new Pen(Color.FromArgb(95, BorderColor)), points);
                    e.Graphics.DrawPath(new Pen(Color.FromArgb(95, BorderColor)), path);
                    e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(95, FillColor)), points);
                    e.Graphics.FillPath(new SolidBrush(Color.FromArgb(95, FillColor)), path);
                }
                else if (ShapeToDraw is RectangleShape)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.FromArgb(95, BorderColor), penWidth), _r);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(95, FillColor)), _r);
                }
                else if (ShapeToDraw is StarShape)
                {
                    PointF[] points = {
                    new PointF(_r.X + _r.Width / 2, _r.Y),
                    new PointF((_r.X + _r.Width / 2) + _r.Width/10, _r.Y + _r.Height/2 - _r.Height/8),
                    new PointF(_r.Right, _r.Y + _r.Height/2.5f),
                    new PointF((_r.X + _r.Width / 2) + _r.Width/6, _r.Y + _r.Height/2 + _r.Height/8),
                    new PointF(_r.X + _r.Width/2 + _r.Width/4, _r.Bottom),
                    new PointF(_r.X + _r.Width/2, _r.Y + _r.Height/2 + _r.Height/4),
                    new PointF(_r.X + _r.Width/2 - _r.Width/4, _r.Bottom),
                    new PointF((_r.X + _r.Width / 2) - _r.Width/6, _r.Y + _r.Height/2 + _r.Height/8),
                    new PointF(_r.X, _r.Y + _r.Height/2.5f),
                    new PointF((_r.X + _r.Width / 2) - _r.Width/10, _r.Y + _r.Height/2 - _r.Height/8),
                    };
                    e.Graphics.DrawPolygon(new Pen(Color.FromArgb(95, BorderColor), penWidth), points);
                    e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(95, FillColor)), points);
                }
                else if (ShapeToDraw is LineShape)
                {
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(95, BorderColor), penWidth + 1), _p, _p2);
                }
            }
            dialogProcessor.ReDraw(sender, e);
        }

        private void ViewPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 26 && ModifierKeys.HasFlag(Keys.Control) && dialogProcessor.ShapeList.Count != 0)
            {
                statusBar.Items[0].Text = "Last action: Ctrl + Z";
                dialogProcessor.ShapeList.RemoveAt(dialogProcessor.ShapeList.Count - 1);
                viewPort.Invalidate();
            }
        }

        private void cancelActionButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Last action: Ctrl + Z";
            dialogProcessor.ShapeList.Remove(dialogProcessor.ShapeList[dialogProcessor.ShapeList.Count - 1]);
            viewPort.Invalidate();
        }

        private void viewPort_MouseWheel(object sender, MouseEventArgs e)
        {
            // Sets the zoom to be used in the future
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.Delta > 0)
                {
                    zoom += 0.1f;
                    viewPort.Width = (int)(viewPortStaticWidth * zoom);
                    viewPort.Height = (int)(viewPortStaticHeight * zoom);
                    
                }
                else if (zoom <= 1)
                {
                    zoom = 1;
                }
                else
                {
                    zoom -= 0.1f;
                    viewPort.Width = (int)(viewPortStaticWidth * zoom);
                    viewPort.Height = (int)(viewPortStaticHeight * zoom);
                }
                zoomInfoLabel.Text = "Zoom:\n" + (zoom * 100).ToString() + "%";
                viewPort.Invalidate();
            }
        }


        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null)
                {
                    //move picked shape to top of list
                    dialogProcessor.ShapeList.Remove(dialogProcessor.Selection);
                    dialogProcessor.AddShape(dialogProcessor.Selection);

                    //  Add and remove in multiple selection using Ctrl 
                    if (ModifierKeys.HasFlag(Keys.Control))
                    {
                        if (!dialogProcessor.Selections.Contains(dialogProcessor.Selection))
                        {
                            dialogProcessor.Selections.Add(dialogProcessor.Selection);
                            dialogProcessor.Selections[dialogProcessor.Selections.Count - 1].IsSelected = true;
                        }
                        else
                        {
                            dialogProcessor.ShapeList.Find(s => s.Equals(dialogProcessor.Selection)).IsSelected = false;
                            dialogProcessor.Selections.Remove(dialogProcessor.Selection);
                        }
                    }
                    else
                    {
                        // When pressed without the shapes - remove all selections
                        for (int i = 0; i < dialogProcessor.Selections.Count - 1; i++)
                        {
                            dialogProcessor.Selections[i].IsSelected = false;
                            dialogProcessor.Selections.Remove(dialogProcessor.Selections[i]);
                        }
                    }
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;

                    // Output info
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";                   
                    infoLabel.Text = "Fill " + dialogProcessor.Selection.FillColor.ToString()
                    + " Border " + dialogProcessor.Selection.BorderColor.ToString() 
                    + "\n width: " + dialogProcessor.Selection.Width + "px;" + " height: " + dialogProcessor.Selection.Height + "px;"
                    + "\n border: " + dialogProcessor.Selection.BorderWidth.ToString() + "px;"
                    + " transparency: " + dialogProcessor.Selection.Transparency + "\n"
                    + " location: " + dialogProcessor.Selection.Location.ToString() + "\n"
                    + " shape: " + dialogProcessor.Selection.GetType().Name;
                } 
                viewPort.Invalidate();
            }
            if (pickUpButton.Checked)
            {
                dialogProcessor.IsDrawingNewShape = true;
                _p = e.Location;
            }
            if (eraseButton.Checked)
            {
                dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Last action: Erase primitive";
                    dialogProcessor.ShapeList.Remove(dialogProcessor.Selection);
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Влачене";
                    dialogProcessor.TranslateTo(e.Location);
                }
                   
                viewPort.Invalidate();
            }

            if (dialogProcessor.IsDrawingNewShape)
            {
                if (e.Button == MouseButtons.Left)
                {
                    // Create a bounding rectangle on the movement of the mouse which suports to draw shapes in viewPort Paint                   
                    _r = new Rectangle(new Point(Math.Min(_p.X, e.Location.X), Math.Min(_p.Y, e.Location.Y)),
                     new Size(Math.Abs(_p.X - e.Location.X), Math.Abs(_p.Y - e.Location.Y)));

                    // The same, but for LineShape
                    _p2 = e.Location;
                    statusBar.Items[0].Text = "Last action: Drawing new shape";
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, MouseEventArgs e)
        {

            dialogProcessor.IsDragging = false;
            if (dialogProcessor.IsDrawingNewShape)
            {
                // Specify a rectangle as the basis for creating a shape with zoom scale of viewPort
                RectangleShape rect = new RectangleShape(new RectangleF(new PointF(Math.Min(_p.X, e.Location.X) / zoom, Math.Min(_p.Y, e.Location.Y) / zoom),
                new SizeF(Math.Abs(_p.X - e.Location.X) / zoom, Math.Abs(_p.Y - e.Location.Y) / zoom)));

                rect.BorderWidth = penWidth;
                rect.Transparency = (int)transparencyPicker.Value;
                rect.Rotation = (float) rotationPicker.Value;

                if (ShapeToDraw is RectangleShape)
                {
                    dialogProcessor.AddShape(rect);
                }
                else if (ShapeToDraw is EllipseShape)
                {
                    dialogProcessor.AddShape(new EllipseShape(rect));
                }
                else if (ShapeToDraw is HeartShape)
                {
                    dialogProcessor.AddShape(new HeartShape(rect));
                }
                else if(ShapeToDraw is StarShape)
                {
                    dialogProcessor.AddShape(new StarShape(rect));
                }
                else if (ShapeToDraw is LineShape)
                {
                    dialogProcessor.AddShape(new LineShape(new PointF(_p.X / zoom, _p.Y / zoom), new PointF(_p2.X / zoom, _p2.Y / zoom), penWidth, rect.Transparency));
                }
                dialogProcessor.IsDrawingNewShape = false;
                viewPort.Invalidate();
            }

        }


        private void fillColorButton_Click(object sender, EventArgs e)
        {
            colorButton.Text = "Fill";
            colorBox.BackColor = FillColor;
            viewPort.Invalidate();
        }


        private void borderColorButton_Click(object sender, EventArgs e)
        {
            colorButton.Text = "Border";
            colorBox.BackColor = BorderColor;
            viewPort.Invalidate();
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            // Change selected color or button
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorBox.BackColor = colorDialog1.Color;
                if (colorButton.Text == "Border")
                {
                    BorderColor = colorDialog1.Color;
                    dialogProcessor.SetBorderColor(BorderColor);
                }
                else
                {
                    FillColor = colorDialog1.Color;
                    dialogProcessor.SetFillColor(FillColor);
                }
                viewPort.Invalidate();
            }
        }

        private void drawButton(object sender, EventArgs e)
        {
            pickUpSpeedButton.Checked = false;
            eraseButton.Checked = false;
        }

        private void pickUpButton_Click(object sender, EventArgs e)
        {
            pickUpButton.Checked = false;
            eraseButton.Checked = false;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            pickUpButton.Checked = false;
            pickUpSpeedButton.Checked = false;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeToDraw = new RectangleShape();
            shapeButton.Image = rectangleButton.Image;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeToDraw = new EllipseShape();
            shapeButton.Image = ellipseButton.Image;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeToDraw = new HeartShape();
            shapeButton.Image = heartButton.Image;
        }

        private void starToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShapeToDraw = new StarShape();
            shapeButton.Image = starButton.Image;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeToDraw = new LineShape();
            shapeButton.Image = lineButton.Image;
        }

        private void heightPicker_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewHeight((int)heightPicker.Value);
            viewPort.Invalidate();
        }

        private void widthPicker_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewWidth((int)widthPicker.Value);
            viewPort.Invalidate();
        }


        private void penWidthPicker_ValueChanged(object sender, EventArgs e)
        {
            penWidth = Convert.ToInt32(penWidthPicker.Value);
            dialogProcessor.SetNewBorderWidth(penWidth, BorderColor);
            viewPort.Invalidate();
        }
     
        private void transparencyPicker_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewTransparency((int)transparencyPicker.Value);
            viewPort.Invalidate();
        }


        private void openFileDrawButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.draw;)| *.draw; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Opener.OpenFileAsDraw(open.FileName, dialogProcessor);
            }

            statusBar.Items[0].Text = "Last action: Uploading project file as draw";
            viewPort.Invalidate();
        }

        private void openFilePngButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png;)| *.png; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Opener.OpenFileAsPng(open.FileName, viewPort);
            }
            viewPort.Invalidate();
        }


        private void saveFileAsDrawButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files(*.draw;)| *.draw; ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Saver.SaveFileAsDraw(save.FileName, dialogProcessor.ShapeList);
            }
            statusBar.Items[0].Text = "Last action: Save project file as draw";
        }

        private void saveFileAsPngButton_Click(object sender, EventArgs e)
        {
            //Drawing our viewPort control to bitmap and then save it
            Bitmap bitmap = new Bitmap(viewPortStaticWidth, viewPortStaticHeight);
            viewPort.DrawToBitmap(bitmap, new Rectangle(0, 0, viewPortStaticWidth, viewPortStaticHeight));

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files(*.png;)| *.png; ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Saver.SaveFileAsPng(save.FileName, bitmap);
            }          
            statusBar.Items[0].Text = "Last action: Save project file as png";
        }


        private void rotationPicker_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewRotation((float)rotationPicker.Value);
            viewPort.Invalidate();
        }


        private void addImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ShapeToDraw = new ImageShape();
                dialogProcessor.AddShape(new ImageShape(open.FileName, new RectangleShape(new RectangleF(0, 0, Image.FromFile(open.FileName).Width / 2, Image.FromFile(open.FileName).Height / 2))));
            }

            //layoutButtons.Add(new Button());
            //foreach (var item in layoutButtons)
            //{
            //    item.BackgroundImage = Image.FromFile(open.FileName);
            //    item.FlatStyle = FlatStyle.Flat;
            //    item.BackColor = Color.FromArgb(0, Color.White);
            //    item.BackgroundImageLayout = ImageLayout.Zoom;
            //    item.TextAlign = ContentAlignment.MiddleLeft;
            //    item.Text = "layout" + layoutButtons.Count.ToString();
            //    item.ForeColor = Color.White;
            //    item.Size = new Size(layoutPanel.Width, 65);
            //    layoutPanel.Controls.Add(item);
            //}
            viewPort.Invalidate();
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitMenuButton(object sender, EventArgs e)
        {
            Close();
        }
    }
}

