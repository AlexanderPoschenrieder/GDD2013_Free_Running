using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class Calendario : Form
    {
        TextBox fecsha_nac;

        public Calendario(TextBox valor)
        {
            fecsha_nac = valor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DockChanged(object sender, EventArgs e)
        {
            fecsha_nac.Text = monthCalendar1.SelectionStart.ToString(); 
        }
    }
}
