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

namespace ElGrafico
{
    public partial class ListaRevistas : System.Web.UI.Page
    {
        RevistasNego revistaNego = new RevistasNego();

        Revista revista = new Revista();

        #region helper
        public class helper
        {
            private int? numeroDeEdicion;

            public int? NumeroDeEdicion
            {
                get { return numeroDeEdicion; }
                set { numeroDeEdicion = value; }
            }

            private DateTime? fecha;

            public DateTime? Fecha
            {
                get { return fecha; }
                set { fecha = value; }
            }

            private string titulo;

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            private string deporte;

            public string Deporte
            {
                get { return deporte; }
                set { deporte = value; }
            }

            private int? cantidad;

            public int? Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }

            private string nombreTapa;

            public string NombreTapa
            {
                get { return nombreTapa; }
                set { nombreTapa = value; }
            }
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string devuelveJson()
        {
            string json = string.Empty;

            IList<ListadoDeRevistasResultSet0> lista = revistaNego.listaRevistas().ToList();

            List<helper> listaHelper = new List<helper>();

            foreach (ListadoDeRevistasResultSet0 data in lista)
            {
                helper helper = new helper();

                helper.NumeroDeEdicion = data.Edicion;
                helper.Fecha = data.Fecha;
                helper.Titulo = data.Titulo;
                helper.Deporte = data.Deporte;
                helper.Cantidad = data.Cantidad;
                helper.NombreTapa = data.NombreImagen;

                listaHelper.Add(helper);
            }

            return json = JsonConvert.SerializeObject(listaHelper);
        }

       

       
    }
}