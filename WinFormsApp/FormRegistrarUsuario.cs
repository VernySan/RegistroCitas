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
    public partial class FormRegistrarUsuario : Form
    {
        public FormRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validaciones())
                {
                    var entity = new UsuariosEntity()
                    {
                        Usuario = txtUsuario.Text,
                        Nombre = txtNombre.Text,
                        Contrasena = txtPassword.Text
                    };

                    var result = IApp.UsuariosServices.Registrar(entity);

                    if (result.CodeError == 0)
                    {
                        MessageBox.Show("Se ingreso el usuario de forma sastifactoria");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show(result.MsgError);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public bool Validaciones()
        {

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El usuario es un campo requerido");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es un campo requerido");
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("La contraseña tiene que tener un maximo de 6 caracteres");
                return false;
            }

            if (!txtPassword.Text.Equals(txtComfirmarContraseña.Text))
            {
                MessageBox.Show("La contraseña y confirmar contraserña no coinciden");
                return false;
            }



            return true;
        }
    }
}
