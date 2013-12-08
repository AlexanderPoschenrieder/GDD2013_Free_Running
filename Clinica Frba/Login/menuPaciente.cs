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
        Paciente miPaciente;
        public menuPaciente()
        {
            InitializeComponent();
        }
        public menuPaciente(Usuario unUser)
        {
            miPaciente = unUser.generarPaciente1();
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

        private void btComprar_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Compra_de_Bono.CompraBonoForm abmCompraBono =new Clinica_Frba.Compra_de_Bono.CompraBonoForm((int)miPaciente.Nro_Afiliado);
            abmCompraBono.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Clinica_Frba.Cancelar_Atencion.CancelarAtencionPaciente abmCancelar = new Clinica_Frba.Cancelar_Atencion.CancelarAtencionPaciente((int)miPaciente.Nro_Afiliado);
            abmCancelar.ShowDialog();
        }

        private void menuPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
