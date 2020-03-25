using LeituraBD;
using QifApi;
using QifApi.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    class QIFGenerator
    {
        public static void ReadData(string filename)
        {
            QifDom qd = new QifDom();

            ConexaoADO.SearchTransactions(qd);

            qd.Export(filename);

           // qd.CreditCardTransactions
        }
    }
}
