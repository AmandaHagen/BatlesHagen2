namespace BatlesHagen2.Personagens;


class Mago : Personagem
{
    public Mago() : base("Merlin", vida: 100, ataque: 10, defesa: 10)
    {

    }
   

    public override void AtaqueNormal(Personagem alvo)
    {

        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} atacou com seu cajado {alvo.Nome} e causou {dano} de dano em seu oponente.");

    }
    public override void AtaqueEspecial(Personagem alvo)
    {

        int dano = Ataque - alvo.Defesa;
        if (dano < 0) dano = 0;

        //alvo.vida -= dano;
        Console.WriteLine($"{Nome} Conjurou um monstro e atacou {alvo.Nome} e causando{dano} de dano no seu oponente. Ao conjurar, perdeu pontos da sua defesa.");

    }
    public void GetDano(int dano)
    {

    }








}