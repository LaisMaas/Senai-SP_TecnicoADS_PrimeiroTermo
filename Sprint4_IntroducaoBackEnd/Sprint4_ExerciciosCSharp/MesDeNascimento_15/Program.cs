using System;

namespace MesDeNascimento_15
{
    class Program

    /* Série: Decisão e Repetição
    
    15. Crie um programa que peça para o usuário um número inteiro entre 1 e 12 e escrever o mês correspondente. Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número. */
    {
        static void Main(string[] args)
        {
            //Declaração da variável
            int mesDeNascimento;

            //Apresentação e solicitação de dados de entrada ao usuário
            System.Console.WriteLine("O que o mês do seu nascimento revela sobre a sua personalidade");
            System.Console.WriteLine("Texto adaptado de: br.blastingnews - Original: F. GLAUCIELEN ");
            System.Console.Write("Digite o número correspondente ao seu mês de nascimento: ");
            mesDeNascimento = Convert.ToInt32(Console.ReadLine());

            //Condicional de verificação e apresentação de dados de saída com informações ao usuário
            if(mesDeNascimento >12||mesDeNascimento <1)
            System.Console.WriteLine("O número digitado não corresponde aos meses do ano. Por favor digite um número válido: ");

            switch(mesDeNascimento)
            {
                case 1:               
                    System.Console.WriteLine("Os nascidos em \"JANEIRO\" são pessoas com personalidades fortes e marcantes,\n gostam de estarem sempre na liderança e são muito teimosas.\n Não gostam de receber ordens, pois gostam de mandar,\n por isso escolhem profissões em que possam fazer isso.");
                    System.Console.WriteLine("");     
                break;

                case 2:
                    System.Console.WriteLine("O que dizes dos nascidos em \"FEVEREIRO\"??? Trabalhadoras,\n as pessoas que nasceram em fevereiro costumam ser honestas e justas,\n estão sempre preparadas para novos projetos e desafios.\n Adoram viajar e conhecer ou conversar com pessoas que tenham a mente aberta. Mas também possuem um lado muito sonhador e apaixonado.");            
                break;

                case 3:
                    System.Console.WriteLine("Aos nascidos no mês de \"março\"...São as pessoas mais solitárias e introvertidas, mas possuem uma poderosa mente criativa secreta.\n Costumam ser reservadas e não gostam de falar sobre a sua vida.\n Amigáveis e gentis, preferem frequentar lugares mais silenciosos e adoram o aconchego do lar.");
                break;

                case 4:
                    System.Console.WriteLine("Se você nasceu nos mês de \"abril\", provavelmente você é daquelas pessoas que detestam receber ordens\n e mostra isso com todas as suas forças! Prefere fazer tudo do seu jeito e de acordo com o seu próprio ritmo.\n Viciados em adrenalina, os que nasceram em abril vivem o ‘agora’ e não pensam em consequências.");
                break;

                case 5:
                    System.Console.WriteLine("Nascidos em \"maio\". Normalmente são temperamentais e indecisas, isso em vários aspectos da vida.\n Adoram se comunicar e discutir. Não gostam de ficar sozinhas,\n por isso procuram sempre se ocupar com programas divertidos e saídas com amigos.");
                break;

                case 6:
                    System.Console.WriteLine("Nascidos em \"incrivelmente\" gentis e tímidos, os que nasceram em junho costumam ser organizados e compreensivos.\n Tudo em sua vida precisa ser muito bem planejado e seus sentimentos normalmente são um mistério.");
                break;

                case 7:
                    System.Console.WriteLine(" Os nascidos em \"Julho\" possuem muita coisa em comum com os nascidos em junho, porém,\n são mais extrovertidos e mais espontâneos.\n Escondem quando estão sofrendo, são amigos fiéis e bons companheiros.");
                break;

                case 8:
                    System.Console.WriteLine("Os nascidos em \"agosto\" destacam-se por terem carreiras notáveis,\n são autoritários e pouco humanitários.\n São frios, calculistas e também craques em esconderem seus sentimentos.");
                break;

                case 9:
                    System.Console.WriteLine("O que dizer dos nascidos em \"setembro\"...Extremamente perfeccionistas,\n as pessoas nascidas em setembro estão sempre cheias de expectativas,\n tanto que vivem mais no mundo da fantasia do que no real, por isso se decepcionam facilmente e com muita frequência.\n São humildes, sensuais e estão sempre em prontidão na hora de ajudar o próximo.");
                break;

                case 10:
                    System.Console.WriteLine("Nascidos em \"outubro\"Não gostam de confrontos, são naturalmente charmosos, faladores e equilibrados.\n Buscam sempre uma boa companhia, por isso estão sempre cercados por bons amigos,\n vivem frequentando encontros prazerosos e divertidos.");
                break;

                case 11:
                    System.Console.WriteLine("Os misteriosos de \"novembro\"...É difícil saber o que estão pensando, pois adoram esconder o que sentem.\n São corajosos, teimosos e independentes, fazem de tudo para conquistar o que querem,\n isso sempre com muita determinação e perseverança.");
                break;

                case 12:
                    System.Console.WriteLine("Os queridos nascidos em \"dezembro\"...Não ficam parados,\n detestam o conformismo e ficar no mesmo lugar por muito tempo. Possuem muita coragem e humildade.\n Estão sempre em busca de agradar e ajudar o próximo.");
                break;
                //default:                
                //break;
            }
        }
    }
}
