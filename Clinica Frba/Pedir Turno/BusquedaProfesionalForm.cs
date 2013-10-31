using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class BusquedaProfesionalForm : Form
    {
        private ModeloBusquedaProfesional miModelo;
        public BusquedaProfesionalForm()
        {
            miModelo = new ModeloBusquedaProfesional();
            InitializeComponent();
            generarComboEspecialidades();
        }

        private void generarComboEspecialidades() {//BINDEA EL COMBO CON LAS ESPECIALIDADES
            ArrayList especialidades= miModelo.especialidades;
            for (int i = 0; i < especialidades.Count; i++)
            {
                comboEspecialidad.Items.Add(especialidades[i]);
            }
        }
        private void armarGrilla() {
            ArrayList profesionales = miModelo.resultadoBusqueda;
            for (int i = 0; i < profesionales.Count; i++)
            {
                gridResultados.Rows.Add(profesionales[i]);
            }    
        }


        private void NombreProfTB_TextChanged(object sender, EventArgs e)
        {
            miModelo.nombre = NombreProfTB.Text;
        }

        private void botonBuscar(object sender, EventArgs e)
        {
            miModelo.especialidadSeleccionada = comboEspecialidad.Text;
            //MessageBox.Show(string.Format("especialidad:'{0}'",miModelo.especialidadSeleccionada));
            miModelo.buscar();
            armarGrilla();
            
        }

    }
}
