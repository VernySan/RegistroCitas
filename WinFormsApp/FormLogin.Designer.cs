
namespace WinFormsApp
{
    partial class FormLogin
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
            this.LinkRegistrase = new System.Windows.Forms.LinkLabel();
            this.Iniciar_Sesion = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // LinkRegistrase
            // 
            this.LinkRegistrase.AutoSize = true;
            this.LinkRegistrase.Location = new System.Drawing.Point(377, 249);
            this.LinkRegistrase.Name = "LinkRegistrase";
            this.LinkRegistrase.Size = new System.Drawing.Size(82, 20);
            this.LinkRegistrase.TabIndex = 13;
            this.LinkRegistrase.TabStop = true;
            this.LinkRegistrase.Text = "Registrarse";
            this.LinkRegistrase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegistrase_LinkClicked);
            // 
            // Iniciar_Sesion
            // 
            this.Iniciar_Sesion.BackColor = System.Drawing.Color.DarkCyan;
            this.Iniciar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciar_Sesion.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.Iniciar_Sesion.IconColor = System.Drawing.Color.White;
            this.Iniciar_Sesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Iniciar_Sesion.IconSize = 40;
            this.Iniciar_Sesion.Location = new System.Drawing.Point(272, 178);
            this.Iniciar_Sesion.Name = "Iniciar_Sesion";
            this.Iniciar_Sesion.Size = new System.Drawing.Size(75, 44);
            this.Iniciar_Sesion.TabIndex = 12;
            this.Iniciar_Sesion.UseVisualStyleBackColor = false;
            this.Iniciar_Sesion.Click += new System.EventHandler(this.Iniciar_Sesion_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(205, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 27);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(205, 60);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(193, 27);
            this.txtUsuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.DarkCyan;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.Location = new System.Drawing.Point(12, 39);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 194);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 278);
            this.Controls.Add(this.LinkRegistrase);
            this.Controls.Add(this.Iniciar_Sesion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LinkRegistrase;
        private FontAwesome.Sharp.IconButton Iniciar_Sesion;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}