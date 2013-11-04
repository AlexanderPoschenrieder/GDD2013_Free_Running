using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.Compra_de_Bono
{
    class CompraBonoModel
    {
        List<Bono> carrito = new List<Bono>();
        List<BonoConsulta> carritoConsulta = new List<BonoConsulta>();
        List<BonoFarmacia> carritoFarmacia = new List<BonoFarmacia>();
        SqlConnection miConexion;
        SqlCommand commandInsert;
        String stringInsert;
        public int montoTotal { get; set; }

        public void comprarBonoFarmacia(int idPaciente)
        {
            BonoFarmacia bonoAux = new BonoFarmacia(idPaciente);
            carrito.Add(bonoAux);
            carritoFarmacia.Add(bonoAux);
            montoTotal += bonoAux.precio;
        }
        public void comprarBonoConsulta(int idPaciente)
        {
            BonoConsulta bonoAux = new BonoConsulta(idPaciente);
            carrito.Add(bonoAux);
            carritoConsulta.Add(bonoAux);
            montoTotal += bonoAux.precio;
        }

        private String armarStringInsert()
        {
            int i = 0;
            //Verifica que la lista no este vacia para hacer el insert
            //
            if (carritoFarmacia.Count != 0)
            {
                stringInsert = "insert into Free_Running.Bono_Farmacia(Fecha_Compra,Afiliado_Compra,Precio,Plan_Correspondiente,Fecha_Vencimiento) values";

                //Agrega por cada Bono los valores al value()----------------------  
                foreach (BonoFarmacia bonoF in carritoFarmacia)
                {
                    if (i == 0)
                    { stringInsert = stringInsert + bonoF.stringInsert(); }
                    else
                    {
                        stringInsert = stringInsert + "," + bonoF.stringInsert();
                    }
                    i++;
                }

                //Verifica que la lista no este vacia, si lo esta no hace insert
                if (carritoConsulta.Count != 0)
                {
                    stringInsert = stringInsert + ";" + "insert into Free_Running.Bono_Consulta(Fecha_Compra,Afiliado_Compra,Precio,Plan_Correspondiente) values";
                    i = 0;
                    //Agrega por cada Bono los valores al value()----------------------  
                    foreach (BonoConsulta bonoC in carritoConsulta)
                    {
                        if (i == 0)
                        { stringInsert = stringInsert + bonoC.stringInsert(); }
                        else
                        {
                            stringInsert = stringInsert + "," + bonoC.stringInsert();
                        }
                        i++;
                    }
                }
            }
            return stringInsert;
        }

        public void finalizarCompra()
        {
            miConexion = Conexion.Conectar();
            armarStringInsert();
            commandInsert = new SqlCommand(stringInsert, miConexion);
            commandInsert.ExecuteNonQuery();
            miConexion.Close();
            MessageBox.Show(string.Format("Gracias por su compra, su monto total es: ${0}", montoTotal));
        }
    }
}
