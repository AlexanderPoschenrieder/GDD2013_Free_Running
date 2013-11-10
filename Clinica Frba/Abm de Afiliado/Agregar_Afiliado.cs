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
using Clinica_Frba.Properties;//necesario para establecer la conexion
using Clinica_Frba.Login;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Agregar_Afiliado : Form
    {
        public Agregar_Afiliado(string tipo)
        {
            Tipo = tipo;
            Principal = 0;
            InitializeComponent();
            cantidad = 0;
        }
        public Agregar_Afiliado()
        {
            Tipo = "Principal";
            Principal = 0;
            InitializeComponent();
            cantidad = 0;
        }


        long Principal;
        string Tipo;
        int cantidad;


        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = textBox1.Text;
            string Apellido = textBox2.Text;
            string Tipo_documento = textBox4.Text;
            long Documento = Convert.ToUInt32(textBox3.Text);
            string Direccion = textBox8.Text;
            long Telefono = Convert.ToUInt32(textBox6.Text);
            string Mail = textBox5.Text;
            DateTime Fecha_nac = Convert.ToDateTime(textBox7.Text);
            string Sexo = comboBox1.Text;
            string Estado_civil = comboBox2.Text;
            int Cant_familiares = Convert.ToInt32(textBox9.Text);
            long Plan_medico = Convert.ToUInt32(comboBox3.Text);
            string Estado = "Activo";
           
                if (Tipo == "Principal")
                {
                    int cantHijos = Convert.ToInt32(textBox9.Text);


                    if (quest_conyugue())//siTieneConyugue
                    {
                        if (conyugue_window("¿Desea Agregar Conyugue?"))  //desea agregar conyugue 
                        {
                            MessageBox.Show("ingreso al if cony");
                            Paciente unPaciente = new Paciente(obtener_NroAfiliado() + 1, Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, "null");
                            Principal = unPaciente.insertarAFiliadoConFamilia();
                            Abm_de_Afiliado.Agregar_Afiliado conyugue = new Agregar_Afiliado("Conyugue");
                            MessageBox.Show("abrio");
                            conyugue.ShowDialog();
                            MessageBox.Show("tomo el control");
                            cantidad = cantidad + 1;
                        }
                        else
                        {
                            cantidad = 0;
                            // no desea agregarla no hago nada xq capas no tiene hijos
                        }
                        MessageBox.Show("salio del if co");
                    }
                  
                    
                    if (cantHijos > 0)
                    {
                        MessageBox.Show("entra a hijos");
                            int i = 0;
                            int limite = cantHijos;

                            while ( i < limite )//&& conyugue_window("¿Desea Agregar Familiar / Hijo?"))
                            {
                                MessageBox.Show("itera: "+i);
                                    //incertar hijos/familiar
                                   // Paciente unPaciente = new Paciente(obtener_NroAfiliado() + cantidad + 1, Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, "null");
                                    //Principal = unPaciente.insertarAFiliadoConFamilia();
                                    Abm_de_Afiliado.Agregar_Afiliado conyugue = new Agregar_Afiliado("Familiar");
                                    conyugue.ShowDialog();
                                    cantidad = cantidad + 1;
                                i++;

                            }

                     }
                    
           }     
         }




        private bool conyugue_window(string agregar)
        {
            Choice_window ventana = new Choice_window(agregar);
            ventana.ShowDialog();
            return (ventana.R);     
        }




        private bool quest_conyugue()
        {
            if (comboBox2.Text == "Concubinato" || comboBox2.Text == "Casado")
            { return true; }
            else { return false; }   
        }






        public long obtener_NroAfiliado()
        {
            SqlConnection miconexion = Conexion.Conectar();

            SqlCommand command = new SqlCommand("dbo.get_NroAfiliado", miconexion);
            using (miconexion)
            {
                command.CommandType = CommandType.StoredProcedure;
                //
                command.Parameters.Add("@RETURN_VALUE",SqlDbType.BigInt).Direction = ParameterDirection.ReturnValue;//Valor devuelto

                command.ExecuteNonQuery();

                int valor = (int)command.Parameters["@RETURN_VALUE"].Value;
                miconexion.Close();
                long resultado = (long)Convert.ToUInt32(valor);

                return resultado;
            }
        }


        private void limpiar_campos()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear(); comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
        }


    }
}
