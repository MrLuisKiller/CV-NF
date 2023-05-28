namespace CV.Forms
{
    partial class Nuevo
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
            this.Nombre = new CV.Componentes.MLKTextBox();
            this.Cancelar = new CV.Componentes.MLKButton();
            this.Aceptar = new CV.Componentes.MLKButton();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.Nombre.BorderColor = System.Drawing.Color.Purple;
            this.Nombre.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.Nombre.BorderRadius = 10;
            this.Nombre.BorderSize = 1;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombre.Location = new System.Drawing.Point(13, 13);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Multiline = false;
            this.Nombre.Name = "Nombre";
            this.Nombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Nombre.PasswordChar = false;
            this.Nombre.PlaceholderColor = System.Drawing.Color.Purple;
            this.Nombre.PlaceholderText = "Nombre";
            this.Nombre.PlaceholderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Size = new System.Drawing.Size(204, 31);
            this.Nombre.TabIndex = 0;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Texts = "";
            this.Nombre.UnderlinedStyle = false;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            this.Nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nombre_KeyDown);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Cancelar.BorderColor = System.Drawing.Color.Purple;
            this.Cancelar.BorderRadius = 10;
            this.Cancelar.BorderSize = 1;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.Location = new System.Drawing.Point(12, 51);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(100, 30);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextColor = System.Drawing.SystemColors.ControlText;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Aceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Aceptar.BorderColor = System.Drawing.Color.Purple;
            this.Aceptar.BorderRadius = 10;
            this.Aceptar.BorderSize = 1;
            this.Aceptar.Enabled = false;
            this.Aceptar.FlatAppearance.BorderSize = 0;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(118, 51);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(100, 30);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.TextColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 96);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.ResumeLayout(false);
        }

        #endregion

        public Componentes.MLKTextBox Nombre;
        private Componentes.MLKButton Cancelar;
        private Componentes.MLKButton Aceptar;
    }
}