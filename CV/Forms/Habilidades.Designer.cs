using System.Windows.Forms;

namespace CV.Forms
{
    partial class Habilidades
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHabilidades = new System.Windows.Forms.Panel();
            this.pHabilidad = new System.Windows.Forms.Panel();
            this.ImpHabilidad = new System.Windows.Forms.Panel();
            this.LHabilidades = new CV.Componentes.MLKComboBox();
            this.Eliminar = new CV.Componentes.MLKButton();
            this.Habilidad = new CV.Componentes.MLKTextBox();
            this.Agregar = new CV.Componentes.MLKButton();
            this.menuStrip1.SuspendLayout();
            this.pHabilidades.SuspendLayout();
            this.pHabilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // pHabilidades
            // 
            this.pHabilidades.Controls.Add(this.Eliminar);
            this.pHabilidades.Controls.Add(this.LHabilidades);
            this.pHabilidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHabilidades.Location = new System.Drawing.Point(0, 24);
            this.pHabilidades.Name = "pHabilidades";
            this.pHabilidades.Size = new System.Drawing.Size(604, 40);
            this.pHabilidades.TabIndex = 1;
            // 
            // pHabilidad
            // 
            this.pHabilidad.Controls.Add(this.Agregar);
            this.pHabilidad.Controls.Add(this.Habilidad);
            this.pHabilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHabilidad.Location = new System.Drawing.Point(0, 64);
            this.pHabilidad.Name = "pHabilidad";
            this.pHabilidad.Size = new System.Drawing.Size(604, 40);
            this.pHabilidad.TabIndex = 2;
            // 
            // ImpHabilidad
            // 
            this.ImpHabilidad.AutoScroll = true;
            this.ImpHabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImpHabilidad.Location = new System.Drawing.Point(0, 104);
            this.ImpHabilidad.Name = "ImpHabilidad";
            this.ImpHabilidad.Size = new System.Drawing.Size(604, 297);
            this.ImpHabilidad.TabIndex = 3;
            // 
            // LHabilidades
            // 
            this.LHabilidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LHabilidades.BorderColor = System.Drawing.Color.Purple;
            this.LHabilidades.BorderSize = 1;
            this.LHabilidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LHabilidades.ForeColor = System.Drawing.Color.DimGray;
            this.LHabilidades.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.LHabilidades.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.LHabilidades.ListTextColor = System.Drawing.Color.DimGray;
            this.LHabilidades.Location = new System.Drawing.Point(124, 3);
            this.LHabilidades.MinimumSize = new System.Drawing.Size(200, 30);
            this.LHabilidades.Name = "LHabilidades";
            this.LHabilidades.Padding = new System.Windows.Forms.Padding(1);
            this.LHabilidades.Size = new System.Drawing.Size(200, 30);
            this.LHabilidades.TabIndex = 0;
            this.LHabilidades.SelectedIndexChanged += new System.EventHandler(this.LHabilidades_SelectedIndexChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Eliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Eliminar.BorderColor = System.Drawing.Color.Purple;
            this.Eliminar.BorderRadius = 10;
            this.Eliminar.BorderSize = 1;
            this.Eliminar.Enabled = false;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Location = new System.Drawing.Point(330, 3);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 30);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextColor = System.Drawing.Color.White;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Habilidad
            // 
            this.Habilidad.BackColor = System.Drawing.SystemColors.Window;
            this.Habilidad.BorderColor = System.Drawing.Color.Purple;
            this.Habilidad.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Habilidad.BorderRadius = 10;
            this.Habilidad.BorderSize = 1;
            this.Habilidad.Enabled = false;
            this.Habilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Habilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Habilidad.Location = new System.Drawing.Point(124, 7);
            this.Habilidad.Margin = new System.Windows.Forms.Padding(4);
            this.Habilidad.Multiline = false;
            this.Habilidad.Name = "Habilidad";
            this.Habilidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Habilidad.PasswordChar = false;
            this.Habilidad.PlaceholderColor = System.Drawing.Color.Purple;
            this.Habilidad.PlaceholderText = "";
            this.Habilidad.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Habilidad.Size = new System.Drawing.Size(200, 31);
            this.Habilidad.TabIndex = 0;
            this.Habilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Habilidad.Texts = "";
            this.Habilidad.UnderlinedStyle = false;
            this.Habilidad.TextChanged += new System.EventHandler(this.Habilidad_TextChanged);
            this.Habilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Habilidad_KeyDown);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Agregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Agregar.BorderColor = System.Drawing.Color.Purple;
            this.Agregar.BorderRadius = 10;
            this.Agregar.BorderSize = 1;
            this.Agregar.Enabled = false;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Agregar.ForeColor = System.Drawing.Color.White;
            this.Agregar.Location = new System.Drawing.Point(330, 7);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 30);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextColor = System.Drawing.Color.White;
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Habilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 401);
            this.Controls.Add(this.ImpHabilidad);
            this.Controls.Add(this.pHabilidad);
            this.Controls.Add(this.pHabilidades);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Habilidades";
            this.Text = "Habilidades";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pHabilidades.ResumeLayout(false);
            this.pHabilidad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private Panel pHabilidades;
        private Componentes.MLKButton Eliminar;
        private Componentes.MLKComboBox LHabilidades;
        private Panel pHabilidad;
        private Componentes.MLKButton Agregar;
        private Componentes.MLKTextBox Habilidad;
        private Panel ImpHabilidad;
    }
}