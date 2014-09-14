using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using Newtonsoft.Json;

namespace ElGrafico.Coleccion
{
    public partial class ListaColeccion : System.Web.UI.Page
    {
        ColeccionNego coleccionNego = new ColeccionNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string devuelveJson()
        {
            string json = string.Empty;

            IList<ListadoColeccionResultSet0> lista = coleccionNego.listaColeccionXDetalleColeccion().ToList();            

            return json = JsonConvert.SerializeObject(lista);
        }        
    }
}