using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class EspMasCanceladas : Form
    {
        public EspMasCanceladas(DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            iniciarDGV();
            cargar(inicio, fin);

        }

        public void cargar(DateTime inicio, DateTime fin)
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = miConexion;
                cmd.CommandText = "Free_Running.EspeMasCanceladas ";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parInicio = cmd.Parameters.Add("@Inicio", SqlDbType.DateTime);
                parInicio.Value = inicio;
                SqlParameter parFin = cmd.Parameters.Add("@Fin", SqlDbType.DateTime);
                parFin.Value = fin;
                SqlDataReader drEstadistica = cmd.ExecuteReader();
                while (drEstadistica.Read())
                {
                    int renglon = dvgTop.Rows.Add();
                    llenardgv(renglon, drEstadistica);

                }
            }
        }

        public void llenardgv(int renglon, SqlDataReader dr)
        {
            dvgTop.Rows[renglon].Cells["Especialidad"].Value = dr[0].ToString();
            dvgTop.Rows[renglon].Cells["Especialidad Nombre"].Value = dr[1].ToString();
            dvgTop.Rows[renglon].Cells["Mes"].Value = dr[2].ToString();
            dvgTop.Rows[renglon].Cells["Cantidad"].Value = dr[3].ToString();
        }

        public void iniciarDGV()
        {
            dvgTop.ColumnCount = 4;
            dvgTop.Columns[0].Name = "Especialidad";
            dvgTop.Columns[1].Name = "Especialidad Nombre";
            dvgTop.Columns[2].Name = "Mes";
            dvgTop.Columns[3].Name = "Cantidad";

        }
    }
}
