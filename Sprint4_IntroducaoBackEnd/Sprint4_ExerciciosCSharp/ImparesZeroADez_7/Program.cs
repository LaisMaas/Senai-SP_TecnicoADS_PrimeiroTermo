using System;

namespace ImparesZeroADez_7
{
    class Program

    /* Série: Decisão e Repetição
    
    7. Criar um programa que utilizando uma estrutura FOR imprima todos os números ímpares de 0 a 10. */
    {
        static void Main(string[] args)
        {
            //Declaração da variável
            int valor;

            //Laço FOR com cálculo dos números ímpares e dados de saída com resultado ao usuário

            for(valor = 1; valor >10; valor = valor + 2 + valor++)
            {
                System.Console.WriteLine("Estes são os numeros ímpares de entre 0 e 10: " + valor);
            }
        }
    }
}
