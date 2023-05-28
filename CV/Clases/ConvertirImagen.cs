using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace CV.Clases
{
    public class ConvertirImagen
    {
        public Byte[] ImagenAByte(Image img)
        {
            MemoryStream MS = new MemoryStream();
            img.Save(MS, ImageFormat.Png);
            return MS.ToArray();
        }

        public Image ByteAImagen(Byte[] ByteArray)
        {
            MemoryStream MS = new MemoryStream(ByteArray);
            return Image.FromStream(MS);
        }

        public object Dash(int OP, String X)
        {
            switch (X)
            {
                case "Dash":
                    return DashStyle.Dash;
                case "Dot":
                    return DashStyle.Dot;
                case "DashDot":
                    return DashStyle.DashDot;
                case "DashDotDot":
                    return DashStyle.DashDotDot;
                case "Round":
                    return DashCap.Round;
                case "Triangle":
                    return DashCap.Triangle;
                default:
                    if (OP == 1)
                        return DashStyle.Solid;
                    else
                        return DashCap.Flat;
            }
        }
    }
}
