using BatlesHagen2.Personagens;

internal class Arqueiro : Personagem
{
    private object dano;

    public Arqueiro() : base("Hank", vida: 100, ataque: 10, defesa: 10)
    {

    }
    public override void AtaqueNormal(Personagem alvo)
    {
        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} lançou suas flechas em {alvo.Nome} e causou {dano} de dano em seu oponente.");
    }

    public override void AtaqueEspecial(Personagem alvo)
    {
        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} usou seu poder de três flechas flamejantes em {alvo.Nome} e causando{dano} de dano no seu oponente. Ao usar seu poder, perdeu pontos da sua defesa.");

    }

    public override ReceberDano(int dano)
    {
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida atual: {Vida}");
    }

}
