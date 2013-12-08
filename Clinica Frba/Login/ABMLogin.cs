using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Login
{
    public partial class ABMLogin : Form
    {
        public ABMLogin()
        {
            InitializeComponent();
        }

        public void realizarLogin()
        {
            Clinica_Frba.Login.Usuario unUser = new Usuario(tbUser.Text, tbPass.Text);
            if ((Validar.noVacio(unUser.pPass)) & (Validar.noVacio(unUser.pUser)))
            {
                if (unUser.Login())
                {
                    this.Hide();
                    unUser.AbrirMenu();
                }
            }
            else { MessageBox.Show("Complete el Usuario y la Contraseña"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            realizarLogin();
        }

        private void ABMLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
