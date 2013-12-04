using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    class ModeloAgenda
    {
        UInt32 nroMedico;
        int nroPaciente;
        SqlConnection miConexion;
        SqlCommand consultaTurnos;
        SqlDataReader drTurnos;
        public List<DateTime> turnos { get; set; }
        public List<DateTime> listaHorarios { get; set; }

        //Constructor para la ABM pedir turno
        public ModeloAgenda(UInt32 nro_Medico,int nro_Paciente) {
            nroMedico = nro_Medico;
            nroPaciente = nro_Paciente;
            turnos=new List<DateTime>();
            turnosDelMedico();
            //quitarTurnosOcupados();

        }

        //Constructor para la ABM Cancelar Turno Medico
        public ModeloAgenda(UInt32 nro_Medico) 
        {
            nroMedico = nro_Medico;
            turnos = new List<DateTime>();
            agendaDelMedico();
        }
        //
        //Metodos para ABM Cancelar Atencion Medico
        //

        public void cancelarListaTurnos(DateTime primerFecha,DateTime segundaFecha ) {
            List<String> diasACancelar = new List<string>();
            
            while (primerFecha <= segundaFecha) {
                diasACancelar.Add(primerFecha.ToString("yyyy-dd-MM HH:mm:ss"));
                primerFecha=primerFecha.AddDays(1);
            }
            (new Clinica_Frba.Cancelar_Atencion.MotivoCancelacionForm(diasACancelar,nroMedico)).ShowDialog();
        }
        public void agendaDelMedico() {
            miConexion = Conexion.Conectar();             //selecciono los horarios de la agenda del medico
            consultaTurnos = new SqlCommand(string.Format("select a.FechaHora_Turno from Free_Running.agenda a where a.Medico = {0}", nroMedico), miConexion);
            drTurnos = consultaTurnos.ExecuteReader();

            while (drTurnos.Read())
            {
                turnos.Add(Convert.ToDateTime(drTurnos[0]));
            }
        
        }
        //
        //Metodos para ABM Pedir turno
        //
        public void turnosDelMedico()
        {
            miConexion = Conexion.Conectar();             //selecciono los horarios de la agenda del medico que...no esten relacionados con un turno o... que si lo estan, entonces que esten cancelados
            consultaTurnos = new SqlCommand(string.Format("select * from Free_Running.turnosLibresMedico({0})", nroMedico), miConexion);
            drTurnos = consultaTurnos.ExecuteReader();
            
            while (drTurnos.Read())
            {
               turnos.Add(Convert.ToDateTime(drTurnos[0]));
            }

            if (turnos.Count() == 0) { throw new Exception("No hay turnos disponibles para este profesional"); }
            drTurnos.Close();

        }

        public void horariosDelDia(DateTime dia)
        {
           listaHorarios = turnos.FindAll(turno => turno.Date == dia.Date);
        }

        public void reservarTurno(DateTime fecha) 
        {
            (new FinalizarPedidoTurno(fecha,nroMedico,nroPaciente)).ShowDialog();
        }
    }
}
