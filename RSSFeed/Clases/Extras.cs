using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Configuration;

namespace RSSFeed.Clases
{
    class Extras
    {
        public static Exception msj;
        public static bool existe_db()
        {
            msj = null;
            try
            {

                if (!System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory()+"\\DB.sdf"))
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["RSSFeed.Properties.Settings.DBConnectionString"].ConnectionString;
                    SqlCeEngine en = new SqlCeEngine(connectionString);
                    en.CreateDatabase();

                    var conexion = new SqlCeConnection(connectionString);
                    conexion.Open();
                    var ruta = System.IO.Directory.GetCurrentDirectory() + "DBCreation.sql";
                    var contenido = System.IO.File.ReadAllText(ruta);
                    var comando = new SqlCeCommand(contenido, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    en.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception f)
            {
                msj = f;
            }
            return false;
        }
    }
}
