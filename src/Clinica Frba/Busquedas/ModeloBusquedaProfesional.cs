using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.Busquedas
{
    class ModeloBusquedaProfesional
    {
        public String nombre { get; set; }
        public String dni { get; set; }
        public SqlDataReader dr_Resultados { get; set;}
        public SqlDataReader dr_Especialidades { get; set; }
        public String especialidadSeleccionada { get; set; }
        private SqlConnection miConexion;
        private SqlCommand miConsulta;
        public String consultaBuscarBase {get;set;}

        public ModeloBusquedaProfesional()
        {
            consultaBuscarBase = //CONSULTA PARA CONSEGUIR LOS PROFESIONALES
           "select distinct m.Nombre as Nombre,m.Apellido as Apellido,m.Id as Id,e.Descripcion  from" +
           "(Free_Running.Medico m left join Free_Running.Especialidad_Por_Med em on m.Id =em.Id)" +
           "join Free_Running.Especialidad e on em.Especialidad_Codigo= e.Codigo";
            
            this.nombre = "";
            
            miConexion = Conexion.Conectar();
            miConsulta = new SqlCommand("select Descripcion from Free_Running.Especialidad", miConexion);
            dr_Especialidades = miConsulta.ExecuteReader();
        }

        public void buscar()
        {

            miConexion = Conexion.Conectar();
            //
            //Ejecuto la Consulta
            //
            SqlCommand consultaBuscar = 
                new SqlCommand(consultaBuscarBase +" where " +whereNombre() +" and "+whereFiltro(), miConexion);
            dr_Resultados = consultaBuscar.ExecuteReader();
            //Filtra por el nombre, HAY QUE REVISAR EL TEMA DE LAS MINUSCULAS/MAYUSCULAS
            
        }

        private string whereNombre() {
            if (nombre.Length == 0) {
                return " 1=1 ";
            }
            String likeString = string.Format(" (Nombre like '%{0}%' or Apellido like '%{0}%')", nombre);
            return likeString;
        }

        //la clase ModeloBusquedaPaciente redefine este metodo
        public virtual string whereFiltro()
        {
            if (especialidadSeleccionada.Length == 0)
            {
                return " 1=1 ";
            }
            string especString = string.Format(" Descripcion = '{0}'", especialidadSeleccionada);
            return especString;
        }


    }
}
