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

        int Idusuario;

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
            dataListadoModulos.Columns[1].Visible = false;
            Bases.DiseñoDGV(ref dataListadoModulos);
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
                obtenerIdUsuario();
                insertarPermisos();
            }
        }

        private void insertarPermisos()
        {
            foreach (DataGridViewRow row in dataListadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if(marcado == true)
                {
                    PermisosServices parametros = new PermisosServices();
                    PermisosData funcion = new PermisosData();
                    parametros.IdModulo = IdModulo;
                    parametros.IdUsuario = Idusuario;
                    funcion.InsertarPermisos(parametros);
                }
            }
            mostrarUsuarios();
            panelRegistro.Visible = false;
        }

        private void mostrarUsuarios()
        {
            DataTable dt = new DataTable();
            UsuariosData funcion = new UsuariosData();
            funcion.MostrarUsuarios(ref dt);
            dataListadoUsuarios.DataSource = dt;
            diseñarDtvUsuarios();
        }

        private void diseñarDtvUsuarios()
        {
            Bases.DiseñoDGV(ref dataListadoUsuarios);
            Bases.DiseñoDGVEliminar(ref dataListadoUsuarios);
            dataListadoUsuarios.Columns[2].Visible = false;
            dataListadoUsuarios.Columns[5].Visible = false;
            dataListadoUsuarios.Columns[6].Visible = false;
        }

        private void obtenerIdUsuario()
        {
            UsuariosData funcion = new UsuariosData();
            funcion.ObtenerIdUsuario(ref Idusuario, txtUsuario.Text);

        }

        private void lblAnuncioIcono_Click(object sender, EventArgs e)
        {
            mostrarPanelIcono();
        }

        private void mostrarPanelIcono()
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }

        private void ocultarPanelIconos()
        {
            panelIcono.Visible=false;
            lblAnuncioIcono.Visible=false;
            Icono.Visible=true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox3.Image;
            ocultarPanelIconos();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox4.Image;
            ocultarPanelIconos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox5.Image;
            ocultarPanelIconos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox6.Image;
            ocultarPanelIconos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox7.Image;
            ocultarPanelIconos();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox8.Image;
            ocultarPanelIconos();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox9.Image;
            ocultarPanelIconos();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox10.Image;
            ocultarPanelIconos();
        }

        private void AgregarIconoPc_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIconos();
            }
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            mostrarPanelIcono();
        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled= false;
            }
            else
            {
                e.Handled= true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            ocultarPanelIconos();
        }
    }
}
