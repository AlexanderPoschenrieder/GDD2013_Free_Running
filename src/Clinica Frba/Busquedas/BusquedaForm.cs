using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Busquedas
{
    public partial class BusquedaForm : Form
    {
        private ModeloBusquedaProfesional miModelo;
        Perfil miPerfil;
        
        //Constructor para la ABM pedirTurno

        public BusquedaForm(Perfil perf) {
            if (perf.perfil == "pac")
            {
                miModelo = new Clinica_Frba.Busquedas.ModeloBusquedaPaciente();
                InitializeComponent();
                label2.Visible = false;//Deshabilito el filtro que no va
                comboEspecialidad.Visible = false;//
                //Le marco la accion ante el click del boton seleccionar
                this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Paciente);
            }
            else
            {
                miModelo = new ModeloBusquedaProfesional();
                miPerfil = perf;
                InitializeComponent();
                label3.Visible = false;//Deshabilito el filtro que no va
                textBox1.Visible = false;//
                generarComboEspecialidades();
                //Le marco la accion ante el click del boton seleccionar
                switch (perf.perfil){
                    case "P": 
                        this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
                        break;
                    case "M":
                        this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Llegada);
                        break;
                    case "A":
                        this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Agenda);
                        break;
                }
            }

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
            comboEspecialidad.Items.Add("");
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
                    Clinica_Frba.Pedir_Turno.MostrarAgendaForm ventana = new Clinica_Frba.Pedir_Turno.MostrarAgendaForm(idMedico, (int)miPerfil.parametro);
                    ventana.ShowDialog();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            };
        }

        //Accion para que levante la ventana registro de llegada
        private void SeleccionarButton_Llegada(object sender, EventArgs e)
        {
            int index = (int)gridResultados.SelectedCells[0].RowIndex;
            UInt32 miProfesional = Convert.ToUInt32(gridResultados.Rows[index].Cells["Id"].Value);
            Clinica_Frba.Registro_de_LLegada.Turnos_Llegada turnoLlegada = new Clinica_Frba.Registro_de_LLegada.Turnos_Llegada(miProfesional, comboEspecialidad.Text);
            turnoLlegada.ShowDialog();
        }

        //Accion para levantar la ventana de Registrar Agenda
        private void SeleccionarButton_Agenda(object sender, EventArgs e)
        {
            int index = (int)gridResultados.SelectedCells[0].RowIndex;
            UInt32 miProfesional = Convert.ToUInt32(gridResultados.Rows[index].Cells["Id"].Value);
            Clinica_Frba.Registrar_Agenda.ABM_Agenda agenda = new Clinica_Frba.Registrar_Agenda.ABM_Agenda(miProfesional);
            agenda.ShowDialog();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

    }
}
