using GestionEmpleados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados.Presentacion
{
    public partial class frmConectar : Form
    {
        public frmConectar()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection sqlCon = new SqlConnection();
        //    sqlCon = Conexion.crearInstancia().CrearConexion();

        //    try
        //    {
        //        sqlCon.Open();
        //        MessageBox.Show("Conexion exitosa");
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show("Conexion  fallida");
        //        MessageBox.Show(ex.Message);
        //    }

        //}


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = Conexion.crearInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();
                    MessageBox.Show("Conexión exitosa");
                }
                catch (SqlException sqlex)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Conexión fallida (SqlException):");
                    foreach (SqlError err in sqlex.Errors)
                    {
                        sb.AppendLine($"- Número: {err.Number} | Clase: {err.Class} | Estado: {err.State}");
                        sb.AppendLine($"  Mensaje: {err.Message}");
                        sb.AppendLine($"  Servidor: {err.Server} | Línea: {err.LineNumber} | Procedimiento: {err.Procedure}");
                    }
                    MessageBox.Show(sb.ToString(), "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Conexión fallida (Exception): " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
