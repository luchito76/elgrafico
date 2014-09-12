using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace ElGrafico.Coleccion
{
    public partial class AgregarColeccion : System.Web.UI.Page
    {
        EstadoNego estadoNego = new EstadoNego();
        ColeccionNego coleccionNego = new ColeccionNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            llenarListas();
        }

        private void llenarListas()
        {
            ddlEstado.DataSource = estadoNego.listaEstados();
            ddlEstado.DataBind();
        }

        private void guardarNombreColeccion()
        {
            Dominio.Coleccion coleccion = new Dominio.Coleccion();

            if ()
            coleccion.Nombre = txtNombreColeccion.Text;
            coleccion.Estado = ddlEstado.SelectedItem.ToString();

            coleccionNego.guardarNombreColeccion(coleccion);
        }

        private void guardarDetalleColeccion(int idNombreColeccion)
        {
            DetalleColeccion detalleColeccion = new DetalleColeccion();

            detalleColeccion.IdColeccion = idNombreColeccion;
            detalleColeccion.Capitulo = int.Parse(txtCapitulo.Text);
            detalleColeccion.Nombre = txtNombreColeccion.Text;

            coleccionNego.guardarDetalleColeccion(detalleColeccion);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarNombreColeccion();

            int ultimoIdColeccion = coleccionNego.ultimoIdColeccionInsertado().IdColeccion;

            guardarDetalleColeccion(ultimoIdColeccion);
        }
    }
}