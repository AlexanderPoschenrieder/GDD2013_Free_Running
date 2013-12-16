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
using Clinica_Frba.Login;
using System.Globalization;
using System.Threading;



namespace Clinica_Frba.Registrar_Agenda
{
    public partial class ABM_Agenda : Form
    {

        public static Medico miMedico;

        public ABM_Agenda(Medico unMedic)
        {
            InitializeComponent();
            miMedico = unMedic;
            limpiar();

        }

        public ABM_Agenda(long idMedic)
        {
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand consultaMedico = new SqlCommand("select * from Free_Running.Medico where Id='" + idMedic + "'", miConexion);
            SqlDataReader dr_Medico = consultaMedico.ExecuteReader();
            dr_Medico.Read();
            Medico unMedico = new Medico(Convert.ToUInt32(dr_Medico[0]), Convert.ToString(dr_Medico[1]), Convert.ToString(dr_Medico[2]), Convert.ToString(dr_Medico[3]), Convert.ToString(dr_Medico[4]), Convert.ToUInt32(dr_Medico[5]), Convert.ToString(dr_Medico[6]), Convert.ToUInt32(dr_Medico[7]), Convert.ToString(dr_Medico[8]), Convert.ToDateTime(dr_Medico[9]), Convert.ToUInt32(dr_Medico[10]), Convert.ToString(dr_Medico[11]), "");
            miConexion.Close();
            InitializeComponent();
            miMedico = unMedico;
            limpiar();
    
        }

        public void limpiar()
        {
            dtpHoraInicio.Value = Convert.ToDateTime("07:00");
            dtpHoraFin.Value = Convert.ToDateTime("7:30");
            dtpFechaInicio.MinDate = DateTime.Today.AddDays(1);
            dtpFechaInicio.Value = DateTime.Today.AddDays(1);
            dtpFechaFin.Value = DateTime.Today.AddDays(2);
            dtpFechaFin.MinDate = DateTime.Today.AddDays(2);
            dtpFechaFin.MaxDate = DateTime.Today.AddDays(122);
            cbLunes.Checked = false;
            cbMartes.Checked = false;
            cbMierc.Checked = false;
            cbJ.Checked = false;
            cbV.Checked = false;
            cbS.Checked = false;
        }

