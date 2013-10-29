using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Clinica_Frba.Abm_de_Afiliado
{
    class Paciente
    {
        public static void Insertar_afiliado(string Nombre, string Apellido, string Tipo_documento, long Documento, string Direccion,
            long Telefono, string Mail, DateTime Fecha_nac, string Sexo, string Estado_civil, int Cant_familiares,
            long Plan_medico, string Estado, string Username)

            //Inserta un nuevo afiliado a la base de datos
        {
            SqlConnection miconexion = Conexion.Conectar();//Conecto a la base de datos
            string sel;
            sel = "INSERT INTO Free_Running.Paciente(Nombre,Apellido,Tipo_documento,Documento,Direccion,Telefono,Mail,fecha_nac,Sexo,Estado_civil,Cant_familiares,Plan_medico,Estado)" +//Username
                  "VALUES(@Nombre, @Apellido, @Tipo_documento, @Documento, @Direccion,@Telefono,@Mail,@Fecha_nac,@Sexo,@Estado_civil,@Cant_familiares,@Plan_medico,@estado)"; //@username
            using (miconexion)
            {
                SqlCommand cmd = new SqlCommand(sel, miconexion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Tipo_documento", Tipo_documento);
                cmd.Parameters.AddWithValue("@Documento", Documento);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                cmd.Parameters.AddWithValue("@Fecha_nac", Fecha_nac);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Cant_familiares", Cant_familiares);
                cmd.Parameters.AddWithValue("@Estado_civil", Estado_civil);
                cmd.Parameters.AddWithValue("@Plan_medico", Plan_medico);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                //cmd.Parameters.AddWithValue("@Username", Username);
                cmd.ExecuteNonQuery();
                //int t = Convert.ToInt32(cmd.ExecuteScalar());
                miconexion.Close();
                //return t;
            }

        }
    }
}
