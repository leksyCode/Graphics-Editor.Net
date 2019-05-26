using Draw.src.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace Draw.src.Common
{
    public class Opener
    {
        public static void OpenFileAsPng(string path, Control control)
        {
            control.BackgroundImageLayout = ImageLayout.Zoom;
            control.BackgroundImage = Image.FromFile(path);           
            control.Invalidate();
        }

        public static void OpenFileAsDraw(string path, DoubleBufferedPanel viewPort)
        {
            /* unfortunately, it's impossible to make desirialization from an abstract class.
            Therefore, we initialize a new type of shape from an instance of shape and then desirialize json file 
            in the List<Shape> from which we create shapes by identifying them using shape.Type */

            var uploadList = JsonConvert.DeserializeObject<List<Shape>>(File.ReadAllText(path));
            foreach (var item in uploadList)
            {
                item.IsSelected = false;
                switch (item.Type)
                {                    
                    case "RectangleShape":
                        viewPort.AddShape(new RectangleShape(item));
                        break;
                    case "EllipseShape":
                        viewPort.AddShape(new EllipseShape(item));
                        break;
                    case "HeartShape":
                        viewPort.AddShape(new HeartShape(item));
                        break;
                    case "ImageShape":
                        viewPort.AddShape(new RectangleShape(item));
                        break;
                    case "LineShape":
                        viewPort.AddShape(new LineShape(item));
                        break;
                    case "StarShape":
                        viewPort.AddShape(new StarShape(item));
                        break;
                }
            }
        }
    }
}
