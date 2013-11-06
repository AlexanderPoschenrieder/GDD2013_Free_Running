using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Registrar_Agenda
{
    public class AgendaDia
    {
        public String dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }

        public AgendaDia()
        { }
        public AgendaDia(String d, DateTime i, DateTime f)
        {
            this.dia = d;
            this.HoraInicio = i;
            this.HoraFin = f;

        }
    }
}
