using System;

namespace ConjugandoVerbo_14
{
    class Program

    /* Série: Decisão e Repetição
    
    14. Crie um programa que permita ao usuário entrar com um verbo no infinitivo e imprimir uma das mensagens:
	• Verbo não está no infinitivo.
	• Verbo da 1ª- conjugação.
	• Verbo da 2ª- conjugação.
    • Verbo da 3ª- conjugação.
    Obs:  infinitivo – é o verbo regulares em seu estado natural, terminando em ar, er ou ir .*/


{
        static void Main(string[] args)

        {
            //Declaração da variável
            string verbo;  

            //Apresentação e solicitação de dados ao usuário, verificação da condição e saída do resultado ao usuário          
            
        do{
            System.Console.WriteLine("Digite um verbo no infinitivo para saber sua conjugação: ");
            System.Console.WriteLine("Ou Digite \"Parar\" Para Sair ");
            verbo = Console.ReadLine();
            int numero = verbo.Length;
            int dois = 2;
            string separado = verbo.Substring(numero - dois);
            
            
            switch(separado)            
            {
                case "ar":                
                Console.WriteLine("O verbo informado está 1° conjugação");
                break;

                case "er":                
                Console.WriteLine("O verbo informado está 2° conjugação");
                break;

                case "ir":                
                Console.WriteLine("O verbo informado está 3° conjugação");
                break;
                default:
                    System.Console.WriteLine("A palavra digitada não é um verbo no infinitivo");
                break;

            }
        }
        while(verbo != "parar");
        }  
    }
}


