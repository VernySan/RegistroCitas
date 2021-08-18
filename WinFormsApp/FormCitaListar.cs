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
    public partial class FormCitaListar : Form
    {
        public FormCitaListar()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            try
            {
                GridViewCita.AutoGenerateColumns = false;
                GridViewCita.DataSource = IApp.CitaService.ListarByDate(new CitaEntity()
                {
                    Fecha = FechaFiltro.Value
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LimpiarDatos() 
        {
            txtIdCita.Text = null;
            txtDoctor.Text = null;
            txtEspecialidad.Text = null;
            txtPaciente.Text = null;
            txtCedula.Text = null;
            txtTelefono.Text = null;
            txtConsulta.Text = null;
            txtProcedimiento.Text = null;
            txtHora.Text = null;
            txtPrecio.Text = null;
        }

        private void FormCitaListar_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargaCboDoctor();
            CargaCboPaciente();
            CargaCboServicio();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
 
                    if (GridViewCita.SelectedRows.Count > 0)
                    {
                        var row = GridViewCita.SelectedRows[0];

                    var sCita = Convert.ToString(row.Cells["IdCita"].Value);

                    if (String.IsNullOrEmpty(sCita))
                    {
                        panelForm.Visible = true;
                    } 
                    else
                    {
                        MessageBox.Show("Ya existe una cita asignada en este horario");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor seleccione un Horario");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

                if (IdSelected.HasValue )
                {
                    var result = IApp.CitaService.GetById(new CitaEntity()
                    { IdCita = IdSelected });

                    if (IdSelected != 0 )
                    {
                        txtIdCita.Text = result.IdCita.ToString();

                        panelForm.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No se puede editar una cita sin asignar");
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



            return true;       
        
        
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidacionFormulario())
                {
                    var IdCita = string.IsNullOrEmpty(txtIdCita.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtIdCita.Text);//Editar

                    var entity = new CitaEntity
                    { 
                        IdCita = IdCita,
                        Fecha = FechaFiltro.Value,
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

        private void FechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            CargarDatos();
        }

        public void CargaCboDoctor()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CargaCboPaciente()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CargaCboServicio()
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GridViewCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (GridViewCita.CurrentCell == null ||
                GridViewCita.CurrentCell.Value == null ||
                e.RowIndex == -1) return;

            //if (GridViewCita.CurrentCell.ColumnIndex.Equals(3))
            //var row = GridViewCita.SelectedRows[e.RowIndex];

            var row = GridViewCita.Rows[e.RowIndex];
            txtIdCita.Text = Convert.ToString(row.Cells["IdCita"].Value);

            var result = IApp.CitaService.ListarById(new CitaEntity()
            { IdCita = Convert.ToInt32(txtIdCita.Text) });

            txtDoctor.Text = result.Doctor;
            txtEspecialidad.Text = result.Especialidad;
            txtPaciente.Text = result.Paciente;
            txtCedula.Text = result.Cedula.ToString();
            txtTelefono.Text = result.Telefono.ToString();
            txtConsulta.Text = result.Consulta;
            txtProcedimiento.Text = result.Procedimiento;
            txtHora.Text = result.Inicio.ToString();
            txtPrecio.Text = result.Precio.ToString(); 
        }


    }
}
