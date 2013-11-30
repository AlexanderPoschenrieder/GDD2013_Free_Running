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

namespace Clinica_Frba.Registro_de_LLegada
{
    public partial class Turnos_Llegada : Form
    {
        public Turnos_Llegada(UInt32 unProf, String unEsp)
        {
            miProf = unProf;
            miEsp = unEsp;

            //tabla que muestra todos los turnos no canselados mayores a la fecha de hoy
            tabla = "select T.Numero,T.Fecha,T.Nro_Afiliado,T.Medico_Id from Free_Running.Turno T where not exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero) and T.Medico_Id = " + miProf + " and T.Fecha > GETDATE() and T.Especialidad_Codigo = Free_Running.especialidadCod('" + miEsp + "')";
            InitializeComponent();
            iniciarDGV(dgvTurnos);
            mostrarTurno(dgvTurnos, tabla, "");

        }
        public static string tabla;
        public static UInt32 miProf;
        public static String miEsp;

        public void iniciarDGV(DataGridView dgv)
        {

            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Turno";
            dgv.Columns[1].Name = "Fecha";
            dgv.Columns[2].Name = "Nro Afiliado";
            dgv.Columns[3].Name = "Medico";

        }

        //me muestra todos los turnos que hay de un determinado profecional
        public void mostrarTurno(DataGridView dgv, string tabla, string filtro)
        {
            dgv.Rows.Clear();
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand cTurno = new SqlCommand(string.Format(tabla + filtro), miConexion);
            SqlDataReader drTurno = cTurno.ExecuteReader();


            while (drTurno.Read())
            {
                int renglon = dgv.Rows.Add();
                dgv.Rows[renglon].Cells["Turno"].Value = drTurno[0];
                dgv.Rows[renglon].Cells["Fecha"].Value = drTurno[1];
                dgv.Rows[renglon].Cells["Nro Afiliado"].Value = drTurno[2];
                dgv.Rows[renglon].Cells["Medico"].Value = drTurno[3];
            }
        }


        //valido el turno si es correcto, es decir si busco que exista un turno para el afiliado que corresponde
        private void btValidar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(textBox1.Text))
            {
                mostrarTurno(dgvTurnos, tabla, "and T.Nro_Afiliado = " + textBox1.Text);
                if (dgvTurnos.RowCount == 0)
                {
                    MessageBox.Show("Nro Afiliado INCORRECTO");
                }
                else
                {
                    string NroAfiliado = Convert.ToString(dgvTurnos.Rows[0].Cells["Nro Afiliado"].Value);
                    UInt32 Turno = Convert.ToUInt32(dgvTurnos.Rows[0].Cells["Turno"].Value);
                    if (NroAfiliado == textBox1.Text)
                    {
                        MessageBox.Show("Turno Confirmado");
                        LlegadaConfirmada llegada = new LlegadaConfirmada(Convert.ToUInt32(NroAfiliado), Turno);
                        llegada.ShowDialog();
                        this.Hide();
                    }
                    else { MessageBox.Show("Turno Erroneo"); }
                }
            }
            else { MessageBox.Show("Complete los Campos"); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tabla = "select T.Numero,T.Fecha,T.Nro_Afiliado,T.Medico_Id from Free_Running.Turno T where not exists (select * from Free_Running.Turno_Cancelado TC where TC.Turno_Numero = T.Numero) and T.Medico_Id = " + miProf + " and T.Fecha > GETDATE()";
            mostrarTurno(dgvTurnos, tabla, ""); 
        }





    }
}
