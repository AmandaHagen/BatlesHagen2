namespace BatlesHagen2.Personagens;

internal class Guerreiro : Personagem
{
    public Guerreiro() : base("Eric", vida: 100, ataque: 15, defesa: 5)
    {
    }

    public override void AtaqueNormal(Personagem alvo)
    {
        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} desferiu um ataque com sua espada {alvo.Nome} e causou {dano} de dano em seu oponente.");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {
        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} usou o poder da espada do trovão {alvo.Nome} e causou {dano} de dano no seu oponente. Ao utilizar o poder, perdeu pontos da sua vida.");

    }
    public override ReceberDano(int dano)
    {
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida atual: {Vida}");
    }

}

