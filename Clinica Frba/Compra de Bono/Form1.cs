using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class CompraBonoForm : Form
    {
        private Clinica_Frba.Compra_de_Bono.CompraBonoModel modelo;
        private int idPaciente;

        public CompraBonoForm(int idPac)
        {
            modelo = new Clinica_Frba.Compra_de_Bono.CompraBonoModel();
            idPaciente = idPac;
            InitializeComponent();
            labelMonto.Text = "0";
        }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            modelo.comprarBonoConsulta(idPaciente);
            labelMonto.Text = modelo.montoTotal.ToString();
        }
        private void botonFarmacia_Click(object sender, EventArgs e)
        {
            modelo.comprarBonoFarmacia(idPaciente);
            labelMonto.Text = modelo.montoTotal.ToString();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            modelo.finalizarCompra();
        }
    }
}
