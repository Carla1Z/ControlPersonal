using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonal.Vistas
{
    public partial class ControlUsuarios : UserControl
    {
        public ControlUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void habilitarPaneles()
        {
            panelRegistro.Visible = true;
            lblAnuncioIcono.Visible = true;
            panelIcono.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }

    }
}
