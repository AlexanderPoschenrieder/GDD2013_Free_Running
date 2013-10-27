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
            dtpFechaInicio.MinDate = DateTime.Today;
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaFin.MaxDate = DateTime.Today.AddDays(120);

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked)
            {
                if (dtpHoraInicio.Value.Hour > 15) { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }
                if (dtpHoraInicio.Value >= Convert.ToDateTime("14:31") && dtpHoraInicio.Value <= Convert.ToDateTime("14:45")) { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }
                if (dtpHoraInicio.Value < Convert.ToDateTime("10:00")) { dtpHoraInicio.Value = Convert.ToDateTime("14:30"); }
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
                if (dtpHoraInicio.Value < Convert.ToDateTime("07:00")) { dtpHoraInicio.Value = Convert.ToDateTime("19:30"); }
                if (dtpHoraInicio.Value > Convert.ToDateTime("07:00") && dtpHoraInicio.Value <= Convert.ToDateTime("19:59"))
                {
                    if (dtpHoraInicio.Value.Minute >= 01 && dtpHoraInicio.Value.Minute <= 15) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute >= 31 && dtpHoraInicio.Value.Minute <= 45) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(29); }
                    if (dtpHoraInicio.Value.Minute <= 29 && dtpHoraInicio.Value.Minute >= 16) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); }
                    if (dtpHoraInicio.Value.Minute <= 59 && dtpHoraInicio.Value.Minute >= 46) { dtpHoraInicio.Value = dtpHoraInicio.Value.AddMinutes(-29); dtpHoraInicio.Value = dtpHoraInicio.Value.AddHours(-1); }
                }
            }
         }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked) 
            {
                if (dtpHoraFin.Value.Hour > 15) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value >= Convert.ToDateTime("15:01") && dtpHoraFin.Value <= Convert.ToDateTime("15:15")) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value < Convert.ToDateTime("10:30")) { dtpHoraFin.Value = Convert.ToDateTime("15:00"); }
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
                if (dtpHoraFin.Value < Convert.ToDateTime("07:30")) { dtpHoraFin.Value = Convert.ToDateTime("20:00"); }
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
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
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










        
    }
}
