﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Hide(); //lo oculto
            //Clinica_Frba.NewFolder10.Form1 login = new Clinica_Frba.NewFolder10.Form1();//creo instancia del form login
            //login.ShowDialog();//toma el control el form login
            //Clinica_Frba.Abm_de_Afiliado.Form1 abmAfiliado = new Clinica_Frba.Abm_de_Afiliado.Form1();
            //abmAfiliado.ShowDialog();
            //Clinica_Frba.Registrar_Agenda.Form1 agenda = new Clinica_Frba.Registrar_Agenda.Form1();
            //agenda.ShowDialog();

            Clinica_Frba.Abm_de_Afiliado.Agregar agregarPaciente = new Clinica_Frba.Abm_de_Afiliado.Agregar();
            agregarPaciente.ShowDialog();
        }
    }
}
