using System;

namespace PesoNosPlanetas_9
{
    class Program

    /* Série: Decisão e Repetição
    
    9- Escrever uma aplicação que leia um peso na Terra e o número de um planeta e imprima o valor do seu peso neste planeta. A relação de planetas é dada a seguir juntamente com o valor das gravidades relativas à Terra:
	Gravidade Relativa	Planeta
    1	0,37	Mercúrio
    2	0,88	Vênus
    3	0,38	Marte
    4	2,64	Júpiter
    5	1,15	Saturno
    6	1,17	Urano
    Para calcular o peso no planeta use a fórmula:
    Planeta=(Pterra/10) * gravidade */

    {
        private const int V = 6;

        static void Main(string[] args)
        { 
            int pesoT = 0;
            int opcao = 0;

            System.Console.WriteLine(" Escolha em qual planeta você deseja calcular seu peso: ");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            switch (opcao)
            {
                case 1:
                System.Console.WriteLine("Seu peso no planeta mercúrio é: " + (pesoT/10)*0.37);
                break;
                
                case 2:
                System.Console.WriteLine("Seu peso no planeta vênus é: " + (pesoT/10)*0.88);
                break;

                case 3:
                System.Console.WriteLine("Seu peso no planeta marte é: " + (pesoT/10)*0.38);
                break;

                case 4:
                System.Console.WriteLine("Seu peso no planeta júpiter é: " + (pesoT/10)*2.64);
                break;

                case 5:
                System.Console.WriteLine("Seu peso no planeta saturno é: " + (pesoT/10)*1.15);
                break;

                case 6:
                System.Console.WriteLine("Seu peso no planeta urano é: " + (pesoT/10)*1.17);
                break;
                
                default:                
                break;
            }
        }
    }
}
