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

        public bool Login()
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


                if (Convert.ToInt32(drUsuario[2]) == 1)//PREGUNTO SI ESTA HABILITADO(1) ...NO HABILITADO(0)
                {

                    if (Convert.ToString(drUsuario[1]) == Validar.getHashSha256(this.pPass))//PREGUNTO SI Coincide el Pass
                    {
                        this.borrarIntentoFallido();//borro todos los intentos fallidos que tenia hasta el momento
                        MessageBox.Show("Bienvenido: " + this.pUser);

                        if (this.roles().Count > 0)
                        {
                            return true;
                        }
                        else { MessageBox.Show("No posee Ningun Rol"); return false; }
                    }
                    else
                    {
                        //INTENTO FALLIDO
                        MessageBox.Show("Contraseña Incorrecta");
                        this.agregarIntentoFallido();//agrego un intento fallido, si la cantidad es 3 => Habilitado = 0 (desde sql)
                        return false;

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

        public void agregarIntentoFallido() //FALTA FECHAA
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {

                SqlCommand cmd = new SqlCommand();
                // Configuramos el comando
                //
                cmd.Connection = miConexion;
                cmd.CommandText = "Free_Running.agregarIntentoFallido";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parUser = cmd.Parameters.Add("@User", SqlDbType.VarChar, 255);
                parUser.Value = this.pUser;
                cmd.ExecuteNonQuery();

            }

        }

        public void borrarIntentoFallido()
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand();
                // Configuramos el comando
                //
                cmd.Connection = miConexion;
                cmd.CommandText = "Free_Running.borrarIntentoFallido";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parUser = cmd.Parameters.Add("@Username", SqlDbType.VarChar, 255);
                parUser.Value = this.pUser;
                cmd.ExecuteNonQuery();

            }

        }

        public void AbrirMenuUnico(String unRol)
        {
            if (unRol == "Afiliado")
            {
                Clinica_Frba.Login.menuPaciente menuPaciente = new menuPaciente(this.generarPaciente());
                menuPaciente.ShowDialog();
            }

            if (unRol == "Administrativo")
            { 
                Clinica_Frba.Login.menuAdministrativo menuAdmin = new menuAdministrativo();
                menuAdmin.ShowDialog();
            }
            else
            {
                if (unRol == "Profesional")
                {
                    Clinica_Frba.Login.menuMedico menuMedico = new menuMedico(this.generarMedico());
                    menuMedico.ShowDialog();
                }
                else
                {
                    if (unRol == "Admnistrador Gerencial")
                    {
                        Clinica_Frba.Login.menuAdministrativo menuAdmin = new menuAdministrativo();
                        menuAdmin.ShowDialog();
                    }
                }
            }
        }

        public ArrayList roles()//CREAR un VECTOR DE ROLES ""VALIDOS"" para un USUARIO
        {
            ArrayList misRoles = new ArrayList();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaRoles = new SqlCommand("select * from Free_Running.Usuario_por_Rol where Username='" + this.pUser + "'", miConexion);
            SqlDataReader dr_roles = consultaRoles.ExecuteReader();
            SqlConnection miConexion2 = Conexion.Conectar();
            while (dr_roles.Read())
            {
                SqlCommand existeRoles = new SqlCommand("select * from Free_Running.Rol where Id='" + Convert.ToString(dr_roles[1]) + "'", miConexion2);
                SqlDataReader dr_rolesActivos = existeRoles.ExecuteReader();
                dr_rolesActivos.Read();
                if ((Convert.ToInt32(dr_rolesActivos[1])) == 1) { misRoles.Add((dr_roles[1])); }

            }

            miConexion.Close();
            miConexion2.Close();
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
            {                   //ABRO el MENU PARA SELECCIONAR UN ROL
                    Clinica_Frba.Login.selecRol menuRol = new selecRol(this);
                    menuRol.ShowDialog();  
            }
        }

        public Paciente generarPaciente()
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaP = new SqlCommand("select * from Free_Running.Paciente P where P.Username = '" + this.pUser + "'", miConexion);
            SqlDataReader drP = consultaP.ExecuteReader();
            drP.Read();
            Paciente miP = new Paciente(Convert.ToUInt32(drP[0]), Convert.ToString(drP[1]), Convert.ToString(drP[2]), Convert.ToUInt32(drP[3]), Convert.ToString(drP[4]), Convert.ToUInt32(drP[5]), Convert.ToString(drP[6]), Convert.ToDateTime(drP[7]), Convert.ToString(drP[8]), Convert.ToString(drP[9]), Convert.ToString(drP[10]), Convert.ToInt32(drP[11]), Convert.ToInt32(drP[12]), Convert.ToString(drP[13]), Convert.ToString(drP[14]),"");
            return miP;

                
        }

        public Medico generarMedico()
        {

            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaMedico = new SqlCommand("select * from Free_Running.Medico where Username='" + this.pUser + "'", miConexion);
            SqlDataReader dr_Medico = consultaMedico.ExecuteReader();
            dr_Medico.Read();
            Medico miMedico = new Medico(Convert.ToUInt32(dr_Medico[0]), Convert.ToString(dr_Medico[1]), Convert.ToString(dr_Medico[2]), Convert.ToString(dr_Medico[3]), Convert.ToString(dr_Medico[4]), Convert.ToUInt32(dr_Medico[5]), Convert.ToString(dr_Medico[6]), Convert.ToUInt32(dr_Medico[7]), Convert.ToString(dr_Medico[8]), Convert.ToDateTime(dr_Medico[9]), Convert.ToUInt32(dr_Medico[10]), Convert.ToString(dr_Medico[11]),1,"");
            return miMedico;

        }


        static public void Eliminar_usuario(string campo_a_modificar, long Parametro, string Tabla)//ver como lo haria polimorficamente
            //Elimina un usuario de la base de datos.
        {
            SqlConnection miconexion = Conexion.Conectar();

            string queryl = "DELETE FROM " + Tabla + " WHERE " + campo_a_modificar + " = " + Parametro;

            using (miconexion)
            {
                SqlCommand cmd = new SqlCommand(queryl, miconexion);


                cmd.ExecuteNonQuery();

                miconexion.Close();
            }
        }


        static public void filtrar_tabla(string campo_a_modificar, string tabla, long Parametro, DataGridView dataGridView)
           //lleno la tabla para modificar los datos
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapt;

            try
            {
                SqlConnection miconexion = Conexion.Conectar();

                string queryl = "SELECT * FROM Free_Running." + tabla + " WHERE " + campo_a_modificar + " =" + Parametro;

                adapt = new SqlDataAdapter(queryl, miconexion);//vinculo la conexion con la consulta

                adapt.Fill(ds, tabla);//Lleno el dataset
                dataGridView.DataSource = ds.Tables[0];//asigno
                //dataGridView1.DataMember = "Paciente_Details";
                //miconexion.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la busqueda de datos", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

        }
    }

}



