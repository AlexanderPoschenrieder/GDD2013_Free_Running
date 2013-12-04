using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Clinica_Frba.Pedir_Turno
{
    class ModeloRegistrarTurno
    {
        SqlConnection miConexion;
        SqlCommand commandEspec;
        public SqlDataReader dr_espec { get; set; }
        SqlCommand commandInsert;
        UInt32 nro_medico;
        int nro_paciente;
        DateTime fechaHora;

        public ModeloRegistrarTurno(DateTime fechaTurno,int nroPaciente, UInt32 nroMedico) {
            nro_paciente = nroPaciente;
            nro_medico = nroMedico;
            miConexion = Conexion.Conectar();
            fechaHora = fechaTurno;
            
            commandEspec = new SqlCommand(
                string.Format("select e.Descripcion,e.Codigo from Free_Running.Medico m join Free_Running.Especialidad_Por_Med em on (em.Id=m.Id)"
                + "left join Free_Running.Especialidad e on (e.Codigo=em.Especialidad_Codigo)"
                + "where m.Id={0}", nro_medico), miConexion);
            dr_espec = commandEspec.ExecuteReader();
        }

        public void generarTurno(int idEspec) {
            String stringInsert= string.Format(
                "insert into Free_Running.Turno(Fecha,Nro_Afiliado,Especialidad_Codigo,Medico_Id,Numero)"+
                "values(cast('{0}' as DateTime),{1},{2},{3},(select (MAX(Numero) + 1) from Free_Running.Turno))",
                    fechaHora.ToString("yyyy-dd-MM HH:mm:ss"),
                    nro_paciente,
                    idEspec,
                    nro_medico);

            commandInsert = new SqlCommand(stringInsert, Conexion.Conectar());
            commandInsert.ExecuteNonQuery();
        
        }
        
    }
}
