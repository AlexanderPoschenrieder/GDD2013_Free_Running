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
    public partial class AtencionForm : Form
    {
        Clinica_Frba.Registro_Resultado_Atencion.ModeloAtencion miModelo;

        public AtencionForm(int llegadaId)
        {   
            miModelo = new ModeloAtencion(llegadaId);
            InitializeComponent();
        }

        private void botonSi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nuevaVentana;
            int idAtencion;
            idAtencion = miModelo.confirmarAtencion("Confirmado");
            //Abro la vista para llenar sintomas y enfermedades
            nuevaVentana=  new Clinica_Frba.Registro_Resultado_Atencion.ResulAtForm(idAtencion);
            nuevaVentana.ShowDialog();
            this.Close();
        }

        private void botonNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            miModelo.confirmarAtencion("No confirmado");
            MessageBox.Show("La consulta no ocurrio");
            this.Close();
        }
    }
}
