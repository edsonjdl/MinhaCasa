using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTests
{
    class CalculadoraWS
    {
        public static void Soma(int a, int b)
        {
            localhost.CalculatorWS cws = new localhost.CalculatorWS();

            int result = cws.add(a, b);

            Console.WriteLine("Result: " + result);
            Console.ReadKey();

        }
    }
}
