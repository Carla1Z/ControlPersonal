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
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        int Idcargo=0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int Idpersonal;
        private int items_por_pagina = 10;
        string Estado;
        int totalPaginas;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LocalizarDgvCargos();
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistros.Visible = true;
            PanelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();
        }

        private void LocalizarDgvCargos()
        {
            dataListadoCargos.Location = new Point(txtSueldoHora.Location.X, txtSueldoHora.Location.Y);
            dataListadoCargos.Size = new Size(469, 141);
            dataListadoCargos.Visible = true;
            lblSueldo.Visible = false;
            PanelBtnGuardarPer.Visible = false;
        }

        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
            Buscar_Cargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (Idcargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                Insertar_Personal();
                            }
                        }

                    }

                }

            }
        }

        private void Insertar_Personal()
        {
            PersonalServices parametros = new PersonalServices();
            PersonalData funcion = new PersonalData();
            parametros.Nombres=txtNombres.Text;
            parametros.Identificacion=txtIdentificacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.InsertarPersonal(parametros) == true)
            {
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }
        }

        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            PersonalData funcion = new PersonalData();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            dataListadoPersonal.DataSource = dt;
            DiseñarDgvPersonal();
        }

        private void DiseñarDgvPersonal()
        {
            Bases.DiseñoDGV(ref dataListadoPersonal);
            Bases.DiseñoDGVEliminar(ref dataListadoPersonal);
            PanelPaginado.Visible = true;
            dataListadoPersonal.Columns[2].Visible = false;
            dataListadoPersonal.Columns[7].Visible = false;
        }

        private void Insertar_Cargos()
        {
            if (!string.IsNullOrEmpty(txtCargoG.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoG.Text))
                {
                    CargosServices parametros = new CargosServices();
                    CargosData funcion = new CargosData();
                    parametros.Cargo = txtCargoG.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
                    if (funcion.InsertarCargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        Buscar_Cargos();
                        PanelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agregue el sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agregue el cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Buscar_Cargos()
        {
            DataTable dt = new DataTable();
            CargosData funcion = new CargosData();
            funcion.BuscarCargos(ref dt, txtCargo.Text);
            dataListadoCargos.DataSource = dt;
            Bases.DiseñoDGV(ref dataListadoCargos);
            dataListadoCargos.Columns[1].Visible = false;
            dataListadoCargos.Columns[3].Visible = false;
            dataListadoCargos.Visible = true;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            Buscar_Cargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargoG.Clear();
            txtSueldoG.Clear();
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            Insertar_Cargos();
        }

        private void txtSueldoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoG, e);
        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHora, e);
        }

        private void dataListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == dataListadoCargos.Columns["Cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }

        private void ObtenerDatosCargos()
        {
            Idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            dataListadoCargos.Visible = false;
            PanelBtnGuardarPer.Visible = true;
            lblSueldo.Visible = true;
        }

        private void ObtenerCargosEditar()
        {
            Idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargoG.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoG.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarC.Visible = false;
            btnGuardarCambiosC.Visible = true;
            txtCargoG.Focus();
            txtCargo.SelectAll();
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
        }

        private void btnVolverCargos_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible=false;
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            PanelRegistros.Visible=false;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }

        private void EditarCargos()
        {
            CargosServices parametros = new CargosServices();
            CargosData funcion = new CargosData();
            parametros.Id_cargo = Idcargo;
            parametros.Cargo = txtCargoG.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
            if (funcion.EditarCargo(parametros) == true)
            {
                txtCargo.Clear();
                Buscar_Cargos();
                PanelCargos.Visible = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
        }

        private void dataListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataListadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("Solo se cambiara el Estado para que no pueda acceder. ¿Desea continuar?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    EliminarPersonal();
                }
            }
            if (e.ColumnIndex == dataListadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }

        private void ObtenerDatos()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            Estado = dataListadoPersonal.SelectedCells[8].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                Restaurar_Personal();
            }
            else
            {
                LocalizarDgvCargos();
                txtNombres.Text = dataListadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentificacion.Text = dataListadoPersonal.SelectedCells[4].Value.ToString();
                cbxPais.Text = dataListadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = dataListadoPersonal.SelectedCells[6].Value.ToString();
                Idcargo = Convert.ToInt32(dataListadoPersonal.SelectedCells[7].Value);
                txtSueldoHora.Text = dataListadoPersonal.SelectedCells[5].Value.ToString();
                PanelPaginado.Visible = false;
                PanelRegistros.Visible = true;
                PanelRegistros.Dock = DockStyle.Fill;
                dataListadoCargos.Visible = false;
                lblSueldo.Visible = true;
                PanelBtnGuardarPer.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                PanelCargos.Visible = false;
            }
        }

        private void Restaurar_Personal()
        {
            DialogResult result = MessageBox.Show("Este Personal se Elimino. ¿Desea volver a habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HabilitarPersonal();
            }
        }

        private void HabilitarPersonal()
        {
            PersonalServices parametros = new PersonalServices();
            PersonalData funcion = new PersonalData();
            parametros.Id_personal = Idpersonal;
            if (funcion.RestaurarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void EliminarPersonal()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            PersonalServices parametros = new PersonalServices();
            PersonalData funcion = new PersonalData();
            parametros.Id_personal = Idpersonal;
            if (funcion.EliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDgvPersonal();
            timer1.Enabled = false;
        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }

        private void EditarPersonal()
        {
            PersonalServices parametros = new PersonalServices();
            PersonalData funcion = new PersonalData();
            parametros.Id_personal = Idpersonal;
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.EditarPersonal(parametros) == true)
            {
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }
        }
    }
}
