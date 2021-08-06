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
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewPaciente.AutoGenerateColumns = false;
                GridViewPaciente.DataSource = IApp.PacienteService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            nPasaporte.Value = 0;
            nCedula.Value = 0;
            txtNombre.Text = null;
            txtPrimerApellido.Text = null;
            txtSegundoApellido.Text = null;
            dFechaNacimiento.Value = DateTime.Now;
            nTelefono.Value = 0;
            txtAlergias.Text = null;
            txtEnfermedades.Text = null;
            txtDireccion.Text = null;
            chckEstado.Checked = true;
            chckGuardar.Checked = false;
        }

        public void CargaCboNacionalidad()
        {
            try
            {
                cboNacionalidad.DisplayMember = "Nacionalidad";
                cboNacionalidad.ValueMember = "IdNacionalidad";

                cboNacionalidad.DataSource = IApp.NacionalidadService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargaCboNacionalidad();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            chckGuardar.Checked = true;
            panelForm.Visible = true;
        }

        public int? GetSelectedRowGrid() 
        {
            if (GridViewPaciente.SelectedRows.Count > 0)
            {
                var row = GridViewPaciente.SelectedRows[0];
                return Convert.ToInt32(row.Cells["Pasaporte"].Value);
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
                    var result = IApp.PacienteService.GetById(new PacienteEntity()
                    { Pasaporte = IdSelected });

                    nPasaporte.Value = (decimal)result.Pasaporte;
                    nCedula.Value = result.Cedula;
                    txtNombre.Text = result.Nombre;
                    txtPrimerApellido.Text = result.PrimerApellido;
                    txtSegundoApellido.Text = result.SegundoApellido;
                    dFechaNacimiento.Value = result.FechaNacimiento;
                    cboNacionalidad.SelectedValue = result.IdNacionalidad;
                    nTelefono.Value = result.Telefono;
                    txtAlergias.Text = result.Alergias;
                    txtEnfermedades.Text = result.Enfermedades;
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
                    var result = IApp.PacienteService.Delete(new PacienteEntity()
                    { Pasaporte = IdSelected });

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
                    var Pasaporte = string.IsNullOrEmpty(nPasaporte.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(nPasaporte.Text);//Editar

                    var entity = new PacienteEntity
                    {
                        Pasaporte = Pasaporte,
                        Cedula = (int)nCedula.Value,
                        Nombre = txtNombre.Text,
                        PrimerApellido = txtPrimerApellido.Text,
                        SegundoApellido = txtSegundoApellido.Text,
                        IdNacionalidad = Convert.ToInt32(cboNacionalidad.SelectedValue),
                        FechaNacimiento = dFechaNacimiento.Value,
                        Telefono = (int)nTelefono.Value,
                        Enfermedades = txtEnfermedades.Text,
                        Alergias = txtAlergias.Text,
                        Direccion = txtDireccion.Text,
                        Estado = chckEstado.Checked


                };

                    var result = new DBEntity();
                    if (!chckGuardar.Checked)
                    {
                        //Actualización
                        result = IApp.PacienteService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.PacienteService.Create(entity);

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
