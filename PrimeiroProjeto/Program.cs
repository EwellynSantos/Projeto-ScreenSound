// Screen Sound
using System.Runtime.InteropServices;

string MensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";
//List<string> listaBandas = new List<string> { "BTS", "The rose", "Seventeen"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("The rose", new List<int> { 10, 8, 10 });
bandasRegistradas.Add("BTS", new List<int> { 30, 8, 20 });

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(MensagemDeBoasVindas);

}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MostrarMedia();
            break;
        case -1:
            Console.WriteLine("Bye!");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcoes("Exibindo as Bandas Registradas");
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloOpcoes(string titulo)
{
    int qtdeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(qtdeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota a banda {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"A nota {nota} registrada com sucesso para a banda {nomeBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }



}

void MostrarMedia()
{
    Console.Clear();
    ExibirTituloOpcoes("Mostrar média da banda");
    Console.Write("Digite a banda que deseja ver a nota: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"A média da banda {nomeBanda} é {notasBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada\n");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
ExibirOpcoesDoMenu();
