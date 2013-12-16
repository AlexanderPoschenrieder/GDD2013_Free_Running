using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();

        }

        string tabla = "SELECT Id FROM Free_Running.Rol WHERE Habilitado = 1";

        public void iniciarDGV()
        {
            dgvRol.ColumnCount = 1;
            dgvRol.Columns[0].Name = "Rol";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvRol.Columns.Add(btn);
            btn.HeaderText = "Eliminar";
            btn.Text = "Eliminar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        public void llenardgv(int renglon, SqlDataReader dr) 
        {
            dgvRol.Rows[renglon].Cells["Rol"].Value = dr.GetSqlString(dr.GetOrdinal("Id")).ToString();
        }

        public void cargardatagridview(string filtro, string tabla)
        {
            SqlConnection con = Conexion.Conectar();
            SqlCommand comando = new SqlCommand(tabla + filtro, con);
            dgvRol.Rows.Clear();
            SqlDataReader dr;
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvRol.Rows.Add();
                llenardgv(renglon, dr);

            }

        }

        private void BajaRol_Load_1(object sender, EventArgs e)
        {
            iniciarDGV();
            cargardatagridview("", tabla);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cargardatagridview("", tabla);
            textBox1.Text = "";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(textBox1.Text))
            {
                string filtro = " and Id LIKE '%" + textBox1.Text + "%'";
                cargardatagridview(filtro, tabla);
            }
            else { MessageBox.Show("Campo vacio"); }
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SqlConnection con = Conexion.Conectar();
                int miFila = dgvRol.CurrentCell.RowIndex;
                string miRol = Convert.ToString(dgvRol.Rows[miFila].Cells["Rol"].Value);
                SqlCommand eliminar = new SqlCommand("UPDATE Free_Running.Rol SET Habilitado = 0 WHERE Id ='" + miRol + "'", con);
                eliminar.ExecuteNonQuery();
                MessageBox.Show("Rol Eliminado con Exito");
                SqlCommand RolxUsuario = new SqlCommand("DELETE FROM Free_Running.Usuario_por_Rol  WHERE Rol_Id ='" + miRol + "'", con);
                RolxUsuario.ExecuteNonQuery();
                cargardatagridview("", tabla);
            }
        }






    }
}
