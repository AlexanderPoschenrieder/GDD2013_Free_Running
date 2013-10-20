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
    public partial class menuPaciente : Form
    {
        public menuPaciente()
        {
            InitializeComponent();
        }

        private void menuPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
