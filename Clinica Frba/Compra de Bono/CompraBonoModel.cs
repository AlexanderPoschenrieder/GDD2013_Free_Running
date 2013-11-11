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
        List<Bono> carritoConsulta = new List<Bono>();
        List<Bono> carritoFarmacia = new List<Bono>();
        SqlConnection miConexion;
        SqlCommand commandInsert;
        String stringInsert;
        public int montoTotal { get; set; }

        public String comprarBonoFarmacia(int idPaciente)
        {
            Bono bonoAux = new Bono(idPaciente,"Bono Farmacia",2);
            carrito.Add(bonoAux);
            carritoFarmacia.Add(bonoAux);
            montoTotal += bonoAux.precio;
            return "Bono Farmacia";
        }
        public String comprarBonoConsulta(int idPaciente)
        {
            Bono bonoAux = new Bono(idPaciente,"Bono Consulta",1);
            carrito.Add(bonoAux);
            carritoConsulta.Add(bonoAux);
            montoTotal += bonoAux.precio;
            return "Bono Consulta";
        }

        private String armarStringInsert()
        {
            int i = 0;
            //Verifica que la lista no este vacia para hacer el insert
            //
            if (carritoFarmacia.Count != 0)
            {
                stringInsert = "insert into Free_Running.Bono_Farmacia(Afiliado_Compra,Precio,Plan_Correspondiente) values";

                //Agrega por cada Bono los valores al value()----------------------  
                foreach (Bono bonoF in carritoFarmacia)
                {
                    if (i == 0)
                    { stringInsert = stringInsert + bonoF.stringInsert(); }
                    else
                    {
                        stringInsert = stringInsert + "," + bonoF.stringInsert();
                    }
                    i++;
                }
            }
                //Verifica que la lista no este vacia, si lo esta no hace insert
            if (carritoConsulta.Count != 0)
            {
                stringInsert = stringInsert + ";" + "insert into Free_Running.Bono_Consulta(Afiliado_Compra,Precio,Plan_Correspondiente) values";
                i = 0;
                //Agrega por cada Bono los valores al value()----------------------  
                foreach (Bono bonoC in carritoConsulta)
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
