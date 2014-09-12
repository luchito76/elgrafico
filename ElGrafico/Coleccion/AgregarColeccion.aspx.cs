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

            ddlColeccion.DataSource = coleccionNego.listaColecciones();
            ddlColeccion.DataBind();
            ddlColeccion.Items.Insert(0, new ListItem("--Seleccione--", "0"));
        }

        private void guardarNombreColeccion()
        {
            Dominio.Coleccion coleccion = new Dominio.Coleccion();

            coleccion.Nombre = txtNombreColeccion.Text;
            coleccion.Estado = ddlEstado.SelectedItem.ToString();

            coleccionNego.guardarNombreColeccion(coleccion);
        }

        private void guardarDetalleColeccion(int idNombreColeccion)
        {
            DetalleColeccion detalleColeccion = new DetalleColeccion();

            int idColeccion = int.Parse(ddlColeccion.SelectedValue);



            detalleColeccion.IdColeccion = idNombreColeccion;
            detalleColeccion.Capitulo = int.Parse(txtCapitulo.Text);
            detalleColeccion.Nombre = txtTitulo.Text;

            coleccionNego.guardarDetalleColeccion(detalleColeccion);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Si es cero la coleccion es nueva
            if (ddlColeccion.SelectedValue == "0")
            {
                guardarNombreColeccion();

                int ultimoIdColeccion = coleccionNego.ultimoIdColeccionInsertado().IdColeccion;

                guardarDetalleColeccion(ultimoIdColeccion);

                ddlColeccion.DataSource = coleccionNego.listaColecciones();
                ddlColeccion.DataBind();
                ddlColeccion.Items.Insert(0, new ListItem("--Seleccione--", "0"));
                ddlColeccion.SelectedValue = ultimoIdColeccion.ToString();
            }
            else
            {
                actualizaDetalleColeccion();
            }

            limpiarControles();
        }


        private void actualizaDetalleColeccion()
        {
            DetalleColeccion detalleColeccion = new DetalleColeccion();

            detalleColeccion.IdColeccion = int.Parse(ddlColeccion.SelectedValue);
            detalleColeccion.Capitulo = int.Parse(txtCapitulo.Text);
            detalleColeccion.Nombre = txtTitulo.Text;

            coleccionNego.guardarDetalleColeccion(detalleColeccion);
        }

        private int devuelveCapituloSiguiente(int idColeccion)
        {
            //Se le suma uno al último capítulo para sugerirle al usuario cual es el capítulo siguiente de una colección determinada.            
            int ultimoCapitulo = coleccionNego.ultimoCapituloXColeccion(idColeccion) + 1;

            return ultimoCapitulo;
        }

        private void limpiarControles()
        {
            txtTitulo.Text = "";
            txtCapitulo.Text = "";
        }
        protected void chkColeccionNueva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColeccion.Checked)
            {
                capaColeccionNueva.Visible = true;
                capaColeccionVieja.Visible = false;
                ddlColeccion.SelectedValue = "0";
            }
            else
            {
                capaColeccionNueva.Visible = false;
                capaColeccionVieja.Visible = true;
            }
        }

        protected void ddlColeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int capituloSugerido = devuelveCapituloSiguiente(int.Parse(ddlColeccion.SelectedValue));

            txtCapitulo.Text = capituloSugerido.ToString();
        }
    }
}