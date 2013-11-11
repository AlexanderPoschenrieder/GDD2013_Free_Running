using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;


namespace Clinica_Frba.Cancelar_Atencion
{
    class ModeloMotivoCancelacion
    {
        SqlConnection miConexion;
        SqlCommand miCommand;
        public List<String> listaMotivos{get;set;}

        public ModeloMotivoCancelacion() {
            levantarDatos();
        }

        public void levantarDatos(){
            SqlDataReader dr_Tipo; 
            String stringCommand = "select * from Free_Running.Tipo_Cancelado";
            listaMotivos = new List<String>();
            miConexion= Conexion.Conectar();
            miCommand = new SqlCommand(stringCommand, miConexion);
            dr_Tipo = miCommand.ExecuteReader();
            while (dr_Tipo.Read()) {
                listaMotivos.Add((string)dr_Tipo.GetString(0));
            }
            dr_Tipo.Close();
            miConexion.Close();

        }
      
    }
}
