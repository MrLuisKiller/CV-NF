using System.Windows.Forms;

namespace CV.Forms
{
    partial class Principal
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.pCurr = new System.Windows.Forms.Panel();
            this.CrearCurr = new CV.Componentes.MLKButton();
            this.pMenuCurr = new System.Windows.Forms.Panel();
            this.Habilidades = new CV.Componentes.MLKButton();
            this.Experiencia = new CV.Componentes.MLKButton();
            this.Educacion = new CV.Componentes.MLKButton();
            this.Personal = new CV.Componentes.MLKButton();
            this.pContenido = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pCurr.SuspendLayout();
            this.pMenuCurr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.AutoScroll = true;
            this.pMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMenu.Controls.Add(this.pCurr);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(180, 431);
            this.pMenu.TabIndex = 0;
            // 
            // pCurr
            // 
            this.pCurr.Controls.Add(this.CrearCurr);
            this.pCurr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCurr.Location = new System.Drawing.Point(0, 0);
            this.pCurr.Name = "pCurr";
            this.pCurr.Size = new System.Drawing.Size(176, 30);
            this.pCurr.TabIndex = 0;
            // 
            // CrearCurr
            // 
            this.CrearCurr.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CrearCurr.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CrearCurr.BorderColor = System.Drawing.Color.Purple;
            this.CrearCurr.BorderRadius = 10;
            this.CrearCurr.BorderSize = 1;
            this.CrearCurr.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrearCurr.FlatAppearance.BorderSize = 0;
            this.CrearCurr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrearCurr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CrearCurr.Image = global::CV.Properties.Resources.CV24;
            this.CrearCurr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearCurr.Location = new System.Drawing.Point(0, 0);
            this.CrearCurr.Name = "CrearCurr";
            this.CrearCurr.Size = new System.Drawing.Size(176, 30);
            this.CrearCurr.TabIndex = 0;
            this.CrearCurr.Text = "Nuevo";
            this.CrearCurr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearCurr.TextColor = System.Drawing.SystemColors.ControlText;
            this.CrearCurr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearCurr.UseVisualStyleBackColor = false;
            this.CrearCurr.Click += new System.EventHandler(this.CrearCurr_Click);
            // 
            // pMenuCurr
            // 
            this.pMenuCurr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMenuCurr.Controls.Add(this.Habilidades);
            this.pMenuCurr.Controls.Add(this.Experiencia);
            this.pMenuCurr.Controls.Add(this.Educacion);
            this.pMenuCurr.Controls.Add(this.Personal);
            this.pMenuCurr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenuCurr.Enabled = false;
            this.pMenuCurr.Location = new System.Drawing.Point(180, 0);
            this.pMenuCurr.Name = "pMenuCurr";
            this.pMenuCurr.Size = new System.Drawing.Size(604, 30);
            this.pMenuCurr.TabIndex = 1;
            // 
            // Habilidades
            // 
            this.Habilidades.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Habilidades.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Habilidades.BorderColor = System.Drawing.Color.Purple;
            this.Habilidades.BorderRadius = 10;
            this.Habilidades.BorderSize = 1;
            this.Habilidades.Enabled = false;
            this.Habilidades.FlatAppearance.BorderSize = 0;
            this.Habilidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Habilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Habilidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Habilidades.Location = new System.Drawing.Point(404, -1);
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.Size = new System.Drawing.Size(100, 30);
            this.Habilidades.TabIndex = 3;
            this.Habilidades.Text = "Habilidades";
            this.Habilidades.TextColor = System.Drawing.SystemColors.ControlText;
            this.Habilidades.UseVisualStyleBackColor = false;
            this.Habilidades.Click += new System.EventHandler(this.Habilidades_Click);
            // 
            // Experiencia
            // 
            this.Experiencia.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Experiencia.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Experiencia.BorderColor = System.Drawing.Color.Purple;
            this.Experiencia.BorderRadius = 10;
            this.Experiencia.BorderSize = 1;
            this.Experiencia.Enabled = false;
            this.Experiencia.FlatAppearance.BorderSize = 0;
            this.Experiencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Experiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Experiencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Experiencia.Location = new System.Drawing.Point(298, -1);
            this.Experiencia.Name = "Experiencia";
            this.Experiencia.Size = new System.Drawing.Size(100, 30);
            this.Experiencia.TabIndex = 2;
            this.Experiencia.Text = "Experiencia";
            this.Experiencia.TextColor = System.Drawing.SystemColors.ControlText;
            this.Experiencia.UseVisualStyleBackColor = false;
            this.Experiencia.Click += new System.EventHandler(this.Experiencia_Click);
            // 
            // Educacion
            // 
            this.Educacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Educacion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Educacion.BorderColor = System.Drawing.Color.Purple;
            this.Educacion.BorderRadius = 10;
            this.Educacion.BorderSize = 1;
            this.Educacion.Enabled = false;
            this.Educacion.FlatAppearance.BorderSize = 0;
            this.Educacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Educacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Educacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Educacion.Location = new System.Drawing.Point(192, -1);
            this.Educacion.Name = "Educacion";
            this.Educacion.Size = new System.Drawing.Size(100, 30);
            this.Educacion.TabIndex = 1;
            this.Educacion.Text = "Educacion";
            this.Educacion.TextColor = System.Drawing.SystemColors.ControlText;
            this.Educacion.UseVisualStyleBackColor = false;
            this.Educacion.Click += new System.EventHandler(this.Educacion_Click);
            // 
            // Personal
            // 
            this.Personal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Personal.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Personal.BorderColor = System.Drawing.Color.Purple;
            this.Personal.BorderRadius = 10;
            this.Personal.BorderSize = 1;
            this.Personal.FlatAppearance.BorderSize = 0;
            this.Personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Personal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Personal.Location = new System.Drawing.Point(86, -1);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(100, 30);
            this.Personal.TabIndex = 0;
            this.Personal.Text = "Personal";
            this.Personal.TextColor = System.Drawing.SystemColors.ControlText;
            this.Personal.UseVisualStyleBackColor = false;
            this.Personal.Click += new System.EventHandler(this.Personal_Click);
            // 
            // pContenido
            // 
            this.pContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenido.Location = new System.Drawing.Point(180, 30);
            this.pContenido.Name = "pContenido";
            this.pContenido.Size = new System.Drawing.Size(604, 401);
            this.pContenido.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.pContenido);
            this.Controls.Add(this.pMenuCurr);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pMenu.ResumeLayout(false);
            this.pCurr.ResumeLayout(false);
            this.pMenuCurr.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel pMenu;
        private Panel pCurr;
        private Componentes.MLKButton CrearCurr;
        private Panel pMenuCurr;
        private Componentes.MLKButton Habilidades;
        private Componentes.MLKButton Experiencia;
        private Componentes.MLKButton Educacion;
        private Componentes.MLKButton Personal;
        private Panel pContenido;
    }
}