using System;

namespace TrianguloInvertido_8
{
    class Program
    /* Série: Decisão e Repetição
    
    8- Criar uma aplicação console que peça ao usuário a altura de um triangulo, desenhe na tela o triangulo invertido, como abaixo:
    Altura do Triangulo: 4
    ****
    ***
    **
    *  */    
    {
        static void Main(string[] args)
        {
            Console.Write ("Digite o tamanho do triângulo desejado: ");
            int tamanhoTriangulo = int.Parse (Console.ReadLine ()); 
            Console.WriteLine();
            string asteriscos = "";
            for (int i = 0; i < tamanhoTriangulo; i++) {
                asteriscos += "*";
                Console.WriteLine (asteriscos);
            }
            Console.WriteLine();
        } 
    }
}

