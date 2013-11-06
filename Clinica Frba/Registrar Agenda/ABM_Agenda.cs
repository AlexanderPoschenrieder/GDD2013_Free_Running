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


namespace Clinica_Frba.Registrar_Agenda
{
    public partial class ABM_Agenda : Form
    {

        static ArrayList misDias = new ArrayList();

        public static Medico miMedico;

        public ABM_Agenda(Medico unMedic)
        {
            InitializeComponent();
            miMedico = unMedic;
            limpiar();

        }

        public void limpiar()
        {
            dtpHoraInicio.Value = Convert.ToDateTime("07:00");
            dtpHoraFin.Value = Convert.ToDateTime("7:30");
            dtpFechaInicio.MinDate = DateTime.Today.AddDays(1);
            dtpFechaInicio.Value = DateTime.Today.AddDays(1);
            dtpFechaFin.Value = DateTime.Today.AddDays(1);
            dtpFechaFin.MinDate = DateTime.Today.AddDays(1);
            dtpFechaFin.MaxDate = DateTime.Today.AddDays(121);
            lbDiascargados.Items.Clear();
            misDias.Clear();
        }

        public void incertarLita(AgendaDia unDia)
        {
            string agenda = "Dia: " + Convert.ToString(unDia.dia) + " Desde: " + Convert.ToString(unDia.HoraInicio.ToString("HH:mm")) + " Hasta: " + Convert.ToString(unDia.HoraFin.ToString("HH:mm"));
            lbDiascargados.Items.Add(agenda);
            misDias.Add(unDia.dia);
            misDias.Add(unDia.HoraInicio);
            misDias.Add(unDia.HoraFin);

        }

        public bool Repetido(string dia, DateTime inicio, DateTime fin)
        {
            bool a = false;
            if (misDias.Count > 1)
            {
                for (int i = 0; i < misDias.Count; i = i + 3)
                {
                    if (igualDia(misDias[i], misDias[i + 1], misDias[i + 2], dia, inicio, fin))
                    { a = true; }
                }
            }
            return a;
        }

        public bool igualDia(object Ldia, object Linicio, object Lfin, string dia, DateTime inicio, DateTime fin)
        {

            bool i = false;
            if (Convert.ToString(Ldia) == dia)
            {
                if (Convert.ToDateTime(Linicio) >= inicio && Convert.ToDateTime(Lfin) <= fin) { i = true; }
                if (Convert.ToDateTime(Linicio) <= inicio && Convert.ToDateTime(Lfin) >= fin) { i = true; }
                if (Convert.ToDateTime(Linicio) < inicio && Convert.ToDateTime(Lfin) > inicio) { i = true; }
                if (Convert.ToDateTime(Linicio) < fin && Convert.ToDateTime(Lfin) > fin) { i = true; }
            }
            return i;

        }

