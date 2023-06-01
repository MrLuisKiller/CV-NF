using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CV.Clases;
using CV.Componentes;

namespace CV.Forms
{
    public partial class EduExp : Form
    {
        private Principal Principal;
        private String Parte;
        private int i = 0, index, Tamanio;
        private bool Actualizar = false;
        private List<DEducacion> Edu;
        private List<DExperiencia> Exp;
        private List<Panel> pE = new List<Panel>();
        private Dictionary<String, Panel> pAgregar = new Dictionary<string, Panel>();
        private Dictionary<String, Label> Titulo = new Dictionary<string, Label>();
        private Dictionary<String, MLKCheckBox> Estoy = new Dictionary<string, MLKCheckBox>();
        private Dictionary<String, MLKDateTimePicker> FInicio = new Dictionary<string, MLKDateTimePicker>();
        private Dictionary<String, MLKDateTimePicker> FFinal = new Dictionary<string, MLKDateTimePicker>();
        private Dictionary<String, MLKTextBox> Descripcion = new Dictionary<string, MLKTextBox>();
        private Dictionary<String, MLKButton> GuardarEditar = new Dictionary<string, MLKButton>();
        private Dictionary<String, int> indexEliminar = new Dictionary<string, int>(), indexEditar = new Dictionary<string, int>();

        public EduExp(Form F, String P, Object X)
        {
            InitializeComponent();
            InitDictionary();
            Principal = F as Principal;
            Parte = P;
            /* if (P == "Educacion")
                Edu = (List<DEducacion>)X;
            else
                Exp = (List<DExperiencia>)X; */
            if (P == "Educacion")
                Edu = ((List<DEducacion>)X).Select(i => i).OrderBy(i => i.FInicio).ToList();
            else
                Exp = ((List<DExperiencia>)X).Select(i => i).OrderBy(i => i.FInicio).ToList();
            Tamanio = P == "Educacion" ? 84 : 144;
            pContenedor.Height = 0;
            Cargar();
        }

        private void InitDictionary()
        {
            pAgregar.Add("Educacion", pEducacion);
            pAgregar.Add("Experiencia", pExperiencia);
            Titulo.Add("Educacion", lEducacion);
            Titulo.Add("Experiencia", lExperiencia);
            Estoy.Add("Educacion", Estudio);
            Estoy.Add("Experiencia", Trabajo);
            FInicio.Add("Educacion", EduFInicio);
            FInicio.Add("Experiencia", ExpFInicio);
            FFinal.Add("Educacion", EduFFinal);
            FFinal.Add("Experiencia", ExpFFinal);
            Descripcion.Add("Educacion", EduDescripcion);
            Descripcion.Add("Experiencia", ExpDescripcion);
            indexEliminar.Add("Educacion", 3);
            indexEliminar.Add("Experiencia", 6);
            indexEditar.Add("Educacion", 4);
            indexEditar.Add("Experiencia", 7);
            GuardarEditar.Add("Educacion", EduGuardarEditar);
            GuardarEditar.Add("Experiencia", ExpGuardarEditar);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            pContenedor.Visible = false;
            Agregar.Visible = false;
            pAgregar[Parte].Visible = true;
            Titulo[Parte].Text = Parte == "Educacion" ? "Nueva Educacion" : "Nueva Experiencia";
        }

        private void EstTrab(object sender, EventArgs e)
        {
            FFinal[Parte].Enabled = !Estoy[Parte].Checked;
            Changed(sender, e);
        }

        private void Cancelar_Click(Object sender, EventArgs e)
        {
            pContenedor.Visible = true;
            Agregar.Visible = true;
            pAgregar[Parte].Visible = false;
            Limpiar();
        }

        private void Changed(object sender, EventArgs e)
        {
            if (GuardarEditar[Parte].Enabled == false)
                GuardarEditar[Parte].Enabled = true;
        }

