using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;


namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class LlegadaConfirmada : Form
    {
        public LlegadaConfirmada(UInt32 pAfiliado, UInt32 pTurno)
        {
            InitializeComponent();
            Afiliado = pAfiliado;
            Turno = pTurno;
            lbAfiliado.Text = Convert.ToString(pAfiliado);
            lbTurno.Text = Convert.ToString(pTurno);
        }

        static public UInt32 Afiliado;
        static public UInt32 Turno;



        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(textBox1.Text))
            {


                SqlConnection miconexion = Conexion.Conectar();
                SqlCommand cmd = new SqlCommand("Free_Running.puedeUsarBC", miconexion);
                UInt32 BC = Convert.ToUInt32(textBox1.Text);
                using (miconexion)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NroAfiliado", (long)Afiliado);
                    cmd.Parameters.AddWithValue("@BC", (long)BC);
                    cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int resultado = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                    if (resultado >= 1)
                    {

                        SqlCommand insertLlegada = new SqlCommand(string.Format("INSERT INTO Free_Running.Llegada_Atencion_Medica(Fecha_Hs_Llegada,Nro_Afiliado,Turno_Numero,Bono_Consulta)values(GETDATE()," + Afiliado + "," + Turno + "," + BC + ")"), miconexion);
                        insertLlegada.ExecuteNonQuery();
                        SqlCommand updateBC = new SqlCommand(string.Format("UPDATE Free_Running.Bono_Consulta set Afiliado_Utiliza = " + (long)Afiliado + ", Numero = (select COUNT(*)+1 from Free_Running.Bono_Consulta BC where BC.Numero is not null and BC.Afiliado_Utiliza is not null and BC.Afiliado_Utiliza = " + Afiliado + ") where Id = " + (long)BC), miconexion);
                        updateBC.ExecuteNonQuery();

                        MessageBox.Show("Llegada Registrada Correctamente");
                        miconexion.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Bono Conslta Invalido");
                        miconexion.Close();
                    }
                }
            }
            else { MessageBox.Show("Complete el Bono Consulta"); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    

    }
}
