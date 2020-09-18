using System;

namespace ConversaoFahrenheit_2
{
    class Program

    /*Série: Algoritmos Simples
    
    2- Criar um programa que leia uma temperatura em graus centígrados e apresentá-la convertida em graus Fahrenheit. A fórmula de conversão é:
    F=(9*C + 160)/5
    Onde:
    F é a temperatura em Fahrenheit.
    C é a temperatura em centígrados. */
    
    {
        static void Main(string[] args)
        {
            //Declaração da variável e inicialização das variáveis
            double f = 0, c = 0;
            
            //Solicitando dados de entrada ao usuário
            System.Console.WriteLine("Digite o valor da temperatura em Celsios: ");

            //Realizando a conversão de dados string para double e tratativa de exceção se necessário
            c = int.Parse(Console.ReadLine());

            //Cálculo a ser executado                        
            f = (9*c+160)/5;

            //Dados de saída com resultado ao usuário
            System.Console.WriteLine(f);

        }
    }
}
