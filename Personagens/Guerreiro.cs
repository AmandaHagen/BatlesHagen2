namespace BatlesHagen2.Personagens;

internal class Guerreiro : Personagem
{
    public Guerreiro() : base("Eric", vida: 100, ataque: 15, defesa: 5){}


    public override void AtaqueNormal(Personagem alvo)
    {
        int dano = Math.Max(Ataque - alvo.Defesa, 0);
        alvo.ReceberDano(dano);

        Console.WriteLine($"\n{Nome} desferiu um ataque com sua espada em {alvo.Nome}");
        Console.WriteLine($"Causou {dano} de dano em seu oponente.");
        Console.WriteLine($"Vida atual: {Vida} | Ataque atual: {Ataque} | Defesa atual: {Defesa}");
    }

    public override void AtaqueEspecial(Personagem alvo)
    {
        int dano = Math.Max((int)(Ataque * 1.2) - alvo.Defesa, 0);
        alvo.ReceberDano(dano);
        Ataque = Math.Max(Ataque - 1, 0);

        Console.WriteLine($"\n{Nome} usou o poder da espada do trovão em {alvo.Nome} e causou {dano} de dano.");
        Console.WriteLine($"{Nome}, perdeu {Ataque} ponto de ataque ao utilizar o especial.");
        Console.WriteLine($"Vida atual: {Vida} | Ataque atual: {Ataque} | Defesa atual: {Defesa}");
    }

    public override void ReceberDano(int dano){}            
    public override void ExibirStatus(){}
}