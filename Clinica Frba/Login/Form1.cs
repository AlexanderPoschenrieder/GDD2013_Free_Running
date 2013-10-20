using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.NewFolder10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void realizarLogin() 
        
        {
            Clinica_Frba.Login.Usuario unUser = new Clinica_Frba.Login.Usuario(tbUser.Text, tbPass.Text);
            if ((Validar.noVacio(unUser.pPass)) & (Validar.noVacio(unUser.pUser)))
            {
                if(unUser.Login())
                {
                    this.Hide();
                    unUser.AbrirMenu();
                }
            }
            else { MessageBox.Show("Complete el Usuario y la Contraseña"); }
        }
        

        private void btAceptar_Click(object sender, EventArgs e)
        {
         realizarLogin();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
