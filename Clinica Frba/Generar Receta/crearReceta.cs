using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//necesario para establecer la conexion
using System.Configuration;//necesario para establecer la conexion

namespace Clinica_Frba.Generar_Receta
{
    public partial class crearReceta : Form
    {
        public crearReceta(UInt32 consulta, UInt32 unAfiliado)
        {
            miAfiliado = unAfiliado;
            miconsulta = consulta;
            InitializeComponent();
        }
        public UInt32 idMedicamento;
        public static UInt32 miAfiliado;
        public static UInt32 miconsulta;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(tbBF.Text) && Validar.noVacio(tbMedicamento.Text) && Validar.noVacio(tbCant.Text)) 
            { 
               

                if (controlar_bono(Convert.ToUInt32(tbBF.Text)) < 5)
                {
                    if (Convert.ToInt32(tbCant.Text) <= 3 && Convert.ToInt32(tbCant.Text) > 0 ) 
                    {
                        if (controlarUtiliza_bono(miAfiliado, Convert.ToUInt32(tbBF.Text)) > 0)
                        {

                            SqlConnection miconexion = Conexion.Conectar();
                            SqlCommand cmdUpdate = new SqlCommand("update Free_Running.Bono_Farmacia set Consulta_Id = "+miconsulta+" where Id = "+Convert.ToUInt32(tbBF.Text), miconexion);
                            SqlCommand cmdInsert = new SqlCommand("insert into Free_Running.Medicamento_por_BonoFarmacia(Bono_Farmacia,Medicamento,Cantidad,Aclaracion_Cantidad)values(" + Convert.ToUInt32(tbBF.Text) + "," + tbMedicamento.Text + "," + Convert.ToInt32(tbCant.Text) + "," + aLetra(Convert.ToInt32(tbCant.Text)) + ")", miconexion);
                            using (miconexion)
                            {
                                cmdInsert.ExecuteNonQuery();
                                cmdUpdate.ExecuteNonQuery();
                                miconexion.Close();

                            }
                            MessageBox.Show(" Medicamento Cargado Correctamente ");

                        }
                        else { MessageBox.Show(" Bono Invalido "); }   

                    }
                    else { MessageBox.Show(" La cantidad debe ser menor o igual a 3"); }              
                }
                else
                { 
                    MessageBox.Show("La Cantidad de Medicamentos supero el Maximo permitido, Ingrese Otro Bono Farmacia"); 
                }



               
            }
        }

        static int controlar_bono(UInt32 Nro_bono)
        {
            SqlConnection miconexion = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("dbo.controlar_cant_medicamentos", miconexion);
            using (miconexion)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros si los hubieran
                cmd.Parameters.AddWithValue("@bono", Nro_bono);
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto
                cmd.ExecuteNonQuery();
                int Cantidad = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();
                return Cantidad;
            }
        }

        static int controlarUtiliza_bono(UInt32 Nro_Afiliado, UInt32 Nro_bono)
        {
            SqlConnection miconexion = Conexion.Conectar();
            SqlCommand cmd = new SqlCommand("dbo.controlar_utilizar_medicamentos", miconexion);
            using (miconexion)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                //parametros si los hubieran
                cmd.Parameters.AddWithValue("@NroAfiliado", Nro_Afiliado);
                cmd.Parameters.AddWithValue("@Bf", Nro_bono);
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto
                cmd.ExecuteNonQuery();
                int Cantidad = (int)cmd.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();
                return Cantidad;
            }
        }

        public String aLetra(int num)
        {
            String txt = "";
            if (num == 1) txt = "uno";
            else if (num == 2) txt = "dos";
            else if (num == 3) txt = "tres";
            return txt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Generar_Receta.Medicamentos medicamentos = new Medicamentos(this);
            medicamentos.ShowDialog();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbBF.Text = "";
            tbCant.Text = "";
            tbMedicamento.Text = "";
        }


    }
}
