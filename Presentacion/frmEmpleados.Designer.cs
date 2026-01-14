namespace GestionEmpleados.Presentacion
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Departamento = new System.Windows.Forms.Label();
            this.Fecha_de_Nacimiento = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1064, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 635);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(35, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(35, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(35, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 53);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Location = new System.Drawing.Point(35, 167);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 53);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(116, 148);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(78, 36);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(116, 184);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(89, 36);
            this.Direccion.TabIndex = 3;
            this.Direccion.Text = "Direccion";
            this.Direccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(116, 220);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(82, 36);
            this.Telefono.TabIndex = 4;
            this.Telefono.Text = "Telefono";
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento.Location = new System.Drawing.Point(116, 256);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(124, 36);
            this.Departamento.TabIndex = 5;
            this.Departamento.Text = "Departamento";
            // 
            // Fecha_de_Nacimiento
            // 
            this.Fecha_de_Nacimiento.AutoSize = true;
            this.Fecha_de_Nacimiento.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_de_Nacimiento.Location = new System.Drawing.Point(575, 148);
            this.Fecha_de_Nacimiento.Name = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.Size = new System.Drawing.Size(173, 36);
            this.Fecha_de_Nacimiento.TabIndex = 6;
            this.Fecha_de_Nacimiento.Text = "Fecha de Nacimiento";
            this.Fecha_de_Nacimiento.Click += new System.EventHandler(this.Fecha_de_Nacimiento_Click);
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(589, 224);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(66, 36);
            this.Salario.TabIndex = 7;
            this.Salario.Text = "Salario";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.Location = new System.Drawing.Point(589, 260);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(61, 36);
            this.Cargo.TabIndex = 8;
            this.Cargo.Text = "Cargo";
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(116, 356);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(66, 36);
            this.Buscar.TabIndex = 9;
            this.Buscar.Text = "Buscar";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Enabled = false;
            this.dateTimeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNacimiento.Location = new System.Drawing.Point(754, 152);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(200, 25);
            this.dateTimeNacimiento.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(269, 188);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(685, 25);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(269, 224);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(284, 25);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(670, 224);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(284, 25);
            this.txtSalario.TabIndex = 14;
            this.txtSalario.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Location = new System.Drawing.Point(269, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 25);
            this.txtNombre.TabIndex = 15;
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentos.Enabled = false;
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(269, 260);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(284, 31);
            this.cmbDepartamentos.TabIndex = 16;
            // 
            // cmbCargos
            // 
            this.cmbCargos.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargos.Enabled = false;
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(670, 260);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(284, 31);
            this.cmbCargos.TabIndex = 17;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(269, 367);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(622, 25);
            this.TxtBuscar.TabIndex = 18;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToOrderColumns = true;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(122, 423);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(832, 190);
            this.dgvLista.TabIndex = 19;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(122, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 53);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnBuscar.CausesValidation = false;
            this.btnBuscar.Location = new System.Drawing.Point(897, 367);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 25);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnCanceled.Location = new System.Drawing.Point(384, 297);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(226, 53);
            this.btnCanceled.TabIndex = 20;
            this.btnCanceled.Text = "Cancelar";
            this.btnCanceled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanceled.UseVisualStyleBackColor = false;
            this.btnCanceled.Visible = false;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(102, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(102, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(572, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 34);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(102, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(574, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 635);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCanceled);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.cmbCargos);
            this.Controls.Add(this.cmbDepartamentos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Fecha_de_Nacimiento);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.Label Fecha_de_Nacimiento;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}