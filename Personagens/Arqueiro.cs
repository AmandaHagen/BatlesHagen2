using BatlesHagen2.Personagens;

internal class Arqueiro : Personagem
{
    private bool flechasTripla = false;

    public Arqueiro() : base("Hank", vida: 100, ataque: 5, defesa: 15){}

    public override void AtaqueNormal(Personagem alvo)
    {
        int danoBase = Ataque;
        if (flechasTripla)
            danoBase += 10;
        int dano = danoBase - alvo.Defesa;
        if (dano < 0)
            dano = 0;
        alvo.ReceberDano(dano);

        Console.WriteLine($"{Nome} (Arqueiro) dispara flechas {(flechasTripla ? "Tripla" : "comum")} em {alvo.Nome}, causando {dano} de dano!");

        flechasTripla = false; 
    }

    public override void AtaqueEspecial(Personagem alvo)
    {
        flechasTripla = true;
        Console.WriteLine($"{Nome} prepara suas flechas Triplas! O próximo ataque será mais forte.");
    }

    public override void ReceberDano(int dano){}

    public override void ExibirStatus(){}
}
