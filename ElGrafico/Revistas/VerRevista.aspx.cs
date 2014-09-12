using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace ElGrafico
{
    public partial class VerRevista : System.Web.UI.Page
    {
        RevistasNego revistaNego = new RevistasNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            cargarRevista();
        }

        private void cargarRevista()
        {
            if (Request["idRevista"] != null)
            {
                int idRevista = int.Parse(Request["idRevista"]);

                IList<Revista> listaRevistas = revistaNego.listaRevistaXIdRevista(idRevista).ToList();

                foreach (Revista data in listaRevistas)
                {
                    lblNroEdicion.Text = data.NumeroDeEdicion.ToString();
                    lblFecha.Text = data.Fecha.ToString();
                    lblTitulo.Text = data.Titulo;
                    lblDeporte.Text = data.Deporte.Nombre;
                    lblEstado.Text = data.Estado.Nombre;
                }
            }
        }
    }
}