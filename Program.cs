using DesafioPOO.Models;

Console.WriteLine("---Teste do Celular---");

Console.WriteLine("\n");

Console.Write("Informe o número do celular: ");
string numeroCelular = Console.ReadLine();

Console.Write("Informe o modelo do celular para testar: 1 - Nokia, 2 - Iphone :");
string smarthPhone = Console.ReadLine();

if (smarthPhone == "1")
{
    Console.Clear();
    Console.WriteLine("Smarthphone Nokia");
    Nokia nokia = new Nokia(numero: numeroCelular, modelo: "Modelo Generico", imei: "22544444454", memoria: 64);

    Console.WriteLine("Informe se deseja 1 - Ligar ou 2 - Receber Ligação: ");
    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        nokia.Ligar();
    }
    else if (opcao == "2")
    {
        nokia.ReceberLigacao();
    }
    else
    {
        Console.WriteLine("Opção Incorreta");
    }

    Console.WriteLine("Informe o Aplicativo que deseja instalar: ");
    string aplicativo = Console.ReadLine();

    nokia.InstalarAplicativo(aplicativo);
}
else
{
    Console.Clear();
    Console.WriteLine("Smartphone Iphone");
    Iphone iphone = new Iphone(numero: numeroCelular, modelo: "Iphone X", imei: "1111111111", memoria: 228);

    Console.WriteLine("Informe se deseja 1 - Ligar ou 2 - Receber Ligação");
    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        iphone.Ligar();
    }
    else if (opcao == "2")
    {
        iphone.ReceberLigacao();
    }
    else
    {
        Console.WriteLine("Opção Incorreta");

    }

    Console.WriteLine("Informe o Aplicativo que deseja instalar: ");
    string aplicativo = Console.ReadLine();

    iphone.InstalarAplicativo(aplicativo);
}

Console.WriteLine("\n");

Console.WriteLine("Finalizando o Sistema de Testes");

Console.WriteLine("\n");