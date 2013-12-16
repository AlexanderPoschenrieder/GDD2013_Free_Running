using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Agregar_Hijo_Familiar : Form
    {
        long Nro_Afiliado;
        int Cant_Familiares;
        string Estado_Civil;
        string Direccion;

        public Agregar_Hijo_Familiar(Login.Paciente unPaciente)
        {
            Nro_Afiliado = unPaciente.Nro_Afiliado;
            Cant_Familiares = unPaciente.Cant_Familiares;
            Estado_Civil = unPaciente.Estado_Civil;
            Direccion = unPaciente.Direccion;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = Nombretxt.Text;
            string Apellido = Apellidotxt.Text;
            string Tipo_documento = TipoDoctxt.Text;
            long Documento = Convert.ToUInt32(NroDoctxt.Text);
            long Telefono = Convert.ToUInt32(Teltxt.Text);
            string Mail = Mailtxt.Text;
            DateTime Fecha_nac = Convert.ToDateTime(FechaNactxt.Text);
            string Sexo = Sexotxt.Text;
            long Plan_medico = Convert.ToUInt32(PlanMedtxt.Text);
            string Estado = "Activo";
            string Usuario = Usertxt.Text;
            string clave = Clavetxt.Text;

            Login.Paciente Familiar = new Login.Paciente(Nro_Afiliado + 1, Nombre, Apellido, Documento, Direccion, Telefono, Mail, Fecha_nac, Sexo, Tipo_documento, Estado_Civil, Cant_Familiares, Plan_medico, Estado, Usuario, clave);
            Familiar.insertar_usuario();
            Familiar.insertarAFiliadoConFamilia();
            MessageBox.Show("Afiliado cargado de forma exitosa", "Ingreso de Afiliados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario(FechaNactxt);
            calendario.ShowDialog();
        }

        private void Nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TipoDoctxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void Sexotxt_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
