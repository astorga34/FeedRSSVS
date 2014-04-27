using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFeed.Clases
{
    public class entry
    {
        #region "variables miembro"
        
        private string name = "";
        private string url = "";
        private string type = "";
        
        #endregion
        
        #region "constructores"

        public entry() { }
        public entry(string name,string url) { this.name = name;this.url = url; }
        public entry(string name, string url, string type) { this.name = name; this.url = url; this.type = type; }

        #endregion

        #region "Propiedades"

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        #endregion

        #region "Metodos"

        #endregion
    }
}
