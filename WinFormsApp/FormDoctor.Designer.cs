
namespace WinFormsApp
{
    partial class FormDoctor
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
            this.GridViewDoctor = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.chckGuardar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.nTelefono = new System.Windows.Forms.NumericUpDown();
            this.chckEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctor)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewDoctor
            // 
            this.GridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.IdEspecialidad,
            this.Especialidad,
            this.Telefono,
            this.Direccion,
            this.Estado});
            this.GridViewDoctor.Location = new System.Drawing.Point(39, 15);
            this.GridViewDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewDoctor.Name = "GridViewDoctor";
            this.GridViewDoctor.ReadOnly = true;
            this.GridViewDoctor.RowHeadersWidth = 51;
            this.GridViewDoctor.RowTemplate.Height = 29;
            this.GridViewDoctor.Size = new System.Drawing.Size(634, 568);
            this.GridViewDoctor.TabIndex = 0;
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
            // IdEspecialidad
            // 
            this.IdEspecialidad.DataPropertyName = "IdEspecialidad";
            this.IdEspecialidad.HeaderText = "IdEspecialidad";
            this.IdEspecialidad.MinimumWidth = 8;
            this.IdEspecialidad.Name = "IdEspecialidad";
            this.IdEspecialidad.ReadOnly = true;
            this.IdEspecialidad.Visible = false;
            this.IdEspecialidad.Width = 150;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 8;
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 150;
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
            this.panelForm.Controls.Add(this.chckGuardar);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.cboEspecialidad);
            this.panelForm.Controls.Add(this.nTelefono);
            this.panelForm.Controls.Add(this.chckEstado);
            this.panelForm.Controls.Add(this.labelEstado);
            this.panelForm.Controls.Add(this.txtDireccion);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.txtSegundoApellido);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtPrimerApellido);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.txtNombre);
            this.panelForm.Controls.Add(this.labelDescripcion);
            this.panelForm.Controls.Add(this.txtCedula);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(681, 15);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(651, 555);
            this.panelForm.TabIndex = 1;
            this.panelForm.Visible = false;
            // 
            // chckGuardar
            // 
            this.chckGuardar.AutoSize = true;
            this.chckGuardar.Location = new System.Drawing.Point(478, 98);
            this.chckGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.chckGuardar.Name = "chckGuardar";
            this.chckGuardar.Size = new System.Drawing.Size(22, 21);
            this.chckGuardar.TabIndex = 19;
            this.chckGuardar.UseVisualStyleBackColor = true;
            this.chckGuardar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cédula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(228, 274);
            this.cboEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(376, 33);
            this.cboEspecialidad.TabIndex = 5;
            // 
            // nTelefono
            // 
            this.nTelefono.Location = new System.Drawing.Point(228, 314);
            this.nTelefono.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nTelefono.Name = "nTelefono";
            this.nTelefono.Size = new System.Drawing.Size(180, 31);
            this.nTelefono.TabIndex = 6;
            this.nTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chckEstado
            // 
            this.chckEstado.AutoSize = true;
            this.chckEstado.Checked = true;
            this.chckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckEstado.Location = new System.Drawing.Point(228, 411);
            this.chckEstado.Margin = new System.Windows.Forms.Padding(4);
            this.chckEstado.Name = "chckEstado";
            this.chckEstado.Size = new System.Drawing.Size(22, 21);
            this.chckEstado.TabIndex = 8;
            this.chckEstado.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(50, 407);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(70, 25);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "Estado:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(228, 353);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(376, 31);
            this.txtDireccion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Especialidad:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(228, 228);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(376, 31);
            this.txtSegundoApellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Segundo Apellido:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(228, 189);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(376, 31);
            this.txtPrimerApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
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
            this.BtnGuardar.Location = new System.Drawing.Point(454, 470);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(166, 56);
            this.BtnGuardar.TabIndex = 9;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 150);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(50, 159);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 25);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Nombre:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(228, 98);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(155, 31);
            this.txtCedula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctores";
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
            this.BtnNuevo.Location = new System.Drawing.Point(49, 618);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(122, 54);
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
            this.BtnEditar.Location = new System.Drawing.Point(191, 618);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(118, 54);
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
            this.BtnEliminar.Location = new System.Drawing.Point(330, 618);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(144, 54);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 716);
            this.Controls.Add(this.GridViewDoctor);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoctor";
            this.Text = "Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDoctor)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTelefono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDoctor;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
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
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chckGuardar;
    }
}