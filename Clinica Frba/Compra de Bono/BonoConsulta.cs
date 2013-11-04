using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Compra_de_Bono
{
    class BonoConsulta:Bono
    {
        public BonoConsulta(int idCliente) : base(idCliente) { }

        public override String stringInsert()
        { //Devuelve el string a concatenar cuando haya que hacer el insert
            return string.Format("('{0}',{1},{2},{3})",
                    fecha_Compra.ToString("yyyy-MM-dd HH:mm:ss"),
                    clienteCompra,
                    precio,
                    plan_correspondiente);

        }

        public override int indice() { return 1;}
        public override String nombreBono() { return "Bono Consulta"; }
    }
}
