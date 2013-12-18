using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;

namespace Clinica_Frba.Pedir_Turno
{
    class ModeloAgendaMedico : ModeloAgenda
    {
        public ModeloAgendaMedico(UInt32 nro_Medico)
        {
            nroMedico = nro_Medico;
            turnos = new List<DateTime>();
            agendaDelMedico();
        }

        public override void cancelarListaTurnos(DateTime primerFecha, DateTime segundaFecha)
        {
            List<String> diasACancelar = new List<string>();

            while (primerFecha <= segundaFecha)
            {
                diasACancelar.Add(primerFecha.ToString("yyyy-dd-MM HH:mm:ss"));
                primerFecha = primerFecha.AddDays(1);
            }
            (new Clinica_Frba.Cancelar_Atencion.MotivoCancelacionForm(diasACancelar, nroMedico)).ShowDialog();
        }
        public void agendaDelMedico()
        {
            miConexion = Conexion.Conectar();             //selecciono los horarios de la agenda del medico
            consultaTurnos = new SqlCommand(string.Format("select a.FechaHora_Turno from Free_Running.agenda a where a.Medico = {0}", nroMedico), miConexion);
            drTurnos = consultaTurnos.ExecuteReader();

            while (drTurnos.Read())
            {
                turnos.Add(Convert.ToDateTime(drTurnos[0]));
            }

        }

        //Obliga la herencia a implementar
        public override void horariosDelDia(DateTime hora){}
        public override void reservarTurno(DateTime fechaHora) { }
    }
}
