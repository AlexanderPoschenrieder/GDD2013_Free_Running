﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class Eliminar_Profesional : Form
    {
        public Eliminar_Profesional()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Validar.noVacio(Idtxt.Text))
            {

                long Id_Profesional = Convert.ToInt32(Idtxt.Text);//carga de datos

                if (Validar.existe_afiliado("Id", Id_Profesional, "Cantidad_profesionales"))
                {
                    Login.Medico.eliminar_especialidad(Id_Profesional);
                    Login.Usuario.Eliminar_usuario("Id", Id_Profesional, "Free_Running.Medico"); //ejecuta el método que elimina al Profesional
                    Validar.MsnAccept("El profesional fue eliminado de forma exitosa", "Eliminar");
                    Idtxt.Clear();
                }
                else
                {
                    Validar.MsnError("Dicho Profesional no se encuentra en el sistema", "Eliminar");
                    Idtxt.Clear();
                }
            }
            else
            {
                Validar.MsnError("Completar los datos", "Eliminar");
            }
        }

        private void Idtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }


    }
}
