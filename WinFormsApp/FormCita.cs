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
                GridViewCita.DataSource = IApp.CitaService.GetByDate(new CitaEntity()
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
            cboDoctor.SelectedIndex = -1;
            cboPaciente.SelectedIndex = -1;
            cboServicio.SelectedIndex = -1;
        }

        private void FormCita_Load(object sender, EventArgs e)
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

                var IdSelected = GetSelectedRowGridHorario();

                if (IdSelected.HasValue)
                {

//                    txtIdHorario.Text = IdSelected.ToString;

                    panelForm.Visible = true;
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

        public int? GetSelectedRowGridHorario()
        {
            if (GridViewCita.SelectedRows.Count > 0)
            {
                var row = GridViewCita.SelectedRows[1];
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
                    var result = IApp.CitaService.GetById(new CitaEntity()
                    { IdCita = IdSelected });

                    txtIdCita.Text = result.IdCita.ToString();
                    txtIdHorario.Text = result.IdHorario.ToString();
                    cboDoctor.SelectedValue = result.IdDoctor;
                    cboPaciente.SelectedValue = result.IdPaciente;
                    cboServicio.SelectedValue = result.IdServicio;

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

            if (string.IsNullOrEmpty(cboDoctor.SelectedValue?.ToString()))
            {
                MessageBox.Show("El camppo Doctor es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(cboPaciente.SelectedValue?.ToString()))
            {
                MessageBox.Show("El camppo Paciente es obligatorio");
                return false;
            }

            if (string.IsNullOrEmpty(cboServicio.SelectedValue?.ToString()))
            {
                MessageBox.Show("El camppo Servicio es obligatorio");
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
                    var IdCita = string.IsNullOrEmpty(txtIdCita.Text)
                                          ? (int?)null //Insertar
                                          : Convert.ToInt32(txtIdCita.Text);//Editar

                    var entity = new CitaEntity
                    { 
                        IdCita = IdCita,
                        IdHorario = Convert.ToInt32(txtIdHorario.Text),
                        Fecha = FechaFiltro.Value,
                        IdDoctor = Convert.ToInt32(cboDoctor.SelectedValue),
                        IdPaciente = Convert.ToInt32(cboPaciente.SelectedValue),
                        IdServicio = Convert.ToInt32(cboServicio.SelectedValue)
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
            CargarDatos();
        }

        public void CargaCboDoctor()
        {
            try
            {
                cboDoctor.DisplayMember = "Doctor";
                cboDoctor.ValueMember = "Cedula";

                cboDoctor.DataSource = IApp.DoctorService.GetLista();

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
                cboPaciente.DisplayMember = "Paciente";
                cboPaciente.ValueMember = "Pasaporte";

                cboPaciente.DataSource = IApp.PacienteService.GetLista();

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
                cboServicio.DisplayMember = "Servicio";
                cboServicio.ValueMember = "IdServicio";

                cboServicio.DataSource = IApp.ServicioService.GetLista();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
