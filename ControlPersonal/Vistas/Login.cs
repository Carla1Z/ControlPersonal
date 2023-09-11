using ControlPersonal.Datos;
using ControlPersonal.Negocios;
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

                    b.Click += new EventHandler(miEventoLabel);
                    I1.Click += miEventoImagen;
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void miEventoImagen(object sender, EventArgs e)
        {
            Usuario = Convert.ToString(((PictureBox)sender).Tag);
            MostrarPanelPass();
        }

        private void miEventoLabel(object sender, EventArgs e)
        {
            Usuario = ((Label)sender).Text;
            MostrarPanelPass();

        }

        private void MostrarPanelPass()
        {
            panelIngresoPassword.Visible = true;
            panelIngresoPassword.Location = new Point((Width - panelIngresoPassword.Width)/2,(Height - panelIngresoPassword.Height)/2);
            panelUsuarios.Visible = false;
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            validarUsuarios();
        }

        private void validarUsuarios()
        {
            UsuariosServices parametros = new UsuariosServices();
            UsuariosData funcion = new UsuariosData();
            parametros.Password = txtIdentificacion.Text;
            parametros.Login = Usuario;
            funcion.ValidarUsuario(parametros, ref Idusuario);
            if (Idusuario > 0)
            {
                Dispose();
                MenuPrincipal frm = new MenuPrincipal();
                frm.ShowDialog();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contraseña erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text += "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
        }

        private void btnBorrarDigito_Click(object sender, EventArgs e)
        {
            int contador;
            contador = txtIdentificacion.Text.Count();
            if (contador > 0)
            {
                txtIdentificacion.Text = txtIdentificacion.Text.Substring(0, txtIdentificacion.Text.Count() - 1);
            }
        }
    }
}
