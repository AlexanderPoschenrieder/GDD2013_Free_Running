using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}

