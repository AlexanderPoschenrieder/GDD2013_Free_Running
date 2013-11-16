using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;

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

        public ModeloAgenda(UInt32 nro_Medico,int nro_Paciente) {
            nroMedico = nro_Medico;
            nroPaciente = nro_Paciente;
            turnos=new List<DateTime>();
            turnosDelMedico();
            quitarTurnosOcupados();

        }

        public void turnosDelMedico()
        {
            miConexion = Conexion.Conectar();
            consultaTurnos = new SqlCommand(string.Format("select A.Fecha_Inicio,A.Fecha_Fin,AD.Dia_Semana,AD.Hora_Inicio,AD.Hora_Fin from Free_Running.Agenda A join Free_Running.Agenda_Dia AD on (A.Id = AD.Agenda) where A.Medico={0}", nroMedico), miConexion);
            drTurnos = consultaTurnos.ExecuteReader();
            
            while (drTurnos.Read())
            {

                DateTime FechaInicio = Convert.ToDateTime(drTurnos[0]);
                DateTime FechaFin = Convert.ToDateTime(drTurnos[1]);
                DateTime HoraInicio = Convert.ToDateTime(Convert.ToString(drTurnos[3]));
                DateTime HoraFin = Convert.ToDateTime(Convert.ToString(drTurnos[4]));
                String DiaSemana = Convert.ToString(drTurnos[2]);
                DateTime FechaRec;
                DateTime HoraRec;
                FechaRec = (FechaInicio>DateTime.Today)?FechaInicio:DateTime.Today;

                while (FechaRec <= FechaFin)
                {             
                    while (String.Compare(FechaRec.ToString("dddd", new CultureInfo("es-ES")), DiaSemana, true) == 0)
                    {
                        HoraRec = HoraInicio;
                        while (HoraRec <= HoraFin)
                        {                            
                            turnos.Add(new DateTime(FechaRec.Year,FechaRec.Month,FechaRec.Day,HoraRec.Hour,HoraRec.Minute,0));
                            HoraRec = HoraRec.AddMinutes(30);
                        }

                        FechaRec = FechaRec.AddDays(1);
                    }
                    FechaRec = FechaRec.AddDays(1);
                }
            }
            drTurnos.Close();
        }

        public void quitarTurnosOcupados() { 
           String stringComando="select Free_Running.turnoLibre('{0}',{1})";
           SqlCommand ComandoChequearTurno;
           List<DateTime> turnosAux= new List<DateTime>(); 

           miConexion = Conexion.Conectar();
           foreach (DateTime turno in turnos)
           {

               ComandoChequearTurno = new SqlCommand(string.Format(stringComando, turno.ToString("yyyy-dd-MM HH:mm:ss"), nroMedico),miConexion);
               if (Convert.ToInt16(ComandoChequearTurno.ExecuteScalar()) == 1) {
                   turnosAux.Add(turno);
               }
           }
           turnos = turnosAux;
        }

        public void horariosDelDia(DateTime dia)
        {
           listaHorarios = turnos.FindAll(turno => turno.Date == dia.Date);
        }

        public void reservarTurno(DateTime fecha) {
            (new FinalizarPedidoTurno(fecha,nroMedico,nroPaciente)).ShowDialog();
        }
    }
}
