using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace WinFormsApp
{
    public partial class FormHorario : Form
    {
        public FormHorario()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewHorario.AutoGenerateColumns = false;
                GridViewHorario.DataSource = IApp.HorarioService.Get();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        
        }

        public void LimpiarDatos() 
        {
            
            txtInicio.Text = null;  
            txtFin.Text = null;
            txtIdHorario.Text = null;
        }

        private void FormHorario_Load(object sender, EventArgs e)
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
            if (GridViewHorario.SelectedRows.Count > 0)
            {
                var row = GridViewHorario.SelectedRows[0];
                return Convert.ToInt32(row.Cells["IdHorario"].Value);
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
                    var result = IApp.HorarioService.GetById(new HorarioEntity()
                    { IdHorario = IdSelected });

                    txtIdHorario.Text = result.IdHorario.ToString();
                    txtInicio.Text = result.Inicio;
                    txtFin.Text = result.Fin;
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
                    var result = IApp.HorarioService.Delete(new HorarioEntity()
                    { IdHorario = IdSelected });

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
            if (string.IsNullOrEmpty(txtInicio.Text) || string.IsNullOrEmpty(txtFin.Text))
            {
                MessageBox.Show("Los campos Inicio y Fin son obligatorios");
                return false;
            }

            DateTime tInicio;
            DateTime tFin;
            bool bInicio = DateTime.TryParse(txtInicio.Text, out tInicio);
            bool bFin = DateTime.TryParse(txtFin.Text, out tFin);

            if (!bInicio && !bFin)
            {
                MessageBox.Show("Las horas se deben digitar en formato HH:MM ó HH:MM AM/PM");
                return false;
            }

            if (tInicio >= tFin)
            {
                MessageBox.Show("Las hora Fin debe ser mayor a la hora Incio");
                return false;
            }

            txtInicio.Text = tInicio.ToString("hh:mm tt");
            txtFin.Text = tFin.ToString("hh:mm tt");
            return true;       
        
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var IdHorario = string.IsNullOrEmpty(txtIdHorario.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtIdHorario.Text);//Editar

                    var entity = new HorarioEntity
                    { 
                        IdHorario = IdHorario,
                        Inicio=txtInicio.Text,
                        Fin=txtFin.Text
                    };

                    var result = new DBEntity();
                    if (entity.IdHorario.HasValue)
                    {
                        //Actualización
                        result = IApp.HorarioService.Update(entity);

                        if (result.CodeError == 0) MessageBox.Show("El registro se actualizó correctamente");
                    }
                    else
                    {
                        result = IApp.HorarioService.Create(entity);

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
