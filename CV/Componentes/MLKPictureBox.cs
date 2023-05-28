using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CV.Componentes
{
    public class MLKPictureBox : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor1 = Color.HotPink, borderColor2 = Color.Purple;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        private void Error(int MIN, int MAX) => MessageBox.Show($"This value is out of range.\nThe range is from {MIN} to {MAX}.", "MLK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        [Category("MLK - Appearence")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                if (value >= 0 && value <= 10)
                {
                    borderSize = value;
                    Invalidate();
                }
                else
                    Error(0, 10);
            }
        }

        [Category("MLK - Appearence")]
        public Color BorderColor1
        {
            get => borderColor1;
            set
            {
                borderColor1 = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public Color BorderColor2
        {
            get => borderColor2;
            set
            {
                borderColor2 = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public DashStyle BorderLineStyle
        {
            get => borderLineStyle;
            set
            {
                borderLineStyle = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public DashCap BorderCapStyle
        {
            get => borderCapStyle;
            set
            {
                borderCapStyle = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        public MLKPictureBox()
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            Rectangle rectContourSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            Rectangle rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            float smoothSize = borderSize > 0 ? borderSize * 3 : 1;
            using (LinearGradientBrush borderGColor = new LinearGradientBrush(rectBorder, borderColor1, borderColor2, gradientAngle))
            using (GraphicsPath pathRegion = new GraphicsPath())
            using (Pen penSmooth = new Pen(Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderGColor, borderSize))
            {
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graphics.DrawEllipse(penBorder, rectBorder);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Height);
        }
    }
}
