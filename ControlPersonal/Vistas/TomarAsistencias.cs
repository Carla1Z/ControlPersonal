using ControlPersonal.Datos;
using ControlPersonal.Negocios;
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
    public partial class TomarAsistencias : Form
    {
        public TomarAsistencias()
        {
            InitializeComponent();
        }

        string Identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechaReg;

        private void TomarAsistencias_Load(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }


        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdent();
            if (Identificacion == txtIdentificacion.Text)
            {
                BuscarAsistenciasId();
                if(Contador == 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Agregar una Observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(resultado == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point((panelRegistro.Location.X), (panelRegistro.Location.Y));
                        panelObservacion.Size = new Size(panelRegistro.Width, panelRegistro.Height);
                        panelObservacion.BringToFront();
                        txtObservacion.Clear();
                        txtObservacion.Focus();
                    }
                    else
                    {
                        InsertarAsistencias();
                    }
                }
                else
                {
                    ConfirmarSalida();
                }
            }
        }

        private void ConfirmarSalida()
        {
            AsistenciasServices parametros = new AsistenciasServices();
            AsistenciasData funcion = new AsistenciasData();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if (funcion.ConfirmarSalida(parametros) == true)
            {
                txtAviso.Text = "SALIDA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }
        }

        private void InsertarAsistencias()
        {
            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "-";
            }

            AsistenciasServices parametros = new AsistenciasServices();
            AsistenciasData funcion = new AsistenciasData();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtObservacion.Text;
            if (funcion.InsertarAsistencias(parametros) == true)
            {
                txtAviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                panelObservacion.Visible = false;
            }

        }

        private void BuscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            AsistenciasData funcion = new AsistenciasData();
            funcion.BuscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;
            if (Contador > 0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
            }
        }

        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            PersonalData funcion = new PersonalData();
            funcion.BuscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if(dt.Rows.Count > 0)
            {
                Identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal = Convert.ToInt32(dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarAsistencias();
        }
    }
}
