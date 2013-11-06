using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Listados_Estadisticos
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();

        }
        public DateTime inicio;
        public DateTime fin;

        public void fechas(DateTime año, int Semestre)
        {
            if (Semestre == 1)
            {
                inicio = new DateTime(año.Year, 1, 1, 0, 0, 0);
                fin = new DateTime(año.Year, 7, 2, 12, 30, 0);
            }
            else
            {

                inicio = new DateTime(año.Year, 7, 2, 12, 31, 0);
                fin = new DateTime(año.Year, 12, 31, 23, 59, 0);
            }
        }



        private void btEspCanc_Click_1(object sender, EventArgs e)
        {
            DateTime año = Convert.ToDateTime(dtpAño.Value);
            int sem = Convert.ToInt32(nSemestre.Value);
            fechas(año, sem);
            this.Hide();
            Clinica_Frba.Listados_Estadisticos.EspMasCanceladas top = new EspMasCanceladas(inicio, fin);
            top.ShowDialog();

        }

        private void btAfiliadoBFvenc_Click_1(object sender, EventArgs e)
        {
            DateTime año = Convert.ToDateTime(dtpAño.Value);
            int sem = Convert.ToInt32(nSemestre.Value);
            fechas(año, sem);
            this.Hide();
            Clinica_Frba.Listados_Estadisticos.AfiliadoBFvenc top = new AfiliadoBFvenc(inicio, fin);
            top.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DateTime año = Convert.ToDateTime(dtpAño.Value);
            int sem = Convert.ToInt32(nSemestre.Value);
            fechas(año, sem);
            this.Hide();
            Clinica_Frba.Listados_Estadisticos.EspMasBFvencidos top = new EspMasBFvencidos(inicio, fin);
            top.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DateTime año = Convert.ToDateTime(dtpAño.Value);
            int sem = Convert.ToInt32(nSemestre.Value);
            fechas(año, sem);
            this.Hide();
            Clinica_Frba.Listados_Estadisticos.AfiliadosMasBnoPropios top = new AfiliadosMasBnoPropios(inicio, fin);
            top.ShowDialog();
        }


    }
}
