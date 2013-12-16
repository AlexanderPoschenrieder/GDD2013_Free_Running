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
        delegate void funcionVentana();
        funcionVentana ventanaALevantar;
        UInt32 idBuscado;
        Perfil miPerfil;
        
        //Constructor para la ABM pedirTurno

        public BusquedaForm(Perfil perf) {
            if (perf.perfil == "pac")
            {
                miModelo = new Clinica_Frba.Busquedas.ModeloBusquedaPaciente();
                InitializeComponent();
                label2.Visible = false;//Deshabilito el filtro que no va
                comboEspecialidad.Visible = false;//
                //Le marco la ventana a levantar ante el click del boton seleccionar
                ventanaALevantar = () =>(new Clinica_Frba.Compra_de_Bono.CompraBonoForm((int)idBuscado)).ShowDialog();
            }
            else
            {
                miModelo = new ModeloBusquedaProfesional();
                miPerfil = perf;
                InitializeComponent();
                label3.Visible = false;//Deshabilito el filtro que no va
                textBox1.Visible = false;//
                generarComboEspecialidades();
                //Le marco la ventana a levantar ante el click del boton seleccionar
                switch (perf.perfil){
                    case "P":
                        ventanaALevantar = () =>
                        //ABM Pedir turno
                        {
                            try
                            {
                                (new Clinica_Frba.Pedir_Turno.MostrarAgendaForm(idBuscado, (int)miPerfil.parametro)).ShowDialog();
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        };        
                        break;
                    case "M":
                        //ABM llegada turnos
                        ventanaALevantar = () => (new Clinica_Frba.Registro_de_LLegada.Turnos_Llegada(idBuscado, comboEspecialidad.Text)).ShowDialog();
                        break;
                    case "A":
                        //ABM registrar Agenda
                        ventanaALevantar = () => (new Clinica_Frba.Registrar_Agenda.ABM_Agenda(idBuscado)).ShowDialog();
                        break;
                }
            }

            gridResultados.MultiSelect = false;
            gridResultados.ReadOnly = true;
            gridResultados.Columns["Id"].Visible = false;  
        }

        private void generarComboEspecialidades()
        {
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
        
        private void SeleccionarButton_Click(object sender, EventArgs e) {
            if (gridResultados.SelectedCells.Count == 0)
            {
                MessageBox.Show("Seleccione al paciente buscado");
            }
            else
            {
                int index = (int)gridResultados.SelectedCells[0].RowIndex;
                idBuscado= Convert.ToUInt32(gridResultados.Rows[index].Cells["Id"].Value);
                ventanaALevantar();
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
