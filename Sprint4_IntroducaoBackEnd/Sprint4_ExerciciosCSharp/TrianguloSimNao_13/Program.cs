using System;

namespace TrianguloSimNao_13
{
    class Program
    /* Série: Decisão e Repetição
    
    13- Criar uma aplicação que peça para o usuário três números e verificar se eles podem ou não ser lados de um triângulo. Imprimir a classificação segundo os lados ou uma mensagem dizendo que os lados não fazem parte de um triângulo. Para ser um triângulo válido, o comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.*/
    
    {
        static void Main(string[] args)
        {
            //Declaração e inicialização das variáveis
            double baseTri =0, alturaTri =0, areaTri = 0;

            //Solicitando dados de entrada ao usuário            
            System.Console.Write("Por favor informe o valor provável da base do triângulo: ");
            baseTri = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine();

            System.Console.Write("Informe também o valor provável da altura do triângulo: ");
            alturaTri = Convert.ToDouble(System.Console.ReadLine());

            //Condicional, cálculo necessário para execução do programa e saída de dados com resultado ao usuário
            if(baseTri > alturaTri + alturaTri)

            {
                Console.WriteLine("Os valores informados são válidos para um triângulo de " + (areaTri = ((baseTri*alturaTri)/2)));
            }else
            {
                System.Console.WriteLine("Os valores informados não são válidos para formação de triângulo. Tente novamente...");
            }        
        }
    }
}
