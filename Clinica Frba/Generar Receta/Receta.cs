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


namespace Clinica_Frba.Generar_Receta
{
    public partial class Receta : Form
    {
        public Receta(UInt32 idConsulta,int unidAtencion)
        {
            InitializeComponent();
            consulta = idConsulta;
            idAtencion = unidAtencion;
        }

        public static UInt32 consulta;
        public static int idAtencion;

        private void button1_Click(object sender, EventArgs e)
        {

            //
            Clinica_Frba.Generar_Receta.crearReceta crearReceta = new crearReceta(consulta,miAfiliado());
        }


        static UInt32 miAfiliado()
        {
            SqlConnection miconexion = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("dbo.afiliadoAtencionMedica", miconexion);
            using (miconexion)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros si los hubieran
                cmd.Parameters.AddWithValue("@atencionMedica", idAtencion);
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue;//Valor devuelto
                cmd.ExecuteNonQuery();
                UInt32 idAfiliado = (UInt32)cmd.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();
                return idAfiliado;
            }
        }
    }
}
