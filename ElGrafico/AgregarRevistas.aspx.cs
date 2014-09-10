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
    public partial class AgregarRevistas : System.Web.UI.Page
    {
        DeportesNego deportesNego = new DeportesNego();
        RevistasNego revistaNego = new RevistasNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            llenarListas();
        }

        private void llenarListas()
        {
            ddlDeportes.DataSource = deportesNego.listaDeportes();
            ddlDeportes.DataBind();
            ddlDeportes.Items.Insert(0, new ListItem("--Seleccione--", "0"));
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filePath = FileUpload1.PostedFile.FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename).ToLower();
            string contenttype = String.Empty;

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

                guardarRevista(bytes);

                limpiarControles(this.Controls);
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "No se reconoce el formato del archivo." +
                  " Subir formatos Image/Word/PDF/Excel ";
            }
        }

        private void guardarRevista(Byte[] bytes)
        {
            Revista revista = new Revista();

            revista.NumeroDeEdicion = int.Parse(txtNumeroDeEdicion.Text);
            revista.Fecha = Convert.ToDateTime(dtpFecha.Text);
            revista.Titulo = txtTitulo.Text;
            revista.IdDeporte = int.Parse(ddlDeportes.SelectedValue);
            revista.Cantidad = 1;
            revista.ImagenTapa = bytes;

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