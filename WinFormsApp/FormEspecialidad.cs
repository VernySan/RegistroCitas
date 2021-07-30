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
    public partial class FormEspecialidad : Form
    {
        public FormEspecialidad()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewEspecialidad.AutoGenerateColumns = false;
                GridViewEspecialidad.DataSource = IApp.EspecialidadService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtEspecialidad.Text = null;
            txtEspecialidadId.Text = null;
        }

        private void FormEspecialidad_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelForm.Visible = true;
        }

        public int? GetSelectedRowGrid() 
        {
            if (GridViewEspecialidad.SelectedRows.Count > 0)
            {
                var row = GridViewEspecialidad.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdEspecialidad"].Value);
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
                    var result = IApp.EspecialidadService.GetById(new EspecialidadEntity()
                    { IdEspecialidad = IdSelected });

                    txtEspecialidadId.Text = result.IdEspecialidad.ToString();
                    txtEspecialidad.Text = result.Especialidad;

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
                    var result = IApp.EspecialidadService.Delete(new EspecialidadEntity()
                    { IdEspecialidad = IdSelected });

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
            if (string.IsNullOrEmpty(txtEspecialidad.Text))
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
                    var IdEspecialidad = string.IsNullOrEmpty(txtEspecialidadId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtEspecialidadId.Text);//Editar

                    var entity = new EspecialidadEntity
                    { 
                        IdEspecialidad = IdEspecialidad,
                        Especialidad=txtEspecialidad.Text
                    
                    };

                    var result = new DBEntity();
                    if (entity.IdEspecialidad.HasValue)
                    {
                        //Actualización
                        result = IApp.EspecialidadService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.EspecialidadService.Create(entity);

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
