using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public class ModeloAtencion
    {
        DateTime fecha = DateTime.Today;
        SqlConnection miConexion;
        SqlCommand commandInsert;

        public int llegadaId;

        public ModeloAtencion(int idLlegada) {
            llegadaId = idLlegada;
        }

        public int confirmarAtencion(String confirmacion){
            miConexion = Conexion.Conectar();
            int idAtencion;
            String miString = string.Format("insert into Free_Running.Atencion_Medica(Llegada_Id,Fecha_Hs,Confirmacion)  output cast(inserted.Id as int) as IdNuevo values({0},'{1}','{2}')",
                                                    llegadaId,fecha.ToString("yyyy-MM-dd HH:mm:ss"), confirmacion);
            commandInsert = new SqlCommand(miString, miConexion);
            idAtencion = (Int32)commandInsert.ExecuteScalar();//Devuelve el numero de atencion
            miConexion.Close();
            return (int)idAtencion;
        }

    }
}
