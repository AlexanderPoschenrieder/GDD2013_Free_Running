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
            //Application.Run(new Login.ABMLogin());//Form1()
            Application.Run(new Compra_de_Bono.CompraBonoAdmin());
        }
    }
}
