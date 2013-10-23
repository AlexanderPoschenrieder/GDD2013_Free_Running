using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Clinica_Frba.NewFolder3
{
    public partial class CompraBonoForm : Form
    {
        private Clinica_Frba.Compra_de_Bono.CompraBonoModel modelo;
        private string usuarioActivo;
        
        public CompraBonoForm()
        {
            InitializeComponent();
        }

        private CompraBonoForm(string unUsuario){
            modelo = new Clinica_Frba.Compra_de_Bono.CompraBonoModel();
            usuarioActivo = unUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelo.comprarBonoConsulta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            modelo.comprarBonoFarmacia();
        }
    }
}


