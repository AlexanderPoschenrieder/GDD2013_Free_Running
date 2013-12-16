using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Busquedas
{
    class ModeloBusquedaPaciente: Clinica_Frba.Busquedas.ModeloBusquedaProfesional
    {
        public ModeloBusquedaPaciente() {
            consultaBuscarBase = //CONSULTA PARA CONSEGUIR LOS PACIENTES
           "select Nombre as Nombre, Apellido as Apellido, Nro_Afiliado as Id " +
           "from Free_Running.Paciente ";

            this.dni = "";
            this.nombre = "";
        }

        public override string whereFiltro()
        {
            if (dni.Length == 0) { return "1=1"; }
            string dniString = string.Format(" Documento = {0} ", dni);
            return dniString;

        }
    }
}
