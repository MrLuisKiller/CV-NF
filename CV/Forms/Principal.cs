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
using System.IO;
using System.Text.Json;
using CV.Clases;
using CV.Componentes;
using System.Diagnostics;

namespace CV.Forms
{
    public partial class Principal : Form
    {
        private Form F;
        private String Key = "";
        private int i = 0, index;
        private bool Nuevo = false;
        private Dictionary<String, Estructura> Estructura;
        private List<MLKButton> BotonCurr = new List<MLKButton>(), ListaMenu = new List<MLKButton>();
        private List<Panel> SubPanelCurr = new List<Panel>();

        public Principal()
        {
            InitializeComponent();
            ListaMenu.Add(Personal);
            ListaMenu.Add(Educacion);
            ListaMenu.Add(Experiencia);
            ListaMenu.Add(Habilidades);
        }

        private async void Principal_Load(object sender, EventArgs e) => await Cargar();

        private Task Guardar()
        {
            File.WriteAllText("Curriculums.json", JsonSerializer.Serialize(Estructura, new JsonSerializerOptions { WriteIndented = true }), Encoding.ASCII);
            return Task.CompletedTask;
        }

        public async Task GuardarJSON(String Parte, Object X)
        {
            switch (Parte)
            {
                case "Personal":
                    if (!Estructura.ContainsKey(Key))
                        Estructura.Add(Key, new Estructura
                        {
                            Personal = new DPersonal(),
                            Educacion = new List<DEducacion>(),
                            Experiencia = new List<DExperiencia>(),
                            Habilidades = new Dictionary<String, List<string>>()
                        });
                    Estructura[Key].Personal = (DPersonal)X;
                    Educacion.Enabled = Estructura.ContainsKey(Key);
                    Experiencia.Enabled = Estructura.ContainsKey(Key);
                    Habilidades.Enabled = Estructura.ContainsKey(Key);
                    break;
                case "Educacion":
                    //Estructura[Key].Educacion = (List<DEducacion>)X;
                    Estructura[Key].Educacion = ((List<DEducacion>)X).OrderBy(i => i.FInicio).ToList();
                    break;
                case "Experiencia":
                    //Estructura[Key].Experiencia = (List<DExperiencia>)X;
                    Estructura[Key].Experiencia = ((List<DExperiencia>)X).OrderByDescending(i => i.FInicio).ToList();
                    break;
                case "Habilidades":
                    Estructura[Key].Habilidades = (Dictionary<String, List<String>>)X;
                    break;
            }
            foreach (Panel SP in SubPanelCurr)
                if (SP.Name.Equals($"{Key}Panel"))
                    if (Estructura[Key].Personal.Perfil.Imagen != null && Estructura[Key].Educacion != null && Estructura[Key].Experiencia != null && Estructura[Key].Habilidades != null)
                        SP.Controls[0].Enabled = Estructura[Key].Educacion.Count > 0 && Estructura[Key].Experiencia.Count > 0 && Estructura[Key].Habilidades.Count > 0;
            Nuevo = false;
            await Guardar();
        }

