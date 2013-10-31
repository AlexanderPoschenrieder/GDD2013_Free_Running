using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Pedir_Turno
{
    class ModeloBusquedaProfesional
    {
        public String nombre { get; set; }
        public ArrayList resultadoBusqueda{ get; set; }
        public ArrayList especialidades{ get; set; }
        public String especialidadSeleccionada { get; set; }
        private SqlConnection miConexion;
        private SqlCommand miConsulta;
        private String consultaBuscarBase = //CONSULTA PARA CONSEGUIR LOS PROFESIONALES
            "select distinct SUBSTRING(Nombre,0,2)+lower(substring(Nombre,2,255))+' '+Apellido as Profesional from"+
            "(Free_Running.Medico m left join Free_Running.Especialidad_Por_Med em on m.Id =em.Id)"+
            "join Free_Running.Especialidad e on em.Especialidad_Codigo= e.Codigo";

        public ModeloBusquedaProfesional()
        {
            this.nombre = "";
            miConexion = Conexion.Conectar();
            resultadoBusqueda= new ArrayList();
            especialidades = new ArrayList();
            miConsulta = new SqlCommand("select Descripcion from Free_Running.Especialidad", miConexion);
            SqlDataReader dr_Especialidades = miConsulta.ExecuteReader();

            while (dr_Especialidades.Read()) {
                especialidades.Add((dr_Especialidades[0]));   
            }
            dr_Especialidades.Close();
            miConexion.Close();
        }

        public void buscar(){
            String whereString;
            miConexion = Conexion.Conectar();
         
            if (especialidadSeleccionada.Length == 0)
            {
                whereString = "";
            }
            else {
                whereString = string.Format(" where Descripcion = '{0}'", especialidadSeleccionada);
            }
            SqlCommand consultaBuscar = new SqlCommand(consultaBuscarBase+ whereString,miConexion);
            SqlDataReader dr_resultados = consultaBuscar.ExecuteReader();
            while (dr_resultados.Read()) {

                resultadoBusqueda.Add(dr_resultados[0]);
            }

            dr_resultados.Close();
            miConexion.Close();

        }


    }
}