        public bool superaHs()
        {
            bool rta = false;
            int total = 0;
            DateTime result = Convert.ToDateTime("00:00");
            DateTime actualresult = Convert.ToDateTime("00:00");
            for (int i = 0; i < misDias.Count; i = i + 3)
            {
                DateTime inicio = Convert.ToDateTime(misDias[i + 1]);
                DateTime fin = Convert.ToDateTime(misDias[i + 2]);
                int intInicio = Convert.ToInt32((inicio.ToString("HHmm")));
                int intFin = Convert.ToInt32((fin.ToString("HHmm")));
                int intRes = intFin - intInicio;
                total = total + intRes;
            }

            DateTime actualFin = Convert.ToDateTime(dtpHoraFin.Value);
            DateTime actualInicio = Convert.ToDateTime(dtpHoraInicio.Value);
            int aF = Convert.ToInt32((actualFin).ToString("HHmm"));
            int aI = Convert.ToInt32((actualInicio).ToString("HHmm"));
            int res = aF - aI;
            total = res + total;
            if (total > 4800) { total = total - res; rta = true; }
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
            if (cbDias.Text == "Sabado")
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
            if (cbDias.Text == "Sabado")
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
            if (cbDias.Text == "Sabado")
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
                {//30
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
                    if (Convert.ToDateTime(drAgenda[3]) < DateTime.Now)
                    {
                        //MessageBox.Show("Agenda Actual Vencida: " + drAgenda[3]);
                        SqlConnection miConexion2 = Conexion.Conectar();
                        SqlCommand consultaAgenda = new SqlCommand("DELETE FROM Free_Running.Agenda  WHERE Medico ='" + miMedico.Id + "'", miConexion2);
                        consultaAgenda.ExecuteReader();
                        miConexion2.Close();
                        miConexion.Close();
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Ya Existe Una Agenda Hasta: " + drAgenda[3]);
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

        public void insertarAgenda()
        {
            using (SqlConnection miConexion = Conexion.Conectar())
            {
                SqlCommand consultaAgenda = new SqlCommand(string.Format("INSERT INTO Free_Running.Agenda(Medico,Fecha_Inicio,Fecha_Fin)values('{0}','{1}','{2}')", miMedico.Id, dtpFechaInicio.Value, dtpFechaFin.Value), miConexion);
                consultaAgenda.ExecuteNonQuery();

                SqlCommand miAgenda = new SqlCommand(string.Format("select * from Free_Running.Agenda A where ((A.Medico = '{0}') and (A.Fecha_Inicio = '{1}') and (A.Fecha_Fin='{2}'))", miMedico.Id, dtpFechaInicio.Value, dtpFechaFin.Value), miConexion);
                SqlDataReader drAgenda = miAgenda.ExecuteReader();
                drAgenda.Read();
                int idAgenda = Convert.ToInt32(drAgenda[0]);
                drAgenda.Dispose();


                for (int i = 0; i < misDias.Count; i = i + 3)
                {

                    SqlCommand consultaL = new SqlCommand(string.Format(
                        "INSERT INTO Free_Running.Agenda_Dia(Agenda,Dia_Semana,Hora_Inicio,Hora_Fin)values('{0}','{1}','{2}','{3}')", idAgenda, Convert.ToString(misDias[i]), Convert.ToDateTime(misDias[i + 1]), Convert.ToString(misDias[i + 2])), miConexion);
                    consultaL.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Operacion Realizada con Exito");
            limpiar();

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dtpFechaInicio_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.MaxDate)
            {
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
                dtpFechaFin.MinDate = dtpFechaInicio.Value;
            }
            if (dtpFechaInicio.Value <= dtpFechaFin.MaxDate && dtpFechaInicio.Value >= dtpFechaFin.MinDate)
            {
                dtpFechaFin.MinDate = dtpFechaInicio.Value;
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
            }
            if (dtpFechaInicio.Value < dtpFechaFin.MinDate)
            {
                dtpFechaFin.MinDate = dtpFechaInicio.Value;
                dtpFechaFin.MaxDate = dtpFechaInicio.Value.AddDays(120);
            }
            dtpFechaFin.MinDate = dtpFechaInicio.Value;
            dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(cbDias.Text))
            {

                if (difHs() >= 0.5)
                {
                    if (!Repetido(cbDias.Text, dtpHoraInicio.Value, dtpHoraFin.Value))
                    {

                        if (!superaHs())
                        {
                            AgendaDia agendaDia = new AgendaDia(cbDias.Text, dtpHoraInicio.Value, dtpHoraFin.Value);
                            incertarLita(agendaDia);

                        }
                        else { MessageBox.Show("Ha superado el limite de 48hs"); }
                    }
                    else { MessageBox.Show("Dia Repetido"); }
                }
                else { MessageBox.Show("La Hs de inicio debe ser menor que la Hs Final"); }
            }
            else { MessageBox.Show("Complete el Dia"); }
        }

        private void cbDias_TextChanged_1(object sender, EventArgs e)
        {
            if (cbDias.Text == "Sabado")
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
            if (lbDiascargados.Items.Count > 0)
            {
                if (!hayAgenda()) { insertarAgenda(); }
            }
            else { MessageBox.Show("Debe Cargar Los Horarios"); }
        }

    }
}
//limpiar al guardar , mje de operacion grabada con exito