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
    public partial class FormMarcaVehiculo : Form
    {
        public FormMarcaVehiculo()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewMarcaVehiculo.AutoGenerateColumns = false;
                GridViewMarcaVehiculo.DataSource = IApp.MarcaVehiculoService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtDescripcion.Text = null;
            txtMarcaVehiculoId.Text = null;
            chckEstado.Checked = true;
        
        }

        private void FormMarcaVehiculo_Load(object sender, EventArgs e)
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
            if (GridViewMarcaVehiculo.SelectedRows.Count > 0)
            {
                var row = GridViewMarcaVehiculo.SelectedRows[0];
                return Convert.ToInt32(row.Cells["MarcaVehiculoId"].Value);
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
                    var result = IApp.MarcaVehiculoService.GetById(new MarcaVehiculoEntity()
                    { MarcaVehiculoId = IdSelected });

                    txtMarcaVehiculoId.Text = result.MarcaVehiculoId.ToString();
                    txtDescripcion.Text = result.Descripcion;
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
                    var result = IApp.MarcaVehiculoService.Delete(new MarcaVehiculoEntity()
                    { MarcaVehiculoId = IdSelected });

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
            if (string.IsNullOrEmpty(txtDescripcion.Text))
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
                    var MarcaVehiculoId = string.IsNullOrEmpty(txtMarcaVehiculoId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtMarcaVehiculoId.Text);//Editar

                    var entity = new MarcaVehiculoEntity
                    { 
                        MarcaVehiculoId= MarcaVehiculoId,
                        Descripcion=txtDescripcion.Text,
                        Estado= chckEstado.Checked
                    
                    };

                    var result = new DBEntity();
                    if (entity.MarcaVehiculoId.HasValue)
                    {
                        //Actualización
                        result = IApp.MarcaVehiculoService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.MarcaVehiculoService.Create(entity);

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
