using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Modificar_Afiliado : Form
    {
        public Modificar_Afiliado()
        {
            InitializeComponent();
        }

        private void Modificar_Afiliado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2013DataSet1.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.gD2C2013DataSet1.Paciente);
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Sexotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TipoDoctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void EstadoCivtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Estadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Doctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void CantFamHijtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(NroAfiliadotxt.Text))
            {
                Login.Usuario.filtrar_tabla("Nro_Afiliado", "Paciente", Convert.ToUInt32(NroAfiliadotxt.Text), dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(Nombretxt.Text) & Validar.noVacio(Apellidotxt.Text) & Validar.noVacio(Doctxt.Text) & Validar.noVacio(Directxt.Text) & Validar.noVacio(Teltxt.Text) & Validar.noVacio(Mailtxt.Text) & Validar.noVacio(FechaNactxt.Text) & Validar.noVacio(TipoDoctxt.Text) & Validar.noVacio(CantFamHijtxt.Text) & Validar.noVacio(Estadotxt.Text) & Validar.noVacio(NroAfiliadotxt.Text) & Validar.IsValidEmail(Mailtxt.Text))
            {
                Login.Paciente.actualizar_usuario(Convert.ToUInt32(NroAfiliadotxt.Text), Usertxt.Text);
                Login.Paciente.actualizar_afiliado(Convert.ToUInt32(NroAfiliadotxt.Text), Nombretxt.Text, Apellidotxt.Text, Convert.ToUInt32(Doctxt.Text), Directxt.Text, Convert.ToUInt32(Teltxt.Text), Mailtxt.Text, Convert.ToDateTime(FechaNactxt.Text), Sexotxt.Text, TipoDoctxt.Text, EstadoCivtxt.Text, Convert.ToInt32(CantFamHijtxt.Text), Convert.ToUInt32(PlanMedtxt.Text), Estadotxt.Text);
                this.pacienteTableAdapter.Fill(this.gD2C2013DataSet1.Paciente);
                MessageBox.Show("Afiliado Acualizado de forma exitosa", "Actualizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_campos();
            }


            else
            {
                MessageBox.Show("Completar correctamente los campos ", "Actualizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar_campos();
            }
        }

        private void limpiar_campos()
        {
            NroAfiliadotxt.Clear(); Nombretxt.Clear(); Apellidotxt.Clear(); Doctxt.Clear(); Directxt.Clear(); Teltxt.Clear(); Mailtxt.Clear(); FechaNactxt.Clear(); Sexotxt.SelectedIndex = -1; TipoDoctxt.SelectedIndex = -1; EstadoCivtxt.SelectedIndex = -1; CantFamHijtxt.Clear(); PlanMedtxt.SelectedIndex = -1; Estadotxt.SelectedIndex = -1; Usertxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(FechaNactxt);
            calendario.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int miFila = dataGridView1.CurrentCell.RowIndex;
            NroAfiliadotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[0].Value);
            Nombretxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[1].Value);
            Apellidotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[2].Value);
            Doctxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[3].Value);
            Directxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[4].Value);
            Teltxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[5].Value);
            Mailtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[6].Value);
            FechaNactxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[7].Value);
            Sexotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[8].Value);           
            TipoDoctxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[9].Value);
            EstadoCivtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[10].Value);
            CantFamHijtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[11].Value);
            PlanMedtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[12].Value);
            Estadotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[13].Value);
            Usertxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[14].Value);
        }

        private void NroAfiliadotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

    }
}
