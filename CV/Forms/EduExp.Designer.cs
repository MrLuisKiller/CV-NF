namespace CV.Forms
{
    partial class EduExp
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
            this.pEduExp = new System.Windows.Forms.Panel();
            this.pExperiencia = new System.Windows.Forms.Panel();
            this.ExpGuardarEditar = new CV.Componentes.MLKButton();
            this.ExpCancelar = new CV.Componentes.MLKButton();
            this.Habilidades = new CV.Componentes.MLKTextBox();
            this.ExpDescripcion = new CV.Componentes.MLKTextBox();
            this.Trabajo = new CV.Componentes.MLKCheckBox();
            this.ExpFFinal = new CV.Componentes.MLKDateTimePicker();
            this.ExpFInicio = new CV.Componentes.MLKDateTimePicker();
            this.Pagina = new CV.Componentes.MLKTextBox();
            this.Direccion = new CV.Componentes.MLKTextBox();
            this.Compania = new CV.Componentes.MLKTextBox();
            this.Nombre = new CV.Componentes.MLKTextBox();
            this.lExperiencia = new System.Windows.Forms.Label();
            this.Agregar = new CV.Componentes.MLKButton();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.pEducacion = new System.Windows.Forms.Panel();
            this.EduGuardarEditar = new CV.Componentes.MLKButton();
            this.EduCancelar = new CV.Componentes.MLKButton();
            this.EduDescripcion = new CV.Componentes.MLKTextBox();
            this.Estudio = new CV.Componentes.MLKCheckBox();
            this.EduFFinal = new CV.Componentes.MLKDateTimePicker();
            this.EduFInicio = new CV.Componentes.MLKDateTimePicker();
            this.Institucion = new CV.Componentes.MLKTextBox();
            this.Carrera = new CV.Componentes.MLKTextBox();
            this.lEducacion = new System.Windows.Forms.Label();
            this.pEduExp.SuspendLayout();
            this.pExperiencia.SuspendLayout();
            this.pEducacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pEduExp
            // 
            this.pEduExp.AutoScroll = true;
            this.pEduExp.Controls.Add(this.Agregar);
            this.pEduExp.Controls.Add(this.pContenedor);
            this.pEduExp.Controls.Add(this.pEducacion);
            this.pEduExp.Controls.Add(this.pExperiencia);
            this.pEduExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEduExp.Location = new System.Drawing.Point(0, 0);
            this.pEduExp.Name = "pEduExp";
            this.pEduExp.Size = new System.Drawing.Size(604, 401);
            this.pEduExp.TabIndex = 0;
            // 
            // pExperiencia
            // 
            this.pExperiencia.Controls.Add(this.ExpGuardarEditar);
            this.pExperiencia.Controls.Add(this.ExpCancelar);
            this.pExperiencia.Controls.Add(this.Habilidades);
            this.pExperiencia.Controls.Add(this.ExpDescripcion);
            this.pExperiencia.Controls.Add(this.Trabajo);
            this.pExperiencia.Controls.Add(this.ExpFFinal);
            this.pExperiencia.Controls.Add(this.ExpFInicio);
            this.pExperiencia.Controls.Add(this.Pagina);
            this.pExperiencia.Controls.Add(this.Direccion);
            this.pExperiencia.Controls.Add(this.Compania);
            this.pExperiencia.Controls.Add(this.Nombre);
            this.pExperiencia.Controls.Add(this.lExperiencia);
            this.pExperiencia.Location = new System.Drawing.Point(6, 3);
            this.pExperiencia.Name = "pExperiencia";
            this.pExperiencia.Size = new System.Drawing.Size(595, 293);
            this.pExperiencia.TabIndex = 1;
            this.pExperiencia.Visible = false;
            // 
            // ExpGuardarEditar
            // 
            this.ExpGuardarEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpGuardarEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpGuardarEditar.BorderColor = System.Drawing.Color.Purple;
            this.ExpGuardarEditar.BorderRadius = 10;
            this.ExpGuardarEditar.BorderSize = 1;
            this.ExpGuardarEditar.Enabled = false;
            this.ExpGuardarEditar.FlatAppearance.BorderSize = 0;
            this.ExpGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpGuardarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ExpGuardarEditar.ForeColor = System.Drawing.Color.White;
            this.ExpGuardarEditar.Location = new System.Drawing.Point(491, 259);
            this.ExpGuardarEditar.Name = "ExpGuardarEditar";
            this.ExpGuardarEditar.Size = new System.Drawing.Size(100, 30);
            this.ExpGuardarEditar.TabIndex = 11;
            this.ExpGuardarEditar.Text = "Guardar";
            this.ExpGuardarEditar.TextColor = System.Drawing.Color.White;
            this.ExpGuardarEditar.UseVisualStyleBackColor = false;
            this.ExpGuardarEditar.Click += new System.EventHandler(this.GuardarEditar_Click);
            // 
            // ExpCancelar
            // 
            this.ExpCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpCancelar.BorderColor = System.Drawing.Color.Purple;
            this.ExpCancelar.BorderRadius = 10;
            this.ExpCancelar.BorderSize = 1;
            this.ExpCancelar.FlatAppearance.BorderSize = 0;
            this.ExpCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ExpCancelar.ForeColor = System.Drawing.Color.White;
            this.ExpCancelar.Location = new System.Drawing.Point(491, 199);
            this.ExpCancelar.Name = "ExpCancelar";
            this.ExpCancelar.Size = new System.Drawing.Size(100, 30);
            this.ExpCancelar.TabIndex = 10;
            this.ExpCancelar.Text = "Cancelar";
            this.ExpCancelar.TextColor = System.Drawing.Color.White;
            this.ExpCancelar.UseVisualStyleBackColor = false;
            this.ExpCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Habilidades
            // 
            this.Habilidades.BackColor = System.Drawing.SystemColors.Window;
            this.Habilidades.BorderColor = System.Drawing.Color.Purple;
            this.Habilidades.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Habilidades.BorderRadius = 10;
            this.Habilidades.BorderSize = 1;
            this.Habilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Habilidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Habilidades.Location = new System.Drawing.Point(4, 199);
            this.Habilidades.Margin = new System.Windows.Forms.Padding(4);
            this.Habilidades.Multiline = true;
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Habilidades.PasswordChar = false;
            this.Habilidades.PlaceholderColor = System.Drawing.Color.Purple;
            this.Habilidades.PlaceholderText = "Habilidades";
            this.Habilidades.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Habilidades.Size = new System.Drawing.Size(480, 90);
            this.Habilidades.TabIndex = 9;
            this.Habilidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Habilidades.Texts = "";
            this.Habilidades.UnderlinedStyle = false;
            this.Habilidades.TextChanged += new System.EventHandler(this.Changed);
            // 
            // ExpDescripcion
            // 
            this.ExpDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.ExpDescripcion.BorderColor = System.Drawing.Color.Purple;
            this.ExpDescripcion.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpDescripcion.BorderRadius = 10;
            this.ExpDescripcion.BorderSize = 1;
            this.ExpDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ExpDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExpDescripcion.Location = new System.Drawing.Point(4, 103);
            this.ExpDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.ExpDescripcion.Multiline = true;
            this.ExpDescripcion.Name = "ExpDescripcion";
            this.ExpDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ExpDescripcion.PasswordChar = false;
            this.ExpDescripcion.PlaceholderColor = System.Drawing.Color.Purple;
            this.ExpDescripcion.PlaceholderText = "Descripcion";
            this.ExpDescripcion.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpDescripcion.Size = new System.Drawing.Size(587, 90);
            this.ExpDescripcion.TabIndex = 8;
            this.ExpDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ExpDescripcion.Texts = "";
            this.ExpDescripcion.UnderlinedStyle = false;
            this.ExpDescripcion.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Trabajo
            // 
            this.Trabajo.CheckedColor = System.Drawing.Color.Purple;
            this.Trabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Trabajo.Location = new System.Drawing.Point(520, 65);
            this.Trabajo.MinimumSize = new System.Drawing.Size(20, 30);
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Trabajo.Size = new System.Drawing.Size(74, 30);
            this.Trabajo.TabIndex = 7;
            this.Trabajo.Text = "Trabajo";
            this.Trabajo.UnCheckedColor = System.Drawing.Color.Gray;
            this.Trabajo.UseVisualStyleBackColor = true;
            this.Trabajo.CheckedChanged += new System.EventHandler(this.EstTrab);
            // 
            // ExpFFinal
            // 
            this.ExpFFinal.BorderColor = System.Drawing.Color.Purple;
            this.ExpFFinal.BorderSize = 1;
            this.ExpFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ExpFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpFFinal.Location = new System.Drawing.Point(412, 65);
            this.ExpFFinal.MinimumSize = new System.Drawing.Size(4, 30);
            this.ExpFFinal.Name = "ExpFFinal";
            this.ExpFFinal.Size = new System.Drawing.Size(106, 30);
            this.ExpFFinal.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpFFinal.TabIndex = 6;
            this.ExpFFinal.TextColor = System.Drawing.Color.White;
            this.ExpFFinal.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // ExpFInicio
            // 
            this.ExpFInicio.BorderColor = System.Drawing.Color.Purple;
            this.ExpFInicio.BorderSize = 1;
            this.ExpFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ExpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpFInicio.Location = new System.Drawing.Point(299, 65);
            this.ExpFInicio.MinimumSize = new System.Drawing.Size(4, 30);
            this.ExpFInicio.Name = "ExpFInicio";
            this.ExpFInicio.Size = new System.Drawing.Size(107, 30);
            this.ExpFInicio.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.ExpFInicio.TabIndex = 5;
            this.ExpFInicio.TextColor = System.Drawing.Color.White;
            this.ExpFInicio.ValueChanged += new System.EventHandler(this.Changed);
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
            this.Pagina.Location = new System.Drawing.Point(152, 65);
            this.Pagina.Margin = new System.Windows.Forms.Padding(4);
            this.Pagina.Multiline = false;
            this.Pagina.Name = "Pagina";
            this.Pagina.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Pagina.PasswordChar = false;
            this.Pagina.PlaceholderColor = System.Drawing.Color.Purple;
            this.Pagina.PlaceholderText = "Pagina";
            this.Pagina.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pagina.Size = new System.Drawing.Size(140, 31);
            this.Pagina.TabIndex = 4;
            this.Pagina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pagina.Texts = "";
            this.Pagina.UnderlinedStyle = false;
            this.Pagina.TextChanged += new System.EventHandler(this.Changed);
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
            this.Direccion.Location = new System.Drawing.Point(4, 65);
            this.Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Direccion.Multiline = false;
            this.Direccion.Name = "Direccion";
            this.Direccion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Direccion.PasswordChar = false;
            this.Direccion.PlaceholderColor = System.Drawing.Color.Purple;
            this.Direccion.PlaceholderText = "Direccion";
            this.Direccion.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Direccion.Size = new System.Drawing.Size(140, 31);
            this.Direccion.TabIndex = 3;
            this.Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Direccion.Texts = "";
            this.Direccion.UnderlinedStyle = false;
            this.Direccion.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Compania
            // 
            this.Compania.BackColor = System.Drawing.SystemColors.Window;
            this.Compania.BorderColor = System.Drawing.Color.Purple;
            this.Compania.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Compania.BorderRadius = 10;
            this.Compania.BorderSize = 1;
            this.Compania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Compania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Compania.Location = new System.Drawing.Point(302, 26);
            this.Compania.Margin = new System.Windows.Forms.Padding(4);
            this.Compania.Multiline = false;
            this.Compania.Name = "Compania";
            this.Compania.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Compania.PasswordChar = false;
            this.Compania.PlaceholderColor = System.Drawing.Color.Purple;
            this.Compania.PlaceholderText = "Compania";
            this.Compania.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Compania.Size = new System.Drawing.Size(289, 31);
            this.Compania.TabIndex = 2;
            this.Compania.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Compania.Texts = "";
            this.Compania.UnderlinedStyle = false;
            this.Compania.TextChanged += new System.EventHandler(this.Changed);
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
            this.Nombre.Location = new System.Drawing.Point(4, 26);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Multiline = false;
            this.Nombre.Name = "Nombre";
            this.Nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Nombre.PasswordChar = false;
            this.Nombre.PlaceholderColor = System.Drawing.Color.Purple;
            this.Nombre.PlaceholderText = "Nombre";
            this.Nombre.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Size = new System.Drawing.Size(289, 31);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre.Texts = "";
            this.Nombre.UnderlinedStyle = false;
            this.Nombre.TextChanged += new System.EventHandler(this.Changed);
            // 
            // lExperiencia
            // 
            this.lExperiencia.AutoSize = true;
            this.lExperiencia.Location = new System.Drawing.Point(6, 6);
            this.lExperiencia.Name = "lExperiencia";
            this.lExperiencia.Size = new System.Drawing.Size(121, 16);
            this.lExperiencia.TabIndex = 0;
            this.lExperiencia.Text = "Nueva Experiencia";
            this.lExperiencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Agregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Agregar.BorderColor = System.Drawing.Color.Purple;
            this.Agregar.BorderRadius = 10;
            this.Agregar.BorderSize = 1;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(501, 3);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 30);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextColor = System.Drawing.Color.White;
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // pContenedor
            // 
            this.pContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pContenedor.Location = new System.Drawing.Point(3, 32);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(598, 84);
            this.pContenedor.TabIndex = 3;
            // 
            // pEducacion
            // 
            this.pEducacion.Controls.Add(this.EduGuardarEditar);
            this.pEducacion.Controls.Add(this.EduCancelar);
            this.pEducacion.Controls.Add(this.EduDescripcion);
            this.pEducacion.Controls.Add(this.Estudio);
            this.pEducacion.Controls.Add(this.EduFFinal);
            this.pEducacion.Controls.Add(this.EduFInicio);
            this.pEducacion.Controls.Add(this.Institucion);
            this.pEducacion.Controls.Add(this.Carrera);
            this.pEducacion.Controls.Add(this.lEducacion);
            this.pEducacion.Location = new System.Drawing.Point(6, 3);
            this.pEducacion.Name = "pEducacion";
            this.pEducacion.Size = new System.Drawing.Size(595, 281);
            this.pEducacion.TabIndex = 0;
            this.pEducacion.Visible = false;
            // 
            // EduGuardarEditar
            // 
            this.EduGuardarEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EduGuardarEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.EduGuardarEditar.BorderColor = System.Drawing.Color.Purple;
            this.EduGuardarEditar.BorderRadius = 10;
            this.EduGuardarEditar.BorderSize = 1;
            this.EduGuardarEditar.Enabled = false;
            this.EduGuardarEditar.FlatAppearance.BorderSize = 0;
            this.EduGuardarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduGuardarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EduGuardarEditar.ForeColor = System.Drawing.Color.White;
            this.EduGuardarEditar.Location = new System.Drawing.Point(492, 239);
            this.EduGuardarEditar.Name = "EduGuardarEditar";
            this.EduGuardarEditar.Size = new System.Drawing.Size(100, 30);
            this.EduGuardarEditar.TabIndex = 8;
            this.EduGuardarEditar.Text = "Guardar";
            this.EduGuardarEditar.TextColor = System.Drawing.Color.White;
            this.EduGuardarEditar.UseVisualStyleBackColor = false;
            this.EduGuardarEditar.Click += new System.EventHandler(this.GuardarEditar_Click);
            // 
            // EduCancelar
            // 
            this.EduCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.EduCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.EduCancelar.BorderColor = System.Drawing.Color.Purple;
            this.EduCancelar.BorderRadius = 10;
            this.EduCancelar.BorderSize = 1;
            this.EduCancelar.FlatAppearance.BorderSize = 0;
            this.EduCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EduCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EduCancelar.ForeColor = System.Drawing.Color.White;
            this.EduCancelar.Location = new System.Drawing.Point(386, 239);
            this.EduCancelar.Name = "EduCancelar";
            this.EduCancelar.Size = new System.Drawing.Size(100, 30);
            this.EduCancelar.TabIndex = 7;
            this.EduCancelar.Text = "Cancelar";
            this.EduCancelar.TextColor = System.Drawing.Color.White;
            this.EduCancelar.UseVisualStyleBackColor = false;
            this.EduCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // EduDescripcion
            // 
            this.EduDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.EduDescripcion.BorderColor = System.Drawing.Color.Purple;
            this.EduDescripcion.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.EduDescripcion.BorderRadius = 10;
            this.EduDescripcion.BorderSize = 1;
            this.EduDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EduDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EduDescripcion.Location = new System.Drawing.Point(4, 104);
            this.EduDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.EduDescripcion.Multiline = true;
            this.EduDescripcion.Name = "EduDescripcion";
            this.EduDescripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.EduDescripcion.PasswordChar = false;
            this.EduDescripcion.PlaceholderColor = System.Drawing.Color.Purple;
            this.EduDescripcion.PlaceholderText = "Descripcion";
            this.EduDescripcion.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EduDescripcion.Size = new System.Drawing.Size(587, 128);
            this.EduDescripcion.TabIndex = 6;
            this.EduDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EduDescripcion.Texts = "";
            this.EduDescripcion.UnderlinedStyle = false;
            this.EduDescripcion.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Estudio
            // 
            this.Estudio.CheckedColor = System.Drawing.Color.Purple;
            this.Estudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Estudio.Location = new System.Drawing.Point(519, 66);
            this.Estudio.MinimumSize = new System.Drawing.Size(20, 30);
            this.Estudio.Name = "Estudio";
            this.Estudio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Estudio.Size = new System.Drawing.Size(73, 30);
            this.Estudio.TabIndex = 5;
            this.Estudio.Text = "Estudio";
            this.Estudio.UnCheckedColor = System.Drawing.Color.Gray;
            this.Estudio.UseVisualStyleBackColor = true;
            this.Estudio.CheckedChanged += new System.EventHandler(this.EstTrab);
            // 
            // EduFFinal
            // 
            this.EduFFinal.BorderColor = System.Drawing.Color.Purple;
            this.EduFFinal.BorderSize = 1;
            this.EduFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EduFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EduFFinal.Location = new System.Drawing.Point(391, 65);
            this.EduFFinal.MinimumSize = new System.Drawing.Size(4, 30);
            this.EduFFinal.Name = "EduFFinal";
            this.EduFFinal.Size = new System.Drawing.Size(122, 30);
            this.EduFFinal.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.EduFFinal.TabIndex = 4;
            this.EduFFinal.TextColor = System.Drawing.Color.White;
            this.EduFFinal.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // EduFInicio
            // 
            this.EduFInicio.BorderColor = System.Drawing.Color.Purple;
            this.EduFInicio.BorderSize = 1;
            this.EduFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EduFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EduFInicio.Location = new System.Drawing.Point(263, 65);
            this.EduFInicio.MinimumSize = new System.Drawing.Size(4, 30);
            this.EduFInicio.Name = "EduFInicio";
            this.EduFInicio.Size = new System.Drawing.Size(122, 30);
            this.EduFInicio.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.EduFInicio.TabIndex = 3;
            this.EduFInicio.TextColor = System.Drawing.Color.White;
            this.EduFInicio.Value = new System.DateTime(2021, 11, 7, 7, 57, 0, 0);
            this.EduFInicio.ValueChanged += new System.EventHandler(this.Changed);
            // 
            // Institucion
            // 
            this.Institucion.BackColor = System.Drawing.SystemColors.Window;
            this.Institucion.BorderColor = System.Drawing.Color.Purple;
            this.Institucion.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Institucion.BorderRadius = 10;
            this.Institucion.BorderSize = 1;
            this.Institucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Institucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Institucion.Location = new System.Drawing.Point(4, 65);
            this.Institucion.Margin = new System.Windows.Forms.Padding(4);
            this.Institucion.Multiline = false;
            this.Institucion.Name = "Institucion";
            this.Institucion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Institucion.PasswordChar = false;
            this.Institucion.PlaceholderColor = System.Drawing.Color.Purple;
            this.Institucion.PlaceholderText = "Institucion";
            this.Institucion.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Institucion.Size = new System.Drawing.Size(252, 31);
            this.Institucion.TabIndex = 2;
            this.Institucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Institucion.Texts = "";
            this.Institucion.UnderlinedStyle = false;
            this.Institucion.TextChanged += new System.EventHandler(this.Changed);
            // 
            // Carrera
            // 
            this.Carrera.BackColor = System.Drawing.SystemColors.Window;
            this.Carrera.BorderColor = System.Drawing.Color.Purple;
            this.Carrera.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Carrera.BorderRadius = 10;
            this.Carrera.BorderSize = 1;
            this.Carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Carrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Carrera.Location = new System.Drawing.Point(4, 26);
            this.Carrera.Margin = new System.Windows.Forms.Padding(4);
            this.Carrera.Multiline = false;
            this.Carrera.Name = "Carrera";
            this.Carrera.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Carrera.PasswordChar = false;
            this.Carrera.PlaceholderColor = System.Drawing.Color.Purple;
            this.Carrera.PlaceholderText = "Carrera";
            this.Carrera.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Carrera.Size = new System.Drawing.Size(587, 31);
            this.Carrera.TabIndex = 1;
            this.Carrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Carrera.Texts = "";
            this.Carrera.UnderlinedStyle = false;
            this.Carrera.TextChanged += new System.EventHandler(this.Changed);
            // 
            // lEducacion
            // 
            this.lEducacion.AutoSize = true;
            this.lEducacion.Location = new System.Drawing.Point(6, 6);
            this.lEducacion.Name = "lEducacion";
            this.lEducacion.Size = new System.Drawing.Size(114, 16);
            this.lEducacion.TabIndex = 0;
            this.lEducacion.Text = "Nueva Educacion";
            // 
            // EduExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.pEduExp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EduExp";
            this.Text = "EduExp";
            this.pEduExp.ResumeLayout(false);
            this.pExperiencia.ResumeLayout(false);
            this.pExperiencia.PerformLayout();
            this.pEducacion.ResumeLayout(false);
            this.pEducacion.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pEduExp;
        private System.Windows.Forms.Panel pEducacion;
        private Componentes.MLKDateTimePicker EduFFinal;
        private Componentes.MLKDateTimePicker EduFInicio;
        private Componentes.MLKTextBox Institucion;
        private Componentes.MLKTextBox Carrera;
        private System.Windows.Forms.Label lEducacion;
        private Componentes.MLKButton EduGuardarEditar;
        private Componentes.MLKButton EduCancelar;
        private Componentes.MLKTextBox EduDescripcion;
        private Componentes.MLKCheckBox Estudio;
        private System.Windows.Forms.Panel pContenedor;
        private Componentes.MLKButton Agregar;
        private System.Windows.Forms.Panel pExperiencia;
        private Componentes.MLKButton ExpGuardarEditar;
        private Componentes.MLKButton ExpCancelar;
        private Componentes.MLKTextBox Habilidades;
        private Componentes.MLKTextBox ExpDescripcion;
        private Componentes.MLKCheckBox Trabajo;
        private Componentes.MLKDateTimePicker ExpFFinal;
        private Componentes.MLKDateTimePicker ExpFInicio;
        private Componentes.MLKTextBox Pagina;
        private Componentes.MLKTextBox Direccion;
        private Componentes.MLKTextBox Compania;
        private Componentes.MLKTextBox Nombre;
        private System.Windows.Forms.Label lExperiencia;
    }
}