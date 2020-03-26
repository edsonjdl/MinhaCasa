using BibliotecaMarie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMarie.Controller.Database
{
    public class RecordItem
    {
        public static void AdicionarLivro(Livro livro)
        {
            BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();

            Item novoLivro = new Item();
            novoLivro.Title = livro.name;
            novoLivro.Size = livro.nPages;
            novoLivro.IdStatus = livro.idStatus;
            novoLivro.Image = livro.image;
            novoLivro.IdType = livro.idType;

            db.Items.InsertOnSubmit(novoLivro);
            db.SubmitChanges();
        }
    }
}