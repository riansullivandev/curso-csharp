using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = " Wo Verine";
            Console.WriteLine(nome);
            // nesse caso ocorreu uma ''inferencia'' o C# identificou
            // que se tratava de uma string e alterou o ''var''
        }
    }
}
