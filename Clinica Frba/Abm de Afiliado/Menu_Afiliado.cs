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
    public partial class Menu_Afiliado : Form
    {
        public Menu_Afiliado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_Afiliado afiliado = new Agregar_Afiliado();
            afiliado.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar_Afiliado afiliado = new Modificar_Afiliado();
            afiliado.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar_Afiliado afiliado = new Eliminar_Afiliado();
            afiliado.ShowDialog();
        }


        
    }
}
