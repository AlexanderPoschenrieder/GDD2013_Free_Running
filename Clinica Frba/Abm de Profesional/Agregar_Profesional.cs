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
    public partial class Agregar_Profesional : Form
    {
        public Agregar_Profesional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(Nombretxt.Text) & Validar.noVacio(Apellidotxt.Text) & Validar.noVacio(TipoDoctxt.Text) & Validar.noVacio(Doctxt.Text) & Validar.noVacio(Directxt.Text) & Validar.noVacio(Teltxt.Text) & Validar.noVacio(Mailtxt.Text) & Validar.noVacio(FechaNactxt.Text) & Validar.noVacio(Sexotxt.Text) & Validar.noVacio(Matriculatxt.Text) & Validar.noVacio(Especialtxt.Text) & Validar.noVacio(Usertxt.Text) & Validar.noVacio(Clavetxt.Text) & Validar.IsValidEmail(Mailtxt.Text))
            {
                //inicializo la variable con los datos del form
                Login.Medico unMedico = new Login.Medico(0, Nombretxt.Text, Apellidotxt.Text, Sexotxt.Text, TipoDoctxt.Text, Convert.ToUInt32(Doctxt.Text), Directxt.Text, Convert.ToUInt32(Teltxt.Text), Mailtxt.Text, Convert.ToDateTime(FechaNactxt.Text), Convert.ToUInt32(Matriculatxt.Text), Usertxt.Text, Convert.ToUInt32(Especialtxt.Text), Clavetxt.Text);


                if (Validar.integridad_de_datos(unMedico.Documento, unMedico.Tipo_Documento, "profesional_cargado"))
                {

                    unMedico.agregar_usuario();
                    unMedico.Insertar_profesional();
                    unMedico.Insertar_especialidad(Login.Medico.obtener_IdMedico("obtener_Id"));
                    Validar.MsnAccept("Profesional cargado de forma exitosa", "Insercion de datos"); 
                    limpiar_campos();
                }
                else
                {
                    Validar.MsnError("El Profesional ya se encuentra registrado en el sistema", "Insercion de datos");
                    limpiar_campos();
                }
            }
            else
            {
                Validar.MsnAccept("Existen campos vacios en el formulario", "Completar formulario");
                //limpiar_campos();
            }
            
        }

        public void limpiar_campos()
        {
            Nombretxt.Clear(); Apellidotxt.Clear(); Sexotxt.SelectedIndex = -1; ; TipoDoctxt.SelectedIndex = -1; Doctxt.Clear(); Directxt.Clear(); Teltxt.Clear(); Mailtxt.Clear(); FechaNactxt.Clear(); Matriculatxt.Clear(); Usertxt.Clear(); Especialtxt.SelectedIndex = -1; Clavetxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(FechaNactxt);
            calendario.ShowDialog();
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Doctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Matriculatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }


    }
}
