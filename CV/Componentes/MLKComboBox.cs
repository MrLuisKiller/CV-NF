using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CV.Componentes
{
    [DefaultEvent("SelectedIndexChanged")]
    public class MLKComboBox : UserControl
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245), listTextColor = Color.DimGray;
        private Color borderColor = Color.Purple;
        private int borderSize = 1;
        private ComboBox comboBox;
        private Label label;
        private Button button;

        private void Error(int MIN, int MAX) => MessageBox.Show($"This value is out of range.\nThe range is from {MIN} to {MAX}.", "MLK Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        [Category("MLK - Appearence")]
        public new Color BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                label.BackColor = value;
                button.BackColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                button.Invalidate();
            }
        }

        [Category("MLK - Appearence")]
        public Color ListBackColor
        {
            get => listBackColor;
            set
            {
                listBackColor = value;
                comboBox.BackColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public Color ListTextColor
        {
            get => listTextColor;
            set
            {
                listTextColor = value;
                comboBox.ForeColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                base.BackColor = value;
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
                    Padding = new Padding(value);
                    AdjustComboBoxDimensions();
                }
                else
                    Error(0, 3);
            }
        }

        [Category("MLK - Appearence")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                label.ForeColor = value;
            }
        }

        [Category("MLK - Appearence")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                label.Font = value;
                comboBox.Font = value;
            }
        }

        [Category("MLK - Appearence")]
        public new String Text { get => label.Text; set => label.Text = value; }

        [Category("MLK - Appearence")]
        public ComboBoxStyle DropDownStyle
        {
            get => comboBox.DropDownStyle;
            set
            {
                if (comboBox.DropDownStyle != ComboBoxStyle.Simple)
                    comboBox.DropDownStyle = value;
            }
        }

        [Category("MLK - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items { get => comboBox.Items; }

        [Category("MLK - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource { get => comboBox.DataSource; set => comboBox.DataSource = value; }

        [Category("MLK - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource { get => comboBox.AutoCompleteCustomSource; set => comboBox.AutoCompleteCustomSource = value; }

        [Category("MLK - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource { get => comboBox.AutoCompleteSource; set => comboBox.AutoCompleteSource = value; }

        [Category("MLK - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode { get => comboBox.AutoCompleteMode; set => comboBox.AutoCompleteMode = value; }

        [Category("MLK - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem { get => comboBox.SelectedItem; set => comboBox.SelectedItem = value; }

        [Category("MLK - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex { get => comboBox.SelectedIndex; set => comboBox.SelectedIndex = value; }

        public event EventHandler SelectedIndexChanged;

        public MLKComboBox()
        {
            comboBox = new ComboBox();
            label = new Label();
            button = new Button();
            SuspendLayout();
            comboBox.BackColor = listBackColor;
            comboBox.Font = new Font(Font.Name, 9.5F);
            comboBox.ForeColor = listTextColor;
            comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            comboBox.TextChanged += new EventHandler(ComboBox_TextChanged);
            button.Dock = DockStyle.Right;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = backColor;
            button.Size = new Size(30, 30);
            button.Cursor = Cursors.Hand;
            button.Click += new EventHandler(Icon_Click);
            button.Paint += new PaintEventHandler(Icon_Paint);
            label.Dock = DockStyle.Fill;
            label.AutoSize = false;
            label.BackColor = backColor;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Padding = new Padding(8, 0, 0, 0);
            label.Font = new Font(Font.Name, 9.5F);
            label.Click += new EventHandler(Surface_Click);
            label.MouseEnter += new EventHandler(Surface_MouseEnter);
            label.MouseLeave += new EventHandler(Surface_MouseLeave);
            Controls.Add(label);
            Controls.Add(button);
            Controls.Add(comboBox);
            MinimumSize = new Size(200, 30);
            Size = new Size(200, 30);
            ForeColor = Color.DimGray;
            Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            ResumeLayout();
            AdjustComboBoxDimensions();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label.Text = comboBox.Text;
            if (SelectedIndexChanged != null)
                SelectedIndexChanged.Invoke(sender, e);
        }

        private void ComboBox_TextChanged(object sender, EventArgs e) => label.Text = comboBox.Text;

        private void Icon_Click(object sender, EventArgs e)
        {
            comboBox.Select();
            comboBox.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14, iconHeight = 6;
            Rectangle rectIcon = new Rectangle((button.Width - iconWidth) / 2, (button.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graphics = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graphics.DrawPath(pen, path);
            }
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            OnClick(e);
            comboBox.Select();
            if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBox.DroppedDown = true;
        }

        private void Surface_MouseEnter(object sender, EventArgs e) => OnMouseEnter(e);

        private void Surface_MouseLeave(object sender, EventArgs e) => OnMouseLeave(e);

        private void AdjustComboBoxDimensions()
        {
            comboBox.Width = label.Width;
            comboBox.Location = new Point()
            {
                X = Width - Padding.Right - comboBox.Width,
                Y = (label.Bottom - comboBox.Height) / 2
            };
        }
    }
}
