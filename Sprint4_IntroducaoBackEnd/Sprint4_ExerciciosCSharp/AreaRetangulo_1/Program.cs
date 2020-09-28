using System;

namespace AreaTriangulo_1
{
    class Program
    /* Algoritmos Simples
    1. Criar uma aplicação que permita ao usuário entrar com a base e a altura de um retângulo e imprimir a seguinte saída:
	• base
    • altura
	• Área
    Existem dois tipos diferentes de retângulo, o primeiro é o com todos os lados iguais, que é chamado de quadrado, e com os lados diferentes.

    O cálculo do retângulo pode ser feito da seguinte forma

    A = b. h

    O raciocínio para descobrir a área do quadrado é o mesmo que o do retângulo deve-se multiplicar a medida da base pela medida da altura, mas diferente do retângulo o quadrado apresenta todos os lado iguais, sendo assim tem uma pequena diferença na sua fórmula.*/

    {
        static void Main(string[] args)
        {

            //Declaração das variáveis e inicialização das variáveis
            int baseRet = 0;
            int alturaRet = 0;
            int area = 0;

            //Solicitando informações de entrada ao usuário

            System.Console.Write("Digite por favor o valor da base do retângulo: ");
            baseRet = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();

            System.Console.Write("Informe  por favor o valor da altura do retângulo: ");
            alturaRet = Convert.ToInt32(Console.ReadLine());

            //Condicional necessária para execução do cálculo

            if(baseRet < alturaRet || baseRet > alturaRet )
            {
                area = baseRet * alturaRet;
                System.Console.WriteLine("A área do retângulo é: " + area + "cm**2");
            }else if(baseRet == alturaRet)

            //Informação de saída com resultado ao usuário
            {
                area = baseRet * alturaRet;
                System.Console.WriteLine("A área do quadrado é: " + area + "cm**2");
            }

        }
    }
}


