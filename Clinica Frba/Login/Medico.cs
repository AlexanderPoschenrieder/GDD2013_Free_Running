using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//necesario para establecer la conexion
using System.Configuration;//necesario para establecer la conexion
using Clinica_Frba.Properties;//necesario para establecer la conexion

namespace Clinica_Frba.Login
{
    public class Medico : Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Documento { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Sexo { get; set; }
        public string Tipo_Documento { get; set; }
        public long Matricula { get; set; }
        public string Username { get; set; }

        public Medico(long id, string nombre, string apellido, string sexo, string tipo_Documento, long documento, string direccion, long telefono, string mail, DateTime fecha_Nac, long matricula, string username)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Direccion = direccion;
            Telefono = telefono;
            Mail = mail;
            Fecha_Nac = fecha_Nac;
            Sexo = sexo;
            Tipo_Documento = tipo_Documento;
            Matricula = matricula;
            Username = username;
        }


        public static void Insertar_profesional(string Nombre, string Apellido, string Sexo, String Tipo_Documento, long Documento, string Direccion,
                 long Telefono, string Mail, DateTime Fecha_nac)//,string Username)

                 //Inserta un nuevo afiliado a la base de datos
        {
            SqlConnection miconexion = Conexion.Conectar();//Conecto a la base de datos

            string queryl = "INSERT INTO Free_Running.Medico(Nombre, Apellido, Sexo, Tipo_Documento,Documento ,Direccion, Telefono, Mail, Fecha_nac)" +//Username
                  "VALUES(@Nombre, @Apellido, @Sexo, @Tipo_Documento, @Documento, @Direccion,@Telefono,@Mail,@Fecha_nac)"; //@username
            using (miconexion)
            {
                SqlCommand cmd = new SqlCommand(queryl, miconexion);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Apellido);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Tipo_Documento", Tipo_Documento);
                cmd.Parameters.AddWithValue("@Documento", Documento);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                cmd.Parameters.AddWithValue("@Fecha_nac", Fecha_nac);

                cmd.ExecuteNonQuery();

                miconexion.Close();
            }
        }
    
    }
}

