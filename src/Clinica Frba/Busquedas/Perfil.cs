using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Busquedas
{//Clase utilizada para las Busquedas de Medicos y Pacientes
    public class Perfil
    {
        public string perfil { get; set; }
        public object parametro { get; set; }

        public Perfil(string perf,object param) {
            parametro = param;
            perfil = perf;
        }        
    }
}
