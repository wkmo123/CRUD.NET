using System.Data.SqlClient;

namespace CRUDCORE.Datos

{
    public class Conexion
    {
        private String cadenaSQL = string.Empty;


        public Conexion() {

             //Codigo para obtener la cadena de conexion a la BD
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL += builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }
        
        public String getCadenaSQL(){ 
            
            return cadenaSQL; 
        }
       
    }
}
