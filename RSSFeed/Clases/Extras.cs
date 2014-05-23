using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

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
                string connectionString = "DataSource=\"test.sdf\";";
                SqlCeEngine en = new SqlCeEngine(connectionString);
                if (!en.Verify())
                {
                    en.CreateDatabase();
                }
                en.Dispose();
            }
            catch (Exception f)
            {
                msj = f;
            }
            return false;
        }
    }
}
