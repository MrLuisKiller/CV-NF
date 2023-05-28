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
    public class MLKCheckBox : CheckBox
    {
        private Color checkedColor = Color.Purple, unCheckedColor = Color.Gray;

        [Category("MLK - Appearence")]
        public Color CheckedColor
        {
            get => checkedColor;
            set
            {
                checkedColor = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public Color UnCheckedColor
        {
            get => unCheckedColor;
            set
            {
                unCheckedColor = value;
                Invalidate();
            }
        }

        public MLKCheckBox()
        {
            Font = new Font(Font.Name, 9.5F);
            MinimumSize = new Size(20, 30);
            Padding = new Padding(10, 0, 0, 0);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float cbBorderSize = 18F, cbCheckSize = 12F;
            RectangleF rectCbBorder = new RectangleF()
            {
                X = .5F,
                Y = (Height - cbBorderSize) / 2,
                Width = cbBorderSize,
                Height = cbBorderSize
            };
            RectangleF rectCbCheck = new RectangleF()
            {
                X = rectCbBorder.X + ((rectCbBorder.Width - cbCheckSize) / 2),
                Y = (Height - cbCheckSize) / 2,
                Width = cbCheckSize,
                Height = cbCheckSize
            };
            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushCbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(ForeColor))
            {
                graphics.Clear(BackColor);
                if (Checked)
                {
                    graphics.DrawEllipse(penBorder, rectCbBorder);
                    graphics.FillEllipse(brushCbCheck, rectCbCheck);
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectCbBorder);
                }
                graphics.DrawString(Text, Font, brushText, cbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
            }
        }
    }
}
