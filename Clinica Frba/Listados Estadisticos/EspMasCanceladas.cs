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
        public EspMasCanceladas(DateTime inicio, DateTime fin , Decimal semestre)
        {
            InitializeComponent();
            iniciarDGV(semestre);
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
            dvgTop.Rows[renglon].Cells[1].Value = Convert.ToInt32(dr[1]);
            dvgTop.Rows[renglon].Cells[2].Value = Convert.ToInt32(dr[2]);
            dvgTop.Rows[renglon].Cells[3].Value = Convert.ToInt32(dr[3]);
            dvgTop.Rows[renglon].Cells[4].Value = Convert.ToInt32(dr[4]);
            dvgTop.Rows[renglon].Cells[5].Value = Convert.ToInt32(dr[5]);
            dvgTop.Rows[renglon].Cells[6].Value = Convert.ToInt32(dr[6]);
        }

        public void iniciarDGV(Decimal semestre)
        {
            dvgTop.ColumnCount = 7;
            dvgTop.Columns[0].Name = "Especialidad";
            if (semestre == 1)
            {
                dvgTop.Columns[1].Name = "Enero";
                dvgTop.Columns[2].Name = "Febrero";
                dvgTop.Columns[3].Name = "Marzo";
                dvgTop.Columns[4].Name = "Abril";
                dvgTop.Columns[5].Name = "Mayo";
                dvgTop.Columns[6].Name = "Junio";
            }
            else
            {
                dvgTop.Columns[1].Name = "Julio";
                dvgTop.Columns[2].Name = "Agosto";
                dvgTop.Columns[3].Name = "Septiembre";
                dvgTop.Columns[4].Name = "Octubre";
                dvgTop.Columns[5].Name = "Noviembre";
                dvgTop.Columns[6].Name = "Diciembre";
            }


        }
    }
}
