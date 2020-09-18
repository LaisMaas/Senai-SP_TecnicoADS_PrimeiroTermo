using System;

namespace IMC
{
    class Program_16
    /* Série: Decisão e Repetição
    
    16. Um endocrinologista deseja controlar a saúde de seus pacientes e, para isso, se utiliza do Índice de Massa Corporal (IMC). Sabendo-se que o IMC é calculado através da seguinte fórmula:
    IMC = peso / altura2
    Onde:
	• Peso é dado em Kg
	• Altura é dada em metros
    Criar um programa que apresente o nome do paciente e sua faixa de risco, baseando-se na seguinte tabela:
    IMC	FAIXA DE RISCO
    abaixo de 20	abaixo do peso
    a partir de 20 até 25	normal
    acima de 25 até 30	excesso de peso
    acima de 30 até 35	obesidade
    acima de 35	obesidade mórbida*/

    {
        static void Main(string[] args)
        {
            //Declaração e inicialização de variáveis
            double imc = 0, peso = 0, altura = 0;

            //Solicitação de dados de entrada ao usuário
            Console.Write("Informe o seu peso: ");
            peso = double.Parse (Console.ReadLine());

            Console.Write("Informe a sua altura: ");
            altura = double.Parse (Console.ReadLine());

            //Atribuição da variável com cálculo de verificação
            imc = peso / (altura * altura);
            
            //string imc = imc.ToString();

            //Condicional de verificação de acordo com dados de entrada e função atribuída a variável, bem como dados de saída com resultado ao usuário
            if(imc > 20)
            {
                System.Console.WriteLine("Peso abaixo da média.");
            }else if (imc <= 25)
            {
                System.Console.WriteLine("Peso normal.");

            }else if (imc > 26)
            {
                System.Console.WriteLine("Excesso de peso.");
            }else if (imc > 31)
            {
                System.Console.WriteLine("Obsidade.");
            }else if(imc > 35)
            {
                System.Console.WriteLine("Obsidade mórbida.");
            }
        }
    }
}
