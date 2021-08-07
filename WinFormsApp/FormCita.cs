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
    public partial class FormCita : Form
    {
        public FormCita()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewCita.AutoGenerateColumns = false;
                GridViewCita.DataSource = IApp.CitaService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            txtCita.Text = null;
            txtCitaId.Text = null;
        }

        private void FormCita_Load(object sender, EventArgs e)
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
            if (GridViewCita.SelectedRows.Count > 0)
            {
                var row = GridViewCita.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdCita"].Value);
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
                    var result = IApp.CitaService.GetById(new CitaEntity()
                    { IdCita = IdSelected });

                    txtCitaId.Text = result.IdCita.ToString();
                    //txtCita.Text = result.Cita;

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
                    var result = IApp.CitaService.Delete(new CitaEntity()
                    { IdCita = IdSelected });

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
            if (string.IsNullOrEmpty(txtCita.Text))
            {
                MessageBox.Show("El campo Cita es obligatorio");
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
                    var IdCita = string.IsNullOrEmpty(txtCitaId.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtCitaId.Text);//Editar

                    var entity = new CitaEntity
                    { 
                        IdCita = IdCita
                        //Cita=txtCita.Text
                    
                    };

                    var result = new DBEntity();
                    if (entity.IdCita.HasValue)
                    {
                        //Actualización
                        result = IApp.CitaService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.CitaService.Create(entity);

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
