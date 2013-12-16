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
    public partial class Ventana_Desicion : Form
    {
        public bool Bandera;

        public Ventana_Desicion(string pregunta)
        {
            InitializeComponent();
            Bandera = false;
            label1.Text = pregunta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bandera = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bandera = false;
            this.Close();
        }
    }
}
