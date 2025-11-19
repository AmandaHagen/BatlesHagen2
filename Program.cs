using BatlesHagen2.Personagens;
using System;
namespace BatlesHagen2.Jogo;


class Program
{

    static void Main(string[] args)
    {
        string mensagemDeBoasVindas = "Bem Vindo ao Batles Hagen!";

        ExbirLogo();
        ExibirTitulo();
        ExibirMenu();



    }
    public static void ExbirLogo()
    {

        Console.WriteLine(@" 

    █▄▄ ▄▀█ ▀█▀ █   █▀▀ █▀   █ █ ▄▀█ █▀▀ █▀▀ █▄ █
    █▄█ █▀█  █   █▄▄ ██▄ ▄█   █▀█ █▀█ █▄█ ██▄ █ ▀█");


    }

    private static void ExibirTitulo()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       BATLES HAGEN 2.0         ");
        Console.WriteLine("=================================");
    }

    public static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Iniciar Jogo");
        Console.WriteLine("2. Sair");

        Console.Write("\nDigite a sua opção: ");
        string entrada = Console.ReadLine()!;
      
        if (int.TryParse(entrada, out int escolha))
        {
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu Iniciar !");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Sair !");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
        Console.Clear();
        ExbirLogo();
        Console.WriteLine("\nRetornando ao menu principal...\n");

    }


    public static void EscolhaDosPlayers()
    {
        string jogador1 = "Player 1";
        string jogador2 = "Player2";

        Console.WriteLine("");
        Console.WriteLine($"Digite 1 para: .");
        Console.WriteLine($"Digite 2 para: .");
        Console.WriteLine($"Digite 3 para: ");
        Console.WriteLine("2. Sair");

        Console.Write("\nDigite a sua opção: ");
        string entrada = Console.ReadLine()!;

        if (int.TryParse(entrada, out int escolha))
        {
            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"Você escolheu: Guerreiro");
                    break;
                case 2:
                    Console.WriteLine($"Você escolheu: Mago");
                    break;
                case 3:
                    Console.WriteLine($"Você escolheu: Arqueiro");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
        Console.Clear();
        ExbirLogo();
        Console.WriteLine("\nRetornando ao menu principal...\n");
    }


}
