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

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana_agregar = new Form2();
            ventana_agregar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ventana_modificar = new Form3();
            ventana_modificar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ventana_eliminar = new Form4();
            ventana_eliminar.Show();
        }
    }
}
