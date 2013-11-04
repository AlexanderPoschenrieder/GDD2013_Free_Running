using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Compra_de_Bono
{
    abstract class Bono
    {
        public int clienteCompra;
        public DateTime fecha_Compra;
        SqlConnection miConexion;
        SqlCommand consultaPlan;
        SqlDataReader dr_datos;
        public int precio;
        public int plan_correspondiente;


        public Bono(int id_Cliente)
        {
            clienteCompra = id_Cliente;
            fecha_Compra = DateTime.Now;
            obtenerDatos();
        }

        private void obtenerDatos(){
            String stringConsulta = string.Format("select CAST(PlanMedico as int), CAST(PrecioBonoConsulta as int),CAST(PrecioBonoFarmacia as int) from Free_Running.Calcula_plan_y_precio({0});", clienteCompra.ToString());
            miConexion = Conexion.Conectar();
            consultaPlan = new SqlCommand(stringConsulta,miConexion);

            //Realizo una consulta
            dr_datos = consultaPlan.ExecuteReader();
            dr_datos.Read();
            precio = (int)dr_datos.GetValue(indice());
            plan_correspondiente = (int)dr_datos.GetInt32(0);
        }

        public abstract String stringInsert();
        public abstract int indice(); //template method, implementado en las subclases
        public abstract String nombreBono();
    }
}
