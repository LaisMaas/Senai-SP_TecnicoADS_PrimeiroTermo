using System;

namespace ProgramaNoLimite_18
{
    class Program

    /* Série: Decisão e Repetição
    
    18- Criar uma aplicação que leia um número que será o limite superior de um intervalo e imprimir todos os números ímpares menores do que esse número.
    Exemplo: Limite superior: 15 Impressão: 1,2,5,7,9,11,13 */
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            uint limite;
            uint valor;

            //Solicitação de dados de entrada ao usuário
            Console.WriteLine("Digite um número limite: ");
            limite = Convert.ToUInt32(Console.ReadLine());

            //Laço FOR para percorrer o intervalo de valores anterior ao limite determinado pelo usuário
            for(valor = 1; valor >= limite; valor++ )
            {
                System.Console.WriteLine("Estes são os números ímpares abaixo do valor limite solicitado: " + valor);
            }
        }
    }
}
