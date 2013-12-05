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

        public CompraBonoForm(int idPac)
        {
            modelo = new Clinica_Frba.Compra_de_Bono.CompraBonoModel(idPac);
            InitializeComponent();
            labelMonto.Text = "0";
        }

        public CompraBonoForm()
        { }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            String nombreBono = modelo.comprarBonoConsulta();
            labelMonto.Text = modelo.montoTotal.ToString();
            gridCarrito.Rows.Add(nombreBono);
        }
        private void botonFarmacia_Click(object sender, EventArgs e)
        {
            String nombreBono = modelo.comprarBonoFarmacia();
            labelMonto.Text = modelo.montoTotal.ToString();
            gridCarrito.Rows.Add(nombreBono);
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            modelo.finalizarCompra();
        }
    }
}
