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
    public partial class menuPaciente : Form
    {
        public menuPaciente()
        {
            InitializeComponent();
        }
        public menuPaciente(Usuario unUser)
        {
            ArrayList misFuncionalidades = new ArrayList();
            InitializeComponent();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmdFuncionalidad = new SqlCommand("select * from Free_Running.Funcionalidad_por_Rol where Rol_Id='Afiliado'", miConexion);
            SqlDataReader dr_Funcionalidades = cmdFuncionalidad.ExecuteReader();
            while (dr_Funcionalidades.Read())
            {
                misFuncionalidades.Add(Convert.ToString(dr_Funcionalidades[1]));
            }
            if (misFuncionalidades.Contains("COMPRA_BONO")) { } else { btComprar.Visible = false; }
            if (misFuncionalidades.Contains("CANCELACION_TURNO")) { } else { btCancelar.Visible = false; }
        }
    }
}
