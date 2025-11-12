class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; }
    public int Ataque { get; }
    public int Defesa { get; }

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
}