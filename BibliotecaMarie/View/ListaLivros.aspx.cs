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
    public partial class ListaLivros : System.Web.UI.Page
    {
        BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();
        private const string tipo = "Livro";
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (!Page.IsPostBack)
            //{
            //1-Inserção das opçoes de idioma no |dropdownlist


            /*
             * Código para trazer imagens e exibí-las numa tabela
             * Na realidade, ao invés de adaptar uma tabela, o que faço agora é criar elementos databind/datagrid
             */
            var resultat = from l in db.Items
                           where l.Type.Type1 == tipo
                           select l;

            GrdDisplayImage.DataSource = resultat;
            GrdDisplayImage.DataBind();


        }

    }
}
