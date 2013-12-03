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

namespace Clinica_Frba.Generar_Receta
{
    public partial class Medicamentos : Form
    {
        public Medicamentos(crearReceta crearReceta)
        {
            ventanaCrearReceta = crearReceta;
            tabla = "select * from Free_Running.Medicamento";
            filtro = "";
            InitializeComponent();
            iniciarDGV(dgvMedicamento);
            mostrarMedicamentos(dgvMedicamento, tabla, "");

        }
        crearReceta ventanaCrearReceta;
        public void iniciarDGV(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            dgv.Columns[0].Name = "Id";
            dgv.Columns[1].Name = "Medicamento";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv.Columns.Add(btn);
            btn.HeaderText = "Seleccionar";
            btn.Text = "Seleccionar";
            btn.Name = "Seleccionar";
            btn.UseColumnTextForButtonValue = true;

        }

        public void mostrarMedicamentos(DataGridView dgv, string tabla, string filtro)
        {
            dgv.Rows.Clear();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cTurno = new SqlCommand(string.Format(tabla + filtro), miConexion);
            SqlDataReader drTurno = cTurno.ExecuteReader();
            while (drTurno.Read())
            {
                int renglon = dgv.Rows.Add();
                dgv.Rows[renglon].Cells["Id"].Value = drTurno[0];
                dgv.Rows[renglon].Cells["Medicamento"].Value = drTurno[1];
            }
        }

        string tabla;
        string filtro;

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(tbMedica.Text)) 
            {
                filtro = " where ( Medicamento LIKE '%" + tbMedica.Text + "%')";
            }
            
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbMedica.Text = "";
            mostrarMedicamentos(dgvMedicamento, tabla, "");
        }

        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int miFila = dgvMedicamento.CurrentCell.RowIndex;
                UInt32 id = Convert.ToUInt32(dgvMedicamento.Rows[miFila].Cells["Id"].Value);
                string Medicamento = Convert.ToString(dgvMedicamento.Rows[miFila].Cells["Medicamento"].Value);
                ventanaCrearReceta.tbMedicamento.Text = Medicamento;
                ventanaCrearReceta.idMedicamento = id;
                this.Close();
            }
        }

    }
}
