using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Principal;
using System.Drawing.Drawing2D;
using CV.Clases;

namespace CV.Forms
{
    public partial class Personal : Form
    {
        private Principal Principal;
        private bool isImage = false;
        private Image Imagen;
        private DPersonal P;

        public Personal(Form F, Object X)
        {
            InitializeComponent();
            Principal = F as Principal;
            P = (DPersonal)X;
            Cargar();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagen|*.jpg;*.png";
                openFileDialog.InitialDirectory = $@"C:\Users\{WindowsIdentity.GetCurrent().Name.Split('\\')[1]}\Pictures\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Imagen = Image.FromFile(openFileDialog.FileName);
                    Perfil.Image = Imagen;
                    isImage = true;
                    Changed(sender, e);
                }
            }
        }

        private void bordeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem X = (ToolStripMenuItem)sender;
            if (X.Text != "Solid")
            {
                PerfilContextMenu.Items[1].Enabled = true;
                Perfil.BorderLineStyle = (DashStyle)new ConvertirImagen().Dash(1, X.Text);
                P.Perfil.Style = X.Text;
            }
            else
            {
                PerfilContextMenu.Items[1].Enabled = false;
                Perfil.BorderLineStyle = DashStyle.Solid;
                P.Perfil.Style = "Solid";
                Perfil.BorderCapStyle = DashCap.Flat;
                P.Perfil.Cap = "Flat";
            }
            Changed(sender, e);
        }

        private void estiloToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ToolStripMenuItem X = (ToolStripMenuItem)sender;
            Perfil.BorderCapStyle = (DashCap)new ConvertirImagen().Dash(2, X.Text);
            P.Perfil.Cap = X.Text;
            Changed(sender, e);
        }

        private void Changed(object sender, EventArgs e)
        {
            if (!Guardar.Enabled)
                Guardar.Enabled = true;
        }

        private async void Guardar_Click(object sender, EventArgs e)
        {
            if (isImage)
                P.Perfil.Imagen = new ConvertirImagen().ImagenAByte(Imagen);
            P.Nombre = Nombre.Texts;
            P.Apellidos = Apellidos.Texts;
            P.FNacimiento = DateTime.Parse(FNacimiento.Value.ToShortTimeString());
            P.Correo = Correo.Texts;
            P.Telefono = Telefono.Texts;
            P.Direccion = Direccion.Texts;
            P.Pagina = Pagina.Texts;
            P.Resumen = Resumen.Texts;
            await Principal.GuardarJSON("Personal", P);
            Guardar.Enabled = false;
        }

        private void Cargar()
        {
            if (P != null)
            {
                if (P.Perfil.Imagen != null)
                    Perfil.Image = new ConvertirImagen().ByteAImagen(P.Perfil.Imagen);
                Perfil.BorderLineStyle = (DashStyle)new ConvertirImagen().Dash(1, P.Perfil.Style);
                PerfilContextMenu.Items[1].Enabled = P.Perfil.Style != "Solid";
                Perfil.BorderCapStyle = P.Perfil.Style == "Solid" ? DashCap.Flat : (DashCap)new ConvertirImagen().Dash(2, P.Perfil.Cap);
                Nombre.Texts = P.Nombre;
                Apellidos.Texts = P.Apellidos;
                FNacimiento.Value = P.FNacimiento;
                Correo.Texts = P.Correo;
                Telefono.Texts = P.Telefono;
                Direccion.Texts = P.Direccion;
                Pagina.Texts = P.Pagina;
                Resumen.Texts = P.Resumen;
            }
            else
                P = new DPersonal()
                {
                    Perfil = new Perfil()
                    {
                        Style = "Solid",
                        Cap = "Flat"
                    }
                };
            Guardar.Enabled = false;
        }
    }
}
