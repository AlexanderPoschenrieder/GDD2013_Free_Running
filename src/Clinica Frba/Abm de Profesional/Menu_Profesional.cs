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
    public partial class Menu_Profesional : Form
    {
        public Menu_Profesional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_de_Profesional.Agregar_Profesional profesional = new Clinica_Frba.Abm_de_Profesional.Agregar_Profesional();
            profesional.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_de_Profesional.Modificar_Profesional profesional = new Clinica_Frba.Abm_de_Profesional.Modificar_Profesional();
            profesional.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Abm_de_Profesional.Eliminar_Profesional profesional = new Clinica_Frba.Abm_de_Profesional.Eliminar_Profesional();
            profesional.ShowDialog();
        }
    }
}
