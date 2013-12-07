using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class BusquedaProfesionalForm : Form
    {
        private ModeloBusquedaProfesional miModelo;
        int nroPaciente;
        
        //Constructor para la ABM pedirTurno
        public BusquedaProfesionalForm(int nro_Paciente)
        {
            miModelo = new ModeloBusquedaProfesional();
            nroPaciente = nro_Paciente;
            InitializeComponent();
            label3.Visible = false;//Deshabilito el filtro que no va
            textBox1.Visible = false;//
            //Le marco la accion ante el click del boton seleccionar
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            
            
            generarComboEspecialidades();
            gridResultados.MultiSelect = false;
            gridResultados.ReadOnly = true;
            gridResultados.Columns["Id"].Visible = false;

        }

        //Constructor para la ABM compraBono
        public BusquedaProfesionalForm() {
            miModelo = new Clinica_Frba.Compra_de_Bono.ModeloBusquedaPaciente();
            InitializeComponent();
            label2.Visible = false;//Deshabilito el filtro que no va
            comboEspecialidad.Visible = false;//
            //Le marco la accion ante el click del boton seleccionar
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Paciente);

            gridResultados.MultiSelect = false;
            gridResultados.ReadOnly = true;
            gridResultados.Columns["Id"].Visible = false;
        }

        private void generarComboEspecialidades()
        {//BINDEA EL COMBO CON LAS ESPECIALIDADES
            while (miModelo.dr_Especialidades.Read())
            {
                comboEspecialidad.Items.Add(miModelo.dr_Especialidades.GetString(0));
            }
        }
        //
        //Lleno la grilla con los resultados
        //
        private void armarGrilla()
        {
            gridResultados.Rows.Clear();
            while (miModelo.dr_Resultados.Read())
            {
                gridResultados.Rows.Add(new Object[]{      
                    miModelo.dr_Resultados.GetString(0),
                    miModelo.dr_Resultados.GetString(1),
                    Convert.ToInt32(miModelo.dr_Resultados.GetValue(2))
                    
                });
            }
          
            gridResultados.Update();
        }

        private void NombreProfTB_TextChanged(object sender, EventArgs e)
        {
            miModelo.nombre = NombreProfTB.Text;
        }

        private void botonBuscar(object sender, EventArgs e)
        {
            miModelo.especialidadSeleccionada = comboEspecialidad.Text;
            miModelo.buscar();
            armarGrilla();

        }

        //Accion para abrir la ventana para PedirTurno
        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (gridResultados.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione al profesional buscado");
            }
            else 
            {
                //Si hay excepcion no abre
                try
                {
                    int index = (int)gridResultados.SelectedCells[0].RowIndex;
                    UInt32 idMedico = Convert.ToUInt32(gridResultados.Rows[index].Cells["Id"].Value);
                    MostrarAgendaForm ventana = new MostrarAgendaForm(idMedico, nroPaciente);
                    ventana.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            };
        }


        //Accion para que levante la ventana de CompraBono
        private void SeleccionarButton_Paciente(object sender, EventArgs e) {
            if (gridResultados.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione al paciente buscado");
            }
            else {
                int index = (int)gridResultados.SelectedCells[0].RowIndex;
                int idPac = Convert.ToInt32(gridResultados.Rows[index].Cells["Id"].Value);
                Compra_de_Bono.CompraBonoForm ventana = new Clinica_Frba.Compra_de_Bono.CompraBonoForm(idPac);
                ventana.ShowDialog();            
            }
        
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            gridResultados.Rows.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            miModelo.dni = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
