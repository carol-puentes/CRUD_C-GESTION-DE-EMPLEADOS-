using System;
using System.Data.SqlClient;

namespace GestionEmpleados.Datos
{
    public class Conexion
    {
        private readonly string Base;
        private readonly string Servidor;
        private static Conexion Con = null;

        private Conexion()
        {
            Servidor = "ITS011"; // Si SSMS usa ITS011\SQLEXPRESS, ponlo igual
            Base = "bd_gestion_empleados_prueba";
        }

        public SqlConnection CrearConexion()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = Servidor,
                InitialCatalog = Base,
                IntegratedSecurity = true, // <<< clave del cambio
                Encrypt = true,
                TrustServerCertificate = true,
                ApplicationName = "GestionEmpleados",
                ConnectTimeout = 15
            };

            return new SqlConnection(builder.ConnectionString);
        }

        public static Conexion crearInstancia()
        {
            if (Con == null) Con = new Conexion();
            return Con;
        }
    }
}
