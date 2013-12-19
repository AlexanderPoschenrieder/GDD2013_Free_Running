using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class ResulAtForm: Form
    {
        //Clinica_Frba.Registro_Resultado_Atencion.ModeloRegistroResultadoAtencion miModelo;
               
        public ResulAtForm(int idAtencion)
        {    
            InitializeComponent();
            AtencionID = idAtencion;
            insertarDatos(idAtencion);
        }

        UInt32 ConsultaID;

        int AtencionID;

        string tablaSintomas = "select 1 from Free_Running.Consulta_por_Sintomas s where (s.Consulta_Id = {0} and s.Sintoma_Id = '{1}')";
        string tablaEnfermedad = "select 1 from Free_Running.Consulta_por_Enfermedades e where (e.Consulta_Id = {0} and e.Enfermedades_Id ='{1}')";

        public void insertarDatos(int idAtencion)
        {
            UInt32 idConsulta;
            String stringInsert = "insert into Free_Running.Consulta(Id_Atencion_Medica) output cast(inserted.Id as int) " +
                                    "values({0})";
            SqlConnection miConexion = Conexion.Conectar();
            SqlCommand commandInsert = new SqlCommand(string.Format(stringInsert, idAtencion), miConexion);
            idConsulta = Convert.ToUInt32(commandInsert.ExecuteScalar());
            ConsultaID = idConsulta;
        }

        private void ResulAtForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2013DataSet3.Sintomas' Puede moverla o quitarla según sea necesario.
            this.sintomasTableAdapter.Fill(this.gD2C2013DataSet3.Sintomas);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2013DataSet2.Enfermedades' Puede moverla o quitarla según sea necesario.
            this.enfermedadesTableAdapter.Fill(this.gD2C2013DataSet2.Enfermedades);

        }

        private void btSintomas_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(cbSintomas.Text))
            {
                if (noRepetidoSintoma(cbSintomas.Text, tablaSintomas) != 1)
                {
                    String stringInsert = "INSERT INTO Free_Running.Consulta_por_Sintomas(Consulta_Id,Sintoma_Id)" +
                                          "values({0},'{1}')";
                    SqlConnection miConexion = Conexion.Conectar();
                    SqlCommand commandInsert = new SqlCommand(string.Format(stringInsert, ConsultaID, cbSintomas.Text), miConexion);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Sintoma Agregado con Exito");
                }
                else { MessageBox.Show("Ya existe el Sintoma"); }
            }
            else { MessageBox.Show("Complete los Sintomas"); }
        }
        
        public int noRepetidoSintoma(string texto,string tabla) 
        {
             SqlConnection miConexion = Conexion.Conectar();
             SqlCommand command = new SqlCommand(string.Format(tabla, ConsultaID, texto), miConexion);
             int result = Convert.ToInt32(command.ExecuteScalar());
             return result;
        }

        private void btEnfermedad_Click(object sender, EventArgs e)
        {
            if (Validar.noVacio(cbEnfermedad.Text))
            {
                if (noRepetidoSintoma(cbEnfermedad.Text, tablaEnfermedad) != 1)
                {
                    String stringInsert = "INSERT INTO Free_Running.Consulta_por_Enfermedades(Consulta_Id,Enfermedades_Id)" +
                                          "values({0},'{1}')";
                    SqlConnection miConexion = Conexion.Conectar();
                    SqlCommand commandInsert = new SqlCommand(string.Format(stringInsert, ConsultaID, cbEnfermedad.Text), miConexion);
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show("Enfermedad Agregado con Exito");
                }
                else { MessageBox.Show("Ya existe la Enfermedad"); }
            }
            else { MessageBox.Show("Complete la Enfermedad"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clinica_Frba.Generar_Receta.Receta receta = new Clinica_Frba.Generar_Receta.Receta(ConsultaID, AtencionID);
            receta.ShowDialog();
        }


    }
}
