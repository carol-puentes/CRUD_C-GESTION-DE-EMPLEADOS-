using GestionEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionEmpleados.Datos
{
    public class D_Empleados
    {
        public DataTable Listar_Empleados(string cBusqueda)
        {
            SqlDataReader resultado; // Resultado devuelto por SQL Server
            DataTable tabla = new DataTable(); // Tabla donde se cargan los datos finales
            SqlConnection SqlCon = new SqlConnection(); // Conexión entre la aplicación y la BD

            try
            {
                // Se crea la conexión a la base de datos
                SqlCon = Conexion.crearInstancia().CrearConexion();

                // Se especifica el Stored Procedure que se va a ejecutar
                SqlCommand comando = new SqlCommand("SP_Listar_empleados", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Se envía el parámetro de búsqueda al Stored Procedure
                comando.Parameters.Add("@cBusqueda", SqlDbType.VarChar).Value = cBusqueda;

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

        public string Guardar_Empleado(E_Empleado Empleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se crea la conexión a la base de datos
                SqlCon = Conexion.crearInstancia().CrearConexion();

                // Se especifica el Stored Procedure que se va a ejecutar
                SqlCommand comando = new SqlCommand("SP_GUARDAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Se envía el parámetro de búsqueda al Stored Procedure
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Empleado.nombre_empleado;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Empleado.direccion_empleado;
                comando.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = Empleado.fecha_nacimiento_empleado;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Empleado.telefono_empleado;
                comando.Parameters.Add("@nSalario", SqlDbType.Money).Value = Empleado.salario_empleado;
                comando.Parameters.Add("@nIdDepartamento", SqlDbType.Int).Value = Empleado.id_departamento; 
                comando.Parameters.Add("@nIdCargo", SqlDbType.Int).Value = Empleado.id_cargo;


                // Se abre la conexión con la base de datos
                SqlCon.Open();

                // Se ejecuta el SP, se obtienen los datos y se cargan en el DataTable
                respuesta = comando.ExecuteNonQuery()>=1 ? "OK":"Los datos no fueron registrados";
              
            }
            catch (Exception ex)
            {
                respuesta=ex.Message;
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;

        }

        public string Actualizar_Empleado(E_Empleado Empleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se crea la conexión a la base de datos
                SqlCon = Conexion.crearInstancia().CrearConexion();

                // Se especifica el Stored Procedure que se va a ejecutar
                SqlCommand comando = new SqlCommand("SP_ACTUALIZAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Se envía el parámetro de búsqueda al Stored Procedure
                comando.Parameters.Add("@nIdEmpleado", SqlDbType.Int).Value = Empleado.id_empleado;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = Empleado.nombre_empleado;
                comando.Parameters.Add("@cDireccion", SqlDbType.VarChar).Value = Empleado.direccion_empleado;
                comando.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = Empleado.fecha_nacimiento_empleado;
                comando.Parameters.Add("@cTelefono", SqlDbType.VarChar).Value = Empleado.telefono_empleado;
                comando.Parameters.Add("@nSalario", SqlDbType.Money).Value = Empleado.salario_empleado;
                comando.Parameters.Add("@nIdDepartamento", SqlDbType.Int).Value = Empleado.id_departamento;
                comando.Parameters.Add("@nIdCargo", SqlDbType.Int).Value = Empleado.id_cargo;


                // Se abre la conexión con la base de datos
                SqlCon.Open();

                // Se ejecuta el SP, se obtienen los datos y se cargan en el DataTable
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no fueron registrados";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;

        }

        public string Desactivar_Empleado(int iCodigoEmpleado)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se crea la conexión a la base de datos
                SqlCon = Conexion.crearInstancia().CrearConexion();

                // Se especifica el Stored Procedure que se va a ejecutar
                SqlCommand comando = new SqlCommand("SP_DESACTIVAR_EMPLEADOS", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Se envía el parámetro de búsqueda al Stored Procedure
                comando.Parameters.Add("@nIdEmpleado", SqlDbType.Int).Value = iCodigoEmpleado;


                // Se abre la conexión con la base de datos
                SqlCon.Open();

                // Se ejecuta el SP, se obtienen los datos y se cargan en el DataTable
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "Los datos no fueron registrados";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                // Se cierra la conexión si está abierta
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return respuesta;

        }
    }

}
