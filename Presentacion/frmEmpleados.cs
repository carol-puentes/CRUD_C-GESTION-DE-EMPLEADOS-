using GestionEmpleados.Datos;
using GestionEmpleados.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados.Presentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        #region "Variables"
        int iCodigoEmpleado = 0;
        bool bEstadoGuardar = true;
        #endregion

        #region "Metodos"
        private void CargarEmpleados(string cBusqueda)
        {
            D_Empleados Datos = new D_Empleados();
            dgvLista.DataSource = Datos.Listar_Empleados(cBusqueda);
            FormatoListaEmpleados();
        }

        private void FormatoListaEmpleados()
        {
            dgvLista.Columns[0].Width = 45;
            dgvLista.Columns[1].Width = 160;
            dgvLista.Columns[2].Width = 160;
            dgvLista.Columns[5].Width = 250;
            dgvLista.Columns[7].Width = 160;

        }

        private void CargarDepartamentos()
        {
            D_Depatamento Datos = new D_Depatamento();
            cmbDepartamentos.DataSource = Datos.Listar_Departamentos();
            cmbDepartamentos.ValueMember = "id_departamento";
            cmbDepartamentos.DisplayMember = "nombre_departamente";
            cmbDepartamentos.SelectedIndex = -1;
        }

        private void CargarCargos()
        {
            D_Cargo Datos = new D_Cargo();
            cmbCargos.DataSource = Datos.Listar_Cargos();
            cmbCargos.ValueMember = "id_cargo";
            cmbCargos.DisplayMember = "nombre_cargo";
            cmbCargos.SelectedIndex = -1;
        }

        private void ActivarTextos(bool bEstado)
        {
            txtNombre.Enabled = bEstado;
            txtDireccion.Enabled = bEstado;
            txtTelefono.Enabled = bEstado;
            txtSalario.Enabled = bEstado;
            cmbDepartamentos.Enabled = bEstado;
            cmbCargos.Enabled = bEstado;
            dateTimeNacimiento.Enabled = bEstado;
            TxtBuscar.Enabled = !bEstado;
        }

        private void ActivarBotones (bool bEstado)
        {
            btnNew.Enabled = bEstado; 
            btnUpdate.Enabled = bEstado;
            btnDelete.Enabled = bEstado;
       
            btnSave.Visible = !bEstado;
            btnCanceled.Visible = !bEstado;
        }

        private void SeleccionarEmpleado()
        {
            iCodigoEmpleado =Convert.ToInt32( dgvLista.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Nombre"].Value);
            txtDireccion.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Direccion"].Value);
            txtTelefono.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Telefono"].Value);
            txtSalario.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Salario"].Value);
            cmbDepartamentos.Text=Convert.ToString(dgvLista.CurrentRow.Cells["Departamento"].Value);
            cmbCargos.Text = Convert.ToString(dgvLista.CurrentRow.Cells["Cargo"].Value);
            dateTimeNacimiento.Value=Convert.ToDateTime(dgvLista.CurrentRow.Cells["Fecha Nacimiento"].Value);
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtSalario.Clear(); 
            TxtBuscar.Clear();
            cmbDepartamentos.SelectedIndex = -1;
            cmbCargos.SelectedIndex = -1;  
            dateTimeNacimiento.Value=DateTime.Now;
            iCodigoEmpleado = 0;
        }

        private void GuardarEmpleados()
        {
            E_Empleado Empleado = new E_Empleado();
            Empleado.nombre_empleado=txtNombre.Text;
            Empleado.direccion_empleado = txtDireccion.Text;
            Empleado.telefono_empleado=txtTelefono.Text;
            Empleado.salario_empleado=Convert.ToDecimal(txtSalario.Text);
            Empleado.fecha_nacimiento_empleado = dateTimeNacimiento.Value;
            Empleado.id_departamento =Convert.ToInt32(cmbDepartamentos.SelectedValue);
            Empleado.id_cargo =Convert.ToInt32(cmbCargos.SelectedValue);

            D_Empleados Datos= new D_Empleados();
            string respuesta =Datos.Guardar_Empleado(Empleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);
                MessageBox.Show("Datos Guardados Correctamente", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarEmpleados()
        {
            E_Empleado Empleado = new E_Empleado();
            Empleado.id_empleado = iCodigoEmpleado;
            Empleado.nombre_empleado = txtNombre.Text;
            Empleado.direccion_empleado = txtDireccion.Text;
            Empleado.telefono_empleado = txtTelefono.Text;
            Empleado.salario_empleado = Convert.ToDecimal(txtSalario.Text);
            Empleado.fecha_nacimiento_empleado = dateTimeNacimiento.Value;
            Empleado.id_departamento = Convert.ToInt32(cmbDepartamentos.SelectedValue);
            Empleado.id_cargo = Convert.ToInt32(cmbCargos.SelectedValue);

            D_Empleados Datos = new D_Empleados();
            string respuesta = Datos.Actualizar_Empleado(Empleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);
                MessageBox.Show("Datos Actualizados Correctamente", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DesactivarEmpleados(int iCodigoEmpleado)
        {

            D_Empleados Datos = new D_Empleados();
            string respuesta = Datos.Desactivar_Empleado(iCodigoEmpleado);

            if (respuesta == "OK")
            {
                CargarEmpleados("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);
                MessageBox.Show(" Registro Eliminado Correctamente", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta, "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validarTexto()
        {
            bool hayTextosVacios=false;
            if (string.IsNullOrEmpty(txtNombre.Text)) { 
                hayTextosVacios = true;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                hayTextosVacios = true;
            }
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                hayTextosVacios = true;
            }
            return hayTextosVacios;
        } 

        #endregion



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
            CargarCargos(); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(TxtBuscar.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;
            iCodigoEmpleado = 0;
            ActivarTextos(true);
            ActivarBotones(false);
            txtNombre.Select();
            Limpiar();
        }
        private void btnCanceled_Click(object sender, EventArgs e)
        {
            bEstadoGuardar=true;
            iCodigoEmpleado=0;
            ActivarTextos(false);
            ActivarBotones(true);
            Limpiar();
        }
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarEmpleado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_de_Nacimiento_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (iCodigoEmpleado == 0)
            {
                MessageBox.Show("Seleciona un registro", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                bEstadoGuardar=false;
                ActivarTextos(true);
                ActivarBotones(false);
                txtNombre.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validarTexto())
            {
                MessageBox.Show("Hay campos vacios, debes llenar todos los campos (*) obligatorios", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bEstadoGuardar)
                {
                    GuardarEmpleados();
                }
                else {
                    ActualizarEmpleados();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (iCodigoEmpleado == 0)
            {
                MessageBox.Show("Seleciona un registro", "Sistema de Gestiòn de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Sistema de Gestiòn de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes) {
                    DesactivarEmpleados(iCodigoEmpleado);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
