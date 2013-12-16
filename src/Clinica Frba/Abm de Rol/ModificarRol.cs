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
    public partial class ModificarRol : Form
    {
        public ModificarRol()
        {
            InitializeComponent();
        }

        string tabla = "SELECT Id FROM Free_Running.Rol";

        public void iniciarDGV()
        {
            dgvRol.ColumnCount = 1;
            dgvRol.Columns[0].Name = "Rol";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvRol.Columns.Add(btn);
            btn.HeaderText = "Modificar";
            btn.Text = "Modificar";
            btn.Name = "Modificar";
            btn.UseColumnTextForButtonValue = true;
        }
        public void llenardgv(int renglon, SqlDataReader dr)
        {
            dgvRol.Rows[renglon].Cells["Rol"].Value = dr.GetSqlString(dr.GetOrdinal("Id")).ToString();
        }

        public void cargardatagridview(string filtro, string tabla)
        {
            SqlConnection con = Conexion.Conectar();
            SqlCommand comando = new SqlCommand(tabla+filtro, con);
            dgvRol.Rows.Clear();
            SqlDataReader dr;
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgvRol.Rows.Add();
                llenardgv(renglon, dr);

            }

        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            iniciarDGV();
            cargardatagridview("", tabla);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cargardatagridview("", tabla);
            tbRol.Text = "";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(tbRol.Text))
            {  
                string filtro = " where Id LIKE '%" +tbRol.Text +"%'";
                cargardatagridview(filtro, tabla);
            }
            else { MessageBox.Show("Campo vacio"); }
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int miFila = dgvRol.CurrentCell.RowIndex;
                string miRol = Convert.ToString(dgvRol.Rows[miFila].Cells["Rol"].Value);
                ModificarRolFunciones modificarFun = new ModificarRolFunciones(miRol);
                modificarFun.ShowDialog();
                this.Hide();
            }
        }
        









    }
}
