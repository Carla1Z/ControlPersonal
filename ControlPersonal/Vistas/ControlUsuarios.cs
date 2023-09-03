using ControlPersonal.Datos;
using ControlPersonal.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            mostrarModulos();
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

        private void mostrarModulos()
        {
            ModulosData funcion = new ModulosData();
            DataTable dt = new DataTable();
            funcion.MostrarModulos(ref dt);
            dataListadoModulos.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblAnuncioIcono.Visible == false)
                        {
                            insertarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la Contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre");
            }
        }

        private void insertarUsuarios()
        {
            UsuariosServices parametros = new UsuariosServices();
            UsuariosData funcion = new UsuariosData();
            parametros.Nombre = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono= ms.GetBuffer();
            if (funcion.InsertarUsuarios(parametros) == true)
            {

            }
        }

    }
}
