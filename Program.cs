using ProjetoCalculadora.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Instanciando a calculadora
Calculadora calc = new();

// Exibir o cabeçalho
Console.WriteLine("Seja bem-vindo à Minha Calculadora!\n");

bool exibirMenu = true;

// Realizar o loop do Menu
while (exibirMenu)
{
    // Exibir o menu na parte superior
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Seno");
    Console.WriteLine("7 - Coseno");
    Console.WriteLine("8 - Tangente");
    Console.WriteLine("0 - Sair\n");

    // Pergunta ao usuário
    Console.WriteLine("Qual operação deseja fazer?\n");

    // Lê a escolha do usuário
    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "0":
            exibirMenu = false; // Sai do loop
            break;

        case "1":
            Console.Write("Digite o primeiro número: ");
            int numSoma1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numSoma2 = int.Parse(Console.ReadLine());
            calc.Somar(numSoma1, numSoma2);
            break;

        case "2":
            Console.Write("Digite o primeiro número: ");
            int numSub1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numSub2 = int.Parse(Console.ReadLine());
            calc.Subtrair(numSub1, numSub2);
            break;

        case "3":
            Console.Write("Digite o primeiro número: ");
            int numMult1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numMult2 = int.Parse(Console.ReadLine());
            calc.Multiplicar(numMult1, numMult2);
            break;

        case "4":
            Console.Write("Digite o primeiro número: ");
            int numDiv1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numDiv2 = int.Parse(Console.ReadLine());
            calc.Dividir(numDiv1, numDiv2);
            break;

        case "5":
            Console.Write("Digite a Base da Potência: ");
            int numPot1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da Potência: ");
            int numPot2 = int.Parse(Console.ReadLine());
            calc.Potencia(numPot1, numPot2);
            break;

        case "6":
            Console.Write("Digite o ângulo: ");
            double anguloSeno = double.Parse(Console.ReadLine());
            calc.Seno(anguloSeno);
            break;

        case "7":
            Console.Write("Digite o ângulo: ");
            double anguloCoseno = double.Parse(Console.ReadLine());            
            calc.Coseno(anguloCoseno);
            break;

        case "8":
            Console.Write("Digite o ângulo: ");
            double anguloTamgente = double.Parse(Console.ReadLine());            
            calc.Tangente(anguloTamgente);
            break;

        // Adicione outros casos para as outras operações...

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");
