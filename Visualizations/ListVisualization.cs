using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations;

public static class ListVisualization
{
    public static void Visualize()
    {
        Console.Clear();
        AnsiColors.WriteLine("======= VISUALIZAÇÃO DE LISTA =======", AnsiColors.Cyan);

        int size = MenuCreator.ReadIntInput("Digite o tamanho da lista: ");
        var list = new ListImpl<int>(size);

        var menuInterface = () =>
        {
            AnsiColors.WriteLine("======= LISTA =======", AnsiColors.Cyan);
            Console.WriteLine($"{AnsiColors.Green}Fila: {string.Join(" -> ", list.GetCopy())}{AnsiColors.Reset}");
            AnsiColors.PrintMenu([
                "Adicionar elemento.",
                "Adicionar elemento na posição.",
                "Remover na posição.",
                "Limpar lista.",
                "Ordenar lista.",
                "Busca linear.",
                "Busca binária (Realiza ordenação automaticamente).",
            ]);
        };

        var menuActions = new List<Action>()
        {
            () =>
            {
                int element = MenuCreator.ReadIntInput("Digite o elemento a ser adicionado: ");
                list.Add(element);
                AnsiColors.WriteLine("Elemento adicionado com sucesso!");
            },
            () =>
            {
                int index = MenuCreator.ReadIntInput("Digite a posição a ser adicionada: ");
                int element = MenuCreator.ReadIntInput("Digite o elemento a ser adicionado: ");
                list.AddAt(element, index);
                AnsiColors.WriteLine("Elemento adicionado com sucesso!");
            },
            () =>
            {
                int index = MenuCreator.ReadIntInput("Digite a posição a ser removida: ");
                list.RemoveAt(index);
            },
            () =>
            {
                AnsiColors.WriteLine("LIMPANDO LISTA.", AnsiColors.Red);
                list.Clear();
            },
            () =>
            {
                AnsiColors.WriteLine("Ordenando lista...", AnsiColors.Magenta);
                list.Sort();
            },
            () =>
            {
                int value = MenuCreator.ReadIntInput("Digite o valor a ser procurado na lista: ");
                var (position, steps) = list.LinearSearch(value);
                AnsiColors.WriteLine($"Passos feitos durante a busca linear: {steps}.", AnsiColors.Yellow);
                if (position < 0)
                {
                    AnsiColors.WriteLine("Valor não está presente na lista.", AnsiColors.Red);
                }
                else
                {
                    AnsiColors.WriteLine($"Elemento presente na posição: {position}.", AnsiColors.Green);
                }
            },
            () =>
            {
                int value = MenuCreator.ReadIntInput("Digite o valor a ser procurado na lista: ");
                var (position, steps) = list.BinarySearch(value);
                AnsiColors.WriteLine($"Passos feitos durante a busca binária: {steps}.", AnsiColors.Yellow);
                if (position < 0)
                {
                    AnsiColors.WriteLine("Valor não está presente na lista.", AnsiColors.Red);
                }
                else
                {
                    AnsiColors.WriteLine($"Elemento presente na posição: {position}.", AnsiColors.Green);
                }
            }
        };

        MenuCreator.ExecuteMenu(menuActions, menuInterface);
        Console.Clear();
    }
}