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
    [DefaultEvent("TextChanged")]
    public class MLKMaskedTextBox : UserControl
    {
        private Color borderColor = Color.Purple, borderFocusColor = Color.MediumSlateBlue;
        private Color placeholderColor = Color.Purple;
        private int borderSize = 1, borderRadius = 10;
        private String placeholderText = "";
        private HorizontalAlignment placeholderTextAlign = HorizontalAlignment.Left, textAlign = HorizontalAlignment.Left;
        private bool underlinedStyle = false;
        private String text = null, mask = null;
        private bool isPasswordChar = false;
        private bool isFocused = false, isPlaceholder = false;
        private MaskedTextBox maskedTextBox;

        private void Error(int MIN, int MAX) => MessageBox.Show($"This value is out of range.\nThe range is from {MIN} to {MAX}.", "MLK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        [Category("MLK - Appearence")]
        public Color BorderColor
        { get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set
            {
                borderFocusColor = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                    maskedTextBox.ForeColor = value;
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

        [Category("MLK - Appearence")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0 && value <= 20)
                {
                    borderRadius = value;
                    Invalidate();
                }
                else
                    Error(0, 20);
            }
        }

        [Category("MLK - Appearence")]
        public String PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                maskedTextBox.Text = "";
                SetPlaceholder();
            }
        }

        [Category("MLK - Appearence")]
        public HorizontalAlignment PlaceholderTextAlign { get => placeholderTextAlign; set => placeholderTextAlign = value; }

        [Category("MLK - Appearence")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public bool PasswordChar
        {
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    maskedTextBox.UseSystemPasswordChar = value;
            }
        }

        [Category("MLK - Appearence")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                maskedTextBox.BackColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                maskedTextBox.ForeColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public override Font Font
        {
            get=> base.Font;
            set
            {
                base.Font = value;
                maskedTextBox.Font = value;
            }
        }

        [Category("MLK - Appearence")]
        public String Texts
        {
            get
            {
                if (isPlaceholder)
                    return "";
                else
                    return maskedTextBox.Text;
            }
            set
            {
                if (!DesignMode || isPlaceholder)
                    RemovePlaceholder();
                maskedTextBox.Text = value;
                SetPlaceholder();
            }
        }

        [Category("MLK - Appearence")]
        public HorizontalAlignment TextAlign
        {
            get => textAlign;
            set
            {
                textAlign = value;
                maskedTextBox.TextAlign = value;
            }
        }

        [Category("MLK - Appearence")]
        public new String Mask
        {
            get => mask;
            set
            {
                mask = value;
                maskedTextBox.Mask = value;
                text = maskedTextBox.Text;
            }
        }

        public void Clear()
        {
            maskedTextBox.Clear();
            SetPlaceholder();
        }

        public void Focus() => RemovePlaceholder();

        [Browsable(true)]
        public event EventHandler TextChanged;

        public MLKMaskedTextBox()
        {
            maskedTextBox = new MaskedTextBox();
            maskedTextBox.BorderStyle = BorderStyle.None;
            maskedTextBox.Dock = DockStyle.Fill;
            maskedTextBox.TextChanged += new EventHandler(MaskedTextBox_TextChanged);
            maskedTextBox.Enter += new EventHandler(MaskedTextBox_Enter);
            maskedTextBox.Leave += new EventHandler(MaskedTextBox_Leave);
            SuspendLayout();
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(maskedTextBox);
            Font = new Font(Font.Name, 9.5F);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(4);
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(200, 30);
            ResumeLayout();
            PerformLayout();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            if (borderRadius >= 1)
            {
                Rectangle rectBorderSmooth = ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(pathBorderSmooth);
                    graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                    penBorder.Alignment = PenAlignment.Center;
                    if (isFocused)
                        penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                    {
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    }
                    else
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;
                    if (isFocused)
                        penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graphics.DrawRectangle(penBorder, 0, 0, Width - .5F, Height - .5F);
                }
        }

        private void MaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
                TextChanged.Invoke(sender, e);
        }

        private void MaskedTextBox_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
            RemovePlaceholder();
        }

        private void MaskedTextBox_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
            SetPlaceholder();
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

        private void SetPlaceholder()
        {
            if (maskedTextBox.Text == text && !String.IsNullOrWhiteSpace(placeholderText))
            {
                isPlaceholder = true;
                maskedTextBox.Mask = null;
                maskedTextBox.Text = placeholderText;
                maskedTextBox.ForeColor = placeholderColor;
                maskedTextBox.TextAlign = placeholderTextAlign;
                if (isPasswordChar)
                    maskedTextBox.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                maskedTextBox.Mask = mask;
                maskedTextBox.Text = "";
                maskedTextBox.ForeColor = ForeColor;
                maskedTextBox.TextAlign = TextAlign;
                if (isPasswordChar)
                    maskedTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
