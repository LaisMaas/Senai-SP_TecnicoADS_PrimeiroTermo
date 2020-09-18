using System;

namespace TrocaValores_5

/* Série: Decisão e Repetição

5. Criar uma aplicação que leia dois valores para as variáveis A e B, efetuar a troca dos valores de forma que a variável A passe a ter o valor da variável B e a variável B passe a ter o valor da variável A. Apresentar os valores trocados. */
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis e inicialização das variáveis
            int valor1 = 0;
            int valor2 = 0;            
            int reserva = 0;

            //Apresentando informações de saída, solicitando dados de entrado ao usuário e efetuando converção de string para int
            Console.WriteLine("Ordendo valores");
            Console.Write("Informe o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe um segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe um terceiro valor: ");
            reserva = Convert.ToInt32(Console.ReadLine());

            //Condicional necessária para execução da ordenação de valores            
            if (valor1 > valor2)
            {
                reserva = valor1;
                valor1 = valor2;
                valor2 = reserva;
            }

            if (valor1 > reserva)
            {
                reserva = valor1;
                valor2 = reserva;
                reserva = valor1;
            }

            //Dados de saída com resultado ao usuário
            System.Console.WriteLine("Os valor ordenados são: " + valor1 + "," + valor2);
        }
    }
}
