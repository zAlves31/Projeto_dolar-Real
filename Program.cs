class Program
{
static void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("=== Conversor de Moedas ===");
        Console.WriteLine("1. Dólar para Real");
        Console.WriteLine("2. Real para Dólar");
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");
        Console.WriteLine();
            

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("Digite o valor em dólares: ");
            double valorEmDolares = double.Parse(Console.ReadLine());

            double valorEmReais = ConversorDeMoedas.DolarParaReal(valorEmDolares);
                
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor em reais: " + valorEmReais);
            Console.ResetColor();
        }

        else if (opcao == 2)
        {
            Console.Write("Digite o valor em reais: ");
            double valorEmReais = double.Parse(Console.ReadLine());

            double valorEmDolares = ConversorDeMoedas.RealParaDolar(valorEmReais);
                
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor em dólares: " + valorEmDolares);
            Console.ResetColor();
        }
            
        else if (opcao == 3)
        {
            Console.WriteLine("Encerrando programa...");
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }

        Console.WriteLine(); 
        
        }
    }
}