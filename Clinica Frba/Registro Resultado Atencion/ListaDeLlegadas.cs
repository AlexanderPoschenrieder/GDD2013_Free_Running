using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class ListaDeLlegadas : Form
    {
        UInt32 id_medico;
        public ListaDeLlegadas(UInt32 idMedico)
        {
            id_medico=idMedico;
            InitializeComponent();
            dataGridLlegadas.MultiSelect = false;
            dataGridLlegadas.ReadOnly = true;
            llenarGrid();
        }

        private void ListaDeLlegadas_Load(object sender, EventArgs e)
        {

        }

        public void llenarGrid() {
            SqlConnection conexion = Conexion.Conectar();
            string stringConsulta = "select * from Free_Running.llegadasTurnos({0}) " +
                "order by Fecha_Hs_Llegada asc";
            SqlCommand consulta = new SqlCommand(String.Format(stringConsulta,id_medico),conexion);
            SqlDataReader dr_llegadas= consulta.ExecuteReader();

            dataGridLlegadas.Rows.Clear();
            while (dr_llegadas.Read())
            {
                dataGridLlegadas.Rows.Add(new Object[]{      
                    dr_llegadas.GetDateTime(0),
                    dr_llegadas.GetString(1),
                    Convert.ToInt32(dr_llegadas.GetValue(2))
                });
            }
            dataGridLlegadas.Update();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridLlegadas.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione al paciente buscado");
            }
            else
            {
                int index = (int)dataGridLlegadas.SelectedCells[0].RowIndex;
                int idLlegada = Convert.ToInt32(dataGridLlegadas.Rows[index].Cells["Id"].Value);
                AtencionForm ventana = new AtencionForm(idLlegada);
                ventana.ShowDialog();
                llenarGrid();
            }
        }
    }
}
