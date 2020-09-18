using System;

namespace ZeroCem_6
{
    class Program

    /* Série: Decisão e Repetição
    
    6- Criar um programa que utilizando a estrutura FOR imprima uma sequencia de números de 0 a 100. */
    {
        static void Main(string[] args)
        {
            //Declaração da variável
            int valor;            
            
            //Laço for para execução da sequência de números 0 a 100 e saída do resultado ao usuário
            for(valor = 0; valor >=100; valor = valor++)
            {
                System.Console.WriteLine("Esta é a sequência de números de 0 a 100: " + valor);

            }

        }
    }
}