        private async void GuardarEditar_Click(object sender, EventArgs e)
        {
            int X = 0;
            String F = new Mes().Abreviar(FInicio[Parte].Value.ToString("MM/yyyy"));
            F += Estoy[Parte].Checked ? " - Actualmente" : $" - {new Mes().Abreviar(FFinal[Parte].Value.ToString("MM/yyyy"))}";
            if (Parte == "Educacion")
            {
                if (Actualizar)
                {
                    pE[index].Controls[0].Text = Carrera.Texts;
                    pE[index].Controls[1].Text = Institucion.Texts;
                    pE[index].Controls[2].Text = F;
                    X = index;
                    Actualizar = false;
                }
                else
                {
                    Creador(Carrera.Texts, Institucion.Texts, F);
                    Edu.Add(new DEducacion { });
                    X = Edu.Count - 1;
                }
                Edu[X].Institucion = Institucion.Texts;
                Edu[X].Carrera = Carrera.Texts;
                Edu[X].FInicio = DateTime.Parse(FInicio[Parte].Value.ToShortDateString());
                Edu[X].FFinal = !Estoy[Parte].Checked ? DateTime.Parse(FFinal[Parte].Value.ToShortDateString()) : DateTime.Parse(DateTime.Now.ToShortDateString());
                Edu[X].Estudio = Estoy[Parte].Checked;
                Edu[X].Descripcion = Descripcion[Parte].Texts;
                await Principal.GuardarJSON(Parte, Edu);
            }
            else
            {
                if (Actualizar)
                {
                    pE[index].Controls[0].Text = Nombre.Texts;
                    pE[index].Controls[1].Text = $"{Compania.Texts} - {Direccion.Texts}";
                    pE[index].Controls[2].Text = F;
                    pE[index].Controls[3].Text = Pagina.Texts;
                    pE[index].Controls[4].Text = Descripcion[Parte].Texts;
                    pE[index].Controls[5].Text = Habilidades.Texts;
                    X = index;
                    Actualizar = false;
                }
                else
                {
                    Creador(Nombre.Texts, $"{Compania.Texts} - {Direccion.Texts}", F, Pagina.Texts, Descripcion[Parte].Texts, Habilidades.Texts);
                    Exp.Add(new DExperiencia { });
                    X = Exp.Count - 1;
                }
                Exp[X].Nombre = Nombre.Texts;
                Exp[X].Compania = Compania.Texts;
                Exp[X].Direccion = Direccion.Texts;
                Exp[X].Pagina = Pagina.Texts;
                Exp[X].FInicio = DateTime.Parse(FInicio[Parte].Value.ToShortDateString());
                Exp[X].FFinal = !Estoy[Parte].Checked ? DateTime.Parse(FFinal[Parte].Value.ToShortDateString()) : DateTime.Parse(DateTime.Now.ToShortDateString());
                Exp[X].Trabajo = Estoy[Parte].Checked;
                Exp[X].Descripcion = Descripcion[Parte].Texts;
                Exp[X].Habilidades = Habilidades.Texts;
                await Principal.GuardarJSON(Parte, Exp);
            }
            //await Principal.GuardarJSON(Parte, Parte == "Educacion" ? Edu : Exp);
            pContenedor.Visible = true;
            Agregar.Visible = true;
            pAgregar[Parte].Visible = false;
            Limpiar();
        }

        private void Cargar()
        {
            String F;
            if (Parte == "Educacion")
                for (int i = 0; i < Edu.Count; i++)
                {
                    F = Edu[i].Estudio ? $"{new Mes().Abreviar(Edu[i].FInicio.ToString("MM/yyyy"))} - Actualmente" : $"{new Mes().Abreviar(Edu[i].FInicio.ToString("MM/yyyy"))} - {new Mes().Abreviar(Edu[i].FFinal.ToString("MM/yyyy"))}";
                    Creador(Edu[i].Institucion, Edu[i].Carrera, F);
                }
            else
                for (int i = 0; i < Exp.Count; i++)
                {
                    F = Exp[i].Trabajo ? $"{new Mes().Abreviar(Exp[i].FInicio.ToString("MM/yyyy"))} - Actualmente" : $"{new Mes().Abreviar(Exp[i].FInicio.ToString("MM/yyyy"))} - {new Mes().Abreviar(Exp[i].FFinal.ToString("MM/yyyy"))}";
                    Creador(Exp[i].Nombre, $"{Exp[i].Compania} - {Exp[i].Direccion}", F, Exp[i].Pagina, Exp[i].Descripcion, Exp[i].Habilidades);
                }
            GuardarEditar[Parte].Enabled = false;
        }

        private void Creador(String D1, String D2, String F, String D3 = "", String D4 = "", String D5 = "")
        {
            CrearPanel();
            if (Parte == "Educacion")
            {
                CrearLabel(D1, new Font(Font.Name, 12F, FontStyle.Bold), new Size(598, 20), new Point(0, 0));
                CrearLabel(D2, new Font(Font.Name, 9.75F, FontStyle.Regular), new Size(598, 16), new Point(0, 23));
                CrearLabel(F, new Font(Font.Name, 9F, FontStyle.Regular), new Size(170, 15), new Point(0, 42));
                CrearBoton("Eliminar", new Point(386, 50));
                CrearBoton("Editar", new Point(492, 50));
            }
            else
            {
                CrearLabel(D1, new Font(Font.Name, 12F, FontStyle.Bold), new Size(598, 20), new Point(0, 0));
                CrearLabel(D2, new Font(Font.Name, 9.75F, FontStyle.Italic), new Size(598, 16), new Point(0, 23));
                CrearLabel(F, new Font(Font.Name, 9F, FontStyle.Regular), new Size(170, 15), new Point(0, 42));
                CrearLabel(D3, new Font(Font.Name, 9F, FontStyle.Regular), new Size(598, 15), new Point(0, 60));
                CrearLabel(D4, new Font(Font.Name, 9F, FontStyle.Regular), new Size(598, 15), new Point(0, 78));
                CrearLabel(D5, new Font(Font.Name, 9F, FontStyle.Regular), new Size(387, 15), new Point(0, 96));
                CrearBoton("Eliminar", new Point(386, 110));
                CrearBoton("Editar", new Point(492, 110));
            }
            i++;
        }

