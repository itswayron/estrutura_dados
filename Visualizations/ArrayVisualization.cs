using estrutura_dados.Implementations;

namespace estrutura_dados.Visualizations
{
    public static class ArrayVisualization
    {
        public static void Visualize()
        {
            Console.Clear();
            AnsiColors.WriteLine("======= VISUALIZAÇÃO DE ARRAY =======", AnsiColors.Cyan);

            int size = MenuCreator.ReadIntInput("Digite o tamanho do array: ");
            var array = new ArrayImpl<int>(size);

            var menuInterface = () =>
            {
                AnsiColors.WriteLine("======= ARRAY =======", AnsiColors.Cyan);
                Console.WriteLine($"{AnsiColors.Green}Array: {string.Join(" -> ", array.GetCopy())}{AnsiColors.Reset}");
                AnsiColors.PrintMenu([
                    "Adicionar elemento.",
                    "Remover elemento.",
                    "Obter elemento por índice.",
                    "Verificar se está vazio.",
                    "Obter tamanho.",
                    "Obter capacidade.",
                    "Limpar array.",
                    "Imprimir array."
                ]);
            };

            var menuActions = new List<Action>()
            {
                () =>
                {
                    int element = MenuCreator.ReadIntInput("Digite o elemento a ser adicionado: ");
                    array.Add(element);
                    AnsiColors.WriteLine("Elemento adicionado com sucesso!");
                },
                () =>
                {
                    int index = MenuCreator.ReadIntInput("Digite o índice do elemento a ser removido: ");
                    array.Remove(index);
                    AnsiColors.WriteLine("Elemento removido com sucesso!");
                },
                () =>
                {
                    int index = MenuCreator.ReadIntInput("Digite o índice: ");
                    int value = array.GetAtIndex(index);
                    AnsiColors.WriteLine($"Elemento na posição {index}: {value}");
                },
                () =>
                {
                    bool isEmpty = array.IsEmpty();
                    AnsiColors.WriteLine(isEmpty ? "O array está vazio." : "O array NÃO está vazio.",
                        AnsiColors.White);
                },
                () => { AnsiColors.WriteLine($"Tamanho atual: {array.GetSize}", AnsiColors.Green); },
                () => { AnsiColors.WriteLine($"Capacidade máxima: {array.GetCapacity}", AnsiColors.Green); },
                () =>
                {
                    array.Clear();
                    AnsiColors.WriteLine("Array limpo com sucesso!", AnsiColors.Red);
                },
                () =>
                {
                    AnsiColors.WriteLine("Conteúdo do array:", AnsiColors.Cyan);
                    array.Print();
                }
            };

            MenuCreator.ExecuteMenu(menuActions, menuInterface);
            Console.Clear();
        }
    }
}