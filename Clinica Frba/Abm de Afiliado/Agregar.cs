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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente.Insertar_afiliado("Roberto", "Aasdasn", "DNI", 3883833, "av siempre viva", 4450023, "pepe@pepe", DateTime.Today, "Femenino", "Soltero", 4, 555559, "Activo", "pepe003");
        }

    }
}
