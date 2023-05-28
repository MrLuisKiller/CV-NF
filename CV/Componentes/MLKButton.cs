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
    public class MLKButton : Button
    {
        private int borderSize = 1, borderRadius = 10;
        private Color borderColor = Color.Purple;

        private void Error(int MIN, int MAX) => MessageBox.Show($"This value is out of range.\nThe range is from {MIN} to {MAX}.", "MLK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        [Category("MLK - Appearence")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                if (value >= 0 && value <= 3)
                {
                    borderSize = value;
                    Invalidate();
                }
                else
                    Error(0, 3);
            }
        }

        [Category("MLK - Appearence")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value == 0 || value >= 2 && value <= 30)
                {
                    borderRadius = value;
                    Invalidate();
                }
                else
                    Error(2, 30);
            }
        }

        [Category("MLK - Appearence")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

        [Category("MLK - Appearence")]
        public Color BackgroundColor { get => BackColor; set => BackColor = value; }

        [Browsable(false)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        [Category("MLK - Appearence")]
        public Color TextColor { get => ForeColor; set => ForeColor = value; }

        public MLKButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font(Font.Name, 9.5F);
            Size = new Size(100, 30);
            BackgroundColor = Color.MediumSlateBlue;
            TextColor = Color.White;
            Resize += new EventHandler(Button_Resize);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;
            if (borderRadius >= 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                    using (Pen penBorder = new Pen(BorderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Container_BackColorChanged(object sender, EventArgs e) => Invalidate();
    }
}
