using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class FinalizarPedidoTurno : Form
    {
        ModeloRegistrarTurno miModelo;
        List<int> idEspecialidades= new List<int>();
        public FinalizarPedidoTurno(DateTime fechaTurno,UInt32 nroMedico,int nroPaciente)
        {
            InitializeComponent();
            button1.Enabled = false;
            miModelo= new ModeloRegistrarTurno(fechaTurno,nroPaciente,nroMedico);


            while(miModelo.dr_espec.Read()) {
                comboEspecialidades.Items.Add(miModelo.dr_espec[0]);
                idEspecialidades.Add(Convert.ToInt32(miModelo.dr_espec[1]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miModelo.generarTurno(idEspecialidades[comboEspecialidades.SelectedIndex]);
            MessageBox.Show("Su turno ha sido cargado con éxito");
            this.Close();
        }

        private void comboEspecialidades_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }



    }
}
