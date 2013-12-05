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
        int nro_paciente;
        int cantidadFarmacia = 0;
        int precioFarmacia;
        int cantidadConsulta = 0;
        int precioConsulta;
        int planCorrespondiente;
        SqlConnection miConexion;
        SqlCommand compraBonos;
        SqlCommand commandConsulta;
        SqlDataReader dr_datos;
        public int montoTotal { get; set; }

        public CompraBonoModel(int nroPaciente)
        {
            nro_paciente = nroPaciente;
            obtenerDatos();
        }

        public String comprarBonoFarmacia()
        {
            cantidadFarmacia++;
            montoTotal += precioFarmacia;
            return "Bono Farmacia";
        }
        public String comprarBonoConsulta()
        {
            cantidadConsulta++;
            montoTotal += precioConsulta;
            return "Bono Consulta";
        }

        private void obtenerDatos()
        {
            String stringConsulta = string.Format("select CAST(PlanMedico as int), CAST(PrecioBonoConsulta as int),CAST(PrecioBonoFarmacia as int) from Free_Running.Calcula_plan_y_precio({0});", nro_paciente);
            miConexion = Conexion.Conectar();
            commandConsulta = new SqlCommand(stringConsulta, miConexion);

            //Realizo una consulta
            dr_datos = commandConsulta.ExecuteReader();
            dr_datos.Read();
            precioFarmacia = (int)dr_datos.GetValue(2);
            precioConsulta = (int)dr_datos.GetValue(1);
            planCorrespondiente = (int)dr_datos.GetInt32(0);
            miConexion.Close();
        }

        public void finalizarCompra()
        {
            miConexion = Conexion.Conectar();
            compraBonos = new SqlCommand(
                string.Format(
                "exec GD2C2013.Free_Running.comprarBonosFarmacia @Afiliado_Compra={0},@plan= {1},@precio= {2},@cantidad={3}; "
                , nro_paciente, planCorrespondiente, precioFarmacia, cantidadFarmacia) +
                string.Format(
                "exec GD2C2013.Free_Running.comprarBonosConsulta @Afiliado_Compra={0},@plan= {1},@precio= {2},@cantidad={3}"
                , nro_paciente, planCorrespondiente, precioFarmacia, cantidadConsulta), miConexion);

            compraBonos.ExecuteNonQuery();
            miConexion.Close();
            MessageBox.Show(string.Format("Gracias por su compra, su monto total es: ${0}", montoTotal));
        }
    }
}
