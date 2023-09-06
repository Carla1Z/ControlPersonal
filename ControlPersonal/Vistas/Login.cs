using ControlPersonal.Datos;
using ControlPersonal.Vistas.AsistenteInstalacion;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string Usuario;
        int Idusuario;
        int Contador;
        string Indicador;

        private void Login_Load(object sender, EventArgs e)
        {
            validarConexion();
        }

        private void validarConexion()
        {
            verificarConexion();
            if (Indicador == "Correcto")
            {
                dibujarUsuarios();
            }
            else
            {
                Dispose();
                EleccionServidor frm = new EleccionServidor();
                frm.ShowDialog();
            }
        }

        private void verificarConexion()
        {
            UsuariosData funcion = new UsuariosData();
            funcion.VerificarUsuarios(ref Indicador);
        }

        private void dibujarUsuarios()
        {
            try
            {
                panelUsuarios.Visible = true;
                panelUsuarios.Dock = DockStyle.Fill;
                panelUsuarios.BringToFront();
                DataTable dt = new DataTable();
                UsuariosData funcion = new UsuariosData();
                funcion.MostrarUsuarios(ref dt);
                foreach (DataRow rdr in dt.Rows)
                {
                    
                    Label b = new Label();
                    Panel p1 = new Panel();
                    PictureBox I1 = new PictureBox();
                    b.Text = rdr["Login"].ToString();
                    b.Name = rdr["IdUsuario"].ToString();
                    b.Size = new Size(175,45);
                    b.Font = new Font("Bookman Old Style", 10);
                    b.BackColor = Color.Transparent;
                    b.ForeColor = Color.Black;
                    b.Dock = DockStyle.Bottom;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.Cursor = Cursors.Hand;

                    p1.Size = new Size(175, 155);
                    p1.BorderStyle = BorderStyle.None;
                    p1.BackColor = Color.PaleVioletRed;

                    I1.Size = new Size(175, 110);
                    I1.Dock = DockStyle.Top;
                    I1.BackgroundImage = null;
                    byte[] bi = (Byte[])rdr["Icono"];
                    MemoryStream ms = new MemoryStream(bi);
                    I1.Image = Image.FromStream(ms);
                    I1.SizeMode = PictureBoxSizeMode.Zoom;
                    I1.Tag = rdr["Login"].ToString();
                    I1.Cursor = Cursors.Hand;

                    p1.Controls.Add(b);
                    p1.Controls.Add(I1);
                    p1.BringToFront();

                    flowLayoutPanel2.Controls.Add(p1);
                }
            }
            catch (Exception)
            {
                flowLayoutPanel2.BackColor = Color.Blue;
            }
        }

    }
}
