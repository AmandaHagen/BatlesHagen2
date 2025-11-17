namespace BatlesHagen2.Personagens;

abstract class Personagem : IAtacavel
{
    public Personagem(string nome, int vida, int ataque, int defesa)
    {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
        Defesa = defesa;
    }

    public string Nome { get; }
    public int Vida { get; protected set; }
    public int Ataque { get;  }
    public int Defesa { get; protected set; }
    public bool EstaVivo => Vida >= 0;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Vida: {Vida}");
        Console.WriteLine($"Ataque: {Ataque}");
        Console.WriteLine($"Defesa: {Defesa}");
    }

    public virtual void ExibirStatus()
    {
        Console.WriteLine($"{Nome} - Vida: {Vida} - Defesa{Defesa}.");
    }
    // Método de ataque simples
    public abstract void AtaqueNormal(Personagem alvo);
    public abstract void AtaqueEspecial(Personagem alvo);


}
