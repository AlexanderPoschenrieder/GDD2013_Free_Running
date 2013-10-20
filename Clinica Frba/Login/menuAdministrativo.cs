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
    public partial class menuAdministrativo : Form
    {
        public menuAdministrativo()
        {
            InitializeComponent();
        }

        private void menuAdministrativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
