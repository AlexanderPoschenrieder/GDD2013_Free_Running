using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class MostrarAgendaForm : Form
    {
        ModeloAgenda miModelo;
        DateTime diaSeleccionado;

        //Constructor para la ABM  Cancelar Consulta Medico
        public MostrarAgendaForm(UInt32 nroMedico,int nro_Paciente)
        {
            InitializeComponent();
            //Deshabilito las partes que no tienen que estarlo en el comienzo
            botonSeleccionar.Enabled = false;
            horariosDisponibles.Enabled = false;
            //---------------------------------------------------------------
            
            calendarioDeAgenda.MaxSelectionCount = 1;//limito la seleccion a un dia
            miModelo = new ModeloAgenda(nroMedico,nro_Paciente);
            calendarioDeAgenda.BoldedDates = miModelo.turnos.ToArray<DateTime>();
            //Le cargo las acciones correspondientes-----------------------------------------
            this.calendarioDeAgenda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioDeAgenda_DateSelected);
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
        }

//Constructor para la ABM cancelar Turno Medico
        public MostrarAgendaForm(UInt32 nroMedico) {
            InitializeComponent();
            label1.Text = "Seleccione una fecha o un intervalo";
            botonSeleccionar.Enabled = false;
            miModelo = new ModeloAgenda(nroMedico);
            calendarioDeAgenda.BoldedDates = miModelo.turnos.ToArray<DateTime>();
            
            //Le cargo las acciones correspondientes-----------------------------------------
            this.botonSeleccionar.Click += new System.EventHandler(this.cancelarTurno_Click);
            this.calendarioDeAgenda.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarioDeAgenda_CancelarTurno);
            
        }

//Accones para la ABM pedir Turno------------------------------------------------------
        private void calendarioDeAgenda_DateSelected(object sender, DateRangeEventArgs e)
        {
            diaSeleccionado= calendarioDeAgenda.SelectionRange.Start;
            if (!miModelo.turnos.Any(turno =>turno.Date==diaSeleccionado.Date))//verifica que el turno este disponible
            {
                horariosDisponibles.Enabled = false;//deshabilito la seleccion de horarios
                MessageBox.Show("Seleccione una fecha disponible");
            }
            else
            {
                this.Width = 400;//expando la ventana para mostrar la seleccion de horarios
                horariosDisponibles.Enabled = true;//habilito la seleccion de horarios
                horariosDisponibles.Rows.Clear();
                miModelo.horariosDelDia(diaSeleccionado);
                foreach (DateTime hora in miModelo.listaHorarios)
                {
                    horariosDisponibles.Rows.Add(new Object[]{
                        hora.ToString("HH:mm:ss")
                    });
                }
            }
        }

        private void horariosDisponibles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            botonSeleccionar.Enabled = true;
        }

        public void botonSeleccionar_Click(object sender, EventArgs e)
        {
            DateTime horarioSeleccionado = Convert.ToDateTime(horariosDisponibles.SelectedCells[0].Value);
            DateTime fechaHora = new DateTime(diaSeleccionado.Year, diaSeleccionado.Month, diaSeleccionado.Day, horarioSeleccionado.Hour, horarioSeleccionado.Minute, horarioSeleccionado.Second);

            miModelo.reservarTurno(fechaHora);
            this.Close();
        }

//-------------------------------------------------------------------------------------
//Acciones para la ABM CancelarTurno---------------------------------------------------
        private void cancelarTurno_Click(object sender, EventArgs e)
        {
            miModelo.cancelarListaTurnos(calendarioDeAgenda.SelectionRange.Start,calendarioDeAgenda.SelectionRange.End);
            this.Close();
        }

        private void calendarioDeAgenda_CancelarTurno(object sender, DateRangeEventArgs e)
        {
            botonSeleccionar.Enabled = true;
        }



    }
}
