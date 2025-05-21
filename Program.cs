using estrutura_dados;
using estrutura_dados.Visualizations;

int options;

do
{
    Console.Clear();
    AnsiColors.PrintMenu([
        "Visualizar Array.",
        "Visualizar Matriz.",
        "Visualizar Lista.",
    ], "MENU INICIAL");

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