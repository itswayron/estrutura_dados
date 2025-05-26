using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations;

public static class StackVisualization
{
    public static void Visualize()
    {
        Console.Clear();
        AnsiColors.WriteLine("======= VISUALIZAÇÃO DE PILHA =======", AnsiColors.Cyan);

        int size = MenuCreator.ReadIntInput("Digite o tamanho da pilha: ");
        StackImpl<int> stack = new StackImpl<int>(size);

        var menuInterface = () =>
        {
            AnsiColors.WriteLine("======= PILHA =======", AnsiColors.Cyan);
            Console.WriteLine($"{AnsiColors.Green}Pilha: {string.Join(" -> ", stack.GetCopy())}{AnsiColors.Reset}");
            AnsiColors.PrintMenu([
                "Empilhar",
                "Desempilhar",
                "Verificar tamanho",
                "Limpar pilha"
            ]);
        };

        var menuActions = new List<Action>()
        {
            () =>
            {
                var element = MenuCreator.ReadIntInput("Digite o número a ser empilhado: ");
                stack.Push(element);
            },
            () => { stack.Pop(); },
            () =>
            {
                AnsiColors.Write("O tamanho da pilha é: ", AnsiColors.Yellow);
                AnsiColors.WriteLine($"{stack.Size()}", AnsiColors.Green);
            },
            () =>
            {
                AnsiColors.WriteLine("LIMPANDO PILHA", AnsiColors.Red);
                stack.Clear();
            }
        };

        MenuCreator.ExecuteMenu(menuActions, menuInterface);
        Console.Clear();
    }
}