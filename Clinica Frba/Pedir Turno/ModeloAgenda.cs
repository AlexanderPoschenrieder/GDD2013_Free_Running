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
            turnosDelMedico();            
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

        //
        //Metodos para ABM Pedir turno
        //
        public void turnosDelMedico()
        {
            miConexion = Conexion.Conectar();             //selecciono los horarios de la agenda del medico que...no esten relacionados con un turno o... que si lo estan, entonces que esten cancelados
            consultaTurnos = new SqlCommand(string.Format("select A.FechaHora_Turno from Free_Running.Agenda A left join Free_Running.Turno T on (T.Fecha = A.FechaHora_Turno)where (T.Numero is null or exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero and TC.Tipo <> 'Sistema')) and  getdate() < A.FechaHora_Turno and A.Medico = {0}", nroMedico), miConexion);
            drTurnos = consultaTurnos.ExecuteReader();
            
            while (drTurnos.Read())
            {
               turnos.Add(Convert.ToDateTime(drTurnos[0]));
            }

            if (turnos.Count() == 0) { MessageBox.Show("No hay Turnos Disponibles"); }
            drTurnos.Close();
        }


        //no va
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

        public void reservarTurno(DateTime fecha) 
        {
            (new FinalizarPedidoTurno(fecha,nroMedico,nroPaciente)).ShowDialog();
        }
    }
}