        public bool superaHs()
        {
            bool rta = false;
            int total = 0;
            DateTime actualFin = Convert.ToDateTime(dtpHoraFin.Value);
            DateTime actualInicio = Convert.ToDateTime(dtpHoraInicio.Value);
            int aF = Convert.ToInt32((actualFin).ToString("HHmm"));
            int aI = Convert.ToInt32((actualInicio).ToString("HHmm"));
            int res = aF - aI;
            total = (res) * (cantDias());
            if (total > 4800) { rta = true; }
            return rta;
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

        public void validarRangoHsInicio()
        {
            if (cbS.Checked)
            {
                if (dtpHoraInicio.Value.Hour > 14) { dtpHoraInicio.Value = Convert.ToDateTime("10:00"); }
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

        public void validarRangoSabado()
        {
            if (cbS.Checked)
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

        public void validarRangoHsFin()
        {
            if (cbS.Checked)
            {
                if (dtpHoraFin.Value.Hour > 15) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value.Hour == 15 && dtpHoraFin.Value.Minute == 59) { dtpHoraFin.Value = Convert.ToDateTime("14:30"); }

                if (dtpHoraFin.Value >= Convert.ToDateTime("15:01") && dtpHoraFin.Value <= Convert.ToDateTime("15:30")) { dtpHoraFin.Value = Convert.ToDateTime("10:30"); }
                if (dtpHoraFin.Value < Convert.ToDateTime("10:29") && dtpHoraFin.Value > Convert.ToDateTime("5:29")) { dtpHoraFin.Value = Convert.ToDateTime("15:00"); }
                if (dtpHoraFin.Value > Convert.ToDateTime("10:28") && dtpHoraFin.Value <= Convert.ToDateTime("15:59"))
                {
                    if (dtpHoraFin.Value.Minute >= 01 && dtpHoraFin.Value.Minute <= 15) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute >= 31 && dtpHoraFin.Value.Minute <= 45) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute <= 29 && dtpHoraFin.Value.Minute >= 16) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); }
                    if (dtpHoraFin.Value.Minute <= 59 && dtpHoraFin.Value.Minute >= 46) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); dtpHoraFin.Value = dtpHoraFin.Value.AddHours(-1); }
                }
            }
            else
            {
                if (dtpHoraFin.Value.Hour >= 20) { dtpHoraFin.Value = Convert.ToDateTime("07:30"); }
                if (dtpHoraFin.Value >= Convert.ToDateTime("20:01") && dtpHoraFin.Value <= Convert.ToDateTime("20:15")) { dtpHoraFin.Value = Convert.ToDateTime("07:30"); }
                if (dtpHoraFin.Value <= Convert.ToDateTime("07:29") && dtpHoraFin.Value > Convert.ToDateTime("05:29")) { dtpHoraFin.Value = Convert.ToDateTime("20:00"); }
                if (dtpHoraFin.Value > Convert.ToDateTime("07:28") && dtpHoraFin.Value <= Convert.ToDateTime("20:59"))
                {
                    if (dtpHoraFin.Value.Minute >= 01 && dtpHoraFin.Value.Minute <= 15) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute >= 31 && dtpHoraFin.Value.Minute <= 45) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(29); }
                    if (dtpHoraFin.Value.Minute <= 29 && dtpHoraFin.Value.Minute >= 16) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); }
                    if (dtpHoraFin.Value.Minute <= 59 && dtpHoraFin.Value.Minute >= 46) { dtpHoraFin.Value = dtpHoraFin.Value.AddMinutes(-29); dtpHoraFin.Value = dtpHoraFin.Value.AddHours(-1); }
                }
            }

        }

        public bool hayAgenda()
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = miConexion;
                cmd.CommandText = "Free_Running.existeAgenda";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parMedico = cmd.Parameters.Add("@Medico", SqlDbType.Decimal);
                parMedico.Value = miMedico.Id;
                SqlDataReader drAgenda = cmd.ExecuteReader();
                if (drAgenda.Read() == true)
                {
                    if (Convert.ToDateTime(drAgenda[2]) < DateTime.Now)
                    {
                        MessageBox.Show("Agenda Actual Vencida: " + drAgenda[2]);
                        SqlConnection miConexion2 = Conexion.Conectar();
                        SqlCommand consultaAgenda = new SqlCommand("DELETE FROM Free_Running.Agenda  WHERE Medico ='" + miMedico.Id + "'", miConexion2);
                        consultaAgenda.ExecuteReader();
                        miConexion2.Close();
                        miConexion.Close();
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Ya Existe Una Agenda Hasta: " + drAgenda[2]);
                        miConexion.Close();
                        return true;
                    }
                }
                else
                {
                    miConexion.Close();
                    return false;
                }
            }
        }

        public bool esDiaSeleccionado(DateTime FechaRec)
        {
            bool rta = false;
            switch (FechaRec.ToString("dddd", new CultureInfo("es-ES")))
            {
                case "lunes": if (cbLunes.Checked) { rta = true; }
                    break;
                case "martes": if (cbMartes.Checked) { rta = true; }
                    break;
                case "miércoles": if (cbMierc.Checked) { rta = true; }
                    break;
                case "jueves": if (cbJ.Checked) { rta = true; }
                    break;
                case "viernes": if (cbV.Checked) { rta = true; }
                    break;
                case "sábado": if (cbS.Checked) { rta = true; }
                    break;
            }
            return rta;

        }

        public void insertarAgenda()
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {
                DateTime fRecorrido = dtpFechaInicio.Value;
                while (fRecorrido <= dtpFechaFin.Value)
                {
                    if (esDiaSeleccionado(fRecorrido))
                    {
                        DateTime HoraInicio = Convert.ToDateTime(Convert.ToString(dtpHoraInicio.Value));
                        DateTime HoraFin = Convert.ToDateTime(Convert.ToString(dtpHoraFin.Value));
                        DateTime HoraRec;
                        HoraRec = HoraInicio;

                        while (HoraRec <= HoraFin)
                        {

                            DateTime dt = (fRecorrido.AddHours(HoraRec.Hour)).AddMinutes(HoraRec.Minute);
                            SqlCommand cargarAgenda = new SqlCommand(string.Format("insert into Free_Running.Agenda(Medico,FechaHora_Turno)values(" + miMedico.Id + ",@Fecha )"), miConexion);
                            cargarAgenda.Parameters.Add(new SqlParameter("@Fecha", System.Data.SqlDbType.DateTime));
                            cargarAgenda.Parameters["@Fecha"].Value = dt;
                            cargarAgenda.ExecuteNonQuery();
                            HoraRec = HoraRec.AddMinutes(30);

                        }

                    }
                    fRecorrido = fRecorrido.AddDays(1);
                }

            }
            MessageBox.Show("Operacion Realizada con Exito");
            limpiar();

        }

        private void dtpFechaInicio_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.MaxDate)
            {
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(121);
                dtpFechaFin.MinDate = dtpFechaInicio.Value.AddDays(1);
            }
            if (dtpFechaInicio.Value <= dtpFechaFin.MaxDate && dtpFechaInicio.Value >= dtpFechaFin.MinDate)
            {
                dtpFechaFin.MinDate = dtpFechaInicio.Value.AddDays(1);
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(121);
            }
            if (dtpFechaInicio.Value < dtpFechaFin.MinDate)
            {
                dtpFechaFin.MinDate = dtpFechaInicio.Value.AddDays(1);
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(121);
            }
            dtpFechaFin.MinDate = dtpFechaInicio.Value.AddDays(1);
            dtpFechaFin.Value = dtpFechaInicio.Value.AddDays(1);
        }  

        public int cantDias()
        {
            int dias = 0;
            if (cbLunes.Checked) { dias = dias + 1; }
            if (cbMartes.Checked) { dias = dias + 1; }
            if (cbMierc.Checked) { dias = dias + 1; }
            if (cbJ.Checked) { dias = dias + 1; }
            if (cbV.Checked) { dias = dias + 1; }
            if (cbS.Checked) { dias = dias + 1; }
            return dias;
        }

        private void dtpHoraFin_ValueChanged(object sender, EventArgs e)
        {
            validarRangoHsFin();
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            validarRangoHsInicio();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (cbLunes.Checked || cbMartes.Checked || cbMierc.Checked || cbJ.Checked || cbV.Checked || cbS.Checked)
            {
                if (difHs() >= 0.5)
                {
                    if (!superaHs())
                    {
                        if (!hayAgenda())
                        {
                            insertarAgenda();
                        }
                    }
                    else { MessageBox.Show("Ha Superado El Maximo Permitido de Hs Por Semana"); }
                }
                else { MessageBox.Show("La Hora de Inicio debe ser Menor A La hora Final"); }

            }
            else { MessageBox.Show("Debe Seleccionar por lo menos 1 dia"); }
        }

        private void cbS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbS.Checked)
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

        private void btLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dtpHoraInicio_ValueChanged_1(object sender, EventArgs e)
        {
            validarRangoHsInicio();
        }

        private void dtpHoraFin_ValueChanged_1(object sender, EventArgs e)
        {
            validarRangoHsFin();
        }

    }
}
