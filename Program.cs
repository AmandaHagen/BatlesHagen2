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
        

        Personagem jogador1 = EscolherPersonagem("Jogador 1");
        Personagem jogador2 = EscolherPersonagem("Jogador 2");

         Console.WriteLine($"\nBATALHA INICIADA: {jogador1.Nome} VS {jogador2.Nome}!\n");

            // Loop de batalha
            while (jogador1.EstaVivo && jogador2.EstaVivo)
            {
                Turno(jogador1, jogador2);
                if (!jogador2.EstaVivo) break;
                Turno(jogador2, jogador1);
            }

            Console.WriteLine("\n=== FIM DE JOGO ===");
            if (jogador1.EstaVivo)
                Console.WriteLine($"{jogador1.Nome} venceu!");
            else
                Console.WriteLine($"{jogador2.Nome} venceu!");


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
        Thread.Sleep(2000);
        Console.Clear();

    }

    static Personagem EscolherPersonagem(string jogador)
    {
        Console.Clear();

        Console.WriteLine($"\n{jogador}: escolha seu personagem:\n");
        Console.WriteLine("Digite 1 - Guerreiro");
        Console.WriteLine("Digite 2 - Mago");
        Console.WriteLine("Digite 3 - Arqueiro");
        Console.Write($"Opção: ");
        string opcao = Console.ReadLine();
        Thread.Sleep(1000);
        Console.Clear();

        return opcao switch
        {
            "1" => new Guerreiro(),
            "2" => new Mago(),
            "3" => new Arqueiro(),
        };


    }

    static void Turno(Personagem atacante, Personagem defensor)
    {
        Console.WriteLine($"\n--- Turno de {atacante.Nome} ---");
        atacante.ExibirStatus();
        defensor.ExibirStatus();

        Console.WriteLine("Escolha sua ação:");
        Console.WriteLine("1 - Atacar");
        Console.WriteLine("2 - Ataque Especial");
        Console.Write("Opção: ");
        string acao = Console.ReadLine();

        if (acao == "1")
            atacante.AtaqueNormal(defensor);
        else
            atacante.AtaqueEspecial(defensor);

        Thread.Sleep(4000);
        Console.Clear();
    }


}
