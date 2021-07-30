
namespace WinFormsApp
{
    partial class FormVehiculo
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
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.txtDefectos = new System.Windows.Forms.RichTextBox();
            this.lbDefectos = new System.Windows.Forms.Label();
            this.chkTieneDefectos = new System.Windows.Forms.CheckBox();
            this.lbTieneDefectos = new System.Windows.Forms.Label();
            this.dpFechaModelo = new System.Windows.Forms.DateTimePicker();
            this.lbFechaModelo = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.cboMarcaVehiculo = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.chckEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelMarcaVehiculo = new System.Windows.Forms.Label();
            this.txtVehiculoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.VehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaVehiculoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVehiculo)).BeginInit();
            this.SuspendLayout();
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
            this.BtnEliminar.Location = new System.Drawing.Point(258, 672);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(115, 43);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.BtnEditar.Location = new System.Drawing.Point(147, 672);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(94, 43);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
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
            this.BtnNuevo.Location = new System.Drawing.Point(33, 672);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(98, 43);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.txtDefectos);
            this.panelForm.Controls.Add(this.lbDefectos);
            this.panelForm.Controls.Add(this.chkTieneDefectos);
            this.panelForm.Controls.Add(this.lbTieneDefectos);
            this.panelForm.Controls.Add(this.dpFechaModelo);
            this.panelForm.Controls.Add(this.lbFechaModelo);
            this.panelForm.Controls.Add(this.txtColor);
            this.panelForm.Controls.Add(this.txtModelo);
            this.panelForm.Controls.Add(this.txtMatricula);
            this.panelForm.Controls.Add(this.lbModelo);
            this.panelForm.Controls.Add(this.lbColor);
            this.panelForm.Controls.Add(this.lbMatricula);
            this.panelForm.Controls.Add(this.cboMarcaVehiculo);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.chckEstado);
            this.panelForm.Controls.Add(this.labelEstado);
            this.panelForm.Controls.Add(this.labelMarcaVehiculo);
            this.panelForm.Controls.Add(this.txtVehiculoId);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(1041, 11);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(585, 713);
            this.panelForm.TabIndex = 6;
            this.panelForm.Visible = false;
            // 
            // txtDefectos
            // 
            this.txtDefectos.Location = new System.Drawing.Point(168, 436);
            this.txtDefectos.Name = "txtDefectos";
            this.txtDefectos.Size = new System.Drawing.Size(338, 100);
            this.txtDefectos.TabIndex = 19;
            this.txtDefectos.Text = "";
            this.txtDefectos.Visible = false;
       
            // 
            // lbDefectos
            // 
            this.lbDefectos.AutoSize = true;
            this.lbDefectos.Location = new System.Drawing.Point(54, 436);
            this.lbDefectos.Name = "lbDefectos";
            this.lbDefectos.Size = new System.Drawing.Size(68, 20);
            this.lbDefectos.TabIndex = 18;
            this.lbDefectos.Text = "Defectos";
            this.lbDefectos.Visible = false;
            // 
            // chkTieneDefectos
            // 
            this.chkTieneDefectos.AutoSize = true;
            this.chkTieneDefectos.Location = new System.Drawing.Point(168, 393);
            this.chkTieneDefectos.Name = "chkTieneDefectos";
            this.chkTieneDefectos.Size = new System.Drawing.Size(18, 17);
            this.chkTieneDefectos.TabIndex = 17;
            this.chkTieneDefectos.UseVisualStyleBackColor = true;
            this.chkTieneDefectos.CheckedChanged += new System.EventHandler(this.chkTieneDefectos_CheckedChanged);
            // 
            // lbTieneDefectos
            // 
            this.lbTieneDefectos.AutoSize = true;
            this.lbTieneDefectos.Location = new System.Drawing.Point(46, 393);
            this.lbTieneDefectos.Name = "lbTieneDefectos";
            this.lbTieneDefectos.Size = new System.Drawing.Size(115, 20);
            this.lbTieneDefectos.TabIndex = 16;
            this.lbTieneDefectos.Text = "Tiene Defectos?";
            // 
            // dpFechaModelo
            // 
            this.dpFechaModelo.Location = new System.Drawing.Point(163, 335);
            this.dpFechaModelo.Name = "dpFechaModelo";
            this.dpFechaModelo.Size = new System.Drawing.Size(343, 27);
            this.dpFechaModelo.TabIndex = 15;
            // 
            // lbFechaModelo
            // 
            this.lbFechaModelo.AutoSize = true;
            this.lbFechaModelo.Location = new System.Drawing.Point(46, 342);
            this.lbFechaModelo.Name = "lbFechaModelo";
            this.lbFechaModelo.Size = new System.Drawing.Size(110, 20);
            this.lbFechaModelo.TabIndex = 14;
            this.lbFechaModelo.Text = "Fecha Modelo :";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(160, 227);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(346, 27);
            this.txtColor.TabIndex = 13;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(160, 276);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(346, 27);
            this.txtModelo.TabIndex = 12;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(160, 176);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(346, 27);
            this.txtMatricula.TabIndex = 11;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(46, 283);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(68, 20);
            this.lbModelo.TabIndex = 10;
            this.lbModelo.Text = "Modelo :";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(46, 227);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(52, 20);
            this.lbColor.TabIndex = 9;
            this.lbColor.Text = "Color :";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(46, 176);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(78, 20);
            this.lbMatricula.TabIndex = 8;
            this.lbMatricula.Text = "Matricula :";
            // 
            // cboMarcaVehiculo
            // 
            this.cboMarcaVehiculo.FormattingEnabled = true;
            this.cboMarcaVehiculo.Location = new System.Drawing.Point(160, 119);
            this.cboMarcaVehiculo.Name = "cboMarcaVehiculo";
            this.cboMarcaVehiculo.Size = new System.Drawing.Size(346, 28);
            this.cboMarcaVehiculo.TabIndex = 7;
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
            this.BtnGuardar.Location = new System.Drawing.Point(216, 630);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(133, 45);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // chckEstado
            // 
            this.chckEstado.AutoSize = true;
            this.chckEstado.Checked = true;
            this.chckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckEstado.Location = new System.Drawing.Point(168, 554);
            this.chckEstado.Name = "chckEstado";
            this.chckEstado.Size = new System.Drawing.Size(18, 17);
            this.chckEstado.TabIndex = 5;
            this.chckEstado.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(46, 551);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(57, 20);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Estado:";
            // 
            // labelMarcaVehiculo
            // 
            this.labelMarcaVehiculo.AutoSize = true;
            this.labelMarcaVehiculo.Location = new System.Drawing.Point(40, 127);
            this.labelMarcaVehiculo.Name = "labelMarcaVehiculo";
            this.labelMarcaVehiculo.Size = new System.Drawing.Size(53, 20);
            this.labelMarcaVehiculo.TabIndex = 2;
            this.labelMarcaVehiculo.Text = "Marca:";
            // 
            // txtVehiculoId
            // 
            this.txtVehiculoId.Location = new System.Drawing.Point(233, 43);
            this.txtVehiculoId.Name = "txtVehiculoId";
            this.txtVehiculoId.Size = new System.Drawing.Size(125, 27);
            this.txtVehiculoId.TabIndex = 1;
            this.txtVehiculoId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario";
            // 
            // GridViewVehiculo
            // 
            this.GridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehiculoId,
            this.MarcaVehiculoDescripcion,
            this.Matricula,
            this.Color,
            this.Modelo,
            this.FechaModelo,
            this.Defectos,
            this.Estado});
            this.GridViewVehiculo.Location = new System.Drawing.Point(2, 1);
            this.GridViewVehiculo.Name = "GridViewVehiculo";
            this.GridViewVehiculo.ReadOnly = true;
            this.GridViewVehiculo.RowHeadersWidth = 51;
            this.GridViewVehiculo.RowTemplate.Height = 29;
            this.GridViewVehiculo.Size = new System.Drawing.Size(1033, 643);
            this.GridViewVehiculo.TabIndex = 5;
            // 
            // VehiculoId
            // 
            this.VehiculoId.DataPropertyName = "VehiculoId";
            this.VehiculoId.HeaderText = "Id";
            this.VehiculoId.MinimumWidth = 6;
            this.VehiculoId.Name = "VehiculoId";
            this.VehiculoId.ReadOnly = true;
            this.VehiculoId.Width = 125;
            // 
            // MarcaVehiculoDescripcion
            // 
            this.MarcaVehiculoDescripcion.DataPropertyName = "MarcaVehiculoDescripcionColum";
            this.MarcaVehiculoDescripcion.HeaderText = "Marca";
            this.MarcaVehiculoDescripcion.MinimumWidth = 6;
            this.MarcaVehiculoDescripcion.Name = "MarcaVehiculoDescripcion";
            this.MarcaVehiculoDescripcion.ReadOnly = true;
            this.MarcaVehiculoDescripcion.Width = 125;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // FechaModelo
            // 
            this.FechaModelo.DataPropertyName = "FechaModelo";
            this.FechaModelo.HeaderText = "Fecha Modelo";
            this.FechaModelo.MinimumWidth = 6;
            this.FechaModelo.Name = "FechaModelo";
            this.FechaModelo.ReadOnly = true;
            this.FechaModelo.Width = 125;
            // 
            // Defectos
            // 
            this.Defectos.DataPropertyName = "Defectos";
            this.Defectos.HeaderText = "Defectos";
            this.Defectos.MinimumWidth = 6;
            this.Defectos.Name = "Defectos";
            this.Defectos.ReadOnly = true;
            this.Defectos.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 736);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.GridViewVehiculo);
            this.Name = "FormVehiculo";
            this.Text = "Vehiculo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.RichTextBox txtDefectos;
        private System.Windows.Forms.Label lbDefectos;
        private System.Windows.Forms.CheckBox chkTieneDefectos;
        private System.Windows.Forms.Label lbTieneDefectos;
        private System.Windows.Forms.DateTimePicker dpFechaModelo;
        private System.Windows.Forms.Label lbFechaModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.ComboBox cboMarcaVehiculo;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private System.Windows.Forms.CheckBox chckEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelMarcaVehiculo;
        private System.Windows.Forms.TextBox txtVehiculoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaVehiculoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Defectos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}