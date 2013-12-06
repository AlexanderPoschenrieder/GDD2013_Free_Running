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
    public partial class Eliminar_Afiliado : Form
    {
        public Eliminar_Afiliado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(NroAfiliadotxt.Text))
            {

                long Numero_afiliado = Convert.ToInt32(NroAfiliadotxt.Text);//carga de datos

                if (Validar.existe_afiliado("Nro_Afiliado", Numero_afiliado, "Cantidad_afiliados"))
                {
                    Login.Paciente.sinTurnos(Numero_afiliado);//elimino los turnos del paciente
                    Login.Usuario.Eliminar_usuario("Nro_Afiliado", Numero_afiliado, "Free_Running.Paciente");//ejecuta el método que elimina al afiliado
                    Validar.MsnAccept("El Afiliado fue eliminado de forma exitosa", "Eliminar Afiliado");
                    NroAfiliadotxt.Clear();
                }
                else
                {
                    Validar.MsnError("El Afiliado no se encuentra en el Sistema", "Eliminar");
                    NroAfiliadotxt.Clear();
                }
            }

            else
            {
                Validar.MsnError("Completar los datos", "Eliminar");
            }
        }


    }
}
