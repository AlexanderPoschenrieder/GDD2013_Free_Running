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
    abstract class ModeloAgenda
    {
        public UInt32 nroMedico;
        public int nroPaciente;
        public SqlConnection miConexion;
        public SqlCommand consultaTurnos;
        public SqlDataReader drTurnos;
        public List<DateTime> turnos { get; set; }
        public List<DateTime> listaHorarios { get; set; }

        public ModeloAgenda() { }

        abstract public void horariosDelDia(DateTime hora);
        abstract public void reservarTurno(DateTime fechaHora);
        abstract public void cancelarListaTurnos(DateTime horaInicio,DateTime horaFin);
    }
 
}
