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
            if (misFuncionalidades.Contains("PROFESIONAL")) { } else { btProf.Visible = false; }
            if (misFuncionalidades.Contains("COMPRA_BONO")) { } else { btCompra.Visible = false; }
            if (misFuncionalidades.Contains("AGENDA")) { } else { btAgenda.Visible = false; }
            if (misFuncionalidades.Contains("LLEGADA_ATENCION_MEDICA")) { } else { this.btLlegada.Visible = false; }
            if (misFuncionalidades.Contains("LISTADO_ESTADISTICO")) { } else { btEstadist.Visible = false; }
        }

        private void btRol_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Abm_de_Rol.ABM_ROL abmRol = new Clinica_Frba.Abm_de_Rol.ABM_ROL();
            abmRol.ShowDialog();
        }

        private void btAfiliado_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Abm_de_Afiliado.Menu_Afiliado mAfiliado = new Clinica_Frba.Abm_de_Afiliado.Menu_Afiliado();
            mAfiliado.ShowDialog();
            //this.Hide();
        }

        private void btLlegada_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Busquedas.BusquedaForm ambLlegada = new Clinica_Frba.Busquedas.BusquedaForm(new Clinica_Frba.Busquedas.Perfil("M",null));
            ambLlegada.ShowDialog();
            //this.Hide();
        }

        private void btEstadist_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Listados_Estadisticos.Estadisticas ambEst = new Clinica_Frba.Listados_Estadisticos.Estadisticas();
            ambEst.ShowDialog();
            //this.Hide();
        }

        private void btProf_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Abm_de_Profesional.Menu_Profesional abmProf = new Clinica_Frba.Abm_de_Profesional.Menu_Profesional();
            abmProf.ShowDialog();

        }

        private void btCompra_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Busquedas.BusquedaForm abmBono = new Clinica_Frba.Busquedas.BusquedaForm(new Clinica_Frba.Busquedas.Perfil("pac",null));
            abmBono.ShowDialog();
        }

        private void menuAdministrativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Busquedas.BusquedaForm ambLlegada = new Clinica_Frba.Busquedas.BusquedaForm(new Clinica_Frba.Busquedas.Perfil("A",null));
            ambLlegada.ShowDialog();

        }
    }
}
