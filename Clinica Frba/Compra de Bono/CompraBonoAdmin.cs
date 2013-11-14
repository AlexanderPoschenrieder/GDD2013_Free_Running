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
    public partial class CompraBonoAdmin :Form
    {
        public CompraBonoAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validar.noVacio(textBox1.Text)) {
                MessageBox.Show("Ingrese el número de afiliado");
            }
            else{
                try {
                    Validar.textoNumeros(textBox1.Text);
                    Validar.nroAfiliadoExiste(Convert.ToInt32(textBox1.Text));

                    CompraBonoForm ventana = new CompraBonoForm(Convert.ToInt32(textBox1.Text));
                    ventana.ShowDialog();
                }
                catch(Exception excep) {
                    MessageBox.Show(excep.Message);
                }
            }
        }


    }
}
