using BatlesHagen2.Personagens;

internal class Arqueiro : Personagem
{
    public Arqueiro() : base("Hank", vida: 100, ataque: 5, defesa: 15)
    {
    }

    public override void AtaqueNormal(Personagem alvo)
    {
        int dano = Math.Max(Ataque - alvo.Defesa, 0);
        alvo.ReceberDano(dano);

        Console.WriteLine($"\n{Nome} lançou suas flechas em {alvo.Nome}");
        Console.WriteLine($"Causou {dano} de dano em seu oponente.");
        Console.WriteLine($"Vida atual: {Vida} | Ataque atual: {Ataque} | Defesa atual: {Defesa}");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {
        int danoTotal = 0;

        Console.WriteLine($"\n{Nome} usou seu poder de TRÊS FLECHAS FLAMEJANTES em {alvo.Nome}!");

        for (int i = 0; i < 3; i++)
        {
            int dano = Math.Max((int)(Ataque * 1.2) - alvo.Defesa, 0);
            alvo.ReceberDano(dano);
        }

        // Penalidade do especial
        int defesaAntes = Defesa;
        Defesa = Math.Max(Defesa - 1, 0);

        Console.WriteLine($"\nDano total causado: {danoTotal}");
        Console.WriteLine($"{Nome} perdeu 1 ponto de defesa (de {defesaAntes} → {Defesa}).");
        Console.WriteLine($"Status atual — Vida: {Vida} | Ataque: {Ataque} | Defesa: {Defesa}");
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
