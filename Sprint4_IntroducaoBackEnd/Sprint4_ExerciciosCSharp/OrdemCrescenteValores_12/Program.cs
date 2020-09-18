using System;

namespace OrdemCrescenteValores
{
    class Program_12

    /* Série: Decisão e Repetição
    
    12- Criar uma aplicação que entre com três números e imprimi-los em ordem crescente (suponha números diferentes).*/
    
    {
        static void Main(string[] args)
        {
            //Declaração e reinicialização das variáveis
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int reserva = 0;

            //Apresentação e solicitação de dados de entrada ao usuário
            Console.WriteLine("Ordendo valores");
            Console.Write("Informe o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe um segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe um terceiro valor: ");
            valor3 = Convert.ToInt32(Console.ReadLine());

            //Condicional e cálculo para ordenação dos valores            
            if (valor1 > valor2)
            {
                reserva = valor1;
                valor1 = valor2;
                valor2 = reserva;
            }

            if (valor1 > valor3)
            {
                reserva = valor1;
                valor1 = valor3;
                valor3 = reserva;
            }

            if (valor2 > valor3)
            {
                reserva = valor1;
                valor2 = valor3;
                valor3 = reserva;
            }

            //Dados de saída com resultado ao usuário
            System.Console.WriteLine("Os valor ordenados são: " + valor1 + "," + valor2 + "," + valor3);
        }
    }
}
