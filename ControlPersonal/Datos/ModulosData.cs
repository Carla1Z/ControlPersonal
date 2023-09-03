using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControlPersonal.Datos
{
    public class ModulosData
    {
        public void MostrarModulos(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Modulos", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
