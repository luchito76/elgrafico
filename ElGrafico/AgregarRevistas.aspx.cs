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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            llenarListas();
            //mostrarImagen();
        }

        private void llenarListas()
        {
            ddlDeportes.DataSource = deportesNego.listaDeportes();
            ddlDeportes.DataBind();
            ddlDeportes.Items.Insert(0, new ListItem("--Seleccione--", "0"));
        }

        //private void mostrarImagen() {
        //    if (Request.QueryString["ImageID"] != null)
        //    {
        //    string pepe = Request.QueryString["ImageID"];
        //        string strQuery = "select numeroDeEdicion, imagenTapa from revistas where idRevista=8";
        //        SqlCommand cmd = new SqlCommand(strQuery);
        //        cmd.Parameters.Add("@idRevista", SqlDbType.Int).Value
        //        = Convert.ToInt32(Request.QueryString["ImageID"]);
        //        DataTable dt = GetData(cmd);
        //        if (dt != null)
        //        {
        //            Byte[] bytes = (Byte[])dt.Rows[0]["imagenTapa"];
        //            Response.Buffer = true;
        //            Response.Charset = "";
        //            Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //            Response.ContentType = "jpg";// dt.Rows[0]["ContentType"].ToString();
        //            Response.AddHeader("content-disposition", "attachment;filename="
        //            + dt.Rows[0]["numeroDeEdicion"].ToString());
        //            Response.BinaryWrite(bytes);
        //            Response.Flush();
        //            Response.End();
        //        }
        //    }
        //}

        private DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["ElGrafico_DesaConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
                sda.Dispose();
                con.Dispose();
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filePath = FileUpload1.PostedFile.FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename);
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

                //insert the file into database
                string strQuery = "insert into Revistas(imagenTapa)" +
                   " values (@imagenTapa)";
                SqlCommand cmd = new SqlCommand(strQuery);
                //cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename;
                //cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = contenttype;
                cmd.Parameters.Add("@imagenTapa", SqlDbType.Binary).Value = bytes;
                InsertUpdateData(cmd);
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "File Uploaded Successfully";
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "File format not recognised." +
                  " Upload Image/Word/PDF/Excel formats";
            }
        }

        private Boolean InsertUpdateData(SqlCommand cmd)
        {
            String strConnString = System.Configuration.ConfigurationManager
            .ConnectionStrings["ElGrafico_DesaConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}