using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace ElGrafico
{
    public partial class VerRevista : System.Web.UI.Page
    {
        RevistasNego revistaNego = new RevistasNego();
        TapaNego tapaNego = new TapaNego();
        DeportesNego deportesNego = new DeportesNego();
        EstadoNego estadoNego = new EstadoNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            llenarListas();
            cargarRevista();
        }

        private void llenarListas()
        {
            ddlDeportes.DataSource = deportesNego.listaDeportes();
            ddlDeportes.DataBind();
            ddlDeportes.Items.Insert(0, new ListItem("--Seleccione--", "0"));

            ddlEstado.DataSource = estadoNego.listaEstados();
            ddlEstado.DataBind();
        }

        private void cargarRevista()
        {
            if (Request["idRevista"] != null)
            {
                int idRevista = int.Parse(Request["idRevista"]);

                IList<Revista> listaRevistas = revistaNego.listaRevistaXIdRevista(idRevista).ToList();

                foreach (Revista data in listaRevistas)
                {
                    txtNumeroDeEdicion.Text = data.NumeroDeEdicion.ToString();
                    dtpFecha.Text = data.Fecha.ToString();
                    txtTitulo.Text = data.Titulo;
                    ddlDeportes.Text = data.Deporte.Nombre;
                    ddlEstado.Text = data.Estado.Nombre;
                    verTapa(data.Tapa.Nombre);
                    //multizoom2.ImageUrl = "../imagenes/" + data.Tapa.Nombre;                    
                }
            }
        }

        public string verTapa(string verTapa)
        {
            string tapa = "../imagenes/balanta.jpg";

            return tapa;
        }

        

        private void subirTapa()
        {
            if (FileUpload1.HasFile)
            {
                string fullPath = Path.Combine(Server.MapPath("~/imagenes"), FileUpload1.FileName);
                FileUpload1.SaveAs(fullPath);
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            subirTapa();

            string filePath = FileUpload1.PostedFile.FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename).ToLower();
            string contenttype = String.Empty;
            int largo = FileUpload1.PostedFile.ContentLength;

            //Set the contenttype based on File Extension
            switch (ext)
            {
                case ".doc":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".docx":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".xls":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".xlsx":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".jpg":
                    contenttype = "image/jpg";
                    break;
                case ".png":
                    contenttype = "image/png";
                    break;
                case ".gif":
                    contenttype = "image/gif";
                    break;
                case ".pdf":
                    contenttype = "application/pdf";
                    break;
            }
            if (contenttype != String.Empty)
            {

                Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                Byte[] bytes = br.ReadBytes((Int32)fs.Length);

                guardarRevista(filename, largo, bytes);

                limpiarControles(this.Controls);
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "No se reconoce el formato del archivo." +
                  " Subir formatos Image/Word/PDF/Excel ";
            }
        }

        private void guardarRevista(string nombreArchivo, int largo, Byte[] bytes)
        {
            Tapa tapa = new Tapa();
            Revista revista = new Revista();

            tapa.Nombre = nombreArchivo.Replace(" ", "");
            tapa.Largo = largo;
            tapa.Imagen = bytes;

            tapaNego.guardarTapa(tapa);

            int ultimoIdTapaInsertado = tapaNego.ultimoIdTapaInsertado().IdTapa;

            revista.NumeroDeEdicion = int.Parse(txtNumeroDeEdicion.Text);
            revista.Fecha = Convert.ToDateTime(dtpFecha.Text);
            revista.Titulo = txtTitulo.Text;
            revista.IdDeporte = int.Parse(ddlDeportes.SelectedValue);
            revista.Cantidad = 1;
            revista.IdTapa = ultimoIdTapaInsertado;

            revistaNego.guardarRevista(revista);
        }

        private void limpiarControles(ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is DropDownList)
                    ((DropDownList)control).ClearSelection();
                else if (control is RadioButtonList)
                    ((RadioButtonList)control).ClearSelection();
                else if (control is CheckBoxList)
                    ((CheckBoxList)control).ClearSelection();
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control.HasControls())
                    //Esta linea detécta un Control que contenga otros Controles
                    //Así ningún control se quedará sin ser limpiado.
                    limpiarControles(control.Controls);
            }
        }
    }
}