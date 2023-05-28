using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV.Forms
{
    public partial class Habilidades : Form
    {
        private Principal Principal;
        private String Key;
        private Dictionary<String, List<String>> H = new Dictionary<string, List<string>>();
        
        public Habilidades(Form F, Object X)
        {
            InitializeComponent();
            Principal = F as Principal;
            H = (Dictionary<String, List<String>>)X;
            foreach (String Key in H.Keys)
                LHabilidades.Items.Add(Key);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Nuevo N = new Nuevo())
            {
                bool Error = false;
                N.StartPosition = FormStartPosition.CenterScreen;
                do
                {
                    try
                    {
                        switch (N.ShowDialog())
                        {
                            case DialogResult.OK:
                                H.Add(N.Nombre.Texts, new List<string>());
                                LHabilidades.Items.Add(N.Nombre.Texts);
                                LHabilidades.SelectedIndex = LHabilidades.Items.Count - 1;
                                break;
                            case DialogResult.Cancel:
                                N.Close();
                                break;
                        }
                        Error = false;
                    }
                    catch
                    {
                        MessageBox.Show("Esta habilidad ya esta en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        N.Nombre.Clear();
                        N.Nombre.Focus();
                        Error = true;
                    }
                }
                while (Error);
            }
        }

        private void LHabilidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key = LHabilidades.Text;
            Eliminar.Enabled = LHabilidades.SelectedIndex != -1;
            Habilidad.Enabled = LHabilidades.SelectedIndex != -1;
            if (LHabilidades.SelectedIndex != -1)
                Cargar();
        }

        private async void Eliminar_Click(object sender, EventArgs e)
        {
            H.Remove(Key);
            LHabilidades.Items.Remove(Key);
            await Principal.GuardarJSON("Habilidades", H);
            LHabilidades.SelectedIndex = LHabilidades.Items.Count - 1;
        }

        private void Habilidad_TextChanged(object sender, EventArgs e) => Agregar.Enabled = !String.IsNullOrWhiteSpace(Habilidad.Texts);

        private void Habilidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Eliminar.Enabled)
                {
                    AgregarH();
                    Habilidad.Focus();
                }
            }
        }

        private void Agregar_Click(Object sender, EventArgs e) => AgregarH();

        private void Cargar()
        {
            for (int i = ImpHabilidad.Controls.Count - 1; i >= 0; i--)
                ImpHabilidad.Controls[i].Dispose();
            foreach (String H in H[Key])
                CrearLabel(H);
        }

        private void CrearLabel(String H)
        {
            LinkLabel Temp = new LinkLabel();
            Temp.Text = H;
            Temp.AutoSize = true;
            Temp.Font = new Font(Font.Name, 9.5F, FontStyle.Regular);
            Temp.LinkBehavior = LinkBehavior.NeverUnderline;
            Temp.LinkColor = Color.Black;
            Temp.Location = new Point(3, 3);
            Temp.LinkClicked += new LinkLabelLinkClickedEventHandler(EliminarLabel);
            ImpHabilidad.Controls.Add(Temp);
            AcomodarLabel();
        }

        private async void EliminarLabel(object sender, EventArgs e)
        {
            LinkLabel clickedLabel = (LinkLabel)sender;
            H[Key].Remove(clickedLabel.Text);
            clickedLabel.Dispose();
            AcomodarLabel();
            await Principal.GuardarJSON("Habilidades", H);
        }

        private void AcomodarLabel()
        {
            int SumX = 3, SumY = 3;
            foreach (LinkLabel label in ImpHabilidad.Controls.OfType<LinkLabel>())
            {
                if (SumX + label.Width > ImpHabilidad.Width)
                {
                    SumX = 3;
                    SumY += 19;
                }
                label.Location = new Point(SumX, SumY);
                SumX += label.Width;
            }
        }

        private async void AgregarH()
        {
            if (H[Key].Contains(Habilidad.Texts))
                MessageBox.Show($"{Habilidad.Texts} ya esta agregado en {Key}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                CrearLabel(Habilidad.Texts);
                H[Key].Add(Habilidad.Texts);
                await Principal.GuardarJSON("Habilidades", H);
                Habilidad.Clear();
            }
        }
    }
}
