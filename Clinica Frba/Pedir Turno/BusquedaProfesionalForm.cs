using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class BusquedaProfesionalForm : Form
    {
        private ModeloBusquedaProfesional miModelo;
        int nroPaciente;
        
        public BusquedaProfesionalForm(int nro_Paciente)
        {
            miModelo = new ModeloBusquedaProfesional();
            nroPaciente = nro_Paciente;
            InitializeComponent();
            generarComboEspecialidades();
            gridResultados.MultiSelect = false;
            gridResultados.ReadOnly = true;
        }

        private void generarComboEspecialidades()
        {//BINDEA EL COMBO CON LAS ESPECIALIDADES
            while (miModelo.dr_Especialidades.Read())
            {
                comboEspecialidad.Items.Add(miModelo.dr_Especialidades.GetString(0));
            }
        }
        //
        //Lleno la grilla con los resultados
        //
        private void armarGrilla()
        {
            gridResultados.Rows.Clear();
            while (miModelo.dr_Medicos.Read())
            {
                gridResultados.Rows.Add(new Object[]{      
                    miModelo.dr_Medicos.GetString(0),
                    miModelo.dr_Medicos.GetString(1),
                    Convert.ToInt32(miModelo.dr_Medicos.GetValue(2))
                    
                });
            }
            gridResultados.Columns["idMedico"].Visible = false;
            gridResultados.Update();
        }

        private void NombreProfTB_TextChanged(object sender, EventArgs e)
        {
            miModelo.nombre = NombreProfTB.Text;
        }

        private void botonBuscar(object sender, EventArgs e)
        {
            miModelo.especialidadSeleccionada = comboEspecialidad.Text;
            miModelo.buscar();
            armarGrilla();

        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (gridResultados.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione un profesional");
            }
            else 
            {
                int index = (int)gridResultados.SelectedCells[0].RowIndex;
                UInt32 idMedico = Convert.ToUInt32(gridResultados.Rows[index].Cells["idMedico"].Value);
                MostrarAgendaForm ventana = new MostrarAgendaForm(idMedico,nroPaciente);
                ventana.ShowDialog();
                this.Close();
            };
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            gridResultados.Rows.Clear();
        }
    }
}
