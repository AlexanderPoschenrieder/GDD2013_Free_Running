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
            //Clinica_Frba.Abm_de_Afiliado.Form1 abmAfiliado = new Clinica_Frba.Abm_de_Afiliado.Form1();
            //abmAfiliado.ShowDialog();
            //Clinica_Frba.Registrar_Agenda.Form1 agenda = new Clinica_Frba.Registrar_Agenda.Form1();
            //agenda.ShowDialog();

            //Clinica_Frba.Compra_de_Bono.CompraBonoForm ventana= new Clinica_Frba.Compra_de_Bono.CompraBonoForm(100);
            //ventana.ShowDialog();

            Clinica_Frba.Login.ABMLogin login = new Clinica_Frba.Login.ABMLogin();//creo instancia del form login
            //Clinica_Frba.Abm_de_Rol.ModificarRol login = new Clinica_Frba.Abm_de_Rol.ModificarRol();
            login.ShowDialog();
        }
    }
}
