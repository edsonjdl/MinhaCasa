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
            novoLivro.Imagem = livro.imagem;
            novoLivro.IdType = tipoLivro;
            novoLivro.IdLanguage = livro.language;

            db.Items.InsertOnSubmit(novoLivro);
            db.SubmitChanges();
        }
    }
}