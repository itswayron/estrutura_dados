using estrutura_dados;
using estrutura_dados.Visualizations;

var ArrayVisualization = new ArrayVisualization();
var MatrixVisualization = new MatrixVisualization();
var QueueVisualization = new QueueVisualization();
int options;

do
{
    Console.Clear();
    AnsiColors.WriteLine("======= MENU =======", AnsiColors.Cyan);
    Console.WriteLine($"{AnsiColors.Red}0. Sair{AnsiColors.Reset}");
    Console.WriteLine($"{AnsiColors.Yellow}1.{AnsiColors.Reset + AnsiColors.Green} Visualizar Array{AnsiColors.Reset}");
    Console.WriteLine($"{AnsiColors.Yellow}2.{AnsiColors.Reset + AnsiColors.Green} Visualizar Matriz{AnsiColors.Reset}");
    Console.WriteLine($"{AnsiColors.Yellow}3.{AnsiColors.Reset + AnsiColors.Green} Visualizar Lista{AnsiColors.Reset}");
    Console.Write("Opção: ", AnsiColors.Yellow);
    if (!int.TryParse(Console.ReadLine(), out options))
    {
        AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
        Console.ReadKey();
        continue;
    }
    switch (options)
    {
        case 0:
            AnsiColors.WriteLine("Saindo...", AnsiColors.Red);
            break;
        case 1:
            ArrayVisualization.Visualize();
            break;
        case 2:
            MatrixVisualization.Visualize();
            break;
        case 3:
            QueueVisualization.Visualize();
            break;
        default:
            AnsiColors.WriteLine("Opção inválida!", AnsiColors.Red);
            break;
    }
} while (options != 0);