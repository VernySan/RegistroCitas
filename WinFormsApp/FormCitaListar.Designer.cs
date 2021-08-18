
namespace WinFormsApp
{
    partial class FormCitaListar
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
            this.GridViewCita = new System.Windows.Forms.DataGridView();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForm = new System.Windows.Forms.Panel();
            this.FechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtProcedimiento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCita)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewCita
            // 
            this.GridViewCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCita,
            this.IdHorario,
            this.xFecha,
            this.Inicio});
            this.GridViewCita.Location = new System.Drawing.Point(1, 1);
            this.GridViewCita.Name = "GridViewCita";
            this.GridViewCita.ReadOnly = true;
            this.GridViewCita.RowHeadersWidth = 51;
            this.GridViewCita.RowTemplate.Height = 29;
            this.GridViewCita.Size = new System.Drawing.Size(357, 501);
            this.GridViewCita.TabIndex = 0;
            this.GridViewCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCita_CellClick);
            // 
            // IdCita
            // 
            this.IdCita.DataPropertyName = "IdCita";
            this.IdCita.HeaderText = "Id";
            this.IdCita.MinimumWidth = 6;
            this.IdCita.Name = "IdCita";
            this.IdCita.ReadOnly = true;
            this.IdCita.Visible = false;
            this.IdCita.Width = 125;
            // 
            // IdHorario
            // 
            this.IdHorario.DataPropertyName = "IdHorario";
            this.IdHorario.HeaderText = "IdHorario";
            this.IdHorario.MinimumWidth = 6;
            this.IdHorario.Name = "IdHorario";
            this.IdHorario.ReadOnly = true;
            this.IdHorario.Visible = false;
            this.IdHorario.Width = 125;
            // 
            // xFecha
            // 
            this.xFecha.DataPropertyName = "Fecha";
            this.xFecha.HeaderText = "Fecha";
            this.xFecha.MinimumWidth = 8;
            this.xFecha.Name = "xFecha";
            this.xFecha.ReadOnly = true;
            this.xFecha.Width = 150;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "Inicio";
            this.Inicio.HeaderText = "Hora";
            this.Inicio.MinimumWidth = 8;
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            this.Inicio.Width = 150;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.FechaFiltro);
            this.panelForm.Controls.Add(this.label11);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.label9);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.txtConsulta);
            this.panelForm.Controls.Add(this.txtPrecio);
            this.panelForm.Controls.Add(this.txtHora);
            this.panelForm.Controls.Add(this.txtProcedimiento);
            this.panelForm.Controls.Add(this.txtTelefono);
            this.panelForm.Controls.Add(this.txtCedula);
            this.panelForm.Controls.Add(this.txtPaciente);
            this.panelForm.Controls.Add(this.txtEspecialidad);
            this.panelForm.Controls.Add(this.txtDoctor);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.txtIdCita);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Location = new System.Drawing.Point(364, 1);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(737, 501);
            this.panelForm.TabIndex = 1;
            // 
            // FechaFiltro
            // 
            this.FechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFiltro.Location = new System.Drawing.Point(28, 134);
            this.FechaFiltro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FechaFiltro.Name = "FechaFiltro";
            this.FechaFiltro.Size = new System.Drawing.Size(121, 27);
            this.FechaFiltro.TabIndex = 1;
            this.FechaFiltro.ValueChanged += new System.EventHandler(this.FechaFiltro_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Hora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Procedimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Consulta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Especialidad:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.Color.White;
            this.txtConsulta.Location = new System.Drawing.Point(28, 382);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ReadOnly = true;
            this.txtConsulta.Size = new System.Drawing.Size(284, 27);
            this.txtConsulta.TabIndex = 23;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(179, 452);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(133, 27);
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(28, 452);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(98, 27);
            this.txtHora.TabIndex = 21;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.BackColor = System.Drawing.Color.White;
            this.txtProcedimiento.Location = new System.Drawing.Point(339, 382);
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.ReadOnly = true;
            this.txtProcedimiento.Size = new System.Drawing.Size(225, 27);
            this.txtProcedimiento.TabIndex = 19;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(470, 307);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(94, 27);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(339, 307);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(109, 27);
            this.txtCedula.TabIndex = 17;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaciente
            // 
            this.txtPaciente.BackColor = System.Drawing.Color.White;
            this.txtPaciente.Location = new System.Drawing.Point(28, 307);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(284, 27);
            this.txtPaciente.TabIndex = 16;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BackColor = System.Drawing.Color.White;
            this.txtEspecialidad.Location = new System.Drawing.Point(339, 241);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(225, 27);
            this.txtEspecialidad.TabIndex = 15;
            // 
            // txtDoctor
            // 
            this.txtDoctor.BackColor = System.Drawing.Color.White;
            this.txtDoctor.Location = new System.Drawing.Point(28, 241);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(284, 27);
            this.txtDoctor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doctor:";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(146, 49);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(125, 27);
            this.txtIdCita.TabIndex = 1;
            this.txtIdCita.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar Citas";
            // 
            // FormCitaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 573);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.GridViewCita);
            this.Name = "FormCitaListar";
            this.Text = "Listar Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCitaListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCita)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewCita;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtProcedimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}