using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelarAtencionPaciente : Form
    {
        ModeloCancelarAtencion miModelo;

        public CancelarAtencionPaciente(int id_Paciente)
        {
            miModelo = new ModeloCancelarAtencion(id_Paciente);
            InitializeComponent();
            dataGridTurnos.MultiSelect = false;
            llenarTurnos();
            dataGridTurnos.Columns["idTurno"].Visible = false;
        }

        //Al seleccionar se abre la ventana para que seleccione el motivo
        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridTurnos.SelectedCells[0].RowIndex;
            if (Validar.anteriorDosDias(Convert.ToDateTime(dataGridTurnos.Rows[index].Cells[0].Value)) > 0)
            {
                MessageBox.Show("Seleccione un turno anterior a dos dias");
            }
            else
            {
                long idTurno = (long)dataGridTurnos.Rows[index].Cells["idTurno"].Value;
                MotivoCancelacionForm ventanaMotivo = new MotivoCancelacionForm(idTurno);
                ventanaMotivo.ShowDialog();
                actualizarGrid();               
            }
        }

        private void llenarTurnos(){
            while (miModelo.dr_turnos.Read())
            {
                dataGridTurnos.Rows.Add(new Object[]{
                    miModelo.dr_turnos.GetDateTime(1),
                    miModelo.dr_turnos.GetString(2),
                    Convert.ToInt64(miModelo.dr_turnos.GetValue(0))
                });
            }
        }

        //actualiza la grilla para que el turno anteriormente cancelado no aparezca
        private void actualizarGrid() {
            dataGridTurnos.Rows.Clear();
            miModelo.obtenerTurnos();
            llenarTurnos();        
        
        }

        private void CancelarAtencionPaciente_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
