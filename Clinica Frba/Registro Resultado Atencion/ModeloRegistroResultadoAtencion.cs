using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    class ModeloRegistroResultadoAtencion
    {
        int idAtencion;
        SqlConnection miConexion;
        SqlCommand commandInsert;

        public ModeloRegistroResultadoAtencion(int idAt) {
            idAtencion = idAt;
        }

        public void insertarDatos(String sintomas, String enfermedades){
            String stringInsert="insert into Free_Running.Consulta(Id_Atencion_Medica,Sintomas,Enfermedades) "+
                                    "values('{0}','{1}','{2}')";
            miConexion = Conexion.Conectar();
            commandInsert = new SqlCommand(string.Format(stringInsert,idAtencion,sintomas,enfermedades),miConexion);
            commandInsert.ExecuteNonQuery();

        }
    }
}
