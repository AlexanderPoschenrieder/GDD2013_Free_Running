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
            UInt32 idConsulta;
            String stringInsert = "insert into Free_Running.Consulta(Id_Atencion_Medica,Sintomas,Enfermedades) output cast(inserted.Id as int) " +
                                    "values({0},'{1}','{2}')";
            miConexion = Conexion.Conectar();
            commandInsert = new SqlCommand(string.Format(stringInsert,idAtencion,sintomas,enfermedades),miConexion);
            idConsulta = Convert.ToUInt32(commandInsert.ExecuteScalar());
            Clinica_Frba.Generar_Receta.Receta receta = new Clinica_Frba.Generar_Receta.Receta(idConsulta,idAtencion);
            receta.ShowDialog();
        }
    }
}
