﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            Console.WriteLine(" Digite a Nota do Aluno ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N) ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }




        }

    }
}
