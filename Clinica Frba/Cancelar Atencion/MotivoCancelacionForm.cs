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
        SqlConnection miConexion;
        SqlCommand commandInsert;
        public MotivoCancelacionForm(long idTurno)
        {
            InitializeComponent();
            turnoACancelar = idTurno;
            miModelo = new ModeloMotivoCancelacion();
            foreach (String motivo in miModelo.listaMotivos) {
                comboMotivos.Items.Add(motivo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miConexion = Conexion.Conectar();
            String stringInsert="begin transaction insert into Free_Running.Turno_Cancelado(Turno_Numero,Cancelado_Por,Motivo,Tipo)"
	            +string.Format("values({0},'{1}','{2}','{3}') commit transaction",turnoACancelar,"Paciente",tbDetalle.Text,comboMotivos.Text);
            commandInsert= new SqlCommand(stringInsert,miConexion);
            commandInsert.ExecuteNonQuery();
        }
    }
}
