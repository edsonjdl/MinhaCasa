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
            

            //1-Inserção das opçoes de idioma no |dropdownlist
            var resultat = from l in db.Languages
                               select l;

            foreach (Language l in resultat)
            {
                if (!string.IsNullOrEmpty(l.Language1))
                {
                    listaIdiomas.Items.Add(new System.Web.UI.WebControls.ListItem(l.Language1));
                }
            }
            
        }

        public void CadastrarLivro(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.name = tituloLivro.Text;
            livro.language = listaIdiomas.SelectedValue;
            livro.nPages = Int32.Parse(nPaginas.Text);

            RecordItem.AdicionarLivro(livro);
        }
    }
}