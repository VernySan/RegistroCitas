
namespace WinFormsApp
{
    partial class FormHorario
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
            this.GridViewHorario = new System.Windows.Forms.DataGridView();
            this.IdHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.chckEstado = new System.Windows.Forms.CheckBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.labelFin = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.labelInicio = new System.Windows.Forms.Label();
            this.txtIdHorario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHorario)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewHorario
            // 
            this.GridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHorario,
            this.Inicio,
            this.Fin,
            this.Estado});
            this.GridViewHorario.Location = new System.Drawing.Point(1, 1);
            this.GridViewHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewHorario.Name = "GridViewHorario";
            this.GridViewHorario.ReadOnly = true;
            this.GridViewHorario.RowHeadersWidth = 51;
            this.GridViewHorario.RowTemplate.Height = 29;
            this.GridViewHorario.Size = new System.Drawing.Size(444, 341);
            this.GridViewHorario.TabIndex = 0;
            // 
            // IdHorario
            // 
            this.IdHorario.DataPropertyName = "IdHorario";
            this.IdHorario.HeaderText = "Id";
            this.IdHorario.MinimumWidth = 6;
            this.IdHorario.Name = "IdHorario";
            this.IdHorario.ReadOnly = true;
            this.IdHorario.Width = 125;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "Inicio";
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.MinimumWidth = 6;
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 125;
            // 
            // Fin
            // 
            this.Fin.DataPropertyName = "Fin";
            this.Fin.HeaderText = "Fin";
            this.Fin.MinimumWidth = 8;
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            this.Fin.Width = 150;
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
            this.panelForm.Controls.Add(this.chckEstado);
            this.panelForm.Controls.Add(this.txtFin);
            this.panelForm.Controls.Add(this.labelEstado);
            this.panelForm.Controls.Add(this.txtInicio);
            this.panelForm.Controls.Add(this.labelFin);
            this.panelForm.Controls.Add(this.BtnGuardar);
            this.panelForm.Controls.Add(this.labelInicio);
            this.panelForm.Controls.Add(this.txtIdHorario);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(477, 9);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(456, 333);
            this.panelForm.TabIndex = 1;
            this.panelForm.Visible = false;
            // 
            // chckEstado
            // 
            this.chckEstado.AutoSize = true;
            this.chckEstado.Checked = true;
            this.chckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckEstado.Location = new System.Drawing.Point(160, 163);
            this.chckEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckEstado.Name = "chckEstado";
            this.chckEstado.Size = new System.Drawing.Size(15, 14);
            this.chckEstado.TabIndex = 7;
            this.chckEstado.UseVisualStyleBackColor = true;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(99, 127);
            this.txtFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(106, 23);
            this.txtFin.TabIndex = 10;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(35, 160);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(45, 15);
            this.labelEstado.TabIndex = 6;
            this.labelEstado.Text = "Estado:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(99, 95);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(106, 23);
            this.txtInicio.TabIndex = 9;
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(35, 128);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(35, 15);
            this.labelFin.TabIndex = 8;
            this.labelFin.Text = "Final:";
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
            this.BtnGuardar.Location = new System.Drawing.Point(183, 204);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 34);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(35, 95);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(39, 15);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = "Inicio:";
            // 
            // txtIdHorario
            // 
            this.txtIdHorario.Location = new System.Drawing.Point(204, 32);
            this.txtIdHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdHorario.Name = "txtIdHorario";
            this.txtIdHorario.Size = new System.Drawing.Size(110, 23);
            this.txtIdHorario.TabIndex = 1;
            this.txtIdHorario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horarios";
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
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 430);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.GridViewHorario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHorario";
            this.Text = "Horario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHorario)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewHorario;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.CheckBox chckEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}