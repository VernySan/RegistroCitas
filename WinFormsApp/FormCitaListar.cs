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
        }

        private void FechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            CargarDatos();
        }

        private void GridViewCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (GridViewCita.CurrentCell == null ||
                GridViewCita.CurrentCell.Value == null ||
                e.RowIndex == -1) return;

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
