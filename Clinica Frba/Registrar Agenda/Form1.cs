using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpFechaInicio.MinDate = DateTime.Today.AddDays(1);
            dtpFechaInicio.Value = DateTime.Today.AddDays(1);
            dtpFechaFin.Value = DateTime.Today.AddDays(1);
            dtpFechaFin.MinDate = DateTime.Today.AddDays(1);
            dtpFechaFin.MaxDate = DateTime.Today.AddDays(121);



        }

        public void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked)
            {
                if (dtpHoraInicio.Value.Hour > 15) { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }
                if (dtpHoraInicio.Value >= Convert.ToDateTime("14:31") && dtpHoraInicio.Value <= Convert.ToDateTime("14:45")) { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }
                if (dtpHoraInicio.Value < Convert.ToDateTime("9:59") && dtpHoraInicio.Value > Convert.ToDateTime("05:59")) { dtpHoraInicio.Value = Convert.ToDateTime("14:30"); }
                if (dtpHoraInicio.Value > Convert.ToDateTime("10:00") && dtpHoraInicio.Value <= Convert.ToDateTime("14:59"))
                {
                    if (dtpHoraInicio.Value.Minute >= 01 && dtpHoraInicio.Value.Minute <= 15) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute >= 31 && dtpHoraInicio.Value.Minute <= 45) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute <= 29 && dtpHoraInicio.Value.Minute >= 16) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); }
                    if (dtpHoraInicio.Value.Minute <= 59 && dtpHoraInicio.Value.Minute >= 46) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); dtpHoraInicio.Value = dtpHoraInicio.Value.AddHours(-1); }
                }
            }
            else
            {
                if (dtpHoraInicio.Value.Hour > 19) { dtpHoraInicio.Value = Convert.ToDateTime("07:00"); }
                if (dtpHoraInicio.Value >= Convert.ToDateTime("19:31") && dtpHoraInicio.Value <= Convert.ToDateTime("19:45")) { dtpHoraInicio.Value = Convert.ToDateTime("07:00"); }
                if (dtpHoraInicio.Value < Convert.ToDateTime("06:59") && dtpHoraInicio.Value > Convert.ToDateTime("05:59")) { dtpHoraInicio.Value = Convert.ToDateTime("19:30"); }

                if (dtpHoraInicio.Value > Convert.ToDateTime("07:00") && dtpHoraInicio.Value <= Convert.ToDateTime("19:59"))
                {
                    if (dtpHoraInicio.Value.Minute >= 01 && dtpHoraInicio.Value.Minute <= 15) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute >= 31 && dtpHoraInicio.Value.Minute <= 45) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute <= 29 && dtpHoraInicio.Value.Minute >= 16) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); }
                    if (dtpHoraInicio.Value.Minute <= 59 && dtpHoraInicio.Value.Minute >= 46) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); dtpHoraInicio.Value = dtpHoraInicio.Value.AddHours(-1); }
                }
            }

         }

        public void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked) 
            {
                if (dtpHoraFin.Value.Hour > 15) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value >= Convert.ToDateTime("15:01") && dtpHoraFin.Value <= Convert.ToDateTime("15:15")) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value < Convert.ToDateTime("10:29") && dtpHoraFin.Value > Convert.ToDateTime("5:29")) { dtpHoraFin.Value = Convert.ToDateTime("15:00"); }
                if (dtpHoraFin.Value > Convert.ToDateTime("10:30") && dtpHoraFin.Value <= Convert.ToDateTime("15:59"))
                {
                    if (dtpHoraFin.Value.Minute >= 01 && dtpHoraFin.Value.Minute <= 15) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute >= 31 && dtpHoraFin.Value.Minute <= 45) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute <= 29 && dtpHoraFin.Value.Minute >= 16) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); }
                    if (dtpHoraFin.Value.Minute <= 59 && dtpHoraFin.Value.Minute >= 46) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); dtpHoraFin.Value = dtpHoraFin.Value.AddHours(-1); }
                }
            }
            else
            {
                if (dtpHoraFin.Value.Hour > 20) { dtpHoraFin.Value = Convert.ToDateTime("07:30"); }
                if (dtpHoraFin.Value >= Convert.ToDateTime("20:01") && dtpHoraFin.Value <= Convert.ToDateTime("20:15")) { dtpHoraFin.Value = Convert.ToDateTime("07:30"); }
                if (dtpHoraFin.Value < Convert.ToDateTime("07:29") && dtpHoraFin.Value > Convert.ToDateTime("05:29")) { dtpHoraFin.Value = Convert.ToDateTime("20:00"); }
                if (dtpHoraFin.Value > Convert.ToDateTime("07:30") && dtpHoraFin.Value <= Convert.ToDateTime("20:59"))
                {
                    if (dtpHoraFin.Value.Minute >= 01 && dtpHoraFin.Value.Minute <= 15) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute >= 31 && dtpHoraFin.Value.Minute <= 45) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute <= 29 && dtpHoraFin.Value.Minute >= 16) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); }
                    if (dtpHoraFin.Value.Minute <= 59 && dtpHoraFin.Value.Minute >= 46) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); dtpHoraFin.Value = dtpHoraFin.Value.AddHours(-1); }
                }
            }


        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

            if (dtpFechaInicio.Value > dtpFechaFin.MaxDate)
            {
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
                dtpFechaFin.MinDate = dtpFechaInicio.Value;

            }
           
            
            if (dtpFechaInicio.Value < dtpFechaFin.MinDate)
            {
                dtpFechaFin.MinDate = dtpFechaInicio.Value;
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
            }
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void cbSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked) 
            {
                if (dtpHoraInicio.Value < Convert.ToDateTime("10:00"))
                { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }

                if (dtpHoraInicio.Value > Convert.ToDateTime("14:30"))
                { dtpHoraInicio.Value = Convert.ToDateTime("14:30"); }

                if (dtpHoraFin.Value < Convert.ToDateTime("10:30"))
                { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }

                if (dtpHoraFin.Value > Convert.ToDateTime("15:00"))
                { dtpHoraFin.Value = Convert.ToDateTime("15:00"); }
            }
        }

        public int cantDiasActivos()
        {
            int i = 0;
            if (cbLunes.Checked) { i = i + 1; }
            if (cbMartes.Checked) { i = i + 1; }
            if (cbMiercoles.Checked) { i = i + 1; }
            if (cbJueves.Checked) { i = i + 1; }
            if (cbViernes.Checked) { i = i + 1; }
            if (cbSabado.Checked) { i = i + 1; }
            return i;
        }

        public double difHs()
        {
            double hFin = dtpHoraFin.Value.Hour * 60;
            double hInicio = dtpHoraInicio.Value.Hour * 60;
            double mFin = dtpHoraFin.Value.Minute + hFin;
            double mInicio = dtpHoraInicio.Value.Minute + hInicio;
            double result = (mFin - mInicio) / 60;
            return result;
        }

        public bool Validar()
        {
            bool i = true;
            if (difHs() <= 0) { MessageBox.Show("El Rango Horario tiene que ser Positivo"); i = false; }
            if (cantDiasActivos() == 0) { MessageBox.Show("Debe seleccionar por lo menos 1 dia"); i = false; }
            if (cantDiasActivos() * difHs() > 48) { MessageBox.Show("Cantidad de Hs Superior al Permitido (48)"); i = false; }
            //yaexistehorario
            //rango fecha lo valida solo
            return i;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Validar()) { } //Guardar}
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }



        
    }

}
