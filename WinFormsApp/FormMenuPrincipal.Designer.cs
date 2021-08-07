
namespace WinFormsApp
{
    partial class FormMenuPrincipal
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
            this.panelMenuIzquierda = new System.Windows.Forms.Panel();
            this.bNacionalidades = new FontAwesome.Sharp.IconButton();
            this.bHorario = new FontAwesome.Sharp.IconButton();
            this.bEspecialidades = new FontAwesome.Sharp.IconButton();
            this.bServicios = new FontAwesome.Sharp.IconButton();
            this.bDoctores = new FontAwesome.Sharp.IconButton();
            this.bPacientes = new FontAwesome.Sharp.IconButton();
            this.bCitas = new FontAwesome.Sharp.IconButton();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenuTop = new System.Windows.Forms.Panel();
            this.MenuLabelPrincipal = new System.Windows.Forms.Label();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelMenuIzquierda.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuIzquierda
            // 
            this.panelMenuIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuIzquierda.Controls.Add(this.bNacionalidades);
            this.panelMenuIzquierda.Controls.Add(this.bHorario);
            this.panelMenuIzquierda.Controls.Add(this.bEspecialidades);
            this.panelMenuIzquierda.Controls.Add(this.bServicios);
            this.panelMenuIzquierda.Controls.Add(this.bDoctores);
            this.panelMenuIzquierda.Controls.Add(this.bPacientes);
            this.panelMenuIzquierda.Controls.Add(this.bCitas);
            this.panelMenuIzquierda.Controls.Add(this.panelMenuLogo);
            this.panelMenuIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzquierda.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuIzquierda.Name = "panelMenuIzquierda";
            this.panelMenuIzquierda.Size = new System.Drawing.Size(192, 575);
            this.panelMenuIzquierda.TabIndex = 0;
            // 
            // bNacionalidades
            // 
            this.bNacionalidades.FlatAppearance.BorderSize = 0;
            this.bNacionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNacionalidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bNacionalidades.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bNacionalidades.IconColor = System.Drawing.Color.LightBlue;
            this.bNacionalidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bNacionalidades.Location = new System.Drawing.Point(11, 365);
            this.bNacionalidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bNacionalidades.Name = "bNacionalidades";
            this.bNacionalidades.Size = new System.Drawing.Size(161, 43);
            this.bNacionalidades.TabIndex = 9;
            this.bNacionalidades.Text = "Nacionalidades";
            this.bNacionalidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNacionalidades.UseVisualStyleBackColor = true;
            this.bNacionalidades.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // bHorario
            // 
            this.bHorario.FlatAppearance.BorderSize = 0;
            this.bHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHorario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bHorario.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bHorario.IconColor = System.Drawing.Color.LightBlue;
            this.bHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bHorario.Location = new System.Drawing.Point(0, 317);
            this.bHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bHorario.Name = "bHorario";
            this.bHorario.Size = new System.Drawing.Size(161, 43);
            this.bHorario.TabIndex = 8;
            this.bHorario.Text = "Horario";
            this.bHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bHorario.UseVisualStyleBackColor = true;
            this.bHorario.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // bEspecialidades
            // 
            this.bEspecialidades.FlatAppearance.BorderSize = 0;
            this.bEspecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEspecialidades.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bEspecialidades.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bEspecialidades.IconColor = System.Drawing.Color.LightBlue;
            this.bEspecialidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bEspecialidades.Location = new System.Drawing.Point(8, 269);
            this.bEspecialidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEspecialidades.Name = "bEspecialidades";
            this.bEspecialidades.Size = new System.Drawing.Size(161, 43);
            this.bEspecialidades.TabIndex = 7;
            this.bEspecialidades.Text = "Especialidades";
            this.bEspecialidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEspecialidades.UseVisualStyleBackColor = true;
            this.bEspecialidades.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // bServicios
            // 
            this.bServicios.FlatAppearance.BorderSize = 0;
            this.bServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bServicios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bServicios.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bServicios.IconColor = System.Drawing.Color.LightBlue;
            this.bServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bServicios.Location = new System.Drawing.Point(0, 213);
            this.bServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bServicios.Name = "bServicios";
            this.bServicios.Size = new System.Drawing.Size(161, 43);
            this.bServicios.TabIndex = 6;
            this.bServicios.Text = "Servicios";
            this.bServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bServicios.UseVisualStyleBackColor = true;
            this.bServicios.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // bDoctores
            // 
            this.bDoctores.FlatAppearance.BorderSize = 0;
            this.bDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDoctores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bDoctores.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bDoctores.IconColor = System.Drawing.Color.LightBlue;
            this.bDoctores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDoctores.Location = new System.Drawing.Point(-1, 164);
            this.bDoctores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDoctores.Name = "bDoctores";
            this.bDoctores.Size = new System.Drawing.Size(161, 43);
            this.bDoctores.TabIndex = 5;
            this.bDoctores.Text = "Doctores";
            this.bDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDoctores.UseVisualStyleBackColor = true;
            this.bDoctores.Click += new System.EventHandler(this.bDoctores_Click);
            // 
            // bPacientes
            // 
            this.bPacientes.FlatAppearance.BorderSize = 0;
            this.bPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bPacientes.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bPacientes.IconColor = System.Drawing.Color.LightBlue;
            this.bPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bPacientes.Location = new System.Drawing.Point(0, 117);
            this.bPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPacientes.Name = "bPacientes";
            this.bPacientes.Size = new System.Drawing.Size(161, 43);
            this.bPacientes.TabIndex = 4;
            this.bPacientes.Text = "Pacientes";
            this.bPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bPacientes.UseVisualStyleBackColor = true;
            this.bPacientes.Click += new System.EventHandler(this.bPacientes_Click);
            // 
            // bCitas
            // 
            this.bCitas.FlatAppearance.BorderSize = 0;
            this.bCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCitas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bCitas.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bCitas.IconColor = System.Drawing.Color.LightBlue;
            this.bCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCitas.Location = new System.Drawing.Point(-3, 69);
            this.bCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCitas.Name = "bCitas";
            this.bCitas.Size = new System.Drawing.Size(161, 43);
            this.bCitas.TabIndex = 3;
            this.bCitas.Text = "Citas";
            this.bCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCitas.UseVisualStyleBackColor = true;
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.Controls.Add(this.iconButton1);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(192, 69);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(192, 65);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Registro de Citas";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelMenuTop
            // 
            this.panelMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelMenuTop.Controls.Add(this.MenuLabelPrincipal);
            this.panelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuTop.Location = new System.Drawing.Point(192, 0);
            this.panelMenuTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuTop.Name = "panelMenuTop";
            this.panelMenuTop.Size = new System.Drawing.Size(1032, 69);
            this.panelMenuTop.TabIndex = 1;
            // 
            // MenuLabelPrincipal
            // 
            this.MenuLabelPrincipal.AutoSize = true;
            this.MenuLabelPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLabelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuLabelPrincipal.Location = new System.Drawing.Point(25, 17);
            this.MenuLabelPrincipal.Name = "MenuLabelPrincipal";
            this.MenuLabelPrincipal.Size = new System.Drawing.Size(141, 21);
            this.MenuLabelPrincipal.TabIndex = 0;
            this.MenuLabelPrincipal.Text = "Clínica Monte Cruz";
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(192, 69);
            this.panelMenuPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(1032, 506);
            this.panelMenuPrincipal.TabIndex = 2;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 575);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Controls.Add(this.panelMenuTop);
            this.Controls.Add(this.panelMenuIzquierda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenuPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.panelMenuIzquierda.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelMenuTop.ResumeLayout(false);
            this.panelMenuTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzquierda;
        private System.Windows.Forms.Panel panelMenuLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelMenuTop;
        private System.Windows.Forms.Label MenuLabelPrincipal;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private FontAwesome.Sharp.IconButton bHorario;
        private FontAwesome.Sharp.IconButton bEspecialidades;
        private FontAwesome.Sharp.IconButton bServicios;
        private FontAwesome.Sharp.IconButton bDoctores;
        private FontAwesome.Sharp.IconButton bPacientes;
        private FontAwesome.Sharp.IconButton bCitas;
        private FontAwesome.Sharp.IconButton bNacionalidades;
    }
}