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
    public class MLKDateTimePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue, borderColor = Color.Purple;
        private Color textColor = Color.White;
        private int borderSize = 1;
        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int ArrowIconWidth = 17;

        private void Error(int MIN, int MAX) => MessageBox.Show($"This value is out of range.\nThe range is from {MIN} to {MAX}.", "MLK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        [Category("MLK - Appearence")]
        public Color SkinColor
        {
            get => skinColor;
            set
            {
                skinColor = value;
                calendarIcon = skinColor.GetBrightness() >= .8F ? Properties.Resources.calendarDark : Properties.Resources.calendarWhite;
                Invalidate();
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

        [Category("MLK - Appearence")]
        public Color TextColor
        {
            get => textColor;
            set
            {
                textColor = value;
                Invalidate();
            }
        }

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

        public MLKDateTimePicker()
        {
            SetStyle(ControlStyles.UserPaint, true);
            MinimumSize = new Size(0, 30);
            Font = new Font(Font.Name, 9.5F);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics graphics = e.Graphics)
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, Width - .5F, Height - .5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.Alignment = StringAlignment.Center;
                textFormat.LineAlignment = StringAlignment.Center;
                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString(Text, Font, textBrush, clientArea, textFormat);
                if (droppedDown)
                    graphics.FillRectangle(openIconBrush, iconArea);
                else
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                graphics.DrawImage(calendarIcon, Width - calendarIcon.Width - 9, (Height - calendarIcon.Height) / 2);
            }
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
            Invalidate();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(Width - iconWidth, 0, iconWidth, Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Cursor = iconButtonArea.Contains(e.Location) ? Cursors.Hand : Cursors.Default;
        }

        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(Text, Font).Width;
            return textWidth <= Width - (calendarIconWidth + 20) ? calendarIconWidth : ArrowIconWidth;
        }
    }
}
