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
using Clinica_Frba.Properties;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Agregar_Afiliado : Form
    {
        bool bandera = false;

        public Agregar_Afiliado()
        {
            InitializeComponent();
        }

        private bool conyugue_window(string pregunta)
        {
            Ventana_Desicion ventana = new Ventana_Desicion(pregunta);
            ventana.ShowDialog();
            return (ventana.Bandera);
        }

        private bool quest_conyugue()
        {
            if (EstCiviltxt.Text == "Concubinato" || EstCiviltxt.Text == "Casado")
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

                command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//Valor devuelto

                command.ExecuteNonQuery();

                int valor = (int)command.Parameters["@RETURN_VALUE"].Value;

                miconexion.Close();

                long resultado = (long)Convert.ToUInt32(valor);

                return resultado;
            }
        }

        public void limpiar_campos()
        {
            Nombretxt.Clear(); Apellidotxt.Clear(); NroDoctxt.Clear(); Mailtxt.Clear(); Teltxt.Clear(); FechaNactxt1.Clear(); Directxt.Clear(); CantFamHijtxt.Clear(); Usertxt.Clear(); Clavetxt.Clear(); Sexotxt.SelectedIndex = -1; EstCiviltxt.SelectedIndex = -1; PlanMedtxt.SelectedIndex = -1; TipoDoctxt.SelectedIndex = -1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
             if (Validar.noVacio(Nombretxt.Text) & Validar.noVacio(Apellidotxt.Text) & Validar.noVacio(NroDoctxt.Text) & Validar.noVacio(TipoDoctxt.Text) & Validar.noVacio(Mailtxt.Text) & Validar.noVacio(Teltxt.Text) & Validar.noVacio(FechaNactxt1.Text) & Validar.noVacio(CantFamHijtxt.Text) & Validar.noVacio(Sexotxt.Text) & Validar.noVacio(EstCiviltxt.Text) & Validar.noVacio(PlanMedtxt.Text) & Validar.IsValidEmail(Mailtxt.Text))
            {

                string Nombre = Nombretxt.Text;
                string Apellido = Apellidotxt.Text;
                string Tipo_documento = TipoDoctxt.Text;
                long Documento = Convert.ToUInt32(NroDoctxt.Text);
                string Direccion = Directxt.Text;
                long Telefono = Convert.ToUInt32(Teltxt.Text);
                string Mail = Mailtxt.Text;
                DateTime Fecha_nac = Convert.ToDateTime(FechaNactxt1.Text);
                string Sexo = Sexotxt.Text;
                string Estado_civil = EstCiviltxt.Text;
                int Cant_familiares = Convert.ToInt32(CantFamHijtxt.Text);
                long Plan_medico = Convert.ToUInt32(PlanMedtxt.Text);
                string Estado = "Activo";
                string usuario = Usertxt.Text;
                string clave = Clavetxt.Text;

                int cantHijos = Convert.ToInt32(CantFamHijtxt.Text);

                if (Validar.integridad_de_datos(Documento, Tipo_documento, "unicidad_de_datos"))
                {
               

                    if (quest_conyugue())//Pregunta si tiene conyugue
                    {
                            if (conyugue_window("¿Desea afiliar al conyugue?"))//Pregunta si quiere agregar al conyugue
                            {

                                Login.Paciente Padre = new Login.Paciente(Login.Paciente.obtener_NroPrincipal("numero_principal") + 1, Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, usuario, clave);
                                Padre.insertar_usuario();
                                Padre.insertarAFiliadoConFamilia();
                                Validar.MsnAccept("Afiliado cargado de forma exitosa", "Ingreso de Afiliados");
                                Abm_de_Afiliado.Agregar_Conyugue conyugue = new Agregar_Conyugue(Padre);
                                conyugue.ShowDialog();
                                bandera = true;
                            }

                    }

                    if (cantHijos > 0)//Verifica que tenga hijos
                    {
                            int i = 0;
                            int limite = cantHijos;

                            while (i < limite && conyugue_window("¿Desea afiliar hijo/s?"))//Pregunta por cada hijo si desea afiliarlo
                            {
                                if (bandera)
                                {
                                    Login.Paciente unFamiliar = new Login.Paciente(obtener_NroAfiliado(), Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, usuario, clave);
                                    Abm_de_Afiliado.Agregar_Hijo_Familiar familiar = new Agregar_Hijo_Familiar(unFamiliar);
                                    familiar.ShowDialog();

                                    i++;
                                }
                                else
                                {
                                    Login.Paciente Padre = new Login.Paciente(Login.Paciente.obtener_NroPrincipal("numero_principal") + 1, Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, usuario, clave);
                                    Padre.insertar_usuario();
                                    Padre.insertarAFiliadoConFamilia();
                                    Validar.MsnAccept("Afiliado cargado de forma exitosa", "Ingreso de Afiliados");
                                    Login.Paciente unPaciente = new Login.Paciente(obtener_NroAfiliado(), Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, usuario, clave);
                                    Abm_de_Afiliado.Agregar_Hijo_Familiar familiar = new Agregar_Hijo_Familiar(unPaciente);
                                    familiar.ShowDialog();
                                    bandera = true;
                                    i++;
                                }

                            }

                    }

                    if (!bandera)
                    {
                        Login.Paciente Padre = new Login.Paciente(Login.Paciente.obtener_NroPrincipal("numero_principal"), Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_civil, Cant_familiares, Plan_medico, Estado, usuario, clave);
                        Padre.insertar_usuario();
                        Padre.insertarAFiliadoConFamilia();
                        Validar.MsnAccept("Afiliado cargado de forma exitosa", "Ingreso de Afiliados");
                    }

                    limpiar_campos();
                }
                else
                {
                    Validar.MsnError("El usuario ya se encuentra registrado en el sistema", "Completar formulario"); 
                    limpiar_campos();
                }
            }
        else
           {
               Validar.MsnError("Existen campos vacios en el formulario, o los mismos tienen valores incorrectos", "Completar formulario");
           }
       }
        




        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void NroDoctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void Teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void CantFamHijtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TipoDoctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(FechaNactxt1);
            calendario.ShowDialog();
        }

    }
}
