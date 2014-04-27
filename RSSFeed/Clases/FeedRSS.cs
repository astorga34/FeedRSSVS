using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RSSFeed.Clases
{
    
    public class FeedRSS
    {
        #region variables miembro

        //Tiene que ser una direccion de url completa, con todo y el protocolo. Por ejemplo http://algo.com/lector.rss
        //URL de prueba: http://www.nyaa.se/?page=rss&offset=1&cats=0_0&filter=0&term=Date
        private string rss = "";
        private Exception msj = null;
        
        #endregion
        
        #region constructores

        public FeedRSS() { }
        public FeedRSS(string rss) { this.rss = rss; }

        #endregion

        #region Propiedades

        public string RSS
        {
            get { return RSS; }
            set { RSS = value; }
        }
        public Exception Mensaje 
        {
            get { return this.msj; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para obtener todas las entradas de la url
        /// </summary>
        /// <returns>Una lista con las entradas</returns>
        public List<entry> getFeed()
        {
            msj = null;
            List<entry> lista = new List<entry>();
            try
            {
                XmlReader reader = XmlReader.Create(this.rss);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    String subject = item.Title.Text;
                    String summary = item.Summary.Text;
                    String category = item.Categories[0].Name;
                    var obj = new entry(item.Title.Text.Trim(), item.Id,category);
                    lista.Add(obj);
                }
            }
            catch (Exception e)
            {
                msj = e;
            }
            return lista;
        }
        /// <summary>
        /// Metodo para obtener todas las entradas y filtrar las deseadas por los terminos proporcionados
        /// </summary>
        /// <param name="palabras">Criterios de busqueda</param>
        /// <param name="andor">Especifica como se aplicara la expresion logica entre los elementos de la busqueda. false es OR y true es AND</param>
        /// <returns>Una lista con las entradas</returns>
        public List<entry> getFeed(List<string> palabras,bool andor = false)
        {
            List<entry> lista = new List<entry>();
            msj = null;
            try
            {
                XmlReader reader = XmlReader.Create(this.rss);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    String subject = item.Title.Text;
                    String summary = item.Summary.Text;
                    String category = item.Categories[0].Name;
                    subject = subject.ToLower();
                    var query = (from palabra in palabras where subject.Contains(palabra.ToLower()) select palabra);
                    if (andor)
                    {
                        if (query.Count() == palabras.Count)
                        {
                            var obj = new entry(item.Title.Text.Trim(), item.Id, category);
                            lista.Add(obj);
                        }
                    }
                    else
                    {
                        if (query.Count() != 0)
                        {
                            var obj = new entry(item.Title.Text.Trim(), item.Id, category);
                            lista.Add(obj);
                        }
                    }

                    
                }
            }
            catch (Exception e)
            {
                msj = e;
            }
            return lista;
        }

        #endregion

    }
}
