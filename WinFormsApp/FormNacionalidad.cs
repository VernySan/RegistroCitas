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
    public partial class FormNacionalidad : Form
    {
        public FormNacionalidad()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewNacionalidad.AutoGenerateColumns = false;
                GridViewNacionalidad.DataSource = IApp.NacionalidadService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtNacionalidad.Text = null;
            txtNacionalidadId.Text = null;
        }

        private void FormNacionalidad_Load(object sender, EventArgs e)
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
            if (GridViewNacionalidad.SelectedRows.Count > 0)
            {
                var row = GridViewNacionalidad.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdNacionalidad"].Value);
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
                    var result = IApp.NacionalidadService.GetById(new NacionalidadEntity()
                    { IdNacionalidad = IdSelected });

                    txtNacionalidadId.Text = result.IdNacionalidad.ToString();
                    txtNacionalidad.Text = result.Nacionalidad;

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
                    var result = IApp.NacionalidadService.Delete(new NacionalidadEntity()
                    { IdNacionalidad = IdSelected });

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
            if (string.IsNullOrEmpty(txtNacionalidad.Text))
            {
                MessageBox.Show("El campo Nacionalidad es obligatorio");
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
                    var IdNacionalidad = string.IsNullOrEmpty(txtNacionalidadId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtNacionalidadId.Text);//Editar

                    var entity = new NacionalidadEntity
                    { 
                        IdNacionalidad = IdNacionalidad,
                        Nacionalidad=txtNacionalidad.Text
                    
                    };

                    var result = new DBEntity();
                    if (entity.IdNacionalidad.HasValue)
                    {
                        //Actualización
                        result = IApp.NacionalidadService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.NacionalidadService.Create(entity);

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
