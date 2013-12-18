using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class ResulAtForm: Form
    {
        Clinica_Frba.Registro_Resultado_Atencion.ModeloRegistroResultadoAtencion miModelo;
               
        public ResulAtForm(int idAtencion)
        {
            miModelo = new Clinica_Frba.Registro_Resultado_Atencion.ModeloRegistroResultadoAtencion(idAtencion);
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (tbSintomas.Text.Length == 0)
            {
                MessageBox.Show("Seleccione un motivo");
            }
            else
            {
                miModelo.insertarDatos(tbSintomas.Text, tbEnfermedades.Text);
                MessageBox.Show("Los datos han sido ingresados");

                this.Close();
            }
        }

        private void ResulAtForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
