using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.EstruturasDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Jose" };
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
