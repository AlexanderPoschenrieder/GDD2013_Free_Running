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

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            listaFuncionalidades();

        }

        public void listaFuncionalidades()
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmmFunc = new SqlCommand("select * from Free_Running.Funcionalidad", miConexion);
            SqlDataReader dr_func = cmmFunc.ExecuteReader();
            while (dr_func.Read())
            {
                cblFuncionalidades.Items.Add((Convert.ToString(dr_func[0])));
            }
            miConexion.Close();
        }

        public bool validarVacioFunc()
        {
            if (Validar.noVacio(textBox1.Text) && cblFuncionalidades.CheckedItems.Count != 0)
            { return true; }
            else { MessageBox.Show("Complete los Campos"); return false; }
        }



        public bool validarRepetidoFunc()
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmmFunc = new SqlCommand("select * from Free_Running.Funcionalidad_por_Rol WHERE (Rol_Id ='" + textBox1.Text + "')", miConexion);
            SqlDataReader dr_func = cmmFunc.ExecuteReader();
            if (dr_func.Read()) { MessageBox.Show("Ya Existe Esa Funcionalidad Para ese Rol"); miConexion.Close(); return false; } else { miConexion.Close(); return true; }

        }

        public bool ExisteRol()
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmmRol = new SqlCommand("select * from Free_Running.Rol WHERE Id ='" + textBox1.Text + "'", miConexion);
            SqlDataReader dr_Rol = cmmRol.ExecuteReader();
            if (dr_Rol.Read()) { miConexion.Close(); return true; } else { miConexion.Close(); return false; }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int x = 0; x <= cblFuncionalidades.Items.Count - 1; x++)
            {
                cblFuncionalidades.SetItemChecked(x, false);
            }

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (validarVacioFunc())
            {

                if (!ExisteRol())//si no existe
                {

                    SqlConnection miConexion = Conexion.Conectar();
                    SqlCommand cmmRol = new SqlCommand("INSERT INTO Free_Running.Rol(Id,Habilitado)Values('" + textBox1.Text + "',1)", miConexion);
                    cmmRol.ExecuteNonQuery();

                    for (int x = 0; x <= cblFuncionalidades.CheckedItems.Count - 1; x++)
                    {
                        string unaFuncionalidad = cblFuncionalidades.CheckedItems[x].ToString();
                        SqlCommand cmmFunc = new SqlCommand("INSERT INTO Free_Running.Funcionalidad_por_Rol(Rol_Id,Funcionalidad_Id)Values('" + textBox1.Text + "','" + unaFuncionalidad + "')", miConexion);
                        cmmFunc.ExecuteNonQuery();
                    }
                    miConexion.Close();
                    MessageBox.Show("La operacion se realizo con exito");
                }
                else { MessageBox.Show("Ya Existe un ROl con ese Nombre"); }
            } 
        }








    }
}
