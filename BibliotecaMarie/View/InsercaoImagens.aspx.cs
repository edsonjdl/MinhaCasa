using BibliotecaMarie.Controller.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMarie.View
{
    /*
     * Artigo: Insert Retrieve images from Database in asp.net LINQ TO SQL
     * 
     */
    public partial class InsercaoImagens : System.Web.UI.Page
    {
        BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(ImageUpload.HasFile && ImageUpload.PostedFile.ContentLength > 0)
            {
                // Create object of table
                Imagem img = new Imagem();
                string nomeImagem = txtImageName.Text;
                img.filename = txtImageName.Text;

                // Create a byte array to store the binary image data

                Byte[] imgbyte = ImageUpload.FileBytes;
                Binary Binarydta = new Binary(imgbyte);
                img.imagem1 = Binarydta; // this is the converted image data
                if (txtImageName.Text.Length == 0)
                {
                    nomeImagem = ImageUpload.FileName;
                    img.filename = ImageUpload.FileName;
                }

                db.Imagems.InsertOnSubmit(img);
                db.SubmitChanges();
                //??
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('" + nomeImagem + " Imagem registrada com sucesso')", true);
                txtImageName.Text = "";
                DisplayImage();
            }
        }

        // This method is useful to just fetch name and id
        public void DisplayImage()
        {
            var vv = from v in db.Imagems
                      select new
                      {
                          v.filename,
                          v.IdImagem,
                      };
            //??
            GrdDispalyImage.DataSource = vv;
            GrdDispalyImage.DataBind();
        }
    }
}