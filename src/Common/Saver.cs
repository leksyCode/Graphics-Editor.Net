using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.src.Common
{
    public class Saver
    {
         
        public static void SaveFileAsDraw(string path, List<Shape> saveData)
        {
            // Serialize to json file 
            var json = JsonConvert.SerializeObject(saveData);
            File.WriteAllText(path, json);
        }

        public static void SaveFileAsPng(string path, Image saveImage)
        {
            saveImage.Save(path, ImageFormat.Png);          
        }
    }
}
