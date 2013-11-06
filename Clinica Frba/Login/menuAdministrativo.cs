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
    public partial class menuAdministrativo : Form
    {
        public menuAdministrativo()
        {
            InitializeComponent();

            ArrayList misFuncionalidades = new ArrayList();
            InitializeComponent();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmdFuncionalidad = new SqlCommand("select * from Free_Running.Funcionalidad_por_Rol where Rol_Id='Administrativo'", miConexion);
            SqlDataReader dr_Funcionalidades = cmdFuncionalidad.ExecuteReader();
            while (dr_Funcionalidades.Read())
            {
                misFuncionalidades.Add(Convert.ToString(dr_Funcionalidades[1]));
            }
            if (misFuncionalidades.Contains("ROL")) { } else { btRol.Visible = false; }
            if (misFuncionalidades.Contains("AFILIADO")) { } else { btAfiliado.Visible = false; }
            if (misFuncionalidades.Contains("PROFECIONAL")) { } else { btProf.Visible = false; }
            if (misFuncionalidades.Contains("COMPRA_BONO")) { } else { btCompra.Visible = false; }
            if (misFuncionalidades.Contains("PEDIDO_TURNO")) { } else { btPedido.Visible = false; }
            if (misFuncionalidades.Contains("LLEGADA_ATENCION_MEDICA")) { } else { btLlegada.Visible = false; }
            if (misFuncionalidades.Contains("LISTADO_ESTADISTICO")) { } else { btEstadist.Visible = false; }
        }

        private void btRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_de_Rol.ABM_ROL abmRol = new Clinica_Frba.Abm_de_Rol.ABM_ROL();
            abmRol.ShowDialog();
        }





    }
}
