using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Clinica_Frba.Abm_de_Afiliado
{
    class Paciente
    {
        public static int Insertar_afiliado(string Nombre, string Apellido, string Tipo_documento, int Documento, string Direccion,
            int Telefono, string Mail, DateTime Fecha_nac, char Sexo, string Estado_civil, int Cant_familiares,
            int Plan_medico, int Nro_afiliado, string Estado, string Username)

            //Inserta un nuevo afiliado a la base de datos
        {
            SqlConnection miconexion = Conexion.Conectar();//Conecto a la base de datos
            string sel;
            sel = "INSERT INTO Free_Running.Paciente(string Nombre,string Apellido,string Tipo_documento,int Documento,string Direccion,int Telefono,string Mail,DateTime fecha_nac,char Sexo,string Estado_civil,int Cant_familiares,int Plan_medico,int Nro_afiliado,string Estado,string Username)" +
                "VALUES " + "(@Nombre, @Apellido, @Tipo_documento, @Documento, @Direccion,@Telefono,@Mail,@Fecha_nac,@Sexo,@Cant_familiares,@Estado_civil,@Plan_medico,@nro_afiliado,@estado,@username)" +
                "SELECT @@Identity";
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
                cmd.Parameters.AddWithValue("@Nro_afiliado", Nro_afiliado);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@Username", Username);
                int t = Convert.ToInt32(cmd.ExecuteScalar());
                miconexion.Close();
                return t;
            }

        }
    }
}
