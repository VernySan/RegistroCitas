
namespace WinFormsApp
{
    partial class FormPaciente
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
            this.GridViewPaciente = new System.Windows.Forms.DataGridView();
            this.Pasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.nPasaporte = new System.Windows.Forms.NumericUpDown();
            this.nCedula = new System.Windows.Forms.NumericUpDown();
            this.txtEnfermedades = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chckGuardar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.nTelefono = new System.Windows.Forms.NumericUpDown();
            this.chckEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaciente)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPasaporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewPaciente
            // 
            this.GridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pasaporte,
            this.Cedula,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdNacionalidad,
            this.Nacionalidad,
            this.FechaNacimiento,
            this.Edad,
            this.Telefono,
            this.Enfermedades,
            this.Alergias,
            this.Direccion,
            this.Estado});
            this.GridViewPaciente.Location = new System.Drawing.Point(27, 9);
            this.GridViewPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewPaciente.Name = "GridViewPaciente";
            this.GridViewPaciente.ReadOnly = true;
            this.GridViewPaciente.RowHeadersWidth = 51;
            this.GridViewPaciente.RowTemplate.Height = 29;
            this.GridViewPaciente.Size = new System.Drawing.Size(444, 341);
            this.GridViewPaciente.TabIndex = 0;
            // 
            // Pasaporte
            // 
            this.Pasaporte.DataPropertyName = "Pasaporte";
            this.Pasaporte.HeaderText = "Pasaporte";
            this.Pasaporte.MinimumWidth = 8;
            this.Pasaporte.Name = "Pasaporte";
            this.Pasaporte.ReadOnly = true;
            this.Pasaporte.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.MinimumWidth = 8;
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 150;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.MinimumWidth = 8;
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 150;
            // 
            // IdNacionalidad
            // 
            this.IdNacionalidad.DataPropertyName = "IdNacionalidad";
            this.IdNacionalidad.HeaderText = "IdNacionalidad";
            this.IdNacionalidad.MinimumWidth = 8;
            this.IdNacionalidad.Name = "IdNacionalidad";
            this.IdNacionalidad.ReadOnly = true;
            this.IdNacionalidad.Visible = false;
            this.IdNacionalidad.Width = 150;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.DataPropertyName = "Nacionalidad";
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.MinimumWidth = 8;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Width = 150;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.MinimumWidth = 8;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 150;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 8;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // Enfermedades
            // 
            this.Enfermedades.DataPropertyName = "Enfermedades";
            this.Enfermedades.HeaderText = "Enfermedades";
            this.Enfermedades.MinimumWidth = 8;
            this.Enfermedades.Name = "Enfermedades";
            this.Enfermedades.ReadOnly = true;
            this.Enfermedades.Width = 150;
            // 
            // Alergias
            // 
            this.Alergias.DataPropertyName = "Alergias";
            this.Alergias.HeaderText = "Alergias";
            this.Alergias.MinimumWidth = 8;
            this.Alergias.Name = "Alergias";
            this.Alergias.ReadOnly = true;
            this.Alergias.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.nPasaporte);
            this.panelForm.Controls.Add(this.nCedula);
            this.panelForm.Controls.Add(this.txtEnfermedades);
            this.panelForm.Controls.Add(this.label11);
            this.panelForm.Controls.Add(this.txtAlergias);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.dFechaNacimiento);
            this.panelForm.Controls.Add(this.txtDireccion);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label9);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.chckGuardar);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.cboNacionalidad);
            this.panelForm.Controls.Add(this.nTelefono);
            this.panelForm.Controls.Add(this.chckEstado);
            this.panelForm.Controls.Add(this.labelEstado);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.txtSegundoApellido);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtPrimerApellido);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.txtNombre);
            this.panelForm.Controls.Add(this.labelDescripcion);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(477, 9);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(456, 394);
            this.panelForm.TabIndex = 1;
            this.panelForm.Visible = false;
            // 
            // nPasaporte
            // 
            this.nPasaporte.Location = new System.Drawing.Point(162, 28);
            this.nPasaporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nPasaporte.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nPasaporte.Name = "nPasaporte";
            this.nPasaporte.Size = new System.Drawing.Size(126, 23);
            this.nPasaporte.TabIndex = 1;
            this.nPasaporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nCedula
            // 
            this.nCedula.Location = new System.Drawing.Point(162, 53);
            this.nCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nCedula.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nCedula.Name = "nCedula";
            this.nCedula.Size = new System.Drawing.Size(126, 23);
            this.nCedula.TabIndex = 2;
            this.nCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEnfermedades
            // 
            this.txtEnfermedades.Location = new System.Drawing.Point(162, 253);
            this.txtEnfermedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnfermedades.Name = "txtEnfermedades";
            this.txtEnfermedades.Size = new System.Drawing.Size(264, 23);
            this.txtEnfermedades.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Enfermedades:";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(162, 229);
            this.txtAlergias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(264, 23);
            this.txtAlergias.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Alergias:";
            // 
            // dFechaNacimiento
            // 
            this.dFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dFechaNacimiento.Location = new System.Drawing.Point(162, 182);
            this.dFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dFechaNacimiento.Name = "dFechaNacimiento";
            this.dFechaNacimiento.Size = new System.Drawing.Size(211, 23);
            this.dFechaNacimiento.TabIndex = 7;
            this.dFechaNacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(162, 276);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 23);
            this.txtDireccion.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cédula:";
            // 
            // chckGuardar
            // 
            this.chckGuardar.AutoSize = true;
            this.chckGuardar.Location = new System.Drawing.Point(390, 28);
            this.chckGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckGuardar.Name = "chckGuardar";
            this.chckGuardar.Size = new System.Drawing.Size(15, 14);
            this.chckGuardar.TabIndex = 19;
            this.chckGuardar.UseVisualStyleBackColor = true;
            this.chckGuardar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pasaporte:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono:";
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(162, 152);
            this.cboNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(264, 23);
            this.cboNacionalidad.TabIndex = 6;
            // 
            // nTelefono
            // 
            this.nTelefono.Location = new System.Drawing.Point(162, 205);
            this.nTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nTelefono.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nTelefono.Name = "nTelefono";
            this.nTelefono.Size = new System.Drawing.Size(126, 23);
            this.nTelefono.TabIndex = 8;
            this.nTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chckEstado
            // 
            this.chckEstado.AutoSize = true;
            this.chckEstado.Checked = true;
            this.chckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckEstado.Location = new System.Drawing.Point(162, 309);
            this.chckEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckEstado.Name = "chckEstado";
            this.chckEstado.Size = new System.Drawing.Size(15, 14);
            this.chckEstado.TabIndex = 12;
            this.chckEstado.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(38, 307);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(45, 15);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nacionalidad:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(162, 125);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(264, 23);
            this.txtSegundoApellido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundo Apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(162, 101);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(264, 23);
            this.txtPrimerApellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Primer Apellido:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 32;
            this.BtnGuardar.Location = new System.Drawing.Point(213, 343);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 34);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(38, 83);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(54, 15);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 32;
            this.BtnNuevo.Location = new System.Drawing.Point(34, 371);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(85, 32);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 32;
            this.BtnEditar.Location = new System.Drawing.Point(134, 371);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(83, 32);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 32;
            this.BtnEliminar.Location = new System.Drawing.Point(231, 371);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 32);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 430);
            this.Controls.Add(this.GridViewPaciente);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPaciente";
            this.Text = "Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPaciente)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPasaporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTelefono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewPaciente;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.NumericUpDown nTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chckGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dFechaNacimiento;
        private System.Windows.Forms.TextBox txtEnfermedades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nCedula;
        private System.Windows.Forms.NumericUpDown nPasaporte;
    }
}