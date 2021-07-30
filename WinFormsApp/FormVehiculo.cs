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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewVehiculo.AutoGenerateColumns = false;
                GridViewVehiculo.DataSource = IApp.VehiculoService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void LimpiarDatos()
        {
            txtVehiculoId.Text = null;
            cboMarcaVehiculo.SelectedIndex = -1;
            txtMatricula.Text = null;
            txtColor.Text = null;
            txtModelo.Text = null;
            dpFechaModelo.Value = DateTime.Now;
            chkTieneDefectos.Checked = false;
            txtDefectos.Text = null;
            chckEstado.Checked = true;

        }

        public int? GetSelectedRowGrid()
        {
            if (GridViewVehiculo.SelectedRows.Count > 0)
            {
                var row = GridViewVehiculo.SelectedRows[0];
                return Convert.ToInt32(row.Cells["VehiculoId"].Value);
            }
            else
            {
                return null;
            }


        }

        public bool ValidacionFormulario()
        {
            if (string.IsNullOrEmpty(cboMarcaVehiculo.SelectedValue?.ToString()))
            {
                MessageBox.Show("El campo Marca Vehiculo es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("El campo Matricula es obligatorio");
                return false;
            }


            if (string.IsNullOrEmpty(txtColor.Text))
            {
                MessageBox.Show("El campo Color es obligatorio");
                return false;
            }


            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("El campo Modelo es obligatorio");
                return false;
            }


            if (string.IsNullOrEmpty(txtDefectos.Text) && chkTieneDefectos.Checked)
            {
                MessageBox.Show("El campo Defectos es obligatorio");
                return false;
            }


            return true;


        }

        public void CargaCboMarcaVehiculo()
        {
            try
            {
                cboMarcaVehiculo.DisplayMember = "Descripcion";
                cboMarcaVehiculo.ValueMember = "MarcaVehiculoId";

                cboMarcaVehiculo.DataSource = IApp.MarcaVehiculoService.GetLista();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        
        
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargaCboMarcaVehiculo();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            panelForm.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();

                var IdSelected = GetSelectedRowGrid();

                if (IdSelected.HasValue)
                {
                    var result = IApp.VehiculoService.GetById(new VehiculoEntity()
                    { VehiculoId = IdSelected });

                    txtVehiculoId.Text = result.VehiculoId.ToString();
                    cboMarcaVehiculo.SelectedValue = result.MarcaVehiculoId;
                    txtMatricula.Text = result.Matricula;
                    txtColor.Text = result.Color;
                    txtModelo.Text = result.Modelo;
                    dpFechaModelo.Value = result.FechaModelo;
                    chkTieneDefectos.Checked = result.TieneDefectos;
                    txtDefectos.Text = result.Defectos;
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var VehiculoId = string.IsNullOrEmpty(txtVehiculoId.Text)
                                            ? (int?)null // Insertar
                                            : Convert.ToInt32(txtVehiculoId.Text); //Editar

                    var entity = new VehiculoEntity
                    {
                        VehiculoId = VehiculoId,
                        MarcaVehiculoId = Convert.ToInt32(cboMarcaVehiculo.SelectedValue),
                        Matricula = txtMatricula.Text,
                        Color = txtColor.Text,
                        Modelo = txtModelo.Text,
                        FechaModelo = dpFechaModelo.Value,
                        TieneDefectos = chkTieneDefectos.Checked,
                        Defectos = chkTieneDefectos.Checked ? txtDefectos.Text : null,
                        Estado = chckEstado.Checked
                    };

                    var result = new DBEntity();

                    if (entity.VehiculoId.HasValue)
                    {
                        //actualizar
                        result = IApp.VehiculoService.Update(entity);

                        if (result.CodeError == 0)
                            MessageBox.Show("Se Actualizo el registro correctamente!");

                    }
                    else
                    {
                        //Insertar
                        result = IApp.VehiculoService.Create(entity);

                        if (result.CodeError == 0)
                            MessageBox.Show("Se guardo el registro correctamente!");
                    }

                    //verificamos que la base de datos no retorne un error
                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    //limpiamos  refrescamos y desaparecemos el form
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
        public void EliminarRegistro()
        {

            var IdSelected = GetSelectedRowGrid();

            if (IdSelected.HasValue)
            {
                //mandamos a eliminar el registro desde la base de datos
                var result = IApp.VehiculoService.Delete(new VehiculoEntity()
                {
                    VehiculoId = IdSelected
                });
                //si el mensaje de error es igual a cero  se elimino correctamente
                if (result.CodeError == 0)
                {
                    MessageBox.Show("El Registro Se elimino Correctamente!");
                    // cargamos de nuevos los datos en la tabla 
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
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                panelForm.Visible = false;

                var Respuesta = MessageBox.Show("Seguro que desea Eliminar este registro?"
                    , "Eliminar", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    EliminarRegistro();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      

        private void chkTieneDefectos_CheckedChanged(object sender, EventArgs e)
        {
            lbDefectos.Visible = chkTieneDefectos.Checked;
            txtDefectos.Visible = chkTieneDefectos.Checked;
        }
    }
    
}
