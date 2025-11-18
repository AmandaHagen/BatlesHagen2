using BatlesHagen2.Personagens;

string mensagemDeBoasVindas = "Bem Vindo ao Batles Hagen!";
//list<Personagem> opoes= new List<Personagem> 
//{   
//    new Guerreiro("Eric", 150, 15, 5),
//    new Mago("Preston", 120, 35, 25),
//    new Arqueiro("Hank", 100, 10, 10)
//}


void ExbirLogo()
{
    Console.WriteLine(@" 

█▄▄ ▄▀█ ▀█▀ █   █▀▀ █▀   █ █ ▄▀█ █▀▀ █▀▀ █▄ █
█▄█ █▀█  █   █▄▄ ██▄ ▄█   █▀█ █▀█ █▄█ ██▄ █ ▀█");

    ExibirTitulo(mensagemDeBoasVindas);
}






















void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string hifem = string.Empty.PadLeft(quantidadeDeLetras, '-'); //Caracteres são aspas simples.
    Console.WriteLine("\n" + hifem);
    Console.WriteLine(titulo);
    Console.WriteLine(hifem + "\n");
}


ExbirLogo();
Console.WriteLine("O jogo está em desenvolvimento...");
Console.ReadLine();