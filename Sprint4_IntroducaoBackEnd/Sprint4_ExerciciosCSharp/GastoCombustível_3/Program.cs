using System;

namespace GastoCombustível_3

/* Série: Algoritmos Simples

3- Criar um programa que efetue o cálculo da quantidade de litros de combustível gastos em uma viagem, sabendo-se que o carro faz 12 km com um litro. Deverão ser fornecidos o tempo em horas gasto na viagem e a velocidade média em kilometros por hora. Utilizar as seguintes fórmulas:
• Distância = tempo x velocidade.
• Litros usados = distância / 12.
O programa deverá apresentar os valores da velocidade média, tempo gasto na viagem, distância percorrida e a quantidade de litros utilizados na viagem.*/

{
    class Program
    {
        static void Main(string[] args)
        { 
            //Declaração de variáveis e inicialização das variáveis
            int distancia = 0, tempo = 0, velocidade = 0, litrosUsados = 0;

            //Cálculos a serem executados para apresentação dos resultados
            tempo = tempo / 60;
            distancia = tempo * velocidade;
            litrosUsados = velocidade / 12;

            //Informações de saída ao usuário

            System.Console.WriteLine("Calcule a velocidade,  distância percorrida e combustível gastos em sua viagem.");

            System.Console.WriteLine();

            //Solicitando informações de entrada ao usuário

            System.Console.Write("Informe por favor o tempo gasto em sua viagem em minutos: ");
            tempo = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            System.Console.WriteLine("Informe por favor a velocidade média: ");

            //Efetuando conversão da cadeia de string para int e tratativas de exceção se necessário
            velocidade = int.Parse(Console.ReadLine());

            //Informações de saída com resultados ao usuário
            System.Console.WriteLine("O tempo gasto na viagem foi de: " + tempo);
            System.Console.WriteLine("Velocidade média de: " + velocidade);
            System.Console.WriteLine("A distância percorridade foi de: " + distancia);
            System.Console.WriteLine("A quantidade de litros de combustível usado foi de: " + litrosUsados);          

        }
    }
}
