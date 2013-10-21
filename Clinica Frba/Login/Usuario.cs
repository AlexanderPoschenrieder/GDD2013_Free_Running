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


namespace Clinica_Frba.Login
{
    public class Usuario
    {

        public String pUser { get; set; }
        public String pPass { get; set; }

        public Usuario() { }
        public Usuario(String u, String c)
        {
            this.pPass = c;
            this.pUser = u;

        }

        public bool Login()//(string pUser, string pPass) static
        {   
            //CREO UNA CONEXION Y X LA CONSULTA BUSCO EL USUARIO
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaUsuario = new SqlCommand(string.Format(
                        "select * from Free_Running.Usuario where Username= '{0}'", this.pUser), miConexion);
            SqlDataReader drUsuario = consultaUsuario.ExecuteReader();

            //PREGUNTO SI PUEDO LEER ...si puedo => EXISTE EL USUARIO
            if (drUsuario.Read() == true)
            {
                    //ACA EXISTE EL USUARIO
                

                    if (Convert.ToInt32(drUsuario[2]) == 1)//PREGUNTO SI ESTA HABILITADO
                    {
                        
                        if (Convert.ToString(drUsuario[1]) == Validar.getHashSha256(this.pPass))//PREGUNTO SI Coincide el Pass
                        {                       
                            MessageBox.Show("Bienvenido: "+this.pUser);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta"); return false;
                            //llamada al procedimiento agregaintentofallido
                        }
                    }
                    else
                    {
                            MessageBox.Show("Usuario NO Habilitado"); return false;
                    }
            }
            else
            {
                MessageBox.Show("Usuario No Existe"); return false;
            }
            //miConexion.Close();
        }

        public void AbrirMenuUnico(String unRol)
        {
            if (unRol == "Afiliado")
            { //paciente 
                Clinica_Frba.Login.menuPaciente menuPaciente = new menuPaciente();
                menuPaciente.ShowDialog();
            }

            if (unRol == "Administrativo")
            { //Administrativo 
                Clinica_Frba.Login.menuAdministrativo menuAdmin = new menuAdministrativo();
                menuAdmin.ShowDialog();
            }
            else
            {
                if (unRol == "Profesional")
                { //Profecional 
                    Clinica_Frba.Login.menuMedico menuMedico = new menuMedico();
                    menuMedico.ShowDialog();
                }
                else
                {
                    if (unRol == "Admnistrador Gerencial")
                    { //Admnistrador Gerencial NOSE SI VA
                        Clinica_Frba.Login.menuAdministrativo menuAdmin = new menuAdministrativo();
                        menuAdmin.ShowDialog();
                    }
                }
            }
        }


        public ArrayList roles()//CREAR un VECTOR DE ROLES para un USUARIO
        {
            ArrayList misRoles = new ArrayList();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaRoles = new SqlCommand("select * from Free_Running.Usuario_por_Rol where Username='" + this.pUser + "'", miConexion);
            SqlDataReader dr_roles = consultaRoles.ExecuteReader();

            while (dr_roles.Read())
            {
                misRoles.Add((dr_roles[1]));
            }

            miConexion.Close();
            return misRoles;
        }

        public void AbrirMenu()//Abre el MENU dependiendo la cantidad de roles que tenga
        {
            ArrayList misROles = this.roles();//CREO ARRAY de ROLES
            if (misROles.Count == 1)//SI SOLO TIENE UN ROL
            {
                this.AbrirMenuUnico((misROles[0].ToString()));//ABRO EL MENU del ROL
            }
            else
            {   //ABRO el MENU PARA SELECCIONAR UN ROL
                Clinica_Frba.Login.selecRol menuRol = new selecRol(this);
                menuRol.ShowDialog();
            }
        }

    }
}
