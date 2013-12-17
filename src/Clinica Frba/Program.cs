using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinica_Frba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login.ABMLogin());
            Application.Run(new Abm_de_Afiliado.Menu_Afiliado());
            //Application.Run(new Abm_de_Profesional.Menu_Profesional());
        }
    }
}