        private void CrearCurr_Click(object sender, EventArgs e)
        {
            using (Nuevo N = new Forms.Nuevo())
            {
                bool Error = false;
                N.StartPosition = FormStartPosition.CenterParent;
                do
                {
                    switch (N.ShowDialog())
                    {
                        case DialogResult.OK:
                            Key = N.Nombre.Texts.Split(' ')[0];
                            if (Estructura.ContainsKey(Key))
                            {
                                MessageBox.Show("Ese nombre ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                N.Nombre.Clear();
                                N.Nombre.Focus();
                                Error = true;
                            }
                            else
                            {
                                index = i;
                                Creador(Key, false);
                                ResetCurr();
                                BotonCurr[BotonCurr.Count - 1].BackgroundColor = Color.MediumBlue;
                                pMenuCurr.Enabled = true;
                                Personal.PerformClick();
                                Nuevo = true;
                                Error = false;
                            }
                            break;
                        case DialogResult.Cancel:
                            N.Close();
                            Error = false;
                            break;
                    }
                }
                while (Error);
            }
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            Educacion.Enabled = Estructura.ContainsKey(Key);
            Experiencia.Enabled = Estructura.ContainsKey(Key);
            Habilidades.Enabled = Estructura.ContainsKey(Key);
            AbrirCerrarForm(new Personal(this, Estructura.ContainsKey(Key) ? Estructura[Key].Personal : null));
            ResetMenu();
            Personal.BackgroundColor = Color.MediumBlue;
        }

        private void Educacion_Click(object sender, EventArgs e)
        {
            AbrirCerrarForm(new EduExp(this, "Educacion", Estructura[Key].Educacion));
            ResetMenu();
            Educacion.BackgroundColor = Color.MediumBlue;
        }

        private void Experiencia_Click(object sender, EventArgs e)
        {
            AbrirCerrarForm(new EduExp(this, "Experiencia", Estructura[Key].Experiencia));
            ResetMenu();
            Experiencia.BackgroundColor = Color.MediumBlue;
        }

        private void Habilidades_Click(object sender, EventArgs e)
        {
            AbrirCerrarForm(new Habilidades(this, Estructura[Key].Habilidades));
            ResetMenu();
            Habilidades.BackgroundColor = Color.MediumBlue;
        }

        private void AbrirCerrarForm(Form Form = null)
        {
            if (Form != null)
            {
                if (F != null)
                    F.Close();
                F = Form;
                Form.TopLevel = false;
                Form.FormBorderStyle = FormBorderStyle.None;
                Form.Dock = DockStyle.Fill;
                pContenido.Controls.Add(Form);
                Form.BringToFront();
                Form.Show();
            }
            else
            {
                F.Close();
                F = null;
            }
        }

        private void ResetMenu()
        {
            foreach (MLKButton mlkB in ListaMenu)
                mlkB.BackgroundColor = Color.MediumSlateBlue;
        }

        private Task Cargar()
        {
            try
            {
                Estructura = JsonSerializer.Deserialize<Dictionary<String, Estructura>>(File.ReadAllText("Curriculums.json", Encoding.ASCII), new JsonSerializerOptions { WriteIndented = true });
                foreach (String Key in Estructura.Keys)
                    Creador(Key);
            }
            catch
            {
                Estructura = new Dictionary<string, Estructura>();
            }
            return Task.CompletedTask;
        }

        private void Creador(String Key, bool Cargar = true)
        {
            bool Activado = false;
            if (Estructura.ContainsKey(Key))
                Activado = Estructura[Key].Personal.Perfil.Imagen != null && Estructura[Key].Educacion.Count > 0 && Estructura[Key].Experiencia.Count > 0 && Estructura[Key].Habilidades.Count > 0;
            CrearBoton(Key);
            CrearSubPanel(Key, Cargar);
            CrearBotonSubPanel("PDF", Activado);
            CrearBotonSubPanel("Eliminar", true);
        }

        private void CrearBoton(String Key)
        {
            MLKButton Temp = new MLKButton();
            Temp.Text = Key;
            Temp.TextAlign = ContentAlignment.MiddleLeft;
            Temp.Dock = DockStyle.Bottom;
            Temp.TextColor = SystemColors.ControlText;
            Temp.TextImageRelation = TextImageRelation.ImageBeforeText;
            Temp.Image = Properties.Resources.U24;
            Temp.ImageAlign = ContentAlignment.MiddleLeft;
            Temp.Padding = new Padding(10, 0, 0, 0);
            Temp.Tag = i;
            Temp.Click += new EventHandler(IDBoton);
            pCurr.Height += 30;
            pCurr.Controls.Add(Temp);
            BotonCurr.Add(Temp);
            i++;
            OcultarSubPanel();
        }

        private void CrearSubPanel(String Key, bool Carga)
        {
            Panel Temp = new Panel();
            Temp.Dock = DockStyle.Bottom;
            Temp.Height = 60;
            Temp.Name = $"{Key}Panel";
            if (Carga)
                Temp.Visible = false;
            else
                pCurr.Height += 60;
            pCurr.Controls.Add(Temp);
            SubPanelCurr.Add(Temp);
        }

        private void CrearBotonSubPanel(String Text, bool Activado)
        {
            MLKButton Temp = new MLKButton();
            Temp.Text = Text;
            Temp.Image = Text == "PDF" ? Properties.Resources.PDF24 : Properties.Resources.E24;
            Temp.Click += Text == "PDF" ? new EventHandler(CrearPDF) : new EventHandler(Eliminar);
            Temp.TextColor = SystemColors.ControlText;
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.Dock = DockStyle.Bottom;
            Temp.TextImageRelation = TextImageRelation.ImageBeforeText;
            Temp.ImageAlign = ContentAlignment.MiddleCenter;
            Temp.Enabled = Activado;
            SubPanelCurr[SubPanelCurr.Count - 1].Controls.Add(Temp);
        }

        private void IDBoton(object sender, EventArgs e)
        {
            MLKButton clickedButton = (MLKButton)sender;
            Key = clickedButton.Text;
            index = int.Parse(clickedButton.Tag.ToString());
            if (!SubPanelCurr[index].Visible)
            {
                MostrarSubPanel(SubPanelCurr[index]);
                pMenuCurr.Enabled = true;
                Personal.PerformClick();
                ResetCurr();
                clickedButton.BackgroundColor = Color.MediumBlue;
            }
            else
            {
                OcultarSubPanel();
                pMenuCurr.Enabled = false;
                AbrirCerrarForm();
            }
        }

        private void CrearPDF(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF|*.pdf";
                saveFileDialog.InitialDirectory = $@"C:\Users\{WindowsIdentity.GetCurrent().Name.Split('\\')[1]}\Documents\";
                saveFileDialog.FileName = $"{Key} Curriculum";
                saveFileDialog.DefaultExt = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    Task.Run(async () =>
                    {
                        Task PDF = new PDF().CrearPDF(Estructura[Key], saveFileDialog.FileName);
                        await PDF;
                        Process.Start(saveFileDialog.FileName);
                    }).GetAwaiter().GetResult();
            }
        }
        

