using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }

}
