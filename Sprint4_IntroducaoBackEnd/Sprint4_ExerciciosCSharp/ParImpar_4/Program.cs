using System;

namespace ParImpar_4
{
    class Program
    {
        /* Série: Decisão e Repetição
        
        4- Desenvolva um programa que solicite ao usuário um número qualquer e calcule se o número digitado é par ou ímpar, informando o resultado ao usuário */
        static void Main(string[] args)
        {
            //Declaração da variável
            int NumeroDigitado;
            
            //Solicitando informações de entrada ao usuário
            System.Console.Write("Digite o número desejado: ");

            //Conversão de string para int na entrada e de int para string na saída de dados
            NumeroDigitado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumeroDigitado.ToString());

            //Condicional necessária para execução da operação e informação de saída ao usuário
            if (NumeroDigitado % 2 == 0)
            {
                Console.WriteLine("Este número é par");

            }
            else
            {
                System.Console.WriteLine("O número digitado é impar");

                Console.ReadKey();
            }
        }
    }
}



