using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
	partial class DoubleBufferedPanel
	{

        // ShapeList is moved to DoubleBufferedDrawingPanel 
        //to be able to save different state for working with diferent files at the same time
        public List<Shape> ShapeList { get; set; } = new List<Shape>();
        public new string Name { get; set; }

        public DoubleBufferedPanel(string name)
        {
            this.Name = name;
        }

        public DoubleBufferedPanel(List<Shape> list)
        {
            this.ShapeList = list;
        }

        public DoubleBufferedPanel(string name, List<Shape> list)
        {
            this.Name = name;
            this.ShapeList = list;
        }

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
            // To know the shape type after deserialization from json file
            shape.Type = shape.GetType().Name;
            ShapeList.Add(shape);
        }

        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		public void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // DoubleBufferedPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.ResumeLayout(false);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MinimumSize = new System.Drawing.Size(480, 720);            
            this.Size = new System.Drawing.Size(1280, 720);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabIndex = 6;
          
        }
    }
}
