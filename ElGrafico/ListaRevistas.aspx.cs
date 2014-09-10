using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using Dominio;
using Negocio;
using System.Collections.Generic;

namespace ElGrafico
{
    public partial class ListaRevistas : System.Web.UI.Page
    {
        RevistasNego revistaNego = new RevistasNego();

        Revista revista = new Revista();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string devuelveJson()
        {
            string json = string.Empty;

            IList<ListadoDeRevistasResultSet0> lista = revistaNego.listaRevistas().ToList();

            List<Revista> listaRevista = new List<Revista>();

            foreach (ListadoDeRevistasResultSet0 data in lista)
            {
                revista.NumeroDeEdicion = data.Edicion;
                revista.Fecha = data.Fecha;
                revista.Titulo = data.Titulo;
                //revista.Deporte.Nombre = data.Deporte;
                revista.Cantidad = data.Cantidad;
                revista.ImagenTapa = data.Tapa;

                listaRevista.Add(revista);
            }

            return json = JsonConvert.SerializeObject(listaRevista);
        }
    }
}