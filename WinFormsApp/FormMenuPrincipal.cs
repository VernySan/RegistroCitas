using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        public Form CurrentForm { get; set; }

        private void AbrirFormPrincipal(Form menuitem) 
        {
            if (CurrentForm != null) 
            {
                CurrentForm.Close();
            }

            CurrentForm = menuitem;

            menuitem.TopLevel = false;
            menuitem.FormBorderStyle = FormBorderStyle.None;
            menuitem.Dock = DockStyle.Fill;

            panelMenuPrincipal.Controls.Add(menuitem);
            panelMenuPrincipal.Tag = menuitem;

            menuitem.BringToFront();
            menuitem.Show();

            MenuLabelPrincipal.Text = menuitem.Text;
        
        
        
        }


        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormEspecialidad());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormServicio());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormNacionalidad());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormHorario());
        }

        private void bDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormDoctor());
        }

        private void bPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormPrincipal(new FormPaciente());
        }
    }
}
