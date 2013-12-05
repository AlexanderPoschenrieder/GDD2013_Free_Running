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
    public partial class AfiliadoBFvenc : Form
    {
        public AfiliadoBFvenc(DateTime inicio, DateTime fin, Decimal semestre)
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
                cmd.CommandText = "Free_Running.AfiliadoBFvenc";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parInicio = cmd.Parameters.Add("@Inicio", SqlDbType.DateTime);
                parInicio.Value = inicio;
                SqlParameter parFin = cmd.Parameters.Add("@Fin", SqlDbType.DateTime);
                parFin.Value = fin;
                SqlDataReader drEstadistica = cmd.ExecuteReader();
                while (drEstadistica.Read())
                {
                    int renglon = dgvTop.Rows.Add();
                    llenardgv(renglon, drEstadistica);

                }
            }
        }

        public void llenardgv(int renglon, SqlDataReader dr)
        {
            dgvTop.Rows[renglon].Cells["Afiliado"].Value = dr[0].ToString();
            dgvTop.Rows[renglon].Cells["Nombre"].Value = dr[1].ToString();
            dgvTop.Rows[renglon].Cells["Apellido"].Value = dr[2].ToString();
            dgvTop.Rows[renglon].Cells[3].Value = Convert.ToInt32(dr[3]);
            dgvTop.Rows[renglon].Cells[4].Value = Convert.ToInt32(dr[4]);
            dgvTop.Rows[renglon].Cells[5].Value = Convert.ToInt32(dr[5]);
            dgvTop.Rows[renglon].Cells[6].Value = Convert.ToInt32(dr[6]);
            dgvTop.Rows[renglon].Cells[7].Value = Convert.ToInt32(dr[7]);
            dgvTop.Rows[renglon].Cells[8].Value = Convert.ToInt32(dr[8]);
        }

        public void iniciarDGV(Decimal semestre)
        {
            dgvTop.ColumnCount = 9;
            dgvTop.Columns[0].Name = "Afiliado";
            dgvTop.Columns[1].Name = "Nombre";
            dgvTop.Columns[2].Name = "Apellido";
            if (semestre == 1)
            {
                dgvTop.Columns[3].Name = "Enero";
                dgvTop.Columns[4].Name = "Febrero";
                dgvTop.Columns[5].Name = "Marzo";
                dgvTop.Columns[6].Name = "Abril";
                dgvTop.Columns[7].Name = "Mayo";
                dgvTop.Columns[8].Name = "Junio";
            }
            else
            {
                dgvTop.Columns[3].Name = "Julio";
                dgvTop.Columns[4].Name = "Agosto";
                dgvTop.Columns[5].Name = "Septiembre";
                dgvTop.Columns[6].Name = "Octubre";
                dgvTop.Columns[7].Name = "Noviembre";
                dgvTop.Columns[8].Name = "Diciembre";
            }

        }

    }
}
