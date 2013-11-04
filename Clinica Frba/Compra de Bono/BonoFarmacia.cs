using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Compra_de_Bono
{
    class BonoFarmacia:Bono
    {
        public BonoFarmacia(int idCliente) : base(idCliente) { }
        public override String stringInsert()
        { //Devuelve el string a concatenar cuando haya que hacer el insert
            return string.Format("('{0}',{1},{2},{3},Free_Running.calcula_fecha_vencimiento('{0}'))",
                    fecha_Compra.ToString("yyyy-MM-dd HH:mm:ss"),
                    clienteCompra,
                    precio,
                    plan_correspondiente);

        }

        public override int indice() { return 2; }
        public override String nombreBono() { return "Bono Farmacia"; }

    }
}
