using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Clinica_Frba.Pedir_Turno
{
    class AgendaModelo
    {
        int idProf {get;set;}
        SqlConnection miConexion;
        SqlDataReader dr_agenda;
        SqlCommand miCommand;
        List<DateTime> diasAgenda; 
        String stringConsulta;

        public AgendaModelo(int id_Prof) {
            idProf = id_Prof;
            generarAgenda();
        }

        public void generarAgenda(){
            miConexion= Conexion.Conectar();
            stringConsulta = string.Format("select * from Free_Running.diasAtencionMedico({0})", idProf);
            miCommand = new SqlCommand(stringConsulta, miConexion);
            dr_agenda = miCommand.ExecuteReader();
        }


    }
}
