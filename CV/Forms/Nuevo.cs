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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nombre_TextChanged(object sender, EventArgs e) => Aceptar.Enabled = !String.IsNullOrWhiteSpace(Nombre.Texts);

        private void Nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Aceptar.Enabled)
                    Aceptar.PerformClick();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void Cancelar_Click(Object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
