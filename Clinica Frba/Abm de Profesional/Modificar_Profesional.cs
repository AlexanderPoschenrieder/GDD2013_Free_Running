using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class Modificar_Profesional : Form
    {
        public Modificar_Profesional()
        {
            InitializeComponent();
        }

        private void Modificar_Profesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2013DataSet.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter.Fill(this.gD2C2013DataSet.Medico);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(FechaNactxt);
            calendario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(Nombretxt.Text) & Validar.noVacio(Apellidotxt.Text) & Validar.noVacio(Doctxt.Text) & Validar.noVacio(Directxt.Text) & Validar.noVacio(Teltxt.Text) & Validar.noVacio(Mailtxt.Text) & Validar.noVacio(FechaNactxt.Text) & Validar.noVacio(TipoDoctxt.Text) & Validar.noVacio(Matriculatxt.Text) & Validar.noVacio(Usertxt.Text) & Validar.noVacio(Sexotxt.Text) & Validar.IsValidEmail(Mailtxt.Text) & Validar.noVacio(Idtxt.Text))
            {


                Login.Medico.actualizar_usuario(Convert.ToUInt32(Idtxt.Text), Usertxt.Text);
                Login.Medico.actualizar_profesional(Convert.ToUInt32(Idtxt.Text), Nombretxt.Text, Apellidotxt.Text, Sexotxt.Text, TipoDoctxt.Text, Convert.ToUInt32(Doctxt.Text), Directxt.Text, Convert.ToUInt32(Teltxt.Text), Mailtxt.Text, Convert.ToDateTime(FechaNactxt.Text), Convert.ToUInt32(Matriculatxt.Text), Usertxt.Text);
                this.medicoTableAdapter.Fill(this.gD2C2013DataSet.Medico);
                MessageBox.Show("Profesional Acualizado de forma exitosa", "Actualizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_campos();
            }


            else
            {
                MessageBox.Show("Completar correctamente los campos ", "Actualizacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar_campos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(Idtxt.Text))
            { Login.Usuario.filtrar_tabla("Id", "Medico", Convert.ToUInt32(Idtxt.Text), dataGridView1); }
        }

        public void limpiar_campos()
        {
            Idtxt.Clear(); Nombretxt.Clear(); Apellidotxt.Clear(); Sexotxt.SelectedIndex = -1; TipoDoctxt.SelectedIndex = -1; Doctxt.Clear(); Directxt.Clear(); Teltxt.Clear(); Mailtxt.Clear(); FechaNactxt.Clear(); Matriculatxt.Clear(); Usertxt.Clear();
        }

        private void Idtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Matriculatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void FechaNactxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Doctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int miFila = dataGridView1.CurrentCell.RowIndex;
            Idtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[0].Value);
            Nombretxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[1].Value);
            Apellidotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[2].Value);
            Sexotxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[3].Value);
            TipoDoctxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[4].Value);
            Doctxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[5].Value);
            Directxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[6].Value);
            Teltxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[7].Value);
            Mailtxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[8].Value);
            FechaNactxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[9].Value);
            Matriculatxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[10].Value);
            Usertxt.Text = Convert.ToString(dataGridView1.Rows[miFila].Cells[11].Value);
                
        }

    }
}
