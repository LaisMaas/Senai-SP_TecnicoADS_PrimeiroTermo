using System;

namespace Intervalo120A300_17
{
    class Program
    /* Série: Decisão e Repetição
    
    17- Criar um programa que imprima os números de 120 a 300. */

    {
        static void Main(string[] args)

        //Declaração da variável
        {
            int valor;
            
            //Laço FOR para percorrer o intervalo de números e impressão dos dados na tela
            for(valor = 120; valor <=300; valor++)
            {
                System.Console.WriteLine("Este são os valor entre 120 e 300: " + valor);
            }
        }
    }
}
