using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class ABM_ROL : Form
    {
        public ABM_ROL()
        {
            InitializeComponent();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            AltaRol alta = new AltaRol();
            //this.Hide();
            alta.ShowDialog();
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            BajaRol baja = new BajaRol();
            //this.Hide();
            baja.ShowDialog();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ModificarRol modif = new ModificarRol();
            //this.Hide();
            modif.ShowDialog();
        }

    }
}
