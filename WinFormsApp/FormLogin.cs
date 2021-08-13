using Entity;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LinkRegistrase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new FormRegistrarUsuario();

            form.Show();
        }


        private void Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("El campo de usuario es obligatorio!!");

                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("El campo de Contraseña es obligatorio!!");

                    return;
                }

                var result = IApp.UsuariosServices.Login(new UsuariosEntity
                {
                    Usuario = txtUsuario.Text,
                    Contrasena = txtPassword.Text

                });

                if (result.CodeError == 0)
                {
                    this.Hide();
                    Session.Usuario = result;

                    var form = new FormMenuPrincipal();

                    form.Show();


                }
                else
                {
                    MessageBox.Show(result.MsgError);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
