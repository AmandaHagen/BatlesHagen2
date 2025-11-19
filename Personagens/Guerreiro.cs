namespace BatlesHagen2.Personagens;

internal class Guerreiro : Personagem
{
    public Guerreiro() : base("Eric", vida: 100, ataque: 15, defesa: 5)
    {
    }

    public override void AtaqueNormal(Personagem alvo)
    {

        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} desferiu um ataque com sua espada {alvo.Nome} e causou {dano} de dano em seu oponente.");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {

        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} usou o poder da espada do trovão {alvo.Nome} e causou {dano} de dano no seu oponente. Ao utilizar o poder, perdeu pontos da sua vida.");

    }

    public override void ReceberDano(int dano)
    {
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida atual: {Vida}");
    }

    public override void ExibirStatus()
    {
        Console.WriteLine("===== STATUS DO PERSONAGEM =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
        Console.WriteLine("================================");
    }

}