        private async void Eliminar(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Desea eliminar el perfil de {Key}?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Estructura.Remove(Key);
                await Guardar();
                OcultarSubPanel();
                BotonCurr[index].Dispose();
                BotonCurr.RemoveAt(index);
                SubPanelCurr[index].Dispose();
                SubPanelCurr.RemoveAt(index);
                pCurr.Height -= 30;
                if (F != null)
                    F.Close();
                pMenuCurr.Enabled = false;
                i--;
                foreach (MLKButton mlkB in BotonCurr)
                    if (int.Parse(mlkB.Tag.ToString()) >= index)
                        mlkB.Tag = int.Parse(mlkB.Tag.ToString()) - 1;
                if (Nuevo)
                    Nuevo = false;
            }
        }

        private void MostrarSubPanel(Panel Panel)
        {
            if (!Panel.Visible)
            {
                OcultarSubPanel();
                Panel.Visible = true;
                pCurr.Height += 60;
            }
            else
            {
                Panel.Visible = false;
                pCurr.Height -= 60;
            }
        }

        private void OcultarSubPanel()
        {
            foreach (Panel Panel in SubPanelCurr)
                if (Panel.Visible)
                {
                    Panel.Visible = false;
                    pCurr.Height -= 60;
                }
        }

        private void ResetCurr()
        {
            foreach (MLKButton mlkB in BotonCurr)
                mlkB.BackgroundColor = Color.MediumSlateBlue;
        }
    }
}
