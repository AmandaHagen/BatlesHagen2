namespace BatlesHagen2.Personagens; 

class Personagem
{
    public Personagem(string nome, int vida, int ataque, int defesa)
    {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
        Defesa = defesa;
    }

    public string Nome { get; }
    public int Vida { get;  }
    public int Ataque { get;  }
    public int Defesa { get; }
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
        Console.WriteLine($"{Nome} - Vida: {Vida}");
    }
    // Método de ataque simples
    public virtual void Atacar(Personagem alvo)
    {
        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0; 

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} atacou {alvo.Nome} e causou {dano} de dano!");
    }



}
