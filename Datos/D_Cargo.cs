using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados.Datos
{
    public class D_Cargo
    {
        public DataTable Listar_Cargos()
        {
            SqlDataReader resultado; // Resultado devuelto por SQL Server
            DataTable tabla = new DataTable(); // Tabla donde se cargan los datos finales
            SqlConnection SqlCon = new SqlConnection(); // Conexión entre la aplicación y la BD

            try
            {
                // Se crea la conexión a la base de datos
                SqlCon = Conexion.crearInstancia().CrearConexion();

                // Se especifica el Stored Procedure que se va a ejecutar
                SqlCommand comando = new SqlCommand("SP_LISTAR_CARGOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;


                // Se abre la conexión con la base de datos
                SqlCon.Open();

                // Se ejecuta el SP, se obtienen los datos y se cargan en el DataTable
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                // Se retorna la tabla con los empleados encontrados
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

    }
}