        private void CrearPanel()
        {
            Panel Temp = new Panel();
            Temp.Dock = DockStyle.Bottom;
            Temp.Height = Tamanio;
            Temp.BorderStyle = BorderStyle.Fixed3D;
            Temp.Tag = i;
            pE.Add(Temp);
            pContenedor.Controls.Add(Temp);
            pContenedor.Height += Tamanio;
        }

        private void CrearLabel(String D, Font F, Size S, Point P)
        {
            Label Temp = new Label();
            Temp.Text = D;
            Temp.Font = F;
            Temp.Size = S;
            Temp.Location = P;
            pE[pE.Count - 1].Controls.Add(Temp);
        }

        private void CrearBoton(String Text, Point P)
        {
            MLKButton Temp = new MLKButton();
            Temp.Image = Text == "Eliminar" ? Properties.Resources.E16 : Properties.Resources.Ed16;
            Temp.Click += Text == "Eliminar" ? new EventHandler(Eliminar) : new EventHandler(Editar);
            Temp.Text = Text;
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.TextImageRelation = TextImageRelation.ImageBeforeText;
            Temp.ImageAlign = ContentAlignment.MiddleCenter;
            Temp.Location = P;
            Temp.Tag = i;
            pE[pE.Count - 1].Controls.Add(Temp);
        }

        private async void Eliminar(object sender, EventArgs e)
        {
            MLKButton clickedButton = (MLKButton)sender;
            int i = int.Parse(clickedButton.Tag.ToString()), X = Parte == "Educacion" ? Edu.Count : Exp.Count;
            if (Parte == "Educacion")
            {
                Edu.RemoveAt(i);
                await Principal.GuardarJSON(Parte, Edu);
            }
            else
            {
                Exp.RemoveAt(i);
                await Principal.GuardarJSON(Parte, Exp);
            }
            //await Principal.GuardarJSON(Parte, Parte == "Educacion" ? Edu : Exp);
            for (int j = i; j < X; j++)
                foreach (MLKButton mlkB in pE[j].Controls.OfType<MLKButton>())
                    mlkB.Tag = int.Parse(mlkB.Tag.ToString()) - 1;
            pContenedor.Controls[i].Dispose();
            pContenedor.Height -= Tamanio;
            pE.RemoveAt(i);
            this.i--;
        }


        private void Editar(object sender, EventArgs e)
        {
            MLKButton clickedButton = (MLKButton)sender;
            index = int.Parse(clickedButton.Tag.ToString());
            Agregar.PerformClick();
            Actualizar = true;
            if (Parte == "Educacion")
            {
                Titulo[Parte].Text = "Editar Educacion";
                Carrera.Texts = Edu[index].Carrera;
                Institucion.Texts = Edu[index].Institucion;
                FInicio[Parte].Value = Edu[index].FInicio;
                if (Edu[index].Estudio)
                    Estoy[Parte].Checked = true;
                else
                    FFinal[Parte].Value = Edu[index].FFinal;
                Descripcion[Parte].Texts = Edu[index].Descripcion;
            }
            else
            {
                Titulo[Parte].Text = "Editar Experiencia";
                Nombre.Texts = Exp[index].Nombre;
                Compania.Texts = Exp[index].Compania;
                Direccion.Texts = Exp[index].Direccion;
                Pagina.Texts = Exp[index].Pagina;
                FInicio[Parte].Value = Exp[index].FInicio;
                if (Exp[index].Trabajo)
                    Estoy[Parte].Checked = true;
                else
                    FFinal[Parte].Value = Exp[index].FFinal;
                Descripcion[Parte].Texts = Exp[index].Descripcion;
                Habilidades.Texts = Exp[index].Habilidades;
            }
        }

        private void Limpiar()
        {
            if (Parte == "Educacion")
            {
                Carrera.Clear();
                Institucion.Clear();
            }
            else
            {
                Nombre.Clear();
                Compania.Clear();
                Direccion.Clear();
                Pagina.Clear();
                Habilidades.Clear();
            }
            FInicio[Parte].Value = DateTime.Now;
            FFinal[Parte].Value = DateTime.Now;
            Estoy[Parte].Checked = false;
            Descripcion[Parte].Clear();
            GuardarEditar[Parte].Enabled = false;
        }
    }
}
