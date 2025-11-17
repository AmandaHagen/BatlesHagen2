string mensagemDeBoasVindas = "Bem Vindo ao }Batles Hagen!";
Dictionary<string, List<int>> personagensRegistrados = new();
personagensRegistrados.Add("Guerreiro", new List<int> { 150, 15, 5 });
personagensRegistrados.Add("Mago", new List<int> { 120, 35, 25 });
personagensRegistrados.Add("Arqueiro", new 
List<int> { 100, 10, 10 });


void ExbirLogo()
{
    Console.WriteLine(@" 

█▄▄ ▄▀█ ▀█▀ █   █▀▀ █▀   █ █ ▄▀█ █▀▀ █▀▀ █▄ █
█▄█ █▀█  █   █▄▄ ██▄ ▄█   █▀█ █▀█ █▄█ ██▄ █ ▀█");

ExibirTitulo(mensagemDeBoasVindas);
}
void ExibirMenu()
{
    ExbirLogo();

    Console.WriteLine($"Digite 1 escolher um personagem: ");
    Console.WriteLine("Digite 2 para exibir a lista de personagens: ");
    Console.WriteLine("Digite 3 para para registrar um personagem: ");
    Console.WriteLine("Digite 4 exibir media\n");
    Console.Write($"Opção escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: EscolherPersonagem();
            break;
        case 2: MostrarPersonagens();
            break; 
        case 3: RegistrarClasse();
            break;
        case 4: ExbirMedia();
            break;
            //default: Console.WriteLine("Opção in3válida!");
    }
    Thread.Sleep(1000);

}

void RegistrarClasse()
{
    Console.Clear();
    ExibirTitulo("Registrar Classe");
    Console.Write("\nDigite o nome da classe que deseja registrar: ");
    string nomeDaClasse = Console.ReadLine()!;
    personagensRegistrados.Add(nomeDaClasse, new());
    Console.WriteLine($"\nA classe {nomeDaClasse} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirMenu();

}

void MostrarPersonagens()
{
    Console.Clear();
    Console.WriteLine($"\nMostrar Personagens: ");
    ExibirTitulo("Digite o nome da classe que deseja escolher: ");
    foreach (string personagens in personagensRegistrados.Keys)
    {
        Console.WriteLine($"Personagem: {personagens}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Thread.Sleep(1000);
    ExibirMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string hifem = string.Empty.PadLeft(quantidadeDeLetras, '-'); //Caracteres são aspas simples.
    Console.WriteLine("\n" + hifem);
    Console.WriteLine(titulo);
    Console.WriteLine(hifem + "\n");
}

void EscolherPersonagem()
{
    //digite qual personagem
    //se o personagem existe no dicionario
    //senão volta ao menu principal.
    Console.Clear();
    ExibirTitulo("Escolha seu personagem: ");
    string nomeDaClasse = Console.ReadLine()!;
    if (personagensRegistrados.ContainsKey(nomeDaClasse))
    {
        Console.Write($"Qual a nota que o personagem {nomeDaClasse} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        personagensRegistrados[nomeDaClasse].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o personagem {nomeDaClasse}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A {nomeDaClasse}, não existe!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void ExbirMedia()
{
    Console.Clear();
    ExibirTitulo("Media personagem: ");
    string nomeDaClasse = Console.ReadLine()!;
    Console.WriteLine($"Digite o personagem para exibir media: {nomeDaClasse}.");

    if (personagensRegistrados.ContainsKey(nomeDaClasse))
    {
        List<int> notas = personagensRegistrados[nomeDaClasse];

        Console.WriteLine($"A média das notas do personagem {nomeDaClasse} é: {notas.Average()}");
    }
    else
    {
        Console.WriteLine("Personagem não encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();

    }
    Console.Clear();

    Thread.Sleep(2000);
    ExibirMenu();


}
ExibirMenu();
