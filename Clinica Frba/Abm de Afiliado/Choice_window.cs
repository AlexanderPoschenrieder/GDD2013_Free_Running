using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//necesario para establecer la conexion
using System.Configuration;//necesario para establecer la conexion
using Clinica_Frba.Properties;//necesario para establecer la conexion
using Clinica_Frba.Login;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Choice_window : Form
    {


        public Choice_window(string agregar)
        {
            InitializeComponent();
            label1.Text = agregar;
            R = false;
        }

        public bool R;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            R = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = true;
            this.Close();
            //Agregar_Afiliado afiliado = new Agregar_Afiliado();
            //Paciente.actualizar_NroAfiliado(afiliado.obtener_NroAfiliado());
        }




    }
}
