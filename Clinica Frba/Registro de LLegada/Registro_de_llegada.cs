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

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class Registro_de_llegada : Form
    {
        public Registro_de_llegada()
        {
            filtro = "";
            InitializeComponent();
            iniciarDGV("Seleccionar", dgvProfecional);
            generarlistaMedico(dgvProfecional, "", tabla);
        }
        
        string filtro;
        string tabla = "select M.Id,M.Nombre,M.Apellido,EP.Descripcion from Free_Running.Medico M join Free_Running.Especialidad_Por_Med EM on (EM.Id = M.Id) join Free_Running.Especialidad EP on (Em.Especialidad_Codigo = EP.Codigo) ";
        public DateTime HsLlegada;
        public UInt32 NroAfiliado;
        public UInt32 Turno;
        public UInt32 BonoConsulta;

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(tbProfecional.Text) && Validar.noVacio(tbEspecialidad.Text))
            {

                filtro = " where (M.Apellido LIKE '%" + tbProfecional.Text + "%' and EP.Descripcion LIKE '%" + tbEspecialidad.Text + "%' )";
            }
            else
            {
                if (Validar.noVacio(tbProfecional.Text))
                {
                    filtro = " WHERE ( M.Apellido LIKE '%" + tbProfecional.Text + "%' )";
                }
                else
                {
                    if (Validar.noVacio(tbEspecialidad.Text))
                    {
                        filtro = " where (EP.Descripcion LIKE '%" + tbEspecialidad.Text + "%' )";
                    }
                    else { MessageBox.Show("Debe completar los campos"); }
                }

            }
            generarlistaMedico(dgvProfecional, filtro, tabla);
        }

        public void iniciarDGV(string boton, DataGridView dgv)
        {
            //M.Id,M.Nombre,M.Apellido,EP.Descripcion
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Id";
            dgv.Columns[1].Name = "Medico Nombre";
            dgv.Columns[2].Name = "Medico Apellido";
            dgv.Columns[3].Name = "Especialidad";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgv.Columns.Add(btn);
            btn.HeaderText = boton;
            btn.Text = boton;
            btn.Name = boton;
            btn.UseColumnTextForButtonValue = true;
        }

        //carga todos loes medicos con sus distintas especialidades
        public void generarlistaMedico(DataGridView dgv, string filtro, string tabla)
        {
            dgv.Rows.Clear();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cMedicos = new SqlCommand(string.Format(tabla + filtro), miConexion);
            SqlDataReader drMedicos = cMedicos.ExecuteReader();


            while (drMedicos.Read())
            {
                int renglon = dgv.Rows.Add();
                dgv.Rows[renglon].Cells["Id"].Value = drMedicos[0];
                dgv.Rows[renglon].Cells["Medico Nombre"].Value = drMedicos[1];
                dgv.Rows[renglon].Cells["Medico Apellido"].Value = drMedicos[2];
                dgv.Rows[renglon].Cells["Especialidad"].Value = drMedicos[3];
            }

            miConexion.Close();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbEspecialidad.Text = "";
            tbProfecional.Text = "";
            generarlistaMedico(dgvProfecional, "", tabla);
        }


        //me manda a la ventana turno llegada
        private void dgvProfecional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int miFila = dgvProfecional.CurrentCell.RowIndex;
                UInt32 miProfecional = Convert.ToUInt32(dgvProfecional.Rows[miFila].Cells["Id"].Value);
                string miEspecialidad = Convert.ToString(dgvProfecional.Rows[miFila].Cells["Especialidad"].Value);
                Turnos_Llegada turnoLlegada = new Turnos_Llegada(miProfecional, miEspecialidad);
                turnoLlegada.ShowDialog();
                this.Hide();
            }
        }




    }
}
