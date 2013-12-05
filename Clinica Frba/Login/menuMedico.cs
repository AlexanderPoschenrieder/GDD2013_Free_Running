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
    public partial class menuMedico : Form
    {
        public menuMedico()
        {
            InitializeComponent();
        }

        public static Medico miMedico;

        public menuMedico(Medico unMedico)
        {
            miMedico = unMedico;
            ArrayList misFuncionalidades = new ArrayList();
            InitializeComponent();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cmdFuncionalidad = new SqlCommand("select * from Free_Running.Funcionalidad_por_Rol where Rol_Id='Profesional'", miConexion);
            SqlDataReader dr_Funcionalidades = cmdFuncionalidad.ExecuteReader();
            while (dr_Funcionalidades.Read())
            {
                misFuncionalidades.Add(Convert.ToString(dr_Funcionalidades[1]));
            }
            if (misFuncionalidades.Contains("AGENDA")) { } else { btAgenda.Visible = false; }
            if (misFuncionalidades.Contains("REGISTRO_RESULTADO")) { } else { btRegRes.Visible = false; }
            if (misFuncionalidades.Contains("CANCELACION_TURNO")) { } else { btCancelarT.Visible = false; }
        }

        private void btAgenda_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Clinica_Frba.Registrar_Agenda.ABM_Agenda agenda = new Clinica_Frba.Registrar_Agenda.ABM_Agenda(miMedico);
            agenda.ShowDialog();
        }

        private void btRegRes_Click(object sender, EventArgs e)
        {
            //Clinica_Frba.Registro_Resultado_Atencion.AtencionForm atencion = new Clinica_Frba.Registro_Resultado_Atencion.AtencionForm();
            //this.Hide();
        }

    }
}
