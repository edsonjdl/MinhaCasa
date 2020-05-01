using BibliotecaMarie.Controller.Database;
using BibliotecaMarie.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibliotecaMarie.View
{
    public partial class CadastroLivros : System.Web.UI.Page
    {
        BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();
        private const string navTablet = "Safari";


        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                //1-Inserção das opçoes de idioma no |dropdownlist
                var resultat = from l in db.Languages
                               select l;
                foreach (Language l in resultat)
                {
                    if (!string.IsNullOrEmpty(l.Language1))
                    {
                        System.Web.UI.WebControls.ListItem novoItem = new System.Web.UI.WebControls.ListItem(l.Language1);
                        novoItem.Value = l.IdLanguage.ToString(); // Definindo o valor do item combolist como o id do idioma

                        listaIdiomas.Items.Add(novoItem);
                    }
                }

                listaIdiomas.SelectedValue = "IdLanguage";

                string browser = Request.Browser.Browser;

                if (!browser.Equals(navTablet))
                {
                    rowTablet1.Visible = false;
                    rowTablet2.Visible = false;

                }
            }


        }

        public void CadastrarLivro(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.name = tituloLivro.Text;
            livro.language = Int32.Parse(listaIdiomas.SelectedValue);
            livro.nPages = Int32.Parse(nPaginas.Text);

            if (ImageUpload.HasFile && ImageUpload.PostedFile.ContentLength > 0)
            {
                // Create object of table
                Imagem img = new Imagem();
                //string nomeImagem = tituloLivro.Text;
                img.filename = tituloLivro.Text;

                //Devido à limitação imposta no tamanho do nome da imagem:
                if (img.filename.Length > 20)
                {
                    img.filename = tituloLivro.Text.Substring(0,19);
                }

                // Create a byte array to store the binary image data

                Byte[] imgbyte = ImageUpload.FileBytes;
                Binary Binarydta = new Binary(imgbyte);
                img.Imagem1 = Binarydta; // this is the converted image data
                //if (tituloLivro.Text.Length == 0)
                //{
                //    nomeImagem = ImageUpload.FileName;
                //    img.filename = ImageUpload.FileName;
                //}

                //db.Imagems.InsertOnSubmit(img);
                //db.SubmitChanges();
                //??
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('" + img.filename + " Imagem registrada com sucesso')", true);
                tituloLivro.Text = "";
                livro.imagem = img;
            }
            

            RecordItem.AdicionarLivro(livro);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('Parabéns! O livro " + livro.name + " agora faz parte da Biblioteca da Marie! :)')", true);

            tituloLivro.Text = "";
            nPaginas.Text = "";

        }
    }
}