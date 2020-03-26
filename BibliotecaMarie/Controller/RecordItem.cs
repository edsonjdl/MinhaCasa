using BibliotecaMarie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMarie.Controller.Database
{
    public class RecordItem
    {
        private const int statusInicialLivro = 1;
        private const int tipoLivro = 1;

        public static void AdicionarLivro(Livro livro)
        {
            BibliotecaMarieDataContext db = new BibliotecaMarieDataContext();

            Item novoLivro = new Item();
            novoLivro.Title = livro.name;
            novoLivro.Size = livro.nPages;
            novoLivro.IdStatus = statusInicialLivro; //Disponível
            //novoLivro.Image = livro.image;
            novoLivro.IdType = tipoLivro;

            db.Items.InsertOnSubmit(novoLivro);
            db.SubmitChanges();
        }
    }
}