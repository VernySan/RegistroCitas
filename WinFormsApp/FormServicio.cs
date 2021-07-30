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
    public partial class FormServicio : Form
    {
        public FormServicio()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewServicio.AutoGenerateColumns = false;
                GridViewServicio.DataSource = IApp.ServicioService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtServicio.Text = null;
            txtIdServicio.Text = null;
            txtProcedimiento.Text = null;
            txtCaracteristicas.Text = null;
            nPrecio.Value = 0;
            chckEstado.Checked = true;
        
        }

        private void FormServicio_Load(object sender, EventArgs e)
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
            if (GridViewServicio.SelectedRows.Count > 0)
            {
                var row = GridViewServicio.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdServicio"].Value);
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
                    var result = IApp.ServicioService.GetById(new ServicioEntity()
                    { IdServicio = IdSelected });

                    txtIdServicio.Text = result.IdServicio.ToString();
                    txtServicio.Text = result.Servicio;
                    txtProcedimiento.Text = result.Procedimiento;
                    txtCaracteristicas.Text = result.Caracteristicas;
                    nPrecio.Value = (decimal)result.Precio;
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
                    var result = IApp.ServicioService.Delete(new ServicioEntity()
                    { IdServicio = IdSelected });

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
            if (string.IsNullOrEmpty(txtServicio.Text) ||
                string.IsNullOrEmpty(txtProcedimiento.Text) ||
                string.IsNullOrEmpty(txtCaracteristicas.Text) 
                )
            {
                MessageBox.Show("Los campos Servicio, Procedimiento y Características son obligatorios");
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
                    var IdServicio = string.IsNullOrEmpty(txtIdServicio.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtIdServicio.Text);//Editar

                    var entity = new ServicioEntity
                    {
                        IdServicio = IdServicio,
                        Servicio = txtServicio.Text,
                        Procedimiento = txtProcedimiento.Text,
                        Caracteristicas = txtCaracteristicas.Text,
                        Precio = (double)nPrecio.Value,
                        Estado = chckEstado.Checked
                    };

                    var result = new DBEntity();
                    if (entity.IdServicio.HasValue)
                    {
                        //Actualización
                        result = IApp.ServicioService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.ServicioService.Create(entity);

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
