using MySql.Data.MySqlClient;
using QifApi;
using QifApi.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraBD
{
    class ConexaoADO
    {
        // String de conexão
        private static string connexion = "server=localhost; user=root; password=root; database=financas; port=3306; SslMode=none";
        private static MySqlConnection msConnection;
        private static MySqlCommand pesquisa;
        private static MySqlDataReader leitor;

        public static void Start()
        {

            // Conector
            msConnection = new MySqlConnection(connexion);

            // Abrind conexão
            msConnection.Open();



        }


        public static void SearchTransactions(QifDom qd)
        {
            Start();
            // Efetuar pesquisa
            string query = "SELECT * FROM transacao";
            pesquisa = new MySqlCommand(query, msConnection);

            // Recuperar informação
            leitor = pesquisa.ExecuteReader();

            // Percorrer resultado
            while (leitor.Read())
            {
                BasicTransaction bt = new BasicTransaction();


                DateTime date = new DateTime();
                
                string payee;
                float value;

                date = (DateTime)leitor[1];
                payee = (string)leitor[2];
                value = (float)leitor[6];

                bt.Date = date;
                bt.Payee = payee;
                bt.Amount = (decimal) value;

                qd.CreditCardTransactions.Add(bt);

                Console.WriteLine("bt.Date: " + bt.Date+" date BD: "+date.ToShortDateString() + " payee: " + payee + " value: " + value);
            }

        }
    }
}
