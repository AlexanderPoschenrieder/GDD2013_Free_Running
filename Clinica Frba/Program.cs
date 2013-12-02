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
            //Clinica_Frba.Pedir_Turno.BusquedaProfesionalForm ventana;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login.ABMLogin());//Form1()
            //Application.Run(ventana = new Clinica_Frba.Pedir_Turno.BusquedaProfesionalForm(100));
            //Application.Run(new Clinica_Frba.Listados_Estadisticos.Estadisticas());
        }
    }
}
