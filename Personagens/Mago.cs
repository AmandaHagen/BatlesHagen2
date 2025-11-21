namespace BatlesHagen2.Personagens;


internal class Mago : Personagem
{
    public Mago() : base("Presto", vida: 100, ataque: 10, defesa: 10)
    {
    }
    public override void AtaqueNormal(Personagem alvo)
    {       

        int dano = Math.Max(Ataque - alvo.Defesa, 0);
        alvo.ReceberDano(dano);
        Console.WriteLine($"\n{Nome} atacou com seu cajado {alvo.Nome}");
        Console.WriteLine($"Causou {dano} de dano em seu oponente.");
        Console.WriteLine($"Vida atual: {Vida} | Ataque atual: {Ataque} | Defesa atual: {Defesa}");
    }
    public override void AtaqueEspecial(Personagem alvo)
    {     
        int dano = (int)(Ataque * 1.5) - alvo.Defesa;
        alvo.ReceberDano(dano);
        Vida -= 10;
        Vida = Math.Max(Vida - 1, 0);

        Console.WriteLine($"\n{Nome} conjurou um monstro e atacou {alvo.Nome}");
        Console.WriteLine($"Causou {dano} de dano em seu oponente.");
        Console.WriteLine($"Ao conjurar, perdeu {Vida} pontos da sua vida.");
        Console.WriteLine($"Vida atual: {Vida} | Ataque atual: {Ataque} | Defesa atual: {Defesa}");

    }
    public override void ReceberDano(int dano)
    {
        Vida = Math.Max(Vida - dano, 0);
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida atual: {Vida}");
    }

    public override void ExibirStatus()
    {
        Console.WriteLine("===== STATUS DO Presto =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
        Console.WriteLine("================================");
    }
}