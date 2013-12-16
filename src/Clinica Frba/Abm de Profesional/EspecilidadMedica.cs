using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Abm_de_Profesional
{
    class EspecilidadMedica
    {
        private long especilidad;


        public EspecilidadMedica(long Especilidad)
        {
            this.especilidad = Especilidad;
        }

        public long getEspecilidad() 
        {
            return this.especilidad;
        } 
    }
}
