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
                var resultat = from l in db.Items
                               where l.Type.Type1 == tipo
                               select l;

                

                foreach (Item l in resultat)
                {
                    if (!string.IsNullOrEmpty(l.Title))
                    {
                        TableRow row = new TableRow();

                        TableCell cell = new TableCell();
                        cell.Text = l.Title;

                        row.Cells.Add(cell);

                        listaLivros.Rows.Add(row);

                    }
                }

            
        }


        // Código para trazer imagens e exibí-las numa tabela
        public void DisplayImage()
        {
            var vv = from v in db.Imagems
                     select new
                     {
                         v.filename,
                         v.IdImagem,
                     };
            //??
            //GrdDispalyImage.DataSource = vv;
           // GrdDispalyImage.DataBind();
        }

    }
}