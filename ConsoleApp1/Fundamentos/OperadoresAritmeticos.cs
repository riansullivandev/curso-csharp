using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // preço desconto
            var preco = 1000.0;
            var imposto = 365;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine("O preço com desconto é {0}", totalComDesconto);

            // IMC
            double peso = 65;
            double altura = 1.75;
            double imc = peso / (altura * altura);
            Console.WriteLine($" O IMC é {imc}.");

            // par e impar

            int par = 22;
            int impar = 77;
            Console.WriteLine("{0}/2 tem resto{1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto{1}", impar, impar % 2);

            


        }
    }
}
