using BatlesHagen2.Personagens;

internal class Arqueiro : Personagem
{
    public Arqueiro() : base("Hank", vida: 100, ataque: 5, defesa: 15)
    {

    }
    public override void AtaqueNormal(Personagem alvo)
    {

        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} lançou suas flechas em {alvo.Nome} e causou {dano} de dano em seu oponente.");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {
        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} usou seu poder de três flechas flamejantes em {alvo.Nome} e causando{dano} de dano no seu oponente. Ao usar seu poder, perdeu pontos da sua defesa.");
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
