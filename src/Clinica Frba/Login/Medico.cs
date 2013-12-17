using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//necesario para establecer la conexion
using System.Configuration;
using Clinica_Frba.Properties;

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
        public string Clave { get; set; }

        public Medico(long id, string nombre, string apellido, string sexo, string tipo_Documento, long documento, string direccion, long telefono, string mail, DateTime fecha_Nac, long matricula, string username, string clave)
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
            Clave = clave;
        }


        public void Insertar_profesional()//,string Username)

                //Inserta un nuevo afiliado a la base de datos
        {
            SqlConnection miconexion = Conexion.Conectar();//Conecto a la base de datos

            string queryl = "INSERT INTO Free_Running.Medico(Nombre, Apellido, Sexo, Tipo_Documento,Documento ,Direccion, Telefono, Mail, Fecha_nac, Matricula, Username)" +
                  "VALUES(@Nombre, @Apellido, @Sexo, @Tipo_Documento, @Documento, @Direccion,@Telefono,@Mail,@Fecha_nac,@Matricula,@Username)";
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
                cmd.Parameters.AddWithValue("@Fecha_nac", Fecha_Nac);
                cmd.Parameters.AddWithValue("@Matricula", Matricula);
                cmd.Parameters.AddWithValue("@Username", Username);

                cmd.ExecuteNonQuery();

                miconexion.Close();
            }
        }


        public void Insertar_especialidad(long Id, long EspecialidadMedica)//,string Username)

                 //Inserta un nuevo afiliado a la base de datos
        {
            SqlConnection miconexion = Conexion.Conectar();

            string cadena = "INSERT INTO Free_Running.Especialidad_Por_Med(Id, Especialidad_Codigo)" + " VALUES(@Id,@Especialidad)";

            using (miconexion)
            {

                SqlCommand cmd = new SqlCommand(cadena, miconexion);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Especialidad", EspecialidadMedica);

                cmd.ExecuteNonQuery();

                miconexion.Close();

            }
        }

        public void agregar_usuario()
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmm = new SqlCommand(
            "INSERT INTO Free_Running.Usuario(Username,Usuario_Password,Habilitado) values(@Username,@Usuario_Password,@Habilitado)", miConexion);

            cmm.Parameters.AddWithValue("@Username", Username);
            cmm.Parameters.AddWithValue("@Usuario_Password", Clave);
            cmm.Parameters.AddWithValue("@Habilitado", 1);

            cmm.ExecuteNonQuery();
            miConexion.Close();
        }

        static public long obtener_IdMedico(string cadena)
        {
            SqlConnection miconexion = Conexion.Conectar();

            SqlCommand command = new SqlCommand("dbo." + cadena, miconexion);

            using (miconexion)
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto

                command.ExecuteNonQuery();

                int valor = (int)command.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();
                long resultado = (long)Convert.ToUInt32(valor);

                return resultado;
            }
        }

        static public void eliminar_especialidad(long Parametro)
        {

            SqlConnection miconexion = Conexion.Conectar();

            string queryl = "DELETE FROM free_running.Especialidad_Por_Med WHERE  Id= " + Parametro;

            using (miconexion)
            {
                SqlCommand cmd = new SqlCommand(queryl, miconexion);


                cmd.ExecuteNonQuery();

                miconexion.Close();
            }

        }


        static public void actualizar_profesional(long Id, string nombre, string apellido, string sexo, string tipo_Documento, long documento, string direccion, long telefono, string mail, DateTime fecha_Nac, long matricula, string username)
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmm = new SqlCommand(
                                                                                                                                                                                                                                            //Matricula,Username='@username' WHERE Id= " + Id, miConexion);
            "UPDATE Free_Running.Medico SET Nombre=@Nombre,Apellido=@Apellido,Sexo=@Sexo,Tipo_Documento=@Tipo_Documento,Documento=@Documento,Direccion=@Direccion,Telefono=@Telefono,Mail=@Mail,Fecha_Nac=@Fecha_Nac,Matricula=@Matricula,Username=@username WHERE Id= " + Id, miConexion);

            cmm.Parameters.AddWithValue("@Nombre", nombre);
            cmm.Parameters.AddWithValue("@Apellido", apellido);
            cmm.Parameters.AddWithValue("@Sexo", sexo);
            cmm.Parameters.AddWithValue("@tipo_Documento", tipo_Documento);
            cmm.Parameters.AddWithValue("@Documento", documento);
            cmm.Parameters.AddWithValue("@Direccion", direccion);
            cmm.Parameters.AddWithValue("@Telefono", telefono);
            cmm.Parameters.AddWithValue("@Mail", mail);
            cmm.Parameters.AddWithValue("@Fecha_Nac", fecha_Nac);
            cmm.Parameters.AddWithValue("@matricula", matricula);
            cmm.Parameters.AddWithValue("@username", username);

            cmm.ExecuteNonQuery();
            miConexion.Close();

        }
    
    }
}

