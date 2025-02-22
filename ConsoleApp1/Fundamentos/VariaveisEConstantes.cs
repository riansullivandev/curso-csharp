using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3,1415 ( quando feito com ''const '' nao pode ser alterado)

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é" + area);
            
            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            // byte so aceita valores positivos
            // dos ''byte'' ate ''ulong'' são os inteiros
            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo De Gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário" + salario);

            // mais usado dos inteiros o ''int''
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor Int" + menorValorInt);

            uint populacaoBrasileira = 207_987_766;
            Console.WriteLine("População Brasileira" +  populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long" + menorValorLong);

            ulong populacaoMundial = 566_455_233;
            Console.WriteLine("População Mundial" + populacaoMundial);

            // pontos flutuantes / valores reais

            //para armazenar um float é necessario colocar um ''f'' ao final do numero
            // se nao colocar o ''F'' estou dizendo ao programa que se trata de um double
            
            float precoComputador = 6545.3f;
            Console.WriteLine("Preço Computador" + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000_000.00; // mais usado dos inteiros
            Console.WriteLine("Valor Apple" +  valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância das Estrelas" + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            string texto = "DeadPool vs Wolverine mt bom";
            Console.WriteLine(texto);

       
 

            

                


                }
    }
}
