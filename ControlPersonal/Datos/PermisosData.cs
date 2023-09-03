using ControlPersonal.Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonal.Datos
{
    public class PermisosData
    {
        public bool InsertarPermisos(PermisosServices parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_permisos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModulo", parametros.IdModulo);
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void MostrarPermisos(ref DataTable dt, PermisosServices parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_permisos", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idusuario", parametros.IdUsuario);
                da.Fill(dt);
                CONEXIONMAESTRA.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public bool EliminarPermisos(PermisosServices parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_permisos", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

    }
}
