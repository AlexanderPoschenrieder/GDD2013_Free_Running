using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Clinica_Frba
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection Conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2008;Initial Catalog=GD2C2013;Persist Security Info=True;User ID=gd;Password=gd2013");
            Conexion.Open();
            try
            {
                //CONEXION EXITOSA
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion Fallida"); //se lo podes sacar
            }
            return Conexion;
        }
    }
}
