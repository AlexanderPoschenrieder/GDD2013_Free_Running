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
        public SqlDataReader dr_Medicos { get; set;}
        public SqlDataReader dr_Especialidades { get; set; }
        public String especialidadSeleccionada { get; set; }
        private SqlConnection miConexion;
        private SqlCommand miConsulta;
        private String consultaBuscarBase = //CONSULTA PARA CONSEGUIR LOS PROFESIONALES
            "select distinct m.Nombre,m.Apellido,m.Id  from"+
            "(Free_Running.Medico m left join Free_Running.Especialidad_Por_Med em on m.Id =em.Id)"+
            "join Free_Running.Especialidad e on em.Especialidad_Codigo= e.Codigo";

        public ModeloBusquedaProfesional()
        {
            this.nombre = "";
            miConexion = Conexion.Conectar();
            miConsulta = new SqlCommand("select Descripcion from Free_Running.Especialidad", miConexion);
            dr_Especialidades = miConsulta.ExecuteReader();
        }

        public void buscar()
        {

            String whereString;
            String likeString= string.Format("and (m.Nombre like '%{0}%' or m.Apellido like '%{0}%')",nombre);
            miConexion = Conexion.Conectar();
            
            //
            //Armo la consulta con el WHERE
            //
            if (especialidadSeleccionada.Length == 0)
            {
                whereString = " where 1=1 ";//Muestra todos los profesionales
            }
            else
            {
                whereString = string.Format(" where Descripcion = '{0}'", especialidadSeleccionada);
            }
            //
            //Ejecuto la Consulta
            //
            SqlCommand consultaBuscar = 
                new SqlCommand(consultaBuscarBase + whereString+likeString, miConexion);
            dr_Medicos = consultaBuscar.ExecuteReader();
            //Filtra por el nombre, HAY QUE REVISAR EL TEMA DE LAS MINUSCULAS/MAYUSCULAS
            
        }
    }
}
