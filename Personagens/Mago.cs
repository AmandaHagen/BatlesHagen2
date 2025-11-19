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
        Console.WriteLine($"{Nome} atacou com seu cajado {alvo.Nome} e causou {dano} de dano em seu oponente.");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {     
        int dano = (int)(Ataque * 1.5) - alvo.Defesa;
        alvo.ReceberDano(dano);
        Vida -= 10; // custo de mana/vitalidade
        Console.WriteLine($"{Nome} Conjurou um monstro e atacou {alvo.Nome} e causando {dano} de dano no seu oponente. Ao conjurar, perdeu pontos da sua defesa.");


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