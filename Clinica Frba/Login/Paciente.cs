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
    public class Paciente : Usuario
    {
        public long Nro_Afiliado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Documento { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public string Mail { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Sexo { get; set; }
        public string Tipo_Documento { get; set; }
        public string Estado_Civil { get; set; }
        public int Cant_Familiares { get; set; }
        public long Plan_Medico { get; set; }
        public string Estado { get; set; }
        public string Username { get; set; }

        public Paciente(long nA, string nombre, string apellido, long documento, string direccion, long telefono, string mail, DateTime fecha_Nac, string sexo, string tipo_Documento, string estado_Civil, int cant_Familiares, long plan_Medico, string estado, string username)
        {
            Nro_Afiliado = nA;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Direccion = direccion;
            Telefono = telefono;
            Mail = mail;
            Fecha_Nac = fecha_Nac;
            Sexo = sexo;
            Tipo_Documento = tipo_Documento;
            Estado_Civil = estado_Civil;
            Cant_Familiares = cant_Familiares;
            Plan_Medico = plan_Medico;
            Estado = estado;
            Username = username;
        }



     


        public long insertarAFiliadoConFamilia()
        {
            long nro = 0;
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmm = new SqlCommand(
            "SET IDENTITY_INSERT Free_Running.Paciente ON INSERT INTO Free_Running.Paciente(Nro_Afiliado,Nombre,Apellido,Documento,Direccion,Telefono,Mail,Fecha_Nac,Sexo,Tipo_Documento,Estado_Civil,Cant_Familiares,Plan_Medico,Estado) values(@Nro_Afiliado,@Nombre,@Apellido,@Documento,@Direccion,@Telefono,@Mail,@Fecha_Nac,@Sexo,@Tipo_Documento,@Estado_Civil,@Cant_Familiares,@Plan_Medico,@Estado)", miConexion);
            cmm.Parameters.AddWithValue("@Nro_Afiliado", (this.Nro_Afiliado));
            cmm.Parameters.AddWithValue("@Nombre", (this.Nombre));
            cmm.Parameters.AddWithValue("@Apellido", (this.Apellido));
            cmm.Parameters.AddWithValue("@Documento", (this.Documento));
            cmm.Parameters.AddWithValue("@Direccion", (this.Direccion));
            cmm.Parameters.AddWithValue("@Telefono", (this.Telefono));
            cmm.Parameters.AddWithValue("@Mail", (this.Mail));
            cmm.Parameters.AddWithValue("@Fecha_Nac", (this.Fecha_Nac));
            cmm.Parameters.AddWithValue("@Sexo", (this.Sexo));
            cmm.Parameters.AddWithValue("@Estado_Civil", (this.Estado_Civil));
            cmm.Parameters.AddWithValue("@Tipo_Documento", (this.Tipo_Documento));
            cmm.Parameters.AddWithValue("@Cant_Familiares", (this.Cant_Familiares));
            cmm.Parameters.AddWithValue("@Plan_Medico", (this.Plan_Medico));
            cmm.Parameters.AddWithValue("@Estado", (this.Estado));
            cmm.ExecuteNonQuery();
            miConexion.Close();
            return this.Nro_Afiliado;
        }








        public static long actualizar_NroAfiliado(long Nro_Afiliado_Actual)
        {
            long Nro_Modificado = Nro_Afiliado_Actual + 1;
            SqlConnection miconexion = Conexion.Conectar();
            /*SqlCommand cmd = new SqlCommand("UPDATE Free_Running.Paciente SET Nro_Afiliado= " + Nro_Modificado + " WHERE Nro_Afiliado =" + Nro_Afiliado_Actual, miconexion);*/
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Free_Running.Paciente ON UPDATE Free_Running.Paciente SET Nro_Afiliado= " + Nro_Modificado + " WHERE Nro_Afiliado =" + Nro_Afiliado_Actual + " SET IDENTITY_INSERT Free_Running.Paciente OFF ", miconexion);
            using (miconexion)
            {
                cmd.ExecuteNonQuery();
                miconexion.Close();
                return Nro_Modificado;


            }
        }
    
    }
}
