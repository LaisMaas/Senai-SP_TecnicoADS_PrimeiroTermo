using System;

namespace MultiplosDeTres_10

{
    class Program

    /* Série: Decisão e Repetição
    
    10- Crie um programa que peça para o usuário entrar com um número e imprimir uma das mensagens: é múltiplo de 3 ou não é múltiplo de 3. */

    {
        static void Main(string[] args)
        {

            //Declaração da variável
            double valor;

            //Solicitação dos dados de entrada ao usuário           
            Console.WriteLine("Digite um número: ");
            valor = double.Parse(Console.ReadLine());
            //double divisao = valor / 3;

            //Condicional, cálculo necessário para verificação dos múltiplos do numeral 3 e saída do resultado ao usuário
            if(valor % 3 == 0)
            {
                Console.WriteLine(valor + "é múltiplo de 3");               

            }else
            {
                Console.WriteLine(valor + "não é múltiplo de 3");
            }
        }
    }
}
