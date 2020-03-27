using BibliotecaMarie.Controller.Database;
using BibliotecaMarie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibliotecaMarie.View
{
    public partial class CadastroLivros : System.Web.UI.Page
    {
        BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();


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
            }
         
        }

        public void CadastrarLivro(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.name = tituloLivro.Text;
            livro.language = listaIdiomas.SelectedIndex;
            livro.nPages = Int32.Parse(nPaginas.Text);

            RecordItem.AdicionarLivro(livro);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alertmessage", "javascript:alert('Parabéns! O livro " + livro.name + " agora faz parte da Biblioteca da Marie! :)')", true);

            tituloLivro.Text = "";
            nPaginas.Text = "";

        }
    }
}