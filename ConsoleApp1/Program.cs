using System;
using System.Collections.Generic;
using ConsoleApp1.Fundamentos;
using ConsoleApp1.EstruturasDeControle;
using CursoCSharp;



namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) 
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() 
            {
                // fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos" , Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},

                // Estruturas De Controle
                {"Estrutura If - EstruturasDeControle", EstruturaIf.Executar},
                {"Estrutura IfElse - EstruturasDeControle", EstruturaIfElse.Executar},
                {"Estrutura IfElseIf - EstruturasDeControle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - EstruturasDeControle", EstruturaSwitch.Executar},
                {"Estrutura While - EstruturasDeControle", EstruturaWhile.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
}