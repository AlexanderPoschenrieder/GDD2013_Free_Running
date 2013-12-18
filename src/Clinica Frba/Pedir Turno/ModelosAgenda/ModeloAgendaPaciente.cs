using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;

namespace Clinica_Frba.Pedir_Turno
{
    class ModeloAgendaPaciente: ModeloAgenda
    {
        public ModeloAgendaPaciente(UInt32 nro_Medico,int nro_Paciente)
        {
            nroMedico = nro_Medico;
            nroPaciente = nro_Paciente;
            turnos=new List<DateTime>();
            turnosDelMedico();
        }
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

        public override void horariosDelDia(DateTime dia)
        {
           listaHorarios = turnos.FindAll(turno => turno.Date == dia.Date);
        }

        public override void reservarTurno(DateTime fecha) 
        {
            (new FinalizarPedidoTurno(fecha,nroMedico,nroPaciente)).ShowDialog();
        }

        //La herencia obliga a implementar
        public override void cancelarListaTurnos(DateTime horaInicio, DateTime horaFin) { }
    }
}
