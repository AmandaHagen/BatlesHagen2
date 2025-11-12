var personagem = new Personagem();
personagem.Nome = "Connan";
personagem.Vida = 100;
personagem.Ataque = 20;
personagem.Defesa = 15;
Console.WriteLine($"O nome do guerreiro é {personagem.Nome}.");
personagem.ExibirFichaTecnica();
personagem.ExibirStatus();