using System.Windows.Forms;

namespace CV.Forms
{
    partial class Personal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PerfilContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Nombre = new CV.Componentes.MLKTextBox();
            this.Apellidos = new CV.Componentes.MLKTextBox();
            this.FNacimiento = new CV.Componentes.MLKDateTimePicker();
            this.Correo = new CV.Componentes.MLKTextBox();
            this.Telefono = new CV.Componentes.MLKMaskedTextBox();
            this.Direccion = new CV.Componentes.MLKTextBox();
            this.Pagina = new CV.Componentes.MLKTextBox();
            this.Resumen = new CV.Componentes.MLKTextBox();
            this.Guardar = new CV.Componentes.MLKButton();
            this.Perfil = new CV.Componentes.MLKPictureBox();
            this.PerfilContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // PerfilContextMenu
            // 
            this.PerfilContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bordeToolStripMenuItem,
            this.estiloToolStripMenuItem});
            this.PerfilContextMenu.Name = "PerfilContextMenu";
            this.PerfilContextMenu.Size = new System.Drawing.Size(106, 48);
            // 
            // bordeToolStripMenuItem
            // 
            this.bordeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dashToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.dashDotToolStripMenuItem,
            this.dashDotDotToolStripMenuItem});
            this.bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
            this.bordeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bordeToolStripMenuItem.Text = "Borde";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.bordeToolStripMenuItem_Click);
            // 
            // dashToolStripMenuItem
            // 
            this.dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            this.dashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashToolStripMenuItem.Text = "Dash";
            this.dashToolStripMenuItem.Click += new System.EventHandler(this.bordeToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.bordeToolStripMenuItem_Click);
            // 
            // dashDotToolStripMenuItem
            // 
            this.dashDotToolStripMenuItem.Name = "dashDotToolStripMenuItem";
            this.dashDotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashDotToolStripMenuItem.Text = "DashDot";
            this.dashDotToolStripMenuItem.Click += new System.EventHandler(this.bordeToolStripMenuItem_Click);
            // 
            // dashDotDotToolStripMenuItem
            // 
            this.dashDotDotToolStripMenuItem.Name = "dashDotDotToolStripMenuItem";
            this.dashDotDotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashDotDotToolStripMenuItem.Text = "DashDotDot";
            this.dashDotDotToolStripMenuItem.Click += new System.EventHandler(this.bordeToolStripMenuItem_Click);
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flatToolStripMenuItem,
            this.roundToolStripMenuItem,
            this.triangleToolStripMenuItem});
            this.estiloToolStripMenuItem.Enabled = false;
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.estiloToolStripMenuItem.Text = "Estilo";
            // 
            // flatToolStripMenuItem
            // 
            this.flatToolStripMenuItem.Name = "flatToolStripMenuItem";
            this.flatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flatToolStripMenuItem.Text = "Flat";
            this.flatToolStripMenuItem.Click += new System.EventHandler(this.estiloToolStripMenuItem_Click);
            // 
            // roundToolStripMenuItem
            // 
            this.roundToolStripMenuItem.Name = "roundToolStripMenuItem";
            this.roundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roundToolStripMenuItem.Text = "Round";
            this.roundToolStripMenuItem.Click += new System.EventHandler(this.estiloToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.estiloToolStripMenuItem_Click);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre.BorderColor = System.Drawing.Color.Purple;
            this.Nombre.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Nombre.BorderRadius = 10;
            this.Nombre.BorderSize = 1;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombre.Location = new System.Drawing.Point(169, 58);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Multiline = false;
            this.Nombre.Name = "Nombre";
            this.Nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Nombre.PasswordChar = false;
            this.Nombre.PlaceholderColor = System.Drawing.Color.Purple;
            this.Nombre.PlaceholderText = "Nombre";
            this.Nombre.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Size = new System.Drawing.Size(139, 31);
            this.Nombre.TabIndex = 2;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre.Texts = "";
            this.Nombre.UnderlinedStyle = false;
            this.Nombre.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Apellidos
            // 
            this.Apellidos.BackColor = System.Drawing.SystemColors.Window;
            this.Apellidos.BorderColor = System.Drawing.Color.Purple;
            this.Apellidos.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Apellidos.BorderRadius = 10;
            this.Apellidos.BorderSize = 1;
            this.Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apellidos.Location = new System.Drawing.Point(316, 58);
            this.Apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.Apellidos.Multiline = false;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Apellidos.PasswordChar = false;
            this.Apellidos.PlaceholderColor = System.Drawing.Color.Purple;
            this.Apellidos.PlaceholderText = "Apellidos";
            this.Apellidos.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellidos.Size = new System.Drawing.Size(139, 31);
            this.Apellidos.TabIndex = 3;
            this.Apellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Apellidos.Texts = "";
            this.Apellidos.UnderlinedStyle = false;
            this.Apellidos.TextChanged += new System.EventHandler(this.Changed);
            // 
            // FNacimiento
            // 
            this.FNacimiento.BorderColor = System.Drawing.Color.Purple;
            this.FNacimiento.BorderSize = 1;
            this.FNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.FNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.FNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FNacimiento.Location = new System.Drawing.Point(462, 58);
            this.FNacimiento.MinimumSize = new System.Drawing.Size(4, 30);
            this.FNacimiento.Name = "FNacimiento";
            this.FNacimiento.Size = new System.Drawing.Size(130, 30);
            this.FNacimiento.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.FNacimiento.TabIndex = 4;
            this.FNacimiento.TextColor = System.Drawing.Color.White;
            this.FNacimiento.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.SystemColors.Window;
            this.Correo.BorderColor = System.Drawing.Color.Purple;
            this.Correo.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Correo.BorderRadius = 10;
            this.Correo.BorderSize = 1;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Correo.Location = new System.Drawing.Point(169, 97);
            this.Correo.Margin = new System.Windows.Forms.Padding(4);
            this.Correo.Multiline = false;
            this.Correo.Name = "Correo";
            this.Correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Correo.PasswordChar = false;
            this.Correo.PlaceholderColor = System.Drawing.Color.Purple;
            this.Correo.PlaceholderText = "Correo";
            this.Correo.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correo.Size = new System.Drawing.Size(286, 31);
            this.Correo.TabIndex = 5;
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Correo.Texts = "";
            this.Correo.UnderlinedStyle = false;
            this.Correo.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.Telefono.BorderColor = System.Drawing.Color.Purple;
            this.Telefono.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Telefono.BorderRadius = 10;
            this.Telefono.BorderSize = 1;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Telefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telefono.Location = new System.Drawing.Point(461, 97);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Telefono.Mask = "(99) 000-000-0000";
            this.Telefono.Name = "Telefono";
            this.Telefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Telefono.PasswordChar = false;
            this.Telefono.PlaceholderColor = System.Drawing.Color.Purple;
            this.Telefono.PlaceholderText = "Telefono";
            this.Telefono.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefono.Size = new System.Drawing.Size(130, 30);
            this.Telefono.TabIndex = 6;
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Telefono.Texts = "";
            this.Telefono.UnderlinedStyle = false;
            this.Telefono.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Direccion
            // 
            this.Direccion.BackColor = System.Drawing.SystemColors.Window;
            this.Direccion.BorderColor = System.Drawing.Color.Purple;
            this.Direccion.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Direccion.BorderRadius = 10;
            this.Direccion.BorderSize = 1;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Direccion.Location = new System.Drawing.Point(169, 136);
            this.Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Direccion.Multiline = false;
            this.Direccion.Name = "Direccion";
            this.Direccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Direccion.PasswordChar = false;
            this.Direccion.PlaceholderColor = System.Drawing.Color.Purple;
            this.Direccion.PlaceholderText = "Direccion";
            this.Direccion.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Direccion.Size = new System.Drawing.Size(207, 31);
            this.Direccion.TabIndex = 7;
            this.Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Direccion.Texts = "";
            this.Direccion.UnderlinedStyle = false;
            this.Direccion.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Pagina
            // 
            this.Pagina.BackColor = System.Drawing.SystemColors.Window;
            this.Pagina.BorderColor = System.Drawing.Color.Purple;
            this.Pagina.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Pagina.BorderRadius = 10;
            this.Pagina.BorderSize = 1;
            this.Pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Pagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pagina.Location = new System.Drawing.Point(384, 136);
            this.Pagina.Margin = new System.Windows.Forms.Padding(4);
            this.Pagina.Multiline = false;
            this.Pagina.Name = "Pagina";
            this.Pagina.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Pagina.PasswordChar = false;
            this.Pagina.PlaceholderColor = System.Drawing.Color.Purple;
            this.Pagina.PlaceholderText = "Pagina";
            this.Pagina.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pagina.Size = new System.Drawing.Size(207, 31);
            this.Pagina.TabIndex = 8;
            this.Pagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pagina.Texts = "";
            this.Pagina.UnderlinedStyle = false;
            this.Pagina.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Resumen
            // 
            this.Resumen.BackColor = System.Drawing.SystemColors.Window;
            this.Resumen.BorderColor = System.Drawing.Color.Purple;
            this.Resumen.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Resumen.BorderRadius = 10;
            this.Resumen.BorderSize = 1;
            this.Resumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Resumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Resumen.Location = new System.Drawing.Point(13, 175);
            this.Resumen.Margin = new System.Windows.Forms.Padding(4);
            this.Resumen.Multiline = true;
            this.Resumen.Name = "Resumen";
            this.Resumen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Resumen.PasswordChar = false;
            this.Resumen.PlaceholderColor = System.Drawing.Color.Purple;
            this.Resumen.PlaceholderText = "Resumen";
            this.Resumen.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resumen.Size = new System.Drawing.Size(578, 213);
            this.Resumen.TabIndex = 9;
            this.Resumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Resumen.Texts = "";
            this.Resumen.UnderlinedStyle = false;
            this.Resumen.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Guardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Guardar.BorderColor = System.Drawing.Color.Purple;
            this.Guardar.BorderRadius = 10;
            this.Guardar.BorderSize = 1;
            this.Guardar.Enabled = false;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(492, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 30);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextColor = System.Drawing.Color.White;
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Perfil
            // 
            this.Perfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.Perfil.BorderColor1 = System.Drawing.Color.HotPink;
            this.Perfil.BorderColor2 = System.Drawing.Color.Purple;
            this.Perfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.Perfil.BorderSize = 3;
            this.Perfil.ContextMenuStrip = this.PerfilContextMenu;
            this.Perfil.GradientAngle = 50F;
            this.Perfil.Image = global::CV.Properties.Resources.U256;
            this.Perfil.Location = new System.Drawing.Point(12, 12);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(150, 150);
            this.Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perfil.TabIndex = 0;
            this.Perfil.TabStop = false;
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Resumen);
            this.Controls.Add(this.Pagina);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.FNacimiento);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Perfil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personal";
            this.Text = "Personal";
            this.PerfilContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Componentes.MLKPictureBox Perfil;
        private ContextMenuStrip PerfilContextMenu;
        private ToolStripMenuItem bordeToolStripMenuItem;
        private ToolStripMenuItem solidToolStripMenuItem;
        private ToolStripMenuItem dashToolStripMenuItem;
        private ToolStripMenuItem dotToolStripMenuItem;
        private ToolStripMenuItem dashDotToolStripMenuItem;
        private ToolStripMenuItem dashDotDotToolStripMenuItem;
        private ToolStripMenuItem estiloToolStripMenuItem;
        private ToolStripMenuItem flatToolStripMenuItem;
        private ToolStripMenuItem roundToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private Componentes.MLKTextBox Nombre;
        private Componentes.MLKTextBox Apellidos;
        private Componentes.MLKDateTimePicker FNacimiento;
        private Componentes.MLKTextBox Correo;
        private Componentes.MLKMaskedTextBox Telefono;
        private Componentes.MLKTextBox Direccion;
        private Componentes.MLKTextBox Pagina;
        private Componentes.MLKTextBox Resumen;
        private Componentes.MLKButton Guardar;
    }
}