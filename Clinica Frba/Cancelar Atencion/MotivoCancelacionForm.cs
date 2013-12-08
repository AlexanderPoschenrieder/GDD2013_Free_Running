using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class MotivoCancelacionForm : Form
    {
        ModeloMotivoCancelacion miModelo;
        long turnoACancelar;
        UInt32 nroMedico;
        public List<String> fechasACancelar = new List<String>();
        SqlConnection miConexion;
        SqlCommand commandInsert;
        String stringInsert =
                "insert into Free_Running.Turno_Cancelado(Turno_Numero,Cancelado_Por,Motivo,Tipo) values";


        public MotivoCancelacionForm(long idTurno)
        {
            InitializeComponent();
            turnoACancelar = idTurno;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            miModelo = new ModeloMotivoCancelacion();
            foreach (String motivo in miModelo.listaMotivos) {
                comboMotivos.Items.Add(motivo);
            }
        }
        //Constructor para la cancelacion del medico
        public MotivoCancelacionForm(List<String> fechas,UInt32 nro_Medico)
        {
            InitializeComponent();
            nroMedico = nro_Medico;
            fechasACancelar = fechas;
            this.button1.Click += new System.EventHandler(this.botonMedico);
            miModelo = new ModeloMotivoCancelacion();
            foreach (String motivo in miModelo.listaMotivos)
            {
                comboMotivos.Items.Add(motivo);

            }
        }

        private void botonMedico(object sender, EventArgs e) {
            miConexion=Conexion.Conectar();
            
            foreach (string fecha in fechasACancelar) {
                stringInsert = string.Format("exec Free_Running.cancelarTurnosDelDia '{0}',{1},'{2}','{3}'",fecha,nroMedico,tbDetalle.Text,comboMotivos.Text);
                commandInsert = new SqlCommand(stringInsert, miConexion);
                commandInsert.ExecuteNonQuery();
            }

            MessageBox.Show("Sus turnos han sido cancelados");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                miConexion = Conexion.Conectar();
                stringInsert = stringInsert + armarStringTurno(turnoACancelar, "Paciente");
                commandInsert = new SqlCommand(stringInsert, miConexion);
                commandInsert.ExecuteNonQuery();
                MessageBox.Show("Su turno ha sido cancelado");

            this.Close();
        }

        private string armarStringTurno(long idTurno,String PacMed) {
            return string.Format("({0},'{1}','{2}','{3}')",
                idTurno,
                PacMed,
                tbDetalle.Text,
                comboMotivos.Text);
        }


    }
}
