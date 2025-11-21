namespace BatlesHagen2.Personagens;

public abstract class Personagem : IAtacavel
{
    public Personagem(string nome, int vida, int ataque, int defesa)
    {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
        Defesa = defesa;
    }

    public string Nome { get; protected set; }
    public int Vida { get; protected set; }
    public int Ataque { get; protected set; }
    public int Defesa { get; protected set; }
    public bool EstaVivo => Vida > 0;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
    }

    public virtual void ExibirStatus()
    {
        Console.WriteLine("===== STATUS DO PERSONAGEM =====");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
        Console.WriteLine("================================");
    }

    // Método de ataque simples
    public abstract void AtaqueNormal(Personagem alvo);
    public abstract void AtaqueEspecial(Personagem alvo);

    public virtual void ReceberDano(int dano)
    {
        Vida = Math.Max(Vida - dano, 0);
    }

}
