using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

//NO-VA

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    class ModeloRegistroResultadoAtencion
    {
        int idAtencion;
        SqlConnection miConexion;
        SqlCommand commandInsert;

        public ModeloRegistroResultadoAtencion(int idAt) {
            idAtencion = idAt;
            insertarDatos();
        }

        public void insertarDatos(){
            UInt32 idConsulta;
            String stringInsert = "insert into Free_Running.Consulta(Id_Atencion_Medica) output cast(inserted.Id as int) " +
                                    "values({0})";
            miConexion = Conexion.Conectar();
            commandInsert = new SqlCommand(string.Format(stringInsert,idAtencion),miConexion);
            idConsulta = Convert.ToUInt32(commandInsert.ExecuteScalar());
            Clinica_Frba.Generar_Receta.Receta receta = new Clinica_Frba.Generar_Receta.Receta(idConsulta,idAtencion);
            receta.ShowDialog();
        }
    }
}
