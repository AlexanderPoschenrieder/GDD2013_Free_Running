using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Clinica_Frba.Cancelar_Atencion
{
    class ModeloCancelarAtencion
    {
        int id_paciente;
        public SqlDataReader dr_turnos{get;set;}
        SqlConnection miConexion;
        SqlCommand miCommand;

        public ModeloCancelarAtencion(int id_pac) 
        {
            id_paciente = id_pac;
            obtenerTurnos();
        }

        public void obtenerTurnos()
        {
            String stringCommand = string.Format("select Numero, Fecha,Descripcion from Free_Running.turnosDePaciente({0}) order by Fecha desc", id_paciente);

            miConexion = Conexion.Conectar();
            miCommand = new SqlCommand(stringCommand, miConexion);
            dr_turnos = miCommand.ExecuteReader();
        }
    }
}
