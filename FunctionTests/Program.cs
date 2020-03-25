using LeituraBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "teste.qif";
            //ConexaoADO.Start();
            //QIFGenerator.ReadData(filename);
            //ParserQifCC.Parse(filename);

            //Web service
            //CalculadoraWS.Soma(2, 4);

            Arquivos.RecursiveSearch("C:\\temp");

            Console.ReadKey();


        }
    }
}
