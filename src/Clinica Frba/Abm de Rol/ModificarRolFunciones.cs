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
    public partial class ModificarRolFunciones : Form
    {
        public ModificarRolFunciones(string miRol)
        {
            InitializeComponent();
            Rol = miRol;
            tbRol.Text = miRol;
            iniciarDGV("Eliminar", dgvFun);
            iniciarDGV("Agregar", dgvAgregar);
            inicializar(Rol);
           
        }

        public void inicializar(string miRol) 
        {
            dgvFun.Rows.Clear();
            dgvAgregar.Rows.Clear();
            tablaEliminar = "SELECT FxR.Funcionalidad_Id Funcionalidad FROM Free_Running.Funcionalidad_por_Rol FxR WHERE FxR.Rol_Id = '" + Rol + "'";
            tablaAgregar = "SELECT Id Funcionalidad FROM Free_Running.Funcionalidad F Where (not exists (select * from Free_Running.Funcionalidad_por_Rol FxR Where FxR.Rol_Id = '" + Rol + "' and F.Id = FxR.Funcionalidad_Id))";
            cargardatagridview("", tablaEliminar, dgvFun);
            cargardatagridview("", tablaAgregar, dgvAgregar);
            cbEstado.Text = estadoRol(miRol);
        }

        public String estadoRol(string miRol) 
        {
            string rta = "Inhabilitado";
            SqlConnection con = Conexion.Conectar();
            SqlCommand comando = new SqlCommand("select R.Habilitado from Free_Running.Rol R where R.Id = '"+miRol+"'", con);
            SqlDataReader dr;
            dr = comando.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToInt16(dr[0]) == 1) { rta = "Habilitado"; }
            }
            else { MessageBox.Show("Rol Incorrecto"); }

            return rta;

        }


        static public string Rol;

        static public string tablaEliminar;

        static public string tablaAgregar;

        public void iniciarDGV(string boton, DataGridView dgv)
        {
            dgv.ColumnCount = 1;
            dgv.Columns[0].Name = "Funcionalidad";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv.Columns.Add(btn);
            btn.HeaderText = boton;
            btn.Text = boton;
            btn.Name = boton;
            btn.UseColumnTextForButtonValue = true;
        }

        public void cargardatagridview(string filtro, string tabla, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlConnection con = Conexion.Conectar();
            SqlCommand comando = new SqlCommand(tabla + filtro, con);
            SqlDataReader dr;
            dr = comando.ExecuteReader();
            while (dr.Read())
            {   
                int renglon = dgv.Rows.Add();
                dgv.Rows[renglon].Cells["Funcionalidad"].Value = dr.GetSqlString(dr.GetOrdinal("Funcionalidad")).ToString();
            }
        }

        private void dgvFun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SqlConnection con = Conexion.Conectar();
                int miFila = dgvFun.CurrentCell.RowIndex;
                string miFuncionalidad = Convert.ToString(dgvFun.Rows[miFila].Cells["Funcionalidad"].Value);
                SqlCommand RolxUsuario = new SqlCommand("DELETE FROM Free_Running.Funcionalidad_por_Rol WHERE Rol_Id ='" + Rol + "' and Funcionalidad_Id = '"+miFuncionalidad+"'", con);
                RolxUsuario.ExecuteNonQuery();
                cargardatagridview("", tablaEliminar, dgvFun);
                cargardatagridview("", tablaAgregar, dgvAgregar);
            }
        }

        private void dgvAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SqlConnection con = Conexion.Conectar();
                int miFila = dgvAgregar.CurrentCell.RowIndex;
                string miFuncionalidad = Convert.ToString(dgvAgregar.Rows[miFila].Cells["Funcionalidad"].Value);
                SqlCommand RolxUsuario = new SqlCommand("INSERT INTO Free_Running.Funcionalidad_por_Rol(Rol_Id,Funcionalidad_Id)values('" + Rol + "','" + miFuncionalidad + "')", con);
                RolxUsuario.ExecuteNonQuery();
                cargardatagridview("", tablaEliminar, dgvFun);
                cargardatagridview("", tablaAgregar, dgvAgregar);
            }
        }

        private void btLimpiarRol_Click(object sender, EventArgs e)
        {
            tbRol.Text = "";
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(tbRol.Text))
            {
                int estado = 0;
                if (cbEstado.Text == "Habilitado"){estado = 1;}
                SqlConnection con = Conexion.Conectar();

                SqlCommand cRol = new SqlCommand("UPDATE Free_Running.Rol SET Id='" + tbRol.Text + "', Habilitado ='"+estado+"' WHERE Id ='" + Rol + "'", con);
                cRol.ExecuteNonQuery();
                Rol = tbRol.Text;
                inicializar(Rol);
            }
            else { MessageBox.Show("Campo Vacio"); }
        }

        public void buscardgv(string tabla, DataGridView dgv, string buscar, string campo)
        {
            if (Validar.noVacio(buscar))
            {
                string filtro = " and "+ campo +" LIKE '%" + buscar + "%'";
                cargardatagridview(filtro, tabla, dgv);
            }
            else { MessageBox.Show("Campo vacio"); }
        }

        private void btBuscar2_Click(object sender, EventArgs e)
        {
            buscardgv(tablaAgregar, dgvAgregar, tbBuscFunc2.Text, "F.Id");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscardgv(tablaEliminar, dgvFun, tbBuscar1.Text, "FxR.Funcionalidad_Id");
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            inicializar(Rol);
            tbBuscar1.Text = "";
        }

        private void btLimpiar2_Click(object sender, EventArgs e)
        {
            inicializar(Rol);
            tbBuscFunc2.Text = "";
        }
    }
}
