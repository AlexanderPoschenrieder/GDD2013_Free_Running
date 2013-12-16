using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class Agregar_Especilidades : Form
    {
        List<EspecilidadMedica> listaEspecialidades = new List<EspecilidadMedica>();
        long IdMedico;
        Login.Medico Medico;

        public Agregar_Especilidades(Login.Medico unMedico, long Id)
        {
            InitializeComponent();
            this.Medico = unMedico;
            this.IdMedico = Id;
        }

        private void Especialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_Especilidades_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                long especilidad = Convert.ToUInt32(Especilidadestxt.Text);
                EspecilidadMedica aux = new EspecilidadMedica(especilidad);

                foreach (EspecilidadMedica p in listaEspecialidades)
                {
                    if (p.getEspecilidad() == aux.getEspecilidad())
                    {
                        throw new Exception("Dicha especilidad ya ha sido cargada");
                    }
                }
                listaEspecialidades.Add(aux);
                Medico.Insertar_especialidad(this.IdMedico, especilidad);
                cargarTabla();

            }
            catch (FormatException)
            {
                Validar.MsnError("Ingrese valores correctos a la lista", "Especialidades");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cargarTabla()
        {
            ListaDeEspecialidades.Rows.Clear();
            foreach (EspecilidadMedica p in listaEspecialidades)
            {
                ListaDeEspecialidades.Rows.Add(new Object[] { p.getEspecilidad().ToString() });

            }
            ListaDeEspecialidades.Update();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Validar.MsnAccept("Profesional cargado de forma exitosa", "Insercion de datos"); 
        }
    }
}
