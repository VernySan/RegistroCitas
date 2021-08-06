using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace WinFormsApp
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewDoctor.AutoGenerateColumns = false;
                GridViewDoctor.DataSource = IApp.DoctorService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtCedula.Text = null;
            txtNombre.Text = null;
            txtPrimerApellido.Text = null;
            txtSegundoApellido.Text = null;
            nTelefono.Value = 0;
            txtDireccion.Text = null;
            chckEstado.Checked = true;
            chckGuardar.Checked = false;
        }

        public void CargaCboEspecialidad()
        {
            try
            {
                cboEspecialidad.DisplayMember = "Especialidad";
                cboEspecialidad.ValueMember = "IdEspecialidad";

                cboEspecialidad.DataSource = IApp.EspecialidadService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargaCboEspecialidad();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            chckGuardar.Checked = true;
            panelForm.Visible = true;
        }

        public int? GetSelectedRowGrid() 
        {
            if (GridViewDoctor.SelectedRows.Count > 0)
            {
                var row = GridViewDoctor.SelectedRows[0];
                return Convert.ToInt32(row.Cells["Cedula"].Value);
            }
            else
            {
                return null;
            }    
        
        
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.DoctorService.GetById(new DoctorEntity()
                    { Cedula = IdSelected });

                    txtCedula.Text = result.Cedula.ToString();
                    txtNombre.Text = result.Nombre;
                    txtPrimerApellido.Text = result.PrimerApellido;
                    txtSegundoApellido.Text = result.SegundoApellido;
                    cboEspecialidad.SelectedValue = result.IdEspecialidad;
                    nTelefono.Value = result.Telefono;
                    txtDireccion.Text = result.Direccion;
                    chckEstado.Checked = result.Estado;

                    panelForm.Visible = true;
                }
                else 
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
                panelForm.Visible = false;

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.DoctorService.Delete(new DoctorEntity()
                    { Cedula = IdSelected });

                    if (result.CodeError == 0)
                    {
                        MessageBox.Show("El registro se elimino correctamente");
                        CargarDatos();
                    }
                    else
                    {
                        throw new Exception(result.MsgError);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public bool ValidacionFormulario()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Descripción es obligatorio");
                return false;
            }

            return true;       
        
        
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var Cedula = string.IsNullOrEmpty(txtCedula.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtCedula.Text);//Editar

                    var entity = new DoctorEntity
                    {
                        Cedula = Cedula,
                        Nombre = txtNombre.Text,
                        PrimerApellido = txtPrimerApellido.Text,
                        SegundoApellido = txtSegundoApellido.Text,
                        IdEspecialidad = Convert.ToInt32(cboEspecialidad.SelectedValue), 
                        Telefono = (int)nTelefono.Value,
                        Direccion = txtDireccion.Text,
                        Estado = chckEstado.Checked


                };

                    var result = new DBEntity();
                    if (!chckGuardar.Checked)
                    {
                        //Actualización
                        result = IApp.DoctorService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.DoctorService.Create(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se insertó correctamente");

                    }

                    if (result.CodeError != 0) throw new Exception(result.MsgError);

                    LimpiarDatos();
                    CargarDatos();
                    panelForm.Visible = false;         

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
