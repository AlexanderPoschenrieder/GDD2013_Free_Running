using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Clinica_Frba.Login
{
    public partial class selecRol : Form
    {
        public selecRol()
        {
            InitializeComponent();
        }

        public Usuario miUser;

        public selecRol(Clinica_Frba.Login.Usuario unUser)
        {
            InitializeComponent();
            miUser = unUser;
            generarMenu(unUser);
        }

        public void generarMenu(Usuario unUser)
        {
            ArrayList misRoles = unUser.roles();
            for (int i = 0; i < misRoles.Count; i++)
            {
                cbRoles.Items.Add(misRoles[i]);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(cbRoles.Text))
            {
                this.Hide();
                miUser.AbrirMenuUnico(cbRoles.Text);
            }
        }






    }
}
