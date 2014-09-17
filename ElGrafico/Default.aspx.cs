using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using Newtonsoft.Json;

namespace ElGrafico
{
    public partial class _Default : Page
    {
        RevistasNego revistaNego = new RevistasNego();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public string devuelveJson()
        {
            string json = string.Empty;

            IList<CantidadRevistasXDeporteResultSet0> lista = revistaNego.cantidadDeRevistasXDeporte().ToList();

            return json = JsonConvert.SerializeObject(lista);
        }

    }
}