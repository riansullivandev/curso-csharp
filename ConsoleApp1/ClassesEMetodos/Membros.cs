using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine($" {sicrano.Nome} tem {sicrano.Idade} anos");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();

            fulano.Nome = "jão";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();



        }
    }
}
