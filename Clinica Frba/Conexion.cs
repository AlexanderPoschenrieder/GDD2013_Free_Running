using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Clinica_Frba.Properties;

namespace Clinica_Frba
{
    class Conexion
    {
        public static string obtenerString()
        {
            return Settings.Default.GD2C2013ConnectionString;
        }

        public static SqlConnection Conectar()
        {
            SqlConnection miConexion = new SqlConnection(obtenerString());
            miConexion.Open();
            return miConexion;

        }

    }
}
