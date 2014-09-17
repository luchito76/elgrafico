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

        public int total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
           devuelveJson();
        }


        public string devuelveJson()
        {
            string json = string.Empty;

            IList<CantidadRevistasXDeporteResultSet0> lista = revistaNego.cantidadDeRevistasXDeporte().ToList();

            total = sumarRevistas(lista);

            return json = JsonConvert.SerializeObject(lista);
        }

        private int sumarRevistas(IList<CantidadRevistasXDeporteResultSet0> lista)
        {
            int totalRevistas = 0;

            foreach (CantidadRevistasXDeporteResultSet0 data in lista)
            {
                totalRevistas = totalRevistas + int.Parse(data.Total.ToString());
            }

            return totalRevistas;
        }

        public int tot()
        {
            

            return total;
        }



    }
}