using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
        public static string FilePath;
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
            layoutButtons.Add(button1);
        }

        private void viewPort_Load(object sender, EventArgs e)
        {
            viewPort.MouseWheel += new MouseEventHandler(viewPort_MouseWheel);
            viewPort.KeyPress += new KeyPressEventHandler(viewPort_KeyPress);
            viewPortStaticWidth = viewPort.Width;
            viewPortStaticHeight = viewPort.Height;
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            if (dialogProcessor.IsDrawingNewShape)
            {
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

        private void viewPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyChar == 26 && dialogProcessor.ShapeList.Count != 0)
            {
                statusBar.Items[0].Text = "Last action: Ctrl + Z";
                dialogProcessor.ShapeList.RemoveAt(dialogProcessor.ShapeList.Count - 1);
                viewPort.Invalidate();
            }
        }

        private void cancelActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Last action: Ctrl + Z";
            dialogProcessor.ShapeList.Remove(dialogProcessor.ShapeList[dialogProcessor.ShapeList.Count - 1]);
            viewPort.Invalidate();
        }

        private void viewPort_MouseWheel(object sender, MouseEventArgs e)
        {
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
                label6.Text = "Zoom:\n" + (zoom * 100).ToString() + "%";
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
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    if (!dialogProcessor.Selections.Contains(dialogProcessor.Selection) && dialogProcessor.Selection != null)
                    {
                        dialogProcessor.Selections.Add(dialogProcessor.Selection);
                        dialogProcessor.Selections[dialogProcessor.Selections.Count - 1].IsSelected = true;
                    }
                    else
                    {
                        dialogProcessor.Selections.Remove(dialogProcessor.Selection);
                        dialogProcessor.ShapeList.Find(s => s.Equals(dialogProcessor.Selection)).IsSelected = false;
                    }
                }
                else
                {
                    for (int i = 0; i < dialogProcessor.Selections.Count - 1; i++)
                    {
                        dialogProcessor.Selections[i].IsSelected = false;
                        dialogProcessor.Selections.Remove(dialogProcessor.Selections[i]);
                    }
                    
                }

                if (dialogProcessor.Selection != null)
                {
                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    //numericUpDown1.Value = dialogProcessor.Selection.BorderWidth;
                    //numericUpDown2.Value = (decimal)dialogProcessor.Selection.Width;
                    //numericUpDown3.Value = (decimal)dialogProcessor.Selection.Height;
                    //numericUpDown4.Value = dialogProcessor.Selection.Transparency;
                    //numericUpDown5.Value = (decimal)dialogProcessor.Selection.Rotation;

                    label8.Text = dialogProcessor.Selection.BorderColor.ToString()
                    + "\n" + dialogProcessor.Selection.FillColor.ToString()
                    + "\n width: " + dialogProcessor.Selection.Width + "\n height: " + dialogProcessor.Selection.Height
                    + "\n border: " + dialogProcessor.Selection.BorderWidth.ToString() + "px"
                    + "\n transparency: " + dialogProcessor.Selection.Transparency + "\n"
                    + "\n location: " + dialogProcessor.Selection.Location.ToString() + "\n"
                    + " shape: " + dialogProcessor.Selection.GetType();
                }

                viewPort.Invalidate();
            }
            if (toolStripButton1.Checked)
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
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }

            if (dialogProcessor.IsDrawingNewShape)
            {
                if (e.Button == MouseButtons.Left)
                {
                    statusBar.Items[0].Text = "Last action: Drawing new shape";
                    _r = new Rectangle(new Point(Math.Min(_p.X, e.Location.X), Math.Min(_p.Y, e.Location.Y)),
                     new Size(Math.Abs(_p.X - e.Location.X), Math.Abs(_p.Y - e.Location.Y)));
                    _p2 = e.Location;
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
            if (dialogProcessor.IsDrawingNewShape)
            {
                RectangleShape rect = new RectangleShape(new RectangleF(new PointF(Math.Min(_p.X, e.Location.X) / zoom, Math.Min(_p.Y, e.Location.Y) / zoom),
                new SizeF(Math.Abs(_p.X - e.Location.X) / zoom, Math.Abs(_p.Y - e.Location.Y) / zoom)));

                rect.BorderWidth = penWidth;
                rect.Transparency = (int)numericUpDown4.Value;
                rect.Rotation = (float) numericUpDown5.Value;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }



        private void fillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorButton.Text = "Fill";
            colorBox.BackColor = FillColor;
            viewPort.Invalidate();
        }


        private void borderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorButton.Text = "Border";
            colorBox.BackColor = BorderColor;
            viewPort.Invalidate();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colorBox_Click(object sender, EventArgs e)
        {
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            pickUpSpeedButton.Checked = false;
            eraseButton.Checked = false;
        }

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            eraseButton.Checked = false;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
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

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewHeight((int)numericUpDown3.Value);
            viewPort.Invalidate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewWidth((int)numericUpDown2.Value);
            viewPort.Invalidate();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            penWidth = Convert.ToInt32(numericUpDown1.Value);
            dialogProcessor.SetNewBorderWidth(penWidth, BorderColor);
            viewPort.Invalidate();
        }
     
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewTransparency((int)numericUpDown4.Value);
            viewPort.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                viewPort.BackgroundImage = Image.FromFile(open.FileName);
            }
            viewPort.Invalidate();
        }


        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SetNewRotation((float)numericUpDown5.Value);
            viewPort.Invalidate();
        }


        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ShapeToDraw = new ImageShape();
                FilePath = open.FileName;
            }

            dialogProcessor.AddShape(new ImageShape(FilePath, new RectangleShape(new RectangleF(0, 0, Image.FromFile(FilePath).Width / 2, Image.FromFile(FilePath).Height / 2))));
            
            layoutButtons.Add(new Button());
            foreach (var item in layoutButtons)
            {
                item.BackgroundImage = Image.FromFile(FilePath);
                item.FlatStyle = FlatStyle.Flat;
                item.BackColor = Color.FromArgb(0, Color.White);
                item.BackgroundImageLayout = ImageLayout.Zoom;
                item.TextAlign = ContentAlignment.MiddleLeft;
                item.Text = "layout" + layoutButtons.Count.ToString();
                item.ForeColor = Color.White;
                item.Size = new Size(layoutPanel.Width, 65);
                layoutPanel.Controls.Add(item);
            }

            viewPort.Invalidate();
        }
    }
}

